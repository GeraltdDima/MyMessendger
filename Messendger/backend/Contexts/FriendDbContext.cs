using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
public class FriendDbContext : DbContext
{
    public FriendDbContext(DbContextOptions<FriendDbContext> options) : base(options) { }
    
    private DbSet<IContextFriend> friends { get; set;  }

    public async Task<DbSet<IContextFriend>> GetFriendsAsync() => friends;

    public async Task AddFriendAsync(IContextFriend friend)
    {
        if (friend == null)
        {
            throw new Exception("Friend is null");
        }
        
        await friends.AddAsync(friend);
    }

    public async Task RemoveFriendAsync(IContextFriend friend)
    {
        if (friend == null)
        {
            throw new Exception("Friend is null");
        }
        
        friends.Remove(friend);
    }

    public async Task UpdateFriendAsync(IContextFriend friendToUpdate, IContextFriend friend)
    {
        if (friend == null)
        {
            throw new Exception("Friend is null");
        }

        IContextFriend _friendToUpdate = await friends.FirstOrDefaultAsync(_friend => _friend.Equals(friendToUpdate));

        if (_friendToUpdate == null)
        {
            throw new Exception("Friend not found");
        }
        
        _friendToUpdate = friend;
        
        await SaveChangesAsync();
    }
}