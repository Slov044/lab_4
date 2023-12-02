namespace Lab4.Networks.Abstractions;

public interface IConnectable
{
    void Connect(IConnectable device);
    void Disconnect(IConnectable device);
    void SendData(string data);
    void ReceiveData(string data);
}