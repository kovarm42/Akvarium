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

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Zverimex_A;Integrated Security=True;";
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
                        Console.WriteLine("Název akvaria: " + radek[0] + ", Jméno: " + radek[1] + ", Příjmení: " + radek[2]);
                    }

                    
                }

                Console.WriteLine("Dotaz_2");

                string dotaz_2 = "SELECT [Ryba_nazev],[Akvarium_nazev],[Datum_pridani],[Datum_odebrani]FROM[Obsah_akvaria]INNER JOIN[Ryba] ON[Obsah_akvaria].[Id_Ryba] = [Ryba].[Id_Ryba]INNER JOIN[Akvarium] ON[Obsah_akvaria].[Id_akvarium] = [Akvarium].[Id_Akvarium];";
                using (SqlDataAdapter adapter = new SqlDataAdapter(dotaz_2, spojeni))
                using (DataSet vysledky = new DataSet())
                {
                    adapter.Fill(vysledky);

                    foreach (DataRow radek in vysledky.Tables[0].Rows)
                    {
                        Console.WriteLine("Ryba název: " + radek[0] + ", Akvarium název: " + radek[1] + ", Datum přijetí: " + radek[2] + ", Datum odebrání: " + radek[3]);
                    }


                }

                Console.WriteLine("Dotaz_3");

                string dotaz_3 = "SELECT [Ryba_nazev],[Akvarium_nazev],[Datum_pridani],[Datum_odebrani]FROM[Obsah_akvaria]INNER JOIN[Ryba] ON[Obsah_akvaria].[Id_Ryba] = [Ryba].[Id_Ryba]INNER JOIN[Akvarium] ON[Obsah_akvaria].[Id_akvarium] = [Akvarium].[Id_Akvarium];";
                using (SqlDataAdapter adapter = new SqlDataAdapter(dotaz_3, spojeni))
                using (DataSet vysledky = new DataSet())
                {
                    adapter.Fill(vysledky);

                    foreach (DataRow radek in vysledky.Tables[0].Rows)
                    {
                        Console.WriteLine("Ryba název: " + radek[0] + ", Akvarium název: " + radek[1] + ", Datum přijetí: " + radek[2] + ", Datum odebrání: " + radek[3]);
                    }


                }







                spojeni.Close();
            }








            

            Console.ReadKey();







        }
    }
}
