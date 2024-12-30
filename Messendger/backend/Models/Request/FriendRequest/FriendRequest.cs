public abstract class FriendRequest : IRequest
{
    public abstract string GetKey();
    public abstract string GetPersonalKey();

    public abstract int GetSenderID();
    public abstract int GetReceiverID();
}