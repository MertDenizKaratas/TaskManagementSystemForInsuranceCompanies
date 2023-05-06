using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProjectsAdministrativeWorkProcess
    {
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public int AdministrativeWorkProcessId { get; set; }
        public AdministrativeWorkProcess AdministrativeWorkProcess { get; set; }
    }
}
