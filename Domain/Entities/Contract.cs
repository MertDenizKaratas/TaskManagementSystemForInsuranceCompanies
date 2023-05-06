using Domain.Enums;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Contract : BaseEntity
    {
        public string Name { get; set; }
        public ContractType Type { get; set; }
        public ICollection<BranchOfficeContracts>? BranchOfficeContracts { get; set; }
        public ICollection<CompaniesContracts>? CompaniesContracts { get; set; }
        public ICollection<CustomersContracts>? CustomersContracts { get; set; }
    }
}
