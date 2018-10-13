using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BloodBank
{
    class Donor
    {
        public String Donor_Name { get; set; }
        public string Donor_CNIC { get; set; }
        public String Donor_BGroup {get; set;}
        public string Donor_RH { get; set; }
        public String Donor_Address { get; set; }
        public String Donor_Tel { get; set; }
    }
}
