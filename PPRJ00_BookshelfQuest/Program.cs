using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PPRJ00_BookshelfQuest.Components;
using PPRJ00_BookshelfQuest.Data;
using PPRJ00_BookshelfQuest.Items;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Setup EFcore
var connectionString = builder.Configuration.GetConnectionString("Default") ?? throw new NullReferenceException("No connection string in config!");
builder.Services.AddDbContextFactory<BookDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddScoped<BookDbContext>();
builder.Services.AddScoped<IBookService, BookService>();

// Call the ConfigureServices method to add additional services
ConfigureServices(builder.Services);

var app = builder.Build();

void ConfigureServices(IServiceCollection services)
{
    // Add an HttpClient service
    services.AddScoped<HttpClient>();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();