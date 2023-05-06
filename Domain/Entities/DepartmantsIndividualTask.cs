using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DepartmantsIndividualTask
    {
        public int DepartmantId { get; set; }
        public Departmant Departmant { get; set; }
        public int IndividualTaskId { get; set; }
        public IndividualTask IndividualTask { get; set; }
    }

}
