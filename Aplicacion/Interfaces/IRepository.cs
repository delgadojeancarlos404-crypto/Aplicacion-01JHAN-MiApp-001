using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetByIdAsyng(int id);
        Task<List<T>>  GetAllAsync();
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);


        
    }
}
