using BloodBank.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BloodBank
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegButton_Click(object sender, EventArgs e)
        {
            User UO = new User();

            UO.UserName = UN.Text;
            UO.Password = Pass.Text;


            Server.Transfer("Register.aspx", true);
        }
    }
}