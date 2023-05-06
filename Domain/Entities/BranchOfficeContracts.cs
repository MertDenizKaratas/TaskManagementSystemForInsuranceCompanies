using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BranchOfficeContracts
    {
        public BranchOffice BranchOffice { get; set; }
        public int BranchOfficeId { get; set; }

        public Contract Contract { get; set; }
        public int ContractId { get; set; }
    }
}
