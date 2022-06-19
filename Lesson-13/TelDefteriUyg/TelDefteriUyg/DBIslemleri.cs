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

        public static void Ekle(string ad, string soyad, string telefon, int sehirID, string adress)
        {
            string sql_command = "Insert Into Kisiler VALUES (@pAd,@pSoyad,@pTelefon,@pSehirID,@pAdress)";
            SqlCommand command = new SqlCommand(sql_command, connection);
            command.Parameters.AddWithValue("@pAd",ad);
            command.Parameters.AddWithValue("@pSoyad", soyad);
            command.Parameters.AddWithValue("@pTelefon", telefon);
            command.Parameters.AddWithValue("@pSehirID", sehirID);
            command.Parameters.AddWithValue("@pAdress", adress);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static DataSet Arama(string ad)
        {
            string sql_command = "Select * From Kisiler where Adi like  @pAd+'%'";
            SqlCommand sqlCommand = new SqlCommand(sql_command,connection);
            sqlCommand.Parameters.AddWithValue("@pAd",ad);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataSet = new DataSet();
            connection.Open();
            dataAdapter.Fill(dataSet);
            connection.Close();
            return dataSet;
        }

        public static void Guncelle(int KisiID, string tel, string adress)
        {
            string sql_command = "Update Kisiler Set Telefon = @pTel, Adress = @pAdress where KisiID = @pKisiID";
            SqlCommand sqlCommand = new SqlCommand(sql_command, connection);
            sqlCommand.Parameters.AddWithValue("@pTel", tel);
            sqlCommand.Parameters.AddWithValue("@pAdress", adress);
            sqlCommand.Parameters.AddWithValue("@pKisiID", KisiID);

            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        public static void Sil(int KisiID)
        {
            string sql_command = "Delete From Kisiler where KisiID = @pKisiID";
            SqlCommand sqlCommand = new SqlCommand(sql_command, connection);
            sqlCommand.Parameters.AddWithValue("@pKisiID", KisiID);

            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }
    }
}
