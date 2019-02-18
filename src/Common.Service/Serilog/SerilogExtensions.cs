using Microsoft.AspNetCore.Hosting;
using Serilog;

namespace Common.Service.Serilog
{
    public static class SerilogExtensions
    {
        public static IWebHostBuilder UseCustomSerilog(this IWebHostBuilder builder)
        {
            return builder
                .UseSerilog((hostingContext, loggerConfiguration) => loggerConfiguration
                    .ReadFrom.Configuration(hostingContext.Configuration));
        }
    }
}
