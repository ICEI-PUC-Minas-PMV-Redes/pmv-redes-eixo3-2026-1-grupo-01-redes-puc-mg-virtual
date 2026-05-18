using MonitoringSystem.Data;
using MonitoringSystem.Models;

namespace MonitoringSystem.Services;

public class AlertService
{
    private readonly AppDbContext _context;

    public AlertService(AppDbContext context)
    {
        _context = context;
    }

    public async Task Check(int sensorId, double temperatura)
    {
        var alertaAtivo = _context.Alerts.FirstOrDefault(a => a.SensorId == sensorId && !a.Resolvido);

        if (temperatura > 30 && alertaAtivo == null)
        {
            _context.Alerts.Add(new Alert
            {
                SensorId = sensorId,
                Tipo = "Temperatura",
                Valor = temperatura,
                Nivel = "Crítico",
                DataHora = DateTime.Now
            });
        }

        if (temperatura < 28 && alertaAtivo != null)
        {
            alertaAtivo.Resolvido = true;
        }

        await _context.SaveChangesAsync();
    }
}
