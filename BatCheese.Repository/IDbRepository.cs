using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BatCheese.Repository
{
    public interface IDbRepository<T> : IDisposable where T : class
    {
        bool AutoDetectChangesEnabled { get; set; }

        bool LazyLoadingEnabled { get; set; }


        DbContextTransaction BeginTransation();

        DbContextTransaction BeginTransation(IsolationLevel isolationLevel);

        void DetachEntries<TEntity>() where TEntity : class;

        void DetachEntry<TEntity>(TEntity entity) where TEntity : class;

        int Commit();

        Task<int> CommitAsync();

        void Delete(T entity);

        T Find(params object[] keyValues);

        Task<T> FindAsync(params object[] keyValues);

        void Insert(T entity);

        IQueryable<T> Query(Expression<Func<T, bool>> filter = null);

        DbSqlQuery<T> QueryWithSql(string sql, params object[] parameters);

        void Update(T entity);
    }
}
