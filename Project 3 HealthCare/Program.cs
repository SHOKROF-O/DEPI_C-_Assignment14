using HealthCare.Data;

namespace HealthCare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();

            dbContext.Database.Migrate();   // applies the Init migration and creates the database
            Console.WriteLine("HealthCare Db is ready");
        }
    }
}
