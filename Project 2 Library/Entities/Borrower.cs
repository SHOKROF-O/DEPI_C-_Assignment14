namespace Library.Entities
{
    public class Borrower
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime MembershipDate { get; set; }

        // Navigational Property (Many-to-Many with Book through Loan)
        public ICollection<Loan> Loans { get; set; } = new HashSet<Loan>();
    }
}
