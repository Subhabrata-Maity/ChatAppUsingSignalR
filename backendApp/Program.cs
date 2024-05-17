using ChatAppUsingSignalR.Hubs;
using Microsoft.AspNetCore.Cors.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSignalR();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// builder.Services.AddCors(out:CorsOptions =>
// {
//     opt.AddPolicy(name: "reactApp", configurePolicy: builder =>
//     {
//         builder.WithOrigins("http://localhost:3000/")
//         .AllowAnyHeader()
//         .AllowAnyMethod()
//         .AllowCredentials();
//     });
// });
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
app.MapHub<ChatHub>(pattern: "/Chat");
app.UseCors("reactApp");

app.Run();
