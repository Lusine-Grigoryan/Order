using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Order.Shared.Interfaces
{
    public interface IRepository<TEntity>
    {
        bool Any(Func<TEntity, bool> filter);

          Task<IEnumerable<TEntity>> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "",
            bool asNoTracking = true);

        TEntity GetByID(object id);

        void Insert(TEntity entity);

        void Delete(object id);
        void Delete(TEntity entityToDelete);

        void Update(TEntity entityToUpdate);
    }
}
