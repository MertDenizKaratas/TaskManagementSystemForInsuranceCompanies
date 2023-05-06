using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DepartmantsFile
    {
        public int DepartmantId { get; set; }
        public Departmant Departmant { get; set; }
        public int FileId { get; set; }
        public ETicaretAPI.Domain.Entities.File File { get; set; }
    }
}
