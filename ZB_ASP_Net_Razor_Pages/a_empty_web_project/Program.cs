var builder = WebApplication.CreateBuilder(args);

// application will user razor pages
builder.Services.AddRazorPages();

var app = builder.Build();
app.UseStaticFiles();

// make the razor pages available through URLs.
app.MapRazorPages();

app.Run();
