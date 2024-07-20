using Do_An_Web_K2.Data;
using Do_An_Web_K2.Models.DichVu;
using Do_An_Web_K2.Models.GiaoDien;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.
    builder.Services.AddControllersWithViews();
    builder.Services.AddScoped<IPhimRepository, PhimRepository>();
    builder.Services.AddScoped<IMucLucPhimRepository, MucLucPhimRepository>();
    builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddDbContext<PhimDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("PhimDbContextConnection")));

    builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<PhimDbContext>();
// Session
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();
builder.Services.AddRazorPages();

var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }
    app.UseHttpsRedirection();
    app.UseStaticFiles();

    // Map Razor Pages
    app.MapRazorPages();
    // Authentication and Authorization
    app.UseAuthentication();
    app.UseAuthorization();

    //app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Phimlist}/{action=Phim}/{id?}");

app.Run();
