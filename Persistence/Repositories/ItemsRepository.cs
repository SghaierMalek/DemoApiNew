using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoApi.Domain;
using DemoApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace DemoApi.Persistence.Repositories
{
    public class ItemsRepository : IItemsRepository
    {
        private AppDbContext _context;

        public ItemsRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable <Item>> getAll()
        {
            var items = await _context.Items.ToListAsync();
            return items;

        }
        public void Add(Item data)
        {
            _context.Items.Add(data);
            _context.SaveChanges();

        }
        public void Delete(int Id)
        {
            var deleteItem = _context.Items.Find(Id);
            _context.Items.Remove(deleteItem);
            _context.SaveChanges();

        }
        public void Update(int Id, Item data)
        {
            var newdata = _context.Items.Find(Id);
            newdata.nom = data.nom;
            newdata.prenom = data.prenom;
            newdata.age = data.age;
            newdata.email = data.email;
            _context.SaveChanges();
        }


        public void SaveChanges()
        {
            //throw new NotImplementedException();
        }

        public Item Get(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
