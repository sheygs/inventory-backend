namespace Catalog.Repositories 
{
    public class FakeServices
    {
        private readonly List<Item> items  = new List<Item>()
        {
           new Item { Id = Guid.NewGuid(), Name = "T-shirt", Price = 500, CreatedAt = DateTimeOffSet.UtcNow },
           new Item { Id = Guid.NewGuid(), Name = "Choco Milo", Price = 100, CreatedAt = DateTimeOffSet.UtcNow },
           new Item { Id = Guid.NewGuid(), Name = "Pasta", Price = 400, CreatedAt = DateTimeOffSet.UtcNow },
           new Item { Id = Guid.NewGuid(), Name = "", Price = 150, CreatedAt = DateTimeOffSet.UtcNow }
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        };

        public Item GetItem(Guid Id)
        {
          return items.Where(item => item.Id == Id).SingleOrDefault();
        }
    }
}