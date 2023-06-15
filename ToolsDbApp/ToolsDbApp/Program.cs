IConfiguration config = new ConfigurationBuilder()
  .AddJsonFile("appsettings.json")
  .Build();

var defaultConnectionString = config.GetConnectionString("DefaultConnection");

Console.WriteLine(defaultConnectionString);

var optionsBuilder = new DbContextOptionsBuilder<ToolsAppDbContext>();
optionsBuilder.UseSqlServer(defaultConnectionString);

var toolsAppDbContext = new ToolsAppDbContext(optionsBuilder.Options);
