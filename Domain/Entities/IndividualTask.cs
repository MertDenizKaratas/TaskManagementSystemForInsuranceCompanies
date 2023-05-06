using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class IndividualTask : BaseEntity
    {
        public string Title { get; set; }
        public ICollection<DepartmantsIndividualTask> DepartmantsIndividualTask { get; set; }
        public ICollection<EmployeesIndividualTask> EmployeesIndividualTask { get; set; }
    }
}
