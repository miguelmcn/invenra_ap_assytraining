using assytraining.application.Domain;
using assytraining.application.Interfaces.Repositories;
using assytraining.infrastructure.Repositories.Context;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace assytraining.infrastructure.Repositories
{
    public class ConfigurationRepository<TDataModel> : IRepository<ApplicationParameterItem>
        where TDataModel : class
    {
        private readonly IContext<TDataModel> _context;
        private readonly ILogger<ApplicationParameterItem> _logger;

        public ConfigurationRepository(IContext<TDataModel> context, ILogger<ApplicationParameterItem> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void Delete(ApplicationParameterItem dataModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ApplicationParameterItem> GetAll()
        {
            return _context.GetAll().Select(u => new ApplicationParameterItem
            {
                Name = "",
                Type = ""
            });
        }

        public ApplicationParameterItem GetBy<TId>(TId id)
        {
            throw new NotImplementedException();
        }

        public ApplicationParameterItem Save(ApplicationParameterItem dataModel)
        {
            throw new NotImplementedException();
        }
    }
}
