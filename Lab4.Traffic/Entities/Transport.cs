using Lab4.Traffic.Abstractions;
using Lab4.Traffic.Enums;

namespace Lab4.Traffic.Entities;

public class Transport : IDriveable
{
    public double Height;
    public double Speed;
    public TransportType TransportType;
    public double Width;

    public void Move()
    {
        Console.WriteLine($"{this} move at a speed of {Speed} km/h");
    }

    public void Stop()
    {
        Console.WriteLine($"{this} stopped.");
    }

    public override string ToString()
    {
        return $"[{GetHashCode()}] {TransportType}";
    }
}