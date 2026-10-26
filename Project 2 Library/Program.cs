using Library.Data;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();

            dbContext.Database.Migrate();   // applies the Init migration and creates the database
            Console.WriteLine("Library Db is ready");
        }
    }
}
