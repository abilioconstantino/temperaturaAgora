using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ddtank.API.Repository.Interfaces
{

    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
   
        Task Add(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);
        
        Task<bool> SaveChangesAsync();
 
    }
}