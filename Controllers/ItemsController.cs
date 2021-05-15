using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Catalog.Entities;
using System;
using System.Linq;
using Catalog.Dtos;

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
        public IEnumerable<ItemDto> GetItems()
        {
          return services.GetItems().Select(item => item.AsDto());
        }

       // GET /items/{Id}
       [HttpGet("{Id}")]
       // ActionResult allows you to return more than one type
       public ActionResult<ItemDto> GetItem(Guid Id)
       {
        var item = services.GetItem(Id);
        if (item is null)
        {
            return NotFound();
        }
        return Ok(item.AsDto());
       }

    }
}