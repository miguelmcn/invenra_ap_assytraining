using assytraining.api.ViewModel;
using assytraining.application.Domain;
using assytraining.application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace assytraining.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConfigurationController(
        IService<ApplicationParameterItem> appConfigurationService
        ) : ControllerBase
    {

        [HttpGet("/json-params-atividade")]
        public async Task<IActionResult> GetAPConfigurationViewModel()
        {
            return Ok((await appConfigurationService.GetAll()).Select(u => new JsonParamItemViewModel
            {
                Name = u.Name,
                Type = u.Type,
            }));
        }
    }
}
