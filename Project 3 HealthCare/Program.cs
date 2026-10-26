using HealthCare.Data;

namespace HealthCare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ApplicationDbContext dbContext = new ApplicationDbContext();

            // Add-Migration Init  ->  Update-Database  (see Steps.txt)
            Console.WriteLine("HealthCare Db is ready");
        }
    }
}
