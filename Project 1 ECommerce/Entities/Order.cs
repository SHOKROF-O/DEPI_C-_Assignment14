namespace ECommerce.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }

        // Foreign Key
        public int CustomerId { get; set; }

        // Navigational Property (Relationship => Many Orders belong to 1 Customer)
        public Customer Customer { get; set; } = null!;

        // Navigational Property (Many-to-Many with Product through OrderDetail)
        public ICollection<OrderDetail> OrderDetails { get; set; } = new HashSet<OrderDetail>();
    }
}
