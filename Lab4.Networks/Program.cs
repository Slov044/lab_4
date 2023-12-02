// See https://aka.ms/new-console-template for more information

using Lab4.Networks.Entities;

namespace Lab4.Networks;

internal class Program
{
    public static void Main(string[] args)
    {
        var network = new Network();

        var server = new Server
        {
            Ip = "192.168.1.1",
            Power = 1000,
            Os = "Windows Server",
            Uri = "MainServer"
        };

        var workstation = new Workstation
        {
            Ip = "192.168.1.2",
            Power = 500,
            CountCpu = 8,
            Os = "Windows 10"
        };

        var router = new Router
        {
            Ip = "192.168.1.254",
            Power = 200,
            Os = "RouterOS",
            CountUsedPorts = 10
        };

        network.AddDevice(server);
        network.AddDevice(workstation);
        network.AddDevice(router);

        network.ConnectDevices(server, router);
        network.ConnectDevices(workstation, router);

        network.TransmitData(server, workstation, "Hello from the server to the workstation!");

        network.DisconnectDevices(server, router);
        network.DisconnectDevices(workstation, router);
    }
}