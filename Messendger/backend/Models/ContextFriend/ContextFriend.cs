public class ContextFriend : IContextFriend
{
    private readonly int ID;
    private readonly int FriendID;

    public ContextFriend(int id, int friendId)
    {
        ID = id;
        FriendID = friendId;
    }

    public int GetID() => ID;
    public int GetFriendID() => FriendID;
}