using ApiTest.Controllers;
using ApiTest.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddOpenApiDocument();

var app = builder.Build();
app.UseStaticFiles();
app.UseOpenApi();
app.UseSwaggerUi();
app.UseCors(cors => cors.AllowAnyMethod());
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

var doc = new PersonController();

app.MapGet("api/person", () =>
{
    return doc.GetOne(1);
});

app.Run();

