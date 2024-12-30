public class DefaultMessageRequest : MessageRequest
{
    private string key;
    private string personalKey;
    
    private IMessage message;

    public DefaultMessageRequest(string key, string personalKey, IMessage message)
    {
        this.key = key;
        this.personalKey = personalKey;
        this.message = message;
    }
    
    public override string GetKey() => key;
    public override string GetPersonalKey() => personalKey;
    public override IMessage GetMessage() => message;
}