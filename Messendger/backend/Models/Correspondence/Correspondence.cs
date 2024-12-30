public class Correspondence : ICorrespondence
{
    private readonly List<IMessage> messages;

    public Correspondence()
    {
        messages = new List<IMessage>();
    }
    
    public IEnumerable<IMessage> GetMessages() => messages;
    
    public void AddMessage(IMessage message) => messages.Add(message);
    public void RemoveMessage(IMessage message) => messages.Remove(message);

    public void UpdateMessage(IMessage updateMessage, IMessage message)
    {
        IMessage messageToUpdate = messages.FirstOrDefault(_message => _message == updateMessage);

        if (messageToUpdate == null)
        {
            throw new Exception("Did not find message to update");
        }

        messageToUpdate = message;
    }
    
    public void ClearMessages() => messages.Clear();
}