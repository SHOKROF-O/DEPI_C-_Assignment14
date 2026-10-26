namespace Library.Entities
{
    // Joining table for the Many-to-Many between Book and Borrower
    public class Loan
    {
        public int BookId { get; set; }
        public int BorrowerId { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }   // null until the book is returned

        public Book Book { get; set; } = null!;
        public Borrower Borrower { get; set; } = null!;
    }
}
