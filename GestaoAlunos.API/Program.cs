using GestaoAlunos.Data.Contexto;
using GestaoAlunos.Data.Repositorios;
using GestaoAlunos.Domain.Interfaces;
using GestaoAlunos.Service.Interfaces;
using GestaoAlunos.Service.Servicos;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<AppDBContext>();

builder.Services.AddDbContext<AppDBContext>(
    options =>
    {
        options.UseSqlServer(
            builder.Configuration
            .GetConnectionString("DefaultConnection")
            );
    }
    );

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();
builder.Services.AddScoped<IAlunoService, AlunoService>();

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
