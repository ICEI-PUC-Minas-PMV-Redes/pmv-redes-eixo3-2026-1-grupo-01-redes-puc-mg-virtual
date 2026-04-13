using Microsoft.AspNetCore.Mvc;
using MonitoringSystem.Data;

namespace MonitoringSystem.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DashboardController : ControllerBase
{
    private readonly AppDbContext _context;

    public DashboardController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("summary")]
    public IActionResult Summary()
    {
        var total = _context.Sensors.Count();
        var alertas = _context.Alerts.Count(a => !a.Resolvido);
        var ativos = total;
        var offline = 0;

        return Ok(new { total, ativos, alertas, offline });
    }

    [HttpGet]
    public IActionResult Dashboard()
    {
        var sensores = _context.Sensors.ToList();

        var dados = sensores.Select(s => {
            var ultima = _context.Metrics
                .Where(m => m.SensorId == s.Id)
                .OrderByDescending(m => m.DataHora)
                .FirstOrDefault();

            string status = "Sem dados";
            if (ultima != null)
                status = ultima.Temperatura > 30 ? "Alerta" : "Normal";

            return new {
                sensor = s.Nome,
                temperatura = ultima?.Temperatura,
                umidade = ultima?.Umidade,
                status
            };
        });

        return Ok(dados);
    }

    [HttpGet("logs")]
    public IActionResult Logs()
    {
        var logs = _context.Metrics
            .OrderByDescending(m => m.DataHora)
            .Take(50)
            .ToList();

        return Ok(logs);
    }
}
