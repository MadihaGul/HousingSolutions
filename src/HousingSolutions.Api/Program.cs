using HousingSolutions.Application.Common.Interfaces;
using HousingSolutions.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add controllers and SignalR
        builder.Services.AddControllers();
        builder.Services.AddSignalR();

        // Swagger
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // Add MediatR and scan handlers from Application project
        builder.Services.AddMediatR(cfg =>
        {
            // Automatically load all MediatR handlers from Aptus.Application assembly
            cfg.RegisterServicesFromAssembly(Assembly.Load("HousingSolutions.Application"));
        });

        // Add EF Core DbContext from Infrastructure
        builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

        // Register IApplicationDbContext so handlers can inject it
        builder.Services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseRouting();
        app.UseAuthorization();

        app.MapControllers();
        // Uncomment when DeviceHub is ready
        // app.MapHub<DeviceHub>("/hub/devices");

        app.Run();
    }
}

