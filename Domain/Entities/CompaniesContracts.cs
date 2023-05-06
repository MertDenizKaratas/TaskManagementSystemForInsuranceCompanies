using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CompaniesContracts
    {
        public Company Company { get; set; }
        public int CompanyId { get; set; }
        public Contract Contract { get; set; }
        public int ContractId { get; set; }
    }
}
