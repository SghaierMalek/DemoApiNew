using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApi.GenericRepositorys
{
    public interface IGenericRepository<TEntity> where TEntity: class
    {
       Task <IEnumerable<TEntity>> GetAll();
      
        void Add(TEntity obj);

        Task Update(object id, TEntity obj);
        void Delete(object id);
        void SaveChanges();
    }
}

