using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class EmployeesIndividualTask
    {
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int IndividualTaskId { get; set; }
        public IndividualTask IndividualTask { get; set; }
    }
}
