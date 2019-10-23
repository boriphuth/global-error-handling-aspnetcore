using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Serilog;
using Serilog.Events;
using Serilog.Formatting.Elasticsearch;

namespace GlobalErrorHandling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseSerilog((hostingContext, loggerConfiguration) => loggerConfiguration
                // .WriteTo.File(new ElasticsearchJsonFormatter(), @"logs/.log", LogEventLevel.Verbose, 1073741824, null, false, false, null, RollingInterval.Day, false, 7, null)
                // .WriteTo.File( @"logs/.log", LogEventLevel.Verbose, "{Timestamp:dd-MM-yyyy HH:mm:ss} {Level:u3} {Message:lj}{NewLine}{Exception}")
                // .WriteTo.File(new ElasticsearchJsonFormatter() , @"logs/.log", LogEventLevel.Verbose, 1073741824, null, false, false, null, RollingInterval.Day, false, 7, null)
                // .WriteTo.Console(new ElasticsearchJsonFormatter())
                // .WriteTo.Console(outputTemplate:
                //  "{Timestamp:dd-MM-yyyy HH:mm:ss} {Level:u3} {Message:lj}{NewLine}{Exception}")
                //   "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}"
                .WriteTo.File(@"logs/.log", LogEventLevel.Verbose,
                "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzzz} [{Level:u4}] {Message:lj}{NewLine}{Exception}"
                , null, 1073741824, null, false, false, null, RollingInterval.Day)
                .WriteTo.Console(outputTemplate:
                    "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzzz} [{Level:u4}] {Message:lj}{NewLine}{Exception}")
                );
    }
}
