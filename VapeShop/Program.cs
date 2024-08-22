using Microsoft.EntityFrameworkCore;
using VapeShop.Core.Abstractions.Users;
using VapeShop.Core.Services;
using VapeShop.Data.Context;
using VapeShop.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

string connection = builder.Configuration.GetConnectionString("DefaultConnection") ?? string.Empty;

builder.Services.AddAuthentication("CookieAuth")
           .AddCookie("CookieAuth", options =>
           {
               options.LoginPath = "/Account/LoginView"; // путь к странице входа
               options.LogoutPath = ""; // путь к странице выхода
           });

builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));

builder.Services.AddHttpContextAccessor();
builder.Services.AddControllersWithViews();

////////////////////////

builder.Services.AddScoped<IUsersRepository, UsersRepository>();
builder.Services.AddScoped<IUserService, UserService>();

///////////////////////////


var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
