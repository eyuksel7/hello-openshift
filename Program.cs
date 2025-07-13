var builder = WebApplication.CreateBuilder(args);

// Swagger servisi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger ve routing middleware'leri
app.UseSwagger();
app.UseSwaggerUI();

// Swagger erişim testi için sade response
app.MapGet("/", () => "pong");

// Örnek API
app.MapGet("/api/hello", () => "Hello from OpenShift Sandbox!");

app.Run();
