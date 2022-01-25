

using AspectCore.Extensions.DependencyInjection;
using aspectcore_framework_overview.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseServiceProviderFactory(new DynamicProxyServiceProviderFactory());

// Add services to the container.
builder.Services.AddControllers().AddControllersAsServices();
builder.Services.AddSingleton(typeof(ILogService<>), typeof(LogService<>));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
