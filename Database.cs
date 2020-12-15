using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;


namespace Proiect_PIU
{
    public class Database
    {
        static string connectionString;
        static SqlConnection connection;
        static public void Connection()
        {
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Facultate\\PIU\\Proiect_PIU\\StoreDB.mdf;Integrated Security=True";

        }
        public static void Interogare(string username, string password)
        {
            connection = new SqlConnection(connectionString);
            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";

            MessageBox.Show("Connection Open!");
            connection.Open();
            sql = "SELECT * FROM login";
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output += dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
            }
            connection.Close();
            MessageBox.Show(Output);
        }
        
    }
}
