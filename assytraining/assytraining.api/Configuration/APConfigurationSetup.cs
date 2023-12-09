using assytraining.application.Domain;
using assytraining.application.Interfaces.Repositories;
using assytraining.application.Interfaces.Services;
using assytraining.application.Services;
using assytraining.infrastructure.Repositories;
using assytraining.infrastructure.Repositories.DataModel;

namespace assytraining.api.Configuration
{
    public static class APConfigurationSetup
    {
        public static void SetupAPConfiguration(IServiceCollection services)
        {
            services.AddScoped<IService<ApplicationParameterItem>, ConfigurationService>();
            services.AddScoped<IRepository<ApplicationParameterItem>, ConfigurationRepository<ApplicationParamItemDataModel>>();
            services.AddSingleton<ILogger<ApplicationParameterItem>, Logger<ApplicationParameterItem>>();
        }
    }
}
