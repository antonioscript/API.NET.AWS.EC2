using Microsoft.EntityFrameworkCore;
using ProjectAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//PostGres
var assemblyName = typeof(Program).Assembly.GetName().Name;
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ProductDbContext>(c => c.UseNpgsql(connectionString, m => m.MigrationsAssembly(assemblyName)));


var app = builder.Build();

//PostGres
using var scope = app.Services.CreateScope();
var context = scope.ServiceProvider.GetRequiredService<ProductDbContext>();
if (context.Database.GetPendingMigrations().Any())
{
    await context.Database.MigrateAsync();
}

// Middleware para redirecionar a raiz (/) para o Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    app.Use(async (context, next) =>
    {
        if (context.Request.Path == "/")
        {
            context.Response.Redirect("/swagger");
            return;
        }

        await next();
    });
}

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
