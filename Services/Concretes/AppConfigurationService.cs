using API.Services.Interfaces;

namespace API.Services.Concretes
{
    public class AppConfigurationService : IAppConfigurationService
    {
        public string? KeyVaultName { get; set; }
        public string? SecretPrefix { get; set; }
        public string? IoTDeviceName { get; set; }
    }
}