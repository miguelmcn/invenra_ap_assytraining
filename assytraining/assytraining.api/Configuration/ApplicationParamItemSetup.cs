using assytraining.application.Domain;
using assytraining.application.Interfaces.Repositories;
using assytraining.application.Interfaces.Services;
using assytraining.application.Services;
using assytraining.infrastructure.Repositories;
using assytraining.infrastructure.Repositories.Context;
using assytraining.infrastructure.Repositories.DataModel;

namespace assytraining.api.Configuration
{
    public static class ApplicationParamItemSetup
    {
        public static void SetupApplicationParamItem(IServiceCollection services)
        {
            services.AddScoped<IService<ApplicationParameterItem>, ConfigurationService>();
            services.AddScoped<IRepository<ApplicationParameterItem>, ConfigurationRepository<ApplicationParamItemDataModel>>();
            services.AddScoped<IContext<ApplicationParamItemDataModel>, ConfigurationContext>();
            services.AddSingleton<ILogger<ApplicationParameterItem>, Logger<ApplicationParameterItem>>();
        }
    }
}
