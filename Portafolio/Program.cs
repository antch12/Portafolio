using Microsoft.AspNetCore.Builder;
using Portafolio.Models;
using Portafolio.UseCases;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
});

builder.Services.AddScoped<TaskContext>();

builder.Services.AddScoped<UserUseCase>();
builder.Services.AddScoped<ProjectUseCase>();
builder.Services.AddScoped<TaskPriorityUseCase>();
builder.Services.AddScoped<TaskStatusUseCase>();
builder.Services.AddScoped<TaskUseCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSession();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
