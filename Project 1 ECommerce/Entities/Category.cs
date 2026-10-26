namespace ECommerce.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        // Navigational Property (Relationship => 1 Category has Many Products)
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
