using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BatCheese.Repository
{
    public abstract class DbRepository<T> : IDbRepository<T> where T : class
    {
        private Lazy<DbContext> lazyDb;

        protected DbRepository(DbContext dbContext)
        {
            this.lazyDb = new Lazy<DbContext>(() => dbContext, LazyThreadSafetyMode.None);
        }

        protected DbRepository(Func<DbContext> dbContextInitFunc)
        {
            this.lazyDb = new Lazy<DbContext>(dbContextInitFunc, LazyThreadSafetyMode.ExecutionAndPublication);
        }


    }
}
