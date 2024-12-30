public abstract class MessageRequest : IRequest
{
    public abstract string GetKey();
    public abstract string GetPersonalKey();
    
    public abstract IMessage GetMessage();
}