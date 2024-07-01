using DesignPattern.Service;
using DesignPattern.Service.Interface;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IDesignPatternService, DesignPatternService>();

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
