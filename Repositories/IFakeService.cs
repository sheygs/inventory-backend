using System;
using System.Collections.Generic;
using Catalog.Entities;

namespace Catalog.Repositories
{
    public interface IFakeService
    {
      Item GetItem(Guid id);
      IEnumerable<Item> GetItems();    
    }

}
