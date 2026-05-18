using Microsoft.Extensions.Hosting;
using MonitoringSystem.Data;
using MonitoringSystem.Models;
using MonitoringSystem.Services;

namespace MonitoringSystem.Workers;

public class SnmpPollingService : BackgroundService
{
    private readonly IServiceProvider _serviceProvider;

    public SnmpPollingService(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            using var scope = _serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            var snmp = scope.ServiceProvider.GetRequiredService<SnmpService>();
            var alertService = scope.ServiceProvider.GetRequiredService<AlertService>();

            var sensores = context.Sensors.ToList();

            foreach (var sensor in sensores)
            {
                var dados = await snmp.GetData(sensor.IP);

                context.Metrics.Add(new Metric
                {
                    SensorId = sensor.Id,
                    Temperatura = dados.temperatura,
                    Umidade = dados.umidade,
                    DataHora = DateTime.Now
                });

                await alertService.Check(sensor.Id, dados.temperatura);
            }

            await context.SaveChangesAsync();

            await Task.Delay(30000);
        }
    }
}
