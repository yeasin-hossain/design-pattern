using DesignPattern.Service;
using DesignPattern.Service.DesignPatterns.AbstractFactory;
using DesignPattern.Service.Interface;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IDesignPatternService, DesignPatternService>();
builder.Services.AddSingleton<INotification, NotificationService>();

builder.Services.AddControllers();
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

app.MapControllers();
app.Run();
