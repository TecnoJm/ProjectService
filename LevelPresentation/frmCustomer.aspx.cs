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
    public partial class frmCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

            }
        }

        //Customer Values of the Customer.cs in Level Entities
        private Customer GetValues()
        {
            Customer objCustomer = new Customer();
            objCustomer.ID = 0;
            objCustomer.CustomerName = txtName.Text;
            objCustomer.Phone = txtPhone.Text;
            objCustomer.Email = txtEmail.Text;

            return objCustomer;
        }

        protected void btnRecord_Click(object sender, EventArgs e)
        {
            //Customer Registration

            Customer objCustomer = GetValues();
            //Send the information to Level Business
            bool response = CustomerBusiness.getInstance().RecordCustomer(objCustomer);
            if (response == true)
            {
                Response.Write("<script>alert('Customer Added!')</script>");
            }
            else
            {
                Response.Write("<script>alert('Customer Information Incorrect!')</script>");
            }
        }
    }
}