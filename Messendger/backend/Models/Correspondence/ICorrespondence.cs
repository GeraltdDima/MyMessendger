public interface ICorrespondence
{
    IEnumerable<IMessage> GetMessages();
    
    void AddMessage(IMessage message);
    void RemoveMessage(IMessage message);
    void UpdateMessage(IMessage updatedMessage, IMessage message);
    
    void ClearMessages();
}