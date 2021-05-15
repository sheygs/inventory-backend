using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Catalog.Entities;
using System;

namespace Catalog.Controllers 
{
    [ApiController]
    [Route("items")]
    public class ItemsControllers: ControllerBase
    {
        private readonly IFakeService services;
        public ItemsControllers(IFakeService services)
        {
            this.services = services;          
        }
 
        // GET /items
        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
          return services.GetItems();
        }

       // GET /items/{Id}
       [HttpGet("{Id}")]
       // ActionResult allows you to return more than one type
       public ActionResult<Item> GetItem(Guid Id)
       {
        var item = services.GetItem(Id);
        if (item is null)
        {
            return NotFound();
        }
        return Ok(item);
       }

    }
}