using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Krzysztof_Badelek_Quiz
{
    public partial class Datenbank
    {
        
        //private const string VerbindungsString = "Server=localhost;Database=Quiz;User=root;Password='';";

        public Datenbank()
        {

        }
        public DataSet PullDataFromDB()
        {
            string connectionString = "Server=localhost;Database=Quiz;User=root;Password='';";
            string query = "SELECT Name, Punkte FROM spieler ORDER BY Punkte DESC;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    return ds;
                }
            }
        }

        public void UpdatePoints(string spieler, int punkte)
        {
            string connStr = "Server=localhost;Database=Quiz;User=root;Password='';";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string sql = $"UPDATE Spieler SET Punkte = GREATEST(@punkte, Punkte) WHERE Name = '@spieler';";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@spieler", spieler);
                    cmd.Parameters.AddWithValue("@punkte", punkte);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void SaveSpieler(string Spieler)
        {
            string connStr = "Server=localhost;Database=Quiz;User=root;Password='';";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            string sql = $"INSERT INTO Spieler(Name) VALUES (@Spieler);";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Spieler", Spieler);
            cmd.ExecuteNonQuery();
            
          
            conn.Close();

            
        }
        public bool FindInDb(string Spieler)
        {
            string connStr = "Server=localhost;Database=Quiz;User=root;Password='';";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            string sql = $"SELECT * FROM spieler WHERE Name = @spieler;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            
            cmd.Parameters.AddWithValue("@Spieler", Spieler);
            var result = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return result > 0;
            
        }
        public string GetRichtigeAntwort(string frage, string antwort, string frageValue)
        {
            string connStr = "Server=localhost;Database=Quiz;User=root;Password='';";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            string sql = $"SELECT {antwort} FROM frage WHERE {frage} = '{frageValue}'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            string correctAnswer = "";
            while (rdr.Read())
            {
                correctAnswer = Convert.ToString(rdr[0]);
            }

            rdr.Close();
            conn.Close();

            return correctAnswer;
        }

        public List<string> GetRandomAntwort(string frage, string antwort, string frageValue)
        {
            List<string> antwortList = new List<string>();
            string connStr = "Server=localhost;Database=Quiz;User=root;Password='';";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            string sql = $"SELECT {antwort} FROM frage WHERE {frage} != '{frageValue}' ORDER BY RAND() LIMIT 3 ";
    
       

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            List<string> list = new List<string>();
            while (rdr.Read())
            {
                for (int i = 0; i < rdr.FieldCount; i++)
                {
                    string value = Convert.ToString(rdr[i]);
                    antwortList.Add(value);
                }
            }

            rdr.Close();
            conn.Close();

            return antwortList;
        }


        public List<string> GetRandomFragen(string fragenArt)
        {
            List<string> fragenList = new List<string>();
            
            string connStr = "Server=localhost;Database=Quiz;User=root;Password='';";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            string sql = $"SELECT {fragenArt} FROM frage ORDER BY RAND() LIMIT 10; ";
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for(int i = 0; i < reader.FieldCount; i++)
                        {
                            string value = Convert.ToString(reader[i]);
                            fragenList.Add(value);
                        }
                        

                    }
                }
            }
                return fragenList;
           
        }
        
    }   
}
