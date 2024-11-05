using Core.Entidades.Interfaces.Repositorio;
using Core.Entidades.Interfaces.Service;
using Core.Repositorio.Data;
using Core.Repositorios;
using Core.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

InicializadorBd.Inicializar();
builder.Services.AddScoped<IEstudanteRepository, EstudanteRepositorio>();
builder.Services.AddScoped<IEstudanteService, EstudanteService>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
