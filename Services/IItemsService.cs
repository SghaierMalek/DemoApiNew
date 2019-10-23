using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoApi.Domain;

namespace DemoApi.Services

    {
        public interface IItemsService
        {
          Task<IEnumerable<Item>> getAll();
        void Add(Item data);
        void Delete(int  Id);
        Item Get(int Id);
        void Update(int id, Item data);
  
    }
}
    

