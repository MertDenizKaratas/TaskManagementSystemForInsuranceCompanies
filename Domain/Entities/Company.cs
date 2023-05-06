using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Company : BaseEntity
    {
        public string OfficialName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public ICollection<CompaniesContracts>? CompaniesContracts { get; set; }
        public ICollection<CompaniesAdministrativeWorkProcess> CompaniesAdministrativeWorkProcess { get; set; }
    }
}
