using Blogs.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Application.Contracts.Repositories
{
    public interface IRepository<TEntity>
        where TEntity : Entity
    {
        TEntity Get(Expression<Func<TEntity, bool>> predicate);

        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate = null, 
            params Expression<Func<TEntity, object>>[] includes);

        void Insert(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        void Save();
    }
}
