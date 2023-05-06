using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Commands.AppUser.CreateEmployee
{
    public class CreateEmployeeCommandResponse
    {
        public bool Succeeded { get; set; }
        public string Message { get; set; }
    }
}
