using idev.Application.Interface;
using idev.Infrastructure.Context;
using idev.Infrastructure.Interface;
using idev.Infrastructure.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Register IdevContext with DI container
builder.Services.AddDbContext<IdevContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("idev"))
);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

// Dependency injection for services and repositories
builder.Services.AddScoped<ITaskManagerRepository, TaskManagerRepository>();
builder.Services.AddScoped<ITaskManagerService, TaskManagerService>();

// CORS configuration
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1");
    });
}

app.UseHttpsRedirection();
app.UseCors("AllowAll");
app.MapControllers();

app.Run();
