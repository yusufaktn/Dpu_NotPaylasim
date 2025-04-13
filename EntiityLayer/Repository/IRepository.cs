using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EntiityLayer.Repository
{
    public  interface IRepository<T> where T : class
    {
        Task<T> GetByIdAsync(Expression<Func<T,bool>>expression,CancellationToken cancellationToken= default);
        Task AddAsync(T entity, CancellationToken cancellationToken = default);//
        void UpdateAsync(T entity);
        void Remove(T entity);
        IQueryable<T> GetAllAsync();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> expression);
    }
   
}
