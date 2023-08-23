using asanbtc_api;


public class Program
{
    public static void Main(string[] args)
       => CreateHostBuilder(args).Build().Run();

    // EF Core uses this method at design time to access the DbContext
    public static IHostBuilder CreateHostBuilder(string[] args)
        => Host.CreateDefaultBuilder(args).ConfigureAppConfiguration((hostingContext, config) =>
        {
            config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            config.AddEnvironmentVariables();

            if (args != null)
            {
                config.AddCommandLine(args);
            }
        })
    .ConfigureWebHostDefaults(
                webBuilder => webBuilder.UseStartup<Startup>());
}
