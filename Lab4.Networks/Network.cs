using Lab4.Networks.Abstractions;

namespace Lab4.Networks;

public class Network
{
    private readonly List<IConnectable> devices = new();

    public void AddDevice(IConnectable device)
    {
        devices.Add(device);
    }

    public void RemoveDevice(IConnectable device)
    {
        devices.Remove(device);
    }

    public void ConnectDevices(IConnectable device1, IConnectable device2)
    {
        device1.Connect(device2);
        device2.Connect(device1);
    }

    public void DisconnectDevices(IConnectable device1, IConnectable device2)
    {
        device1.Disconnect(device2);
        device2.Disconnect(device1);
    }

    public void TransmitData(IConnectable sender, IConnectable receiver, string data)
    {
        sender.SendData(data);
        receiver.ReceiveData(data);
    }
}