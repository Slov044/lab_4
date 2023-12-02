using Lab4.Traffic.Entities;
using Lab4.Traffic.Enums;

namespace Lab4.Traffic;

internal static class Program
{
    private static void Main()
    {
        var cityRoad = new Road
        {
            CurrentTrafficLevel = Random.Shared.NextDouble() * 4,
            Length = Random.Shared.Next(1, 10),
            NumberLanes = Random.Shared.Next(1, 4),
            Width = Random.Shared.NextDouble() * 2 + 1
        };

        var car = new Transport
        {
            Width = Random.Shared.NextDouble() * 2 + 1,
            Height = 4,
            Speed = Random.Shared.NextDouble() * 2 + 1,
            TransportType = (TransportType)Random.Shared.Next(0, 2)
        };

        TrafficSimulator.SimulateTraffic(car, cityRoad);
    }
}