using Lab4.Networks.Abstractions;

namespace Lab4.Networks.Entities;

public class Computer : IConnectable
{
    public string Ip;
    public string Os;
    public int Power;

    public virtual void Connect(IConnectable device)
    {
        Console.WriteLine($"{this} is connected to {device}.");
    }

    public virtual void Disconnect(IConnectable device)
    {
        Console.WriteLine($"{device} is disconnected from {device}.");
    }

    public virtual void SendData(string data)
    {
        Console.WriteLine($"{this} sent data: {data}");
    }

    public virtual void ReceiveData(string data)
    {
        Console.WriteLine($"{this} received data: {data}");
    }

    public override string ToString()
    {
        return $"{GetType().Name} ({Ip})";
    }
}