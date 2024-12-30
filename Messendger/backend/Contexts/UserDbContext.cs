using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

public class UserDbContext : IdentityDbContext
{
    public UserDbContext(DbContextOptions<UserDbContext> options) { }
}