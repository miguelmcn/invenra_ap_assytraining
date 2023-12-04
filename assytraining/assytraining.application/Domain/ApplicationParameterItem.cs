using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace assytraining.application.Domain
{
    public class ApplicationParameterItem : IDomainModel
    {        
        public required string Name { get; set; }

        public required string Type { get; set; }
    }
}
