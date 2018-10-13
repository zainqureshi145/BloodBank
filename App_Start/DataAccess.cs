using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace BloodBank.App_Start
{
    public class DataAccess
    {
        private string ConnectionString = @"Server=localhost;Database=blooddonor;Uid=root;Pwd=1234";
        User UO = new User();

        public int RegisterUser(User UO)
        {

            int RowUpdated = 0;
            MySqlConnection connection = new MySqlConnection();
            MySqlCommand command = new MySqlCommand();
            string QueryString = "Insert Into donor(DonorName,DonorPass,DonorEmail) values('" + UO.UserName + "','" + UO.Password + "','" + UO.Email + "')";
            connection.ConnectionString = ConnectionString;
            command.CommandText = QueryString;
            command.Connection = connection;
            connection.Open();

            RowUpdated = command.ExecuteNonQuery();

            return RowUpdated;
        }
        public void DeleteUser()
        {
            MySqlConnection connection = new MySqlConnection();
            MySqlCommand command = new MySqlCommand();
            string QueryString = "Delete From donor Where DonorName = '"+UO.UserName+"'";
            connection.ConnectionString = ConnectionString;
            command.Connection = connection;
            command.CommandText = QueryString;
            connection.Open();
            command.ExecuteNonQuery();
        }


    }
}