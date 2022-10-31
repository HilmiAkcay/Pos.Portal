using Microsoft.EntityFrameworkCore;
using CloudData;
using Microsoft.AspNetCore.OData;
using TestApi.EntityDataModels;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


var contextOptions = new DbContextOptionsBuilder<CloudContext>()
    .UseSqlServer(builder.Configuration.GetConnectionString("CloudConnection"))
    .EnableSensitiveDataLogging()
    .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking).Options;

builder.Services.AddControllers().AddOData(o =>o.AddRouteComponents("v1", new CloudApiEntityDataModel().GetEdmModel())
                                .Select()
                                .Filter()
                                .Expand()
                                .SetMaxTop(100)
                                .Count()
                                .OrderBy());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "PurePOS Cloud Api", Version = "v1" });
});
//Add Odata 
builder.Services.AddDbContext<CloudContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("CloudConnection"))
.EnableSensitiveDataLogging()
.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PurePOS Cloud Api v1"));
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



