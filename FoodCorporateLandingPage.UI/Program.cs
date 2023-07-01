using FoodCorporateLandingPage.Business.Concrete;
using FoodCorporateLandingPage.Core.Abstract.Repository;
using FoodCorporateLandingPage.Core.Abstract.Services;
using FoodCorporateLandingPage.DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<FoodDbContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseSqlServer(connectionString);
});


builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

#region Services Classes
builder.Services.AddTransient(typeof(IAboutService), typeof(AboutService));
builder.Services.AddTransient(typeof(IBlogService), typeof(BlogService));
builder.Services.AddTransient(typeof(IContactFormService), typeof(ContactFormService));
builder.Services.AddTransient(typeof(IContactService), typeof(ContactService));
builder.Services.AddTransient(typeof(IHeaderBannerService), typeof(HeaderBannerService));
builder.Services.AddTransient(typeof(IServiceService), typeof(ServiceService));
builder.Services.AddTransient(typeof(ISocialMediaService), typeof(SocialMediaService));
builder.Services.AddTransient(typeof(ISubscribeService), typeof(SubscribeService));

#endregion






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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
