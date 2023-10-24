using System.Diagnostics;
using ClickHouse.EntityFrameworkCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

public class ClickHouseDesignTimeServices : IDesignTimeServices
{
    public void ConfigureDesignTimeServices(IServiceCollection services)
    {
        //Debugger.Launch();
        Console.WriteLine("IDesignTimeServices runned");
        Debug.Print("IDesignTimeServices runned");
        if (services == null)
        {
            throw new ArgumentNullException(nameof(services));
        }

        services.AddEntityFrameworkClickHouseDesignTime();
    }
}
internal class Program
{
    private static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddDbContext<ClickHouseContext>(a => a.UseClickHouse($"Host=localhost;Protocol=http;Port=8123;Database=weather;Username=default;Password=;"));

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        var t = builder.Services.BuildServiceProvider();
        var m = t.GetRequiredService<ClickHouseContext>();
        await m.Database.EnsureCreatedAsync();
        await m.Database.MigrateAsync();

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}