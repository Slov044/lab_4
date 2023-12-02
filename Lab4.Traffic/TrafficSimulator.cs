using Lab4.Traffic.Entities;

namespace Lab4.Traffic;

public class TrafficSimulator
{
    public static void SimulateTraffic(Transport transport, Road road)
    {
        Console.WriteLine($"Simulating traffic for {transport} on a road of length {road.Length} km, " +
                          $"width {road.Width} m, and {road.NumberLanes} lanes.");

        if (road.CurrentTrafficLevel > 2)
        {
            Console.WriteLine("Heavy traffic! Consider alternative routes.");
            transport.Stop();
        }
        else if (road.Width < transport.Width)
        {
            Console.WriteLine($"Transport is wider than the road! ({road.Width} < {transport.Width}");
            transport.Stop();
        }
        else
        {
            Console.WriteLine("Smooth traffic. Proceeding with normal speed.");
            transport.Move();
        }
    }
}