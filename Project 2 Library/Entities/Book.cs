namespace Library.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;

        // Foreign Key
        public int AuthorId { get; set; }

        // Navigational Property (Relationship => Many Books belong to 1 Author)
        public Author Author { get; set; } = null!;

        // Navigational Property (Many-to-Many with Borrower through Loan)
        public ICollection<Loan> Loans { get; set; } = new HashSet<Loan>();
    }
}
