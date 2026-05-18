using Microsoft.AspNetCore.Mvc;
using MonitoringSystem.Data;
using MonitoringSystem.Models;

namespace MonitoringSystem.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SensorsController : ControllerBase
{
    private readonly AppDbContext _context;

    public SensorsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Get() => Ok(_context.Sensors.ToList());

    [HttpPost]
    public IActionResult Create(Sensor sensor)
    {
        _context.Sensors.Add(sensor);
        _context.SaveChanges();
        return Ok(sensor);
    }
}
