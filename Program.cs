using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Akvarium
{
    internal class Program
    {
        static void Main(string[] args)

        {

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Zverimex_A;Integrated Security=True";
            using (SqlConnection pripojeni = new SqlConnection(connectionString))
            {
                pripojeni.Open();
                Console.WriteLine("Aplikace se úspěšně připojila k databázi.");
            }
            Console.ReadKey();







        }
    }
}
