using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace szamonkereslinq
{
    internal class SzornyAdatbazis
    {
        private readonly string connectionString;

        public SzornyAdatbazis()
        {
            this.connectionString = "server=localhost;port=3306;user=root;password=;database="fantasybestariumdb"; 
        }

        public List<Szorny> Feltolt()
        {
            var szornyek = new List<Szorny>();

            using (MySqlConnection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM szornyek";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Szorny szorny = new Szorny(
                                reader.GetInt32("id"),
                                reader.GetString("nev"),
                                reader.GetInt32("veszelyessegiSzint"),
                                reader.GetString("elohely"),
                                reader.GetString("foGyengeseg"),
                                reader.GetString("leggyakoribbZsakmany"),
                                reader.GetBoolean("veszelyesE")
                            );
                            szornyek.Add(szorny);
                        }
                    }

                }




                return szornyek;
            }
        }
    }
}