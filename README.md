# HTTP-Verb-Handson
Hands on for Today

Maintain a list of employee (no DB operation) and write method for all 5 HTTP verbs - Get, psot, put, patch and delete
Implement Swagger - Install Swashbuckle.AspNetCore package and your program.cs should look like

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();
