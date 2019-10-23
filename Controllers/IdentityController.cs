using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoApi.Domain;
using DemoApi.Persistence.Context;
using DemoApi.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{
    [EnableCors("KPMGPolicy")]
    [Route("api/identity")]
    [ApiController]
    public class IdentityController : Controller
    {
   
        private IIdentitiesService _Test;
        private readonly AppDbContext _context;

        public IdentityController(IIdentitiesService Rep, AppDbContext context)
        {
            _Test = Rep;
            _context = context;

        }

        [HttpGet]
        public async Task<IEnumerable<Identity>> getAll()
        {
            var identiti = await _Test.getAll();
            return identiti;


        }

        [HttpPost]

        public IActionResult Post([FromBody] Identity cordonne)
        {

            var Login = cordonne.login;
            var Password = cordonne.password;
            var result = _context.Identities.FirstOrDefault(x => x.login == Login
                                                        && x.password == Password);
            if (result != null)
            {
                return Ok(cordonne);
            }
            else
            {
               return Ok("Verify");
            }

            
        }


    }
    }

