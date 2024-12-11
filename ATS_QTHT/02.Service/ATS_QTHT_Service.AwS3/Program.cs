using ATS_QTHT_Service.AwsS3.Ioc;
using NetCore.Logging.Extensions;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
//dùng nlog hoặc Serilog được cấu hình ở Netcore.Loggin

// Add services to the container.
builder.Services.RegisterIoCs(configuration);
LoggingBuilderExten.UseSerilog(builder, configuration);

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
