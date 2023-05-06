using ETicaretAPI.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Employee : AppUser
    {
        public ICollection<EmployeesIndividualTask> EmployeesIndividualTask { get; set; }
    }
}
