namespace ECommerce.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

        // Foreign Key
        public int CategoryId { get; set; }

        // Navigational Property (Relationship => Many Products belong to 1 Category)
        public Category Category { get; set; } = null!;

        // Navigational Property (Many-to-Many with Order through OrderDetail)
        public ICollection<OrderDetail> OrderDetails { get; set; } = new HashSet<OrderDetail>();
    }
}
