using Microsoft.EntityFrameworkCore;
using MonitoringSystem.Models;

namespace MonitoringSystem.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Sensor> Sensors { get; set; }
    public DbSet<Metric> Metrics { get; set; }
    public DbSet<Alert> Alerts { get; set; }
}
