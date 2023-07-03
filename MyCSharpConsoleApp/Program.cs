using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MyCSharpConsoleApp;
using Serilog;

Console.WriteLine("Hello, World!");

//IConfiguration configuration = new ConfigurationBuilder()
//    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
//    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
//    .Build();

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .WriteTo.File("logs/log.txt", rollingInterval: RollingInterval.Day, retainedFileCountLimit: 7)
    .CreateLogger();

var services = new ServiceCollection();

//DbConfig dbConfig = new();
//configuration.GetSection("DatabaseSettings").Bind(dbConfig);

//services.AddSingleton(dbConfig);
services.AddLogging(builder => builder.AddSerilog());
services.AddTransient<RecordTest>();

// Build the service provider
var serviceProvider = services.BuildServiceProvider();

// Resolve the DataService and execute the method
var logger = serviceProvider.GetRequiredService<ILogger<Program>>();

logger.LogInformation("Hi");

var recordTest = serviceProvider.GetRequiredService<RecordTest>();
recordTest.Run();