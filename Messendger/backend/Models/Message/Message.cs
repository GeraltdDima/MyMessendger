public class Message : IMessage
{
    private string _info;
    private int _senderID;
    private int _receiverID;

    public Message(string info, int senderID, int receiverID)
    {
        _info = info;
        _senderID = senderID;
        _receiverID = receiverID;
    }
    
    public string GetInfo() => _info;
    public int GetSenderID() => _senderID;
    public int GetReceiverID() => _receiverID;
}