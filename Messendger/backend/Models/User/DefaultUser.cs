using Microsoft.AspNetCore.Identity;

public class DefaultUser : User
{
    private readonly List<IMessage> messages;
    private readonly List<IFriend> friends;
    
    private readonly IRequestSender requestSender;

    private readonly string apiURL;

    public DefaultUser()
    {
        messages = new List<IMessage>();
        friends = new List<IFriend>();
        
        requestSender = new RequestSender();

        apiURL = "https://localhost:8080";
    }

    private void AddMessage(IMessage message) => messages.Add(message);
    
    private void AddMessages(params IMessage[] _messages)
    {
        foreach (var message in _messages)
        {
            AddMessage(message);
        }
    }
    private void RemoveMessage(IMessage message) => messages.Remove(message);

    private void RemoveMessages(params IMessage[] _messages)
    {
        foreach (var message in _messages)
        {
            RemoveMessage(message);
        }
    }
    
    private void AddFriend(IFriend friend) => friends.Add(friend);

    private void AddFriends(params IFriend[] friends)
    {
        foreach (var friend in friends)
        {
            AddFriend(friend);
        }
    }
    
    private void RemoveFriend(IFriend friend) => friends.Remove(friend);

    private void RemoveFriends(params IFriend[] friends)
    {
        foreach (var friend in friends)
        {
            RemoveFriend(friend);
        }
    }

    public override async Task SendMessageAsync(MessageRequest messageRequest)
    {
        try
        {
            await requestSender.PostAsync("{apiURL}/users/messages/post", messageRequest);
        }
        catch (Exception e)
        {
            throw new Exception($"Failed to send message: {e.Message}");
        }
    }

    public override async Task<IEnumerable<IMessage>> ReceiveMessageAsync()
    {
        try
        {
            string url = $"{apiURL}/api/users/messages/get/{Id}";
            IEnumerable<IMessage> messages = await WebUtil.GetAsync<IEnumerable<IMessage>>(url);

            if (messages == null)
            {
                throw new Exception($"Failed to get messages from {apiURL}");
            }
            
            AddMessages(messages.ToArray());
            return messages;
        }
        catch (Exception e)
        {
            throw new Exception($"Failed to receive messages: {e.Message}");
        }
    }

    public override async Task SendFriendRequestAsync(FriendRequest friendRequest)
    {
        try
        {
            await requestSender.PostAsync("{apiURL}/users/friends/post", friendRequest);
        }
        catch (Exception e)
        {
            throw new Exception($"Failed to send friend request: {e.Message}");
        }
    }

    public override async Task<IEnumerable<IFriend>> ReceiveFriendRequestsAsync()
    {
        try
        {
            IEnumerable<IFriend> friends = await WebUtil.GetAsync<IEnumerable<IFriend>>(apiURL);

            if (friends == null)
            {
                throw new Exception($"Failed to receive friend requests: {apiURL}");
            }
            
            return friends;
        }
        catch (Exception e)
        {
            throw new Exception($"Failed to receive friend requests: {e.Message}");
        }
    }
}