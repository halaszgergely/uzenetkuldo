using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using uzenetkuldo.Interfaces;
using uzenetkuldo.Models;

namespace uzenetkuldo.Services
{
    public class UzenetServices : ICRUD
    {
        public string Create(Tablazat tablazat)
        {
            string connectionString = "SERVER = localhost;" +
                         "DATABASE= uzenetkuldo;" +
                         "UID = root;" +
                         "PASSWORD =;";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            string sql = "INSERT INTO uzenet (Szoveg, KüldesiIdo, UzenetTipus, Telefon, Email) VALUES (@szoveg, @küldesiido, @uzenettipus, @telefon, @email)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@szoveg", (tablazat as Uzenet).Szoveg);
            cmd.Parameters.AddWithValue("@küldesiido", (tablazat as Uzenet).KüldesiIdo);
            cmd.Parameters.AddWithValue("@uzenettipus", (tablazat as Uzenet).UzenetTipus);
            cmd.Parameters.AddWithValue("@telefon", (tablazat as Uzenet).Telefon);
            cmd.Parameters.AddWithValue("@email", (tablazat as Uzenet).Email);
            int sorokSzama = cmd.ExecuteNonQuery();
            conn.Close();
            if (sorokSzama > 0)
            {
                return "Sikeres beszúrás";
            }
            else
            {
                return "Sikertelen beszúrás";
            }
        }

        public List<Tablazat> Read()
        {
            List<Tablazat> tablazatok = new List<Tablazat>();
            string connectionString = "SERVER = localhost;" +
                        "DATABASE= uzenetkuldo;" +
                        "UID = root;" +
                        "PASSWORD =;";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            string sql = "SELECT * FROM uzenet";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = conn;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Uzenet uzenet = new Uzenet();
                uzenet.Id = reader.GetInt32("Id");
                uzenet.Szoveg = reader.GetString("Szoveg");
                uzenet.KüldesiIdo = reader.GetDateTime("KüldesiIdo");
                uzenet.UzenetTipus = reader.GetString("UzenetTipus");
                uzenet.Telefon = reader.IsDBNull(reader.GetOrdinal("Telefon")) ? null : reader.GetString("Telefon");
                uzenet.Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader.GetString("Email");
                tablazatok.Add(uzenet);
            }
            conn.Close();
            return tablazatok;
        }

        public string Update(Tablazat tablazat)
        {
            string connectionString = "SERVER = localhost;" +
                         "DATABASE= uzenetkuldo;" +
                         "UID = root;" +
                         "PASSWORD =;";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            string sql = "UPDATE uzenet SET Szoveg = @szoveg, KüldesiIdo = @küldesiido, UzenetTipus = @uzenettipus, Telefon = @telefon, Email = @email WHERE Id = @id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@szoveg", (tablazat as Uzenet).Szoveg);
            cmd.Parameters.AddWithValue("@küldesiido", (tablazat as Uzenet).KüldesiIdo);
            cmd.Parameters.AddWithValue("@uzenettipus", (tablazat as Uzenet).UzenetTipus);
            cmd.Parameters.AddWithValue("@telefon", (tablazat as Uzenet).Telefon);
            cmd.Parameters.AddWithValue("@email", (tablazat as Uzenet).Email);
            cmd.Parameters.AddWithValue("@id", (tablazat as Uzenet).Id);
            int sorokSzama = cmd.ExecuteNonQuery();
            conn.Close();
            return sorokSzama > 0 ? "Sikeres frissítés" : "Sikertelen frissítés";
        }

        public string Delete(int Id)
        {
            string connectionString = "SERVER = localhost;" +
                        "DATABASE= uzenetkuldo;" +
                        "UID = root;" +
                        "PASSWORD =;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string sql = "DELETE FROM uzenet WHERE Id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", Id);

                int sorokSzama = cmd.ExecuteNonQuery();
                return sorokSzama > 0 ? "Sikeres törlés" : "Sikertelen törlés";
            }
            catch (Exception ex)
            {
                return "Hiba történt a törlés során: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}