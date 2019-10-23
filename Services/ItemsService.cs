using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoApi.Domain;
using DemoApi.Persistence.Context;
using DemoApi.Persistence.Repositories;

namespace DemoApi.Services
{
    public class ItemsService : IItemsService
    { 
        private IItemsRepository _Repository;
        //private AppDbContext _serv;


        public ItemsService(IItemsRepository ItemRep, AppDbContext Serv )
        {
            _Repository = ItemRep;
           // _serv = Serv;
            
        }

        public async Task<IEnumerable<Item>> getAll()
        {
            var Data = await _Repository.getAll();
            return Data;
                
        }
        public void Add(Item data)
        {
             _Repository.Add(data);
            _Repository.SaveChanges();

        }
        public void Delete(int Id)
        {
            _Repository.Delete(Id);
            _Repository.SaveChanges();
           

        }
        public void Update(int Id, Item data)
        {
            _Repository.Update(Id, data);
            _Repository.SaveChanges();
        }

        public Item Get(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Item data)
        {
           // throw new NotImplementedException();
        }
    }
}
