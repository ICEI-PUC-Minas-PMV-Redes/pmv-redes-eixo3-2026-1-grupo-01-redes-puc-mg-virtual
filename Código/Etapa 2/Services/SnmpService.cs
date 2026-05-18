namespace MonitoringSystem.Services;

public class SnmpService
{
    public async Task<(double temperatura, double umidade)> GetData(string ip)
    {
        Random rnd = new Random();
        return (rnd.Next(20, 40), rnd.Next(40, 80));
    }
}
