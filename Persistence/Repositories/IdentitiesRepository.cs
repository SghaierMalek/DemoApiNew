using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoApi.Domain;
using DemoApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace DemoApi.Persistence.Repositories
{
    public class IdentitiesRepository: IIdentitiesRepository
    {
        private AppDbContext _authentification;


        public IdentitiesRepository(AppDbContext authentification)
        {
            _authentification = authentification;
        }

        public async Task<IEnumerable<Identity>> getAll()
        {
            var ident = await _authentification.Identities.ToListAsync();
            return ident;

        }
        public void Add(Identity cordonne)
        {
            _authentification.Identities.Add(cordonne);
            _authentification.SaveChanges();

        }

        public void SaveChanges()
        {
            //throw new NotImplementedException();
        }
    }

}

