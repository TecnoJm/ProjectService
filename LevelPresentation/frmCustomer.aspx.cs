using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LevelEntities;
using LevelBusiness;
using System.Web.Services;

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

        //##################################################################//

        [WebMethod]
        public static List<Customer> ListCustomer()
        {
            List<Customer> Lista = null;
            try
            {
                Lista = CustomerBusiness.getInstance().ListCustomer();
            }
            catch(Exception ex)
            {
                Lista = null;
            }

            return Lista;
        }

        //##################################################################//

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

        //##################################################################//

        protected void btnRecord_Click(object sender, EventArgs e)
        {
            //Customer Registration

            Customer objCustomer = GetValues();
            //Send the information to Level Business
            bool response = false;
            if (txtName.Text != "" && txtEmail.Text != "" && txtPhone.Text != "")
            {
                response = CustomerBusiness.getInstance().RecordCustomer(objCustomer);
                Response.Write("<script>alert('Customer Added!')</script>");
                txtName.Text = null;
                txtPhone.Text = null;
                txtEmail.Text = null;
            }
            else
            {
                Response.Write("<script>alert('Customer Information Incorrect!')</script>");
                txtName.Text = null;
                txtPhone.Text = null;
                txtEmail.Text = null;
            }
        }
    }
}