using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CustomersContracts
    {
        public Customer Customer { get; set; }
        public string CustomerId { get; set; }
        public Contract Contract { get; set; }
        public int ContractId { get; set; }
    }
}
