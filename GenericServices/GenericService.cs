using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoApi.Domain;
using DemoApi.GenericRepositorys;

namespace DemoApi.GenericServices
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class
    {
        private IGenericRepository<TEntity> _repo;
       // private IGenericRepository<Identity> _repoidentity;

        public GenericService(IGenericRepository<TEntity> repo)
        {
            _repo = repo;
           // _repoidentity = repoidentity;
        }

        public void Add(TEntity obj)
        {
            _repo.Add(obj);
            _repo.SaveChanges();
        }

        public void Delete(object id)
        {
            _repo.Delete(id);
            _repo.SaveChanges();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            var res = await _repo.GetAll();
            return res;

        }

      

        public async Task Update(object id, TEntity obj)
        {
          await   _repo.Update(id, obj);
             _repo.SaveChanges();
        }
    }
   
}
