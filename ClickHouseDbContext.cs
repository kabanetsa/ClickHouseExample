using ClickHouse.EntityFrameworkCore.Core;
using ClickHouse.EntityFrameworkCore.Extensions;
using ClickHouseExample;
using Microsoft.EntityFrameworkCore;

public class ClickHouseContext : ClickHouseDbContext
{
    public ClickHouseContext(DbContextOptions op) : base(op)
    {

    }
    
    public DbSet<WeatherForecast> WeatherForecasts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WeatherForecast>().HasKey(e => e.Id);
        modelBuilder.Entity<WeatherForecast>().Property(e => e.Id).ValueGeneratedNever();

        modelBuilder.Entity<WeatherForecast>()
            .HasMergeTreeEngine()
            .HasOrderBy(a => a.Id);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // optionsBuilder.UseClickHouse("Host=localhost;Protocol=http;Port=8123;Database=weather");

    }
}