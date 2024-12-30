using Microsoft.AspNetCore.Identity;

public abstract class User : IdentityUser
{
    public abstract Task SendMessageAsync(MessageRequest messageRequest);
    public abstract Task<IEnumerable<IMessage>> ReceiveMessageAsync();
    
    public abstract Task SendFriendRequestAsync(FriendRequest friendRequest);
    
    public abstract Task<IEnumerable<IFriend>> ReceiveFriendRequestsAsync();
}