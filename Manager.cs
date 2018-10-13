using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace BloodBank
{
    class Manager:Donor{
        Donor DO = new Donor();

        private string ConnectionString = "Server=localhost;Database=blooddonor;Uid=root;Pwd=1234";
        public void Register()
        {
            Console.WriteLine("Enter Donor Name ");
            DO.Donor_Name = Console.ReadLine();
            Console.WriteLine("Enter Donor CNIC ");
            DO.Donor_CNIC = Console.ReadLine();
            Console.WriteLine("Enter Donor Blood Group ");
            DO.Donor_BGroup = Console.ReadLine();
            Console.WriteLine("Enter Donor RH Factor ");
            DO.Donor_RH = Console.ReadLine();
            Console.WriteLine("Enter Donor Address ");
            DO.Donor_Address = Console.ReadLine();
            Console.WriteLine("Enter Donor Telephone Number ");
            DO.Donor_Tel = Console.ReadLine();

            //Create Connection
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = ConnectionString;
            Console.WriteLine(connection.Ping().ToString());
            connection.Open();

            Console.WriteLine("Connection Established");

            string queryString = "Insert Into donor(Donor_Name,Donor_CNIC,Donor_BGroup,Donor_RH,Donor_Address,Donor_Tel) Values('" + DO.Donor_Name + "','" + DO.Donor_CNIC + "','" + DO.Donor_BGroup + "','" + DO.Donor_RH + "','" + DO.Donor_Address + "','" + DO.Donor_Tel + "')";

            MySqlCommand command = new MySqlCommand();

            command.CommandText = queryString;
            command.Connection = connection;

            int result = command.ExecuteNonQuery();
            if (result == 1)
            {
                Console.WriteLine("Donor Registered...");
            }
            connection.Close();
        }/////////////////////////////Register Ended Here

        public void SearchByName()/////////////SearchByName Started Here
        {
            Console.WriteLine("Enter Name To Search ");
            DO.Donor_Name = Console.ReadLine();
            string Name = DO.Donor_Name;
            string queryString = "select * from donor where Donor_Name = '"+Name+"'";
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = ConnectionString;
                connection.Open();
                Console.WriteLine("Connection Established...");
                MySqlDataReader reader = null;
                MySqlCommand command = new MySqlCommand();
                command.CommandText = queryString;
                command.Connection = connection;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("Name = " + reader["Donor_Name"].ToString());
                    Console.WriteLine("CNIC = " + reader["Donor_CNIC"].ToString());
                    Console.WriteLine("Blood Group = " + reader["Donor_BGroup"].ToString());
                    Console.WriteLine("Blood RH Factor = " + reader["Donor_RH"].ToString());
                    Console.WriteLine("Donor Address = " + reader["Donor_Address"].ToString());
                    Console.WriteLine("Donor Telephone Number = " + reader["Donor_Tel"].ToString());
                }
                connection.Close();
        }////////////////////////////////////////SearchByName Ended Here
        public void MatchingBGroup()/////////////////////////////////Matching Blood Group
        {
            Console.WriteLine("Search Matching Blood Group ");
            DO.Donor_BGroup = Console.ReadLine();
            string BloodType = DO.Donor_BGroup;  
            MySqlConnection connection = new MySqlConnection();
            MySqlDataReader reader = null;
            connection.ConnectionString = ConnectionString;
            connection.Open();
            Console.WriteLine("Connection Established...");
            string queryString = "Select * From donor Where Donor_BGroup = '"+BloodType+"'";
            MySqlCommand command = new MySqlCommand();
            command.CommandText = queryString;
            command.Connection = connection;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Name = " + reader["Donor_Name"].ToString());
            }
            connection.Close();

        }////////////////////////////////////////////////////////////Matching Blood Group
        public void DisplayDonors()/////////////////////////////////Display Donors
        {
            Console.WriteLine("Connecting To Database.... ");
            MySqlConnection connection = new MySqlConnection();
            MySqlDataReader reader = null;
            connection.ConnectionString = ConnectionString;
            connection.Open();
            Console.WriteLine("Connection Established...");
            Console.WriteLine("Searching Donors.... ");
            string queryString = "Select * From donor";
            MySqlCommand command = new MySqlCommand();
            command.CommandText = queryString;
            command.Connection = connection;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Name = " + reader["Donor_Name"].ToString());
            }
            connection.Close();
        }////////////////////////////////////////////////////////////Display Donors
        public void Amount()////////////////////////////////////////Amount
        {
            string queryString = "select count(1) from donor";/////////Change this Query....
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = ConnectionString;
                connection.Open();
                MySqlCommand command = new MySqlCommand();

                command.CommandText = queryString;
                command.Connection = connection;

                object objValue = command.ExecuteScalar();

                if (objValue != null)
                {
                    Console.WriteLine("Blood Types Available are " +objValue.ToString());
                }

                connection.Close();
            }////////////////////////////////////////////////////////Amount Ended Here
    }
}
