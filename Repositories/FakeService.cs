using System.Collections.Generic;
using Catalog.Entities;
using System;
using System.Linq;

namespace Catalog.Repositories 
{
   
    public class FakeService : IFakeService
    {
        private readonly List<Item> items  = new List<Item>()
        {
           new Item { Id = Guid.NewGuid(), Name = "T-shirt", Price = 500, CreatedAt = DateTimeOffset.UtcNow },
           new Item { Id = Guid.NewGuid(), Name = "Choco Milo", Price = 100, CreatedAt = DateTimeOffset.UtcNow },
           new Item { Id = Guid.NewGuid(), Name = "Pasta", Price = 400, CreatedAt = DateTimeOffset.UtcNow },
           new Item { Id = Guid.NewGuid(), Name = "Bread", Price = 150, CreatedAt = DateTimeOffset.UtcNow }
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(Guid Id)
        {
          return items.Where(item => item.Id == Id).SingleOrDefault();
        }

        
    }
}