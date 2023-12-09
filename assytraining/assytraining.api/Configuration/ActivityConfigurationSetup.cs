using assytraining.application.Domain;
using assytraining.application.Interfaces.Repositories;
using assytraining.application.Interfaces.Services;
using assytraining.application.Interfaces.Services.Activities;
using assytraining.application.Services;
using assytraining.application.Services.Activities;
using assytraining.infrastructure.Repositories;
using assytraining.infrastructure.Repositories.DataModel;

namespace assytraining.api.Configuration
{
    public static class ActivityConfigurationSetup
    {
        public static void SetupActivityConfiguration(IServiceCollection services)
        {
            services.AddScoped<IService<Activity>, ActivityManagementService>();
            services.AddScoped<IActivityCreatorService, ActivityCreatorService>();
            services.AddScoped<IActivityDeploymentService, ActivityDeploymentService>();
            services.AddScoped<IActivityExecutionService, ActivityExecutionService>();
            services.AddScoped<IActivityReaderService, ActivityReaderService>();


            services.AddScoped<IRepository<Activity>, ActivityRepository<ActivityDataModel>>();
        }
    }
}
