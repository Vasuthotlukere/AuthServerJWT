using AccessManagement.API.Models;

namespace AccessManagement.API.Services
{
    public static class AppSettingsService
    {
        public static AppSettings AddAppSettings(this IServiceCollection service)
        {
            var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Sandbox";

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                .AddJsonFile($"appsettings.{env}.json", optional : true)
                .AddEnvironmentVariables()
                .Build();

            var appSettings = configuration.GetSection("AppSettings").Get<AppSettings>();

            if (appSettings != null)
                throw new InvalidOperationException("AppSettings section is missing in configuration.");

            service.AddSingleton(appSettings);
            return appSettings;
        }
    }
}