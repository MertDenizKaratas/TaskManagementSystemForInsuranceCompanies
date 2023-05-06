using ETicaretAPI.Application.Repositories;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Repositories
{
    public class FileReadRepository : ReadRepository<ETicaretAPI.Domain.Entities.File>, IFileReadRepository
    {
        public FileReadRepository(TMSDbContext context) : base(context)
        {
        }
    }
}
