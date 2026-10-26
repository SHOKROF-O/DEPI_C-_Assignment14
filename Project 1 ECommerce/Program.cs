using ECommerce.Data;

namespace ECommerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();

            dbContext.Database.Migrate();   // applies the Init migration and creates the database
            Console.WriteLine("ECommerce Db is ready");
        }
    }
}
