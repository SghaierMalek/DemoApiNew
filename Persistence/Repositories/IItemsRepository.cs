using DemoApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApi.Persistence.Repositories
{
    public interface IItemsRepository
    {
        

        Task<IEnumerable<Item>> getAll();
        void Add(Item data);
        void SaveChanges();
        void Delete(int Id);
        Item Get(int Id);
        
        void Update(int id, Item newdata);

    }

}
