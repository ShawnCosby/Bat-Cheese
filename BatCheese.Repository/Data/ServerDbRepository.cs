using BatCheese.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BatCheese.Repository.Data
{
    public class ServerDbRepository : DbRepository<Server>, IServerDbRepository
    {
        public ServerDbRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public ServerDbRepository(Func<DbContext> dbContextInitFunc) : base(dbContextInitFunc)
        {
        }
    }
}
