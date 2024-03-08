
using KashanExpress.ContextFiles;
using KashanExpress.DataAccessLayer.Infrastructure.IReposatory;
using KashanExpress.DataAccessLayer.Infrastructure.Reposatory;


using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();





// Add DbContext
builder.Services.AddDbContext<EcommerceDataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("dbcon"));
});

builder.Services.AddScoped<IUnitofWork, UnitofWork>();
builder.Services.AddScoped<ICategory, CategoryRepository>();

var app = builder.Build();





// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
