namespace Catalog.Entities
{
   public record Item 
   {
       public string Id { get; init; }
       public string Name { get; init; }
       public string Price { get; init; }
       public string DateTimeOffSet CreatedAt { get; init; }
   }
}