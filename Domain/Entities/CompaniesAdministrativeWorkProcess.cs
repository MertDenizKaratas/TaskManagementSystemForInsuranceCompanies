using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CompaniesAdministrativeWorkProcess
    {
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public int AdministrativeWorkProcessId { get; set; }
        public AdministrativeWorkProcess AdministrativeWorkProcess { get; set; }
    }
}
