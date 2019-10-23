using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace DemoApi.GenericRepositorys {
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private AppDbContext _context;



        public GenericRepository(AppDbContext context)
        {
            _context = context;

        }

       public void Add(TEntity obj)

        {
            _context.Set<TEntity>().Add(obj);
             _context.SaveChanges();
        }

        public void Delete(object id)
        {
            var delet = _context.Set<TEntity>().Find(id);
            _context.Set<TEntity>().Remove(delet);
            _context.SaveChanges();
        }

       

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            var donnee = await _context.Set<TEntity>().ToListAsync();
            return donnee;
        }

        public void SaveChanges()
        {
           // throw new NotImplementedException();
        }

        public async Task Update(object id, TEntity obj)
        {
            _context.Set<TEntity>().Update(obj);
            await _context.SaveChangesAsync();
        }



       
    }
    }