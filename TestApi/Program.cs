using Microsoft.EntityFrameworkCore;
using CloudData;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


var contextOptions = new DbContextOptionsBuilder<CloudContext>()
    .UseSqlServer(builder.Configuration.GetConnectionString("CloudConnection"))
    .EnableSensitiveDataLogging()
    .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking).Options;

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CloudContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("CloudConnection"))
.EnableSensitiveDataLogging()
.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

//Hilmi: This created the database if it is not created.
//it adds the table(s) also.

using (CloudContext cloudContext = new CloudContext(contextOptions))
{
    cloudContext.Database.EnsureCreated();
}

app.Run();



