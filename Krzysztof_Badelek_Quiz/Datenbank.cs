using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Krzysztof_Badelek_Quiz
{
    public partial  class Datenbank
    {
        public static List<string> GetFragen()
        {
            List<string> fragenListe = new List<string>();
            string sqlconn = "Server=localhost;Database=Quiz;User ID=root;Password=;";
            //MySqlConnection conn = new MySqlConnection(sqlconn);

            

           
           // string fragenString = frage;
            

              //  connection.Open();
        using(var conn = new MySqlConnection(sqlconn))
            {
                conn.Open();
                MySqlCommand query = new MySqlCommand("SELECT * FROM Frage ORDER BY RAND() LIMIT BY 10;");
                using (MySqlDataReader reader = query.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        // Assuming the result is a string, change the data type accordingly
                                        string resultValue = reader.GetString(0);

                                        // Add the value to the list
                                        fragenListe.Add(resultValue);
                                    }
                                }
                conn.Close();
            }
                
               // query.Parameters.AddWithValue(fragenString, fragenString);
                //query.Prepare();
                

               

                

            return fragenListe;
            
        }
           
            
           
            
        
    }
    
   
}
