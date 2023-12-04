using assytraining.application.Domain;
using assytraining.application.Interfaces.Repositories;
using assytraining.application.Interfaces.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assytraining.application.Services
{
    public class ConfigurationService(ILogger<ApplicationParameterItem> logger, IRepository<ApplicationParameterItem> repository) : IService<ApplicationParameterItem>
    {
        private readonly IRepository<ApplicationParameterItem> _repository = repository;
        private readonly ILogger<ApplicationParameterItem> _logger = logger;

        public IEnumerable<ApplicationParameterItem> GetAll()
        {
            return _repository.GetAll();
        }

        public ApplicationParameterItem GetBy(string id)
        {
            throw new NotImplementedException();
        }
    }
}
