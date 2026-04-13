namespace MonitoringSystem.Models;
public class Metric
{
    public int Id { get; set; }
    public int SensorId { get; set; }
    public double Temperatura { get; set; }
    public double Umidade { get; set; }
    public DateTime DataHora { get; set; }
}
