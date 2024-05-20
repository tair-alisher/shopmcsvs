using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder
    .Configuration.SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile(
        //        $"ocelot.{env.HostingEnvironment.EnvironmentName}.json",
        "ocelot.dev.json",
        optional: false,
        reloadOnChange: true
    )
    .AddEnvironmentVariables();

builder.Services.AddOcelot(builder.Configuration);

var app = builder.Build();
app.UseHsts();
await app.UseOcelot();

app.MapGet("/", () => "Ocelot is running");

app.Run();
