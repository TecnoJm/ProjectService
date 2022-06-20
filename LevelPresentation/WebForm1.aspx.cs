using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LevelEntities;
using LevelBusiness;

namespace LevelPresentation
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            //Log In with Local Database Connection

            //Instance with UserBusiness Class
            User objUser = UserBusiness.getInstance().LogIn(txtUser.Text, txtPassword.Text);

            if(objUser != null)
            {
                Response.Write("<script>alert('Welcome!')</script>");
                Response.Redirect("GeneralPanel.aspx");
            }
            else
            {
                Response.Write("<script>alert('Wrong user')</script>");
            }
        }
    }
}