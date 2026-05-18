namespace MonitoringSystem.Models;
public class Alert
{
    public int Id { get; set; }
    public int SensorId { get; set; }
    public string Tipo { get; set; }
    public double Valor { get; set; }
    public string Nivel { get; set; }
    public DateTime DataHora { get; set; }
    public bool Resolvido { get; set; }
}
