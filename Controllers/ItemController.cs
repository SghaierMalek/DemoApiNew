using DemoApi.Domain;
using DemoApi.GenericRepositorys;
using DemoApi.GenericServices;
using DemoApi.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApi.Controllers
{
    [EnableCors("KPMGPolicy")]
    [Route("api/Item")]
    [ApiController]
    public class ItemController : Controller
    {



        private IGenericService<Item> _newService;

        public ItemController(IGenericService<Item> newService)
        {

            _newService = newService;

        }

        [HttpGet]
        public async Task<IEnumerable<Item>> getAll()
        {
            //var item = await _Test.getAll();
            //return item;
            var item = await _newService.GetAll();
            return item;

        }

        [HttpPost]
        public IActionResult Post([FromBody] Item obj)
        {

            if (!ModelState.IsValid)
                return BadRequest();

            _newService.Add(obj);
            return Ok(obj);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int Id)
        {
            //Item data = _Test.Get(Id);
            //if (data == null)
            //{
            //    return NotFound("Not found");
            //}
            //_Test.Delete(data);
            //return NoContent();
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _newService.Delete(Id);
            return Ok();

        }
        [HttpPut("{id}")]
        public IActionResult Put(int Id, [FromBody] Item data)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            _newService.Update(Id, data);
            return Ok();
        }
    }
}
