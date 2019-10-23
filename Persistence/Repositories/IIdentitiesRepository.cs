using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoApi.Domain;

namespace DemoApi.Persistence.Repositories
{
    public interface IIdentitiesRepository
    {
        Task<IEnumerable<Identity>> getAll();
        void Add(Identity cordonne);
        void SaveChanges();
    }
}
