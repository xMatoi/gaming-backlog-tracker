using DotNetEnv;
using GamingBacklogTracker.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
Env.Load();

var connectionString = Environment.GetEnvironmentVariable("ConnectionStrings__PostgresConnection") 
                       ?? throw new InvalidOperationException("Falta la cadena de conexión.");

// Llamamos al método que inyecta los repositorios y la base de datos
builder.Services.AddInfrastructure(connectionString);

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();
app.Run();
