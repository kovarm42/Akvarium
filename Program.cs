using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Akvarium
{
    internal class Program
    {
        static void Main(string[] args)

        {

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Zverimex_A;Integrated Security=True";
            using (SqlConnection spojeni = new SqlConnection(connectionString))

            {
                spojeni.Open();

                Console.WriteLine("Dotaz_1");

                string dotaz = "SELECT [Akvarium_nazev],[Zakaznik].[Jmeno],[Zakaznik].[Prijmeni] FROM[Akvarium] INNER JOIN[Zakaznik] ON[Akvarium].[Id_zakaznik] = [Zakaznik].[Id_Zakaznik] ORDER BY[Akvarium_nazev];";
                using (SqlDataAdapter adapter = new SqlDataAdapter(dotaz, spojeni))
                using (DataSet vysledky = new DataSet())
                {
                    adapter.Fill(vysledky);

                    foreach (DataRow radek in vysledky.Tables[0].Rows)
                    {
                        Console.WriteLine("Jmeno: " + radek[0] + ", Prijmeni: " + radek[1] + ", anglicky: " + radek[2]);
                    }

                    
                }


                spojeni.Close();
            }








            

            Console.ReadKey();







        }
    }
}
