using ETicaretAPI.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Customer : AppUser
    {
        public ICollection<CustomersContracts>? CustomersContracts { get; set; }
    }
}
