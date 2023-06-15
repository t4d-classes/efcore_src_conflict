namespace ToolsDbApp.Models;

public class ToolsAppDbContext : DbContext
{
  public ToolsAppDbContext(DbContextOptions<ToolsAppDbContext> options)
    : base(options) { }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Color>().HasData(
      new Color() { Id = 1, Name = "red", HexCode = "#FF0000" },
      new Color() { Id = 2, Name = "green", HexCode = "#00FF00" },
      new Color() { Id = 3, Name = "blue", HexCode = "#0000FF" }
    );

    modelBuilder.Entity<Car>()
      .Property(c => c.Price)
      .HasPrecision(18, 2);

    modelBuilder.Entity<Car>().HasData(
      new()
      {
        Id = 1,
        Make = "Ford",
        Model = "Fusion Hybrid",
        Year = 2022,
        Color = "blue",
        Price = 45000m,
        Country = "USA",
        Transmission = "automatic"
      },
      new()
      {
        Id = 2,
        Make = "Tesla",
        Model = "S",
        Year = 2020,
        Color = "red",
        Price = 120000m,
        Country = "USA",
        Transmission = "automatic"
      }
    );
  }

  public DbSet<Color> Colors { get; set; } = null!;
  public DbSet<Car> Cars { get; set; } = null!;
}