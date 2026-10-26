namespace Library.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }

        // Navigational Property (Relationship => 1 Author has Many Books)
        public ICollection<Book> Books { get; set; } = new HashSet<Book>();
    }
}
