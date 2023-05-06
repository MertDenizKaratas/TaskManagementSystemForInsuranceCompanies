using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class AdministrativeWorkProcess : BaseEntity
    {
        public string Title { get; set; }
        public string Definition { get; set; }
        public ICollection<CompaniesAdministrativeWorkProcess>? CompaniesAdministrativeWorkProcess { get; set; }
        public ICollection<ProjectsAdministrativeWorkProcess>? ProjectsAdministrativeWorkProcess { get; set; }
    }
}
