using assytraining.api.ViewModel;
using assytraining.application.Domain;
using assytraining.application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace assytraining.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnalyticsController(
        IService<AnalyticsConfiguration> analyticsConfigurationService,
        IAnalyticsReportService analyticsReportService
        ) : Controller
    {
        [HttpGet("/lista-analytics-atividade")]
        public async Task<IActionResult> GetAnalyticsListViewModel()
        {
            var domainmodel = await analyticsConfigurationService.GetBy(string.Empty);

            var viewmodel = new AnalyticsListViewModel
            {
                Qualitative = domainmodel?.Qualitative?.Select(u => new AnalyticsItemViewModel { Name = u.Name, Type = u.Type, Value = u.Value }),
                Quantitative = domainmodel?.Quantitative?.Select(u => new AnalyticsItemViewModel { Name = u.Name, Type = u.Type, Value = u.Value }),
            };

            return Ok(viewmodel);
        }

        [HttpPost("/analytics-atividade")]
        public async Task<IActionResult> GetAnalyticsViewModel([FromBody] GetAnalyticsViewModel activityID)
        {
            var domainmodel = await analyticsReportService.GetReport(activityID.ActivityID);

            var viewmodel = new AnalyticsViewModel
            {
                InvenIRAStudentID = domainmodel.InvenIRAStudentID,
                Qualitative = domainmodel?.Qualitative?.Select(u => new AnalyticsItemViewModel { Name = u.Name, Type = u.Type, Value = u.Value }),
                Quantitative = domainmodel?.Quantitative?.Select(u => new AnalyticsItemViewModel { Name = u.Name, Type = u.Type, Value = u.Value }),
            };

            return Ok(viewmodel);
        }
    }
}
