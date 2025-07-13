var builder = WebApplication.CreateBuilder(args);

// Swagger servisini ekle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger middleware’i ekle
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/api/hello", () => "Hello from OpenShift Sandbox!");

app.Run();
