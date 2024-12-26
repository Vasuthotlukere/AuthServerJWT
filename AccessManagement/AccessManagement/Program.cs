using AccessManagement.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
var appSettings = builder.Services.AddAppSettings();
var jwtSettings = appSettings.JwtSettings;


var app = builder.Build();

// Configure the HTTP request pipeline.

app.Run();