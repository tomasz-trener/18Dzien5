using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04BibliotekaPolaczenieZBaza
{
    public class PolaczenieZBaza
    {
        private string connString;

        public PolaczenieZBaza(string connString)
        {
            this.connString = connString;
        }

        public object[][] WykonajZapytanie(string sql)
        {
            SqlConnection connection;// do nawiązywania polaczenia z baza
            SqlCommand command; // przechwywanie polecen sql 
            SqlDataReader sqlDataReader;// do czytania wynikow 

            connection = new SqlConnection(connString);

            command = new SqlCommand(sql, connection);

            connection.Open();

            sqlDataReader = command.ExecuteReader();

            List<object[]> listaWierszy = new List<object[]>();

            int liczbaKolumn = sqlDataReader.FieldCount;

            while (sqlDataReader.Read())
            {
                object[] komorki = new object[liczbaKolumn];
                for (int i = 0; i < liczbaKolumn; i++)
                    komorki[i]= sqlDataReader.GetValue(i);
                
                listaWierszy.Add(komorki);
            }

            connection.Close();

            return listaWierszy.ToArray();
        }


    }
}
