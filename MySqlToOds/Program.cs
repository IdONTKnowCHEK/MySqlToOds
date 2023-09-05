using Microsoft.EntityFrameworkCore;
using MySqlToOds.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectString = builder.Configuration["ConnectionString:DefaultConnection"];


builder.Services.AddDbContext<StudentDataContext>(options => options.UseMySQL(connectString));


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
