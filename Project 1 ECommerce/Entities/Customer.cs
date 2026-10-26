namespace ECommerce.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        // Navigational Property (Relationship => 1 Customer has Many Orders)
        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
