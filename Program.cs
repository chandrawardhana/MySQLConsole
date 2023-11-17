using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace MySQLTESTCON
{
    class Program
    {
        static void Main()
        {
            string server = "192.168.103.231";
            string database = "rv4_saf1";
            string username = "root";
            string password = "";

            string connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};";

            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                Console.WriteLine("Menunggu untuk Koneksi...");
                connection.Open();
                Console.WriteLine($"=============================================");
                Console.WriteLine("Connection opened successfully!");
                Console.WriteLine($"IP: {server}");
                Console.WriteLine($"DATABASE: {database}");
                Console.WriteLine($"User Privilege:{username}");
                Console.WriteLine($"=============================================");

             

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    Console.WriteLine($"=============================================");
                    Console.WriteLine("Connection closed.");
                }
            }

            Console.ReadLine();
        }
    }

}



