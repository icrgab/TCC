using Microsoft.EntityFrameworkCore;
using test_v01.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SITEtccDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllersWithViews();

var app = builder.Build();

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
    pattern: "{controller=Documentos}/{action=Index}/{id?}");

app.Run();
