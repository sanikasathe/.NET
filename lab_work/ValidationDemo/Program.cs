var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Error handling
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}


// app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

// Static files (CSS, JS)
app.MapStaticAssets();

// ✅ Default route → Student/Create
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Student}/{action=Create}/{id?}");

app.Run();