var builder = WebApplication.CreateBuilder(args);

// Registra los controladores
builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Conecta las rutas de los controladores
app.MapControllers();

app.Run();