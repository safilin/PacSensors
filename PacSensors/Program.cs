using Microsoft.EntityFrameworkCore;
using PacSensors.Data;
using PacSensors.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextPool<PacSensorsDbContext>(options =>
{
    options.UseMySql(builder.Configuration.GetConnectionString("UbuntuConnectionDEV"),
    ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("UbuntuConnectionDEV")));
});

builder.Services.AddScoped<IGP_OVERVIEW_Repository, GP_OVERVIEW_Repository>();
builder.Services.AddScoped<IGP_INST_Repository, GP_INST_Repository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
