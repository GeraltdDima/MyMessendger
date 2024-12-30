using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;

public class Startup
{
    private readonly IConfiguration _configuration;

    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();

        services.AddCors(options =>
        {
            options.AddPolicy("AllowFrontendOnly", builder =>
            {
                builder.WithOrigins("https://localhost:5050")
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
        });
        
        services.AddDbContext<UserDbContext>(options =>
        {
            options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        });

        services.AddDbContext<CorrespondenceDbContext>(options =>
        {
            options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        });

        services.AddDbContext<CorrespondenceDbContext>(options =>
        {
            options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        });

        services.AddDatabaseDeveloperPageExceptionFilter();

        services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true).
            AddEntityFrameworkStores<UserDbContext>();

        services.Configure<IdentityOptions>(options =>
        {
            options.Password.RequireDigit = true;
            options.Password.RequireLowercase = true;
            options.Password.RequireUppercase = true;
            options.Password.RequireNonAlphanumeric = true;
            options.Password.RequiredLength = 10;
            options.Password.RequiredUniqueChars = 1;

            options.User.RequireUniqueEmail = true;
            options.User.AllowedUserNameCharacters =
                "qwertyuiopasdfghjklzxcvbnm1234567890-=_+[]{};',.<>";

            options.SignIn.RequireConfirmedAccount = true;
            options.SignIn.RequireConfirmedEmail = true;
            options.SignIn.RequireConfirmedPhoneNumber = true;

            options.Lockout.AllowedForNewUsers = true;
            options.Lockout.MaxFailedAccessAttempts = 5;
            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
        });

        services.ConfigureApplicationCookie(options =>
        {
            options.Cookie.HttpOnly = true;
            options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
            options.LoginPath = "/Account/Login";
            options.AccessDeniedPath = "/Account/AccessDenied";
            options.SlidingExpiration = true;
        });
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }
        
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseCors("AllowFrontendOnly");
        app.UseAuthentication();
        app.UseAuthorization();

        app.UseEndpoints(endPoints =>
        {
            endPoints.MapControllers();
        });
    }
}