using ETicaretAPI.Application.Repositories;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Repositories
{
    public class FileWriteRepository : WriteRepository<ETicaretAPI.Domain.Entities.File>, IFileWriteRepository
    {
        public FileWriteRepository(TMSDbContext context) : base(context)
        {
        }
    }
}
