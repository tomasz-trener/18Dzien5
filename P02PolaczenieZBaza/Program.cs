using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02PolaczenieZBaza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection;// do nawiązywania polaczenia z baza
            SqlCommand command; // przechwywanie polecen sql 
            SqlDataReader sqlDataReader;// do czytania wynikow 

            string connString = "Data Source=.;Initial Catalog=Zawodnicy;User ID=sa;Password=alx";

            connection = new SqlConnection(connString);

            command = new SqlCommand("select * from zawodnicy", connection);

            connection.Open();

            sqlDataReader= command.ExecuteReader();
           
            //sqlDataReader.Read();
            //string wynik = (string)sqlDataReader.GetValue(2);
            //Console.WriteLine(wynik);
            //sqlDataReader.Read();
            //wynik = (string)sqlDataReader.GetValue(2);
            //Console.WriteLine(wynik);
            while (sqlDataReader.Read())
            {
                 string wynik = (string)sqlDataReader.GetValue(2)+ " " +
                         (string)sqlDataReader.GetValue(3);
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    object komorka = sqlDataReader.GetValue(i);
                }
                Console.WriteLine(wynik);
            }


            connection.Close();

            Console.ReadKey();
        }
    }
}
