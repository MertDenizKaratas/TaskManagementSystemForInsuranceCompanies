﻿using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Departmant : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<DepartmantsFile> DepartmantsFiles { get; set; }
        public ICollection<DepartmantsIndividualTask> DepartmantsIndividualTask { get; set; }
    }
}
