using Core.Repositorio.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

InicializadorBd.Inicializar();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
