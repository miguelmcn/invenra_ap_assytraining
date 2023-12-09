using assytraining.application.Domain;
using assytraining.application.Interfaces.Repositories;
using assytraining.application.Interfaces.Services;
using assytraining.application.Services.Metrics;
using assytraining.infrastructure.Repositories;

namespace assytraining.api.Configuration
{
    public static class AnalyticsConfigurationSetup
    {
        public static void SetupAnalyticsConfiguration(IServiceCollection services)
        {
            services.AddScoped<IService<AnalyticsConfiguration>, AnalyticsConfigurationService>();            
            services.AddScoped<IRepository<AnalyticsConfiguration>, AnalyticsConfigurationRepository<AnalyticsConfiguration>>();
        }
    }
}
