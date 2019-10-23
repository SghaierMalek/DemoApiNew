using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoApi.Domain;
using DemoApi.Persistence.Repositories;

namespace DemoApi.Services
{

    public class IdentitiesService: IIdentitiesService
    {
        private IIdentitiesRepository _Repository;

        public IdentitiesService(IIdentitiesRepository ItemRep)
        {
            _Repository = ItemRep;

        }

        public async Task<IEnumerable<Identity>> getAll()
        {
            var Data = await _Repository.getAll();
            return Data;

        }
        public void Add(Identity cordonne)
        {
            _Repository.Add(cordonne);
            _Repository.SaveChanges();

        }

    }

}

