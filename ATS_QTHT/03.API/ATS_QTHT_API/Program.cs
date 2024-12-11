using ATS_QTHT_API.Ioc;
using NetCore.Logging.Extensions;
using NetCore.Logging.NLogCustom;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

//dùng nlog hoặc Serilog được cấu hình ở Netcore.Loggin

// Add services to the container.
builder.Services.AddApiServices(configuration);
LoggingBuilderExten.UseSerilog(builder, configuration);

builder.Services.RegisterAddCorsComponents();

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
app.UseRouting();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
