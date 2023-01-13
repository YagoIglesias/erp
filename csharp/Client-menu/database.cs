using System.Data ;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Infrastructure;
using System.Security.Cryptography;

namespace Client_menu
{
    internal class database
    {
        
        static string connectString = "server=localhost;userid=root;password=123;database=ERP";
        static MySqlConnection mySqlConnection;
        //static MySqlDataReader mySqlDataReader;
        //static MySqlCommand mySqlCommand;

        public static void Connect()
        {
            if (mySqlConnection == null || mySqlConnection.State != ConnectionState.Open)
            {
                mySqlConnection = new MySqlConnection(connectString);
                mySqlConnection.Open();

            }


        }

        public static void Insert(string sql)
        {
            using (MySqlCommand cmd = mySqlConnection.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 300;
                cmd.CommandText = sql;

                cmd.ExecuteNonQuery();
                
            }
        }

        public static void Update(string sql)
        {
            using (MySqlCommand cmd = mySqlConnection.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 300;
                cmd.CommandText = sql;

                cmd.ExecuteNonQuery();

            }





        }

        public static MySqlDataReader Select(string sql)
        {
            using (MySqlCommand cmd = mySqlConnection.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 300;
                cmd.CommandText = sql;

                var reader = cmd.ExecuteReader(); _ = reader.HasRows;
                return reader;

            }





        }

        public static string sha256(string input)
        {
            using (var hashGenerator = SHA256.Create())
            {
                var hash = hashGenerator.ComputeHash(Encoding.Default.GetBytes(input));
                return BitConverter.ToString(hash);


            

            }


        }

        



    }



}