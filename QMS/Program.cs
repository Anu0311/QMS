using Microsoft.EntityFrameworkCore;
using QMS.core.DatabaseContext;
using QMS.core.Repositories;
using QMS.core.Repositories.UsersRepository;

var builder = WebApplication.CreateBuilder(args);

// Register the DbContext (Make sure your connection string is named "QMSConnection" or adjust as needed)
builder.Services.AddDbContext<QMSDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("QMSConnection")));

// Register your repositories
builder.Services.AddScoped<IUsersRepository, UsersRepository>();

// Add MVC services
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
