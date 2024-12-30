public class DefaultFriendRequest : FriendRequest
{
    private int senderID;
    private int receiverID;

    private string key;
    private string personalKey;

    public DefaultFriendRequest(int senderID, int receiverID, string key, string personalKey)
    {
        this.senderID = senderID;
        this.receiverID = receiverID;
        this.key = key;
        this.personalKey = personalKey;
    }

    public override string GetKey() => key;
    public override string GetPersonalKey() => personalKey;
    
    public override int GetSenderID() => senderID;
    public override int GetReceiverID() => receiverID;
}