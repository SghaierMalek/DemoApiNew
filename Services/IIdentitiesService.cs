using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoApi.Domain;
namespace DemoApi.Services
{
    public interface IIdentitiesService
    {
        

        Task<IEnumerable<Identity>> getAll();
        void Add(Identity cordonne);
    }
}
