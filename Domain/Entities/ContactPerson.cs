using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ContactPerson : BaseEntity
    {
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
