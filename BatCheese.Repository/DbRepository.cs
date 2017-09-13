using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
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

        public bool AutoDetectChangesEnabled { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool LazyLoadingEnabled { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DbContextTransaction BeginTransation()
        {
            throw new NotImplementedException();
        }

        public DbContextTransaction BeginTransation(IsolationLevel isolationLevel)
        {
            throw new NotImplementedException();
        }

        public int Commit()
        {
            throw new NotImplementedException();
        }

        public Task<int> CommitAsync()
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void DetachEntries<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }

        public void DetachEntry<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public T Find(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<T> FindAsync(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Query(Expression<Func<T, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public DbSqlQuery<T> QueryWithSql(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
