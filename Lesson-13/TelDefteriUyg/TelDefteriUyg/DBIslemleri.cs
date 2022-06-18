using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TelDefteriUyg
{
    internal class DBIslemleri
    {
        static string baglanti = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\batuh\source\repos\CS102\Lesson-13\TelDefteriUyg\db\TelDefteri.mdf;Integrated Security=True;Connect Timeout=30";
        static SqlConnection connection = new SqlConnection(baglanti);
        public static DataSet ulkeleriCek()
        {
            string sql_command = "Select * from Ulkeler";
            SqlCommand cmd = new SqlCommand(sql_command, connection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = cmd;
            DataSet dataSet = new DataSet();
            connection.Open();  
            sqlDataAdapter.Fill(dataSet);   
            connection.Close();
            return dataSet; 
        }
       
        public static DataSet sehileriCek(int UlkeID)
        {
            string sql_command = "Select * from Sehirler where UlkeId ="+ UlkeID;
            SqlCommand sql = new SqlCommand(sql_command, connection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sql;
            DataSet dataSet = new DataSet();
            connection.Open();
            dataAdapter.Fill(dataSet);
            connection.Close();
            return dataSet;
        }
    }
}
