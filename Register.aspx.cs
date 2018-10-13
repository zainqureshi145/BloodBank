using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BloodBank;
using BloodBank.App_Start;

namespace BloodBank
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Reg_Click(object sender, EventArgs e)
        {
            User UO = new User();
            UO.UserName = UN.Text;
            UO.Password = Pass.Text;
            UO.Email = Email.Text;

            DataAccess DAO = new DataAccess();

            int rows = DAO.RegisterUser(UO);
            if (rows > 0)
            {
                Response.Write("User Successfully Registered");
            }
        }
    }
}