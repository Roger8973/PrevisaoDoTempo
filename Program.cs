using Previsao_do_Tempo.Models;
using Previsao_do_Tempo.Repositorio;
using Previsao_do_Tempo.Repositorio.Interfaces;
using Previsao_do_Tempo.Servicos;
using Previsao_do_Tempo.Servicos.Interface;
using Previsao_do_Tempo.Utils;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ITemperaturaRepositorio, TemperaturaRepositorio>();
builder.Services.AddScoped<ITemperaturaServico, TemperaturaServico>();

builder.Services.AddScoped<HttpClientExtensions>();
builder.Services.AddScoped<TemperaturaModel>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
