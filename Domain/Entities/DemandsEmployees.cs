using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DemandsEmployees
    {
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int DemandId { get; set; }
        public Demand Demand { get; set; }
    }
}
