namespace Catalog.Entities
{
   public record Item 
   {
       public Guid Id { get; init; }
       public string Name { get; init; }
       public string Price { get; init; }
       public DateTimeOffSet CreatedAt { get; init; }
   }
}