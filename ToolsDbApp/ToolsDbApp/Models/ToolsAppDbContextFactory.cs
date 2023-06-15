namespace ToolsDbApp.Models;

public class ToolsAppDbContextFactory : IDesignTimeDbContextFactory<ToolsAppDbContext>
{
  public ToolsAppDbContext CreateDbContext(string[] args)
  {
    IConfiguration config = new ConfigurationBuilder()
      .AddJsonFile("appsettings.json")
      .Build();

    var optionsBuilder = new DbContextOptionsBuilder<ToolsAppDbContext>();
    optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));

    return new ToolsAppDbContext(optionsBuilder.Options);
  }
}