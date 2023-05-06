using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BranchOffice : BaseEntity
    {
        public string OfficialName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public ICollection<BranchOfficeContracts>? BranchOfficeContracts { get; set; }
    }
}
