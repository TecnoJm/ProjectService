using System;
using LevelEntities;
using LevelBusiness;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace LevelPresentation
{
    public partial class frmOilServiceaspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Take the Client PC date.
            txtDate.Text = DateTime.Now.ToString();
            txtDate.Enabled = false;
        }

        //##################################################################//

        //Customer Values of the OilService.cs in Level Entities
        private OilService GetValues()
        {
            OilService objOilService = new OilService();
            objOilService.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            objOilService.Customer = txtCustomerName.Text;
            objOilService.Grade = txtGrade.Text;
            objOilService.Miles = Convert.ToInt32(txtMiles.Text);
            objOilService.OilType = ddlOilType.SelectedItem.Text;

            //Take the Client PC date in real time.
            txtDate.Text = DateTime.Now.ToString();
            objOilService.Date = txtDate.Text;

            return objOilService;
        }

        //##################################################################//

        protected void btnRecord_Click(object sender, EventArgs e)
        {
            //Oil Service Registration

            OilService objOilService = GetValues();
            //Send the information to Level Business
            bool response = false;
            if (txtCustomerID.Text != "" && txtGrade.Text != "" && txtMiles.Text != "" && txtDate.Text != "")
            {
                response = OilServiceBusiness.getInstance().RecordOilService(objOilService);
                Response.Write("<script>alert('Oil Service Added!')</script>");
                txtCustomerID.Text = null;
                txtGrade.Text = null;
                txtMiles.Text = null;
                txtOilType.Text = null;


                //Send Email of Confirmation 

                //I need to find a method to send the emails even without professional approval.

                /*MailAddress to = new MailAddress("Receptor");
                MailAddress from = new MailAddress("Transmitter");

                MailMessage message = new MailMessage(from, to);
                message.Subject = "Hi!, Jean";
                message.Body = "This is a just test for Email code.";

                SmtpClient client = new SmtpClient("smtp.live.com", 465) //465 //587
                {
                    Credentials = new NetworkCredential("user", "pass"),
                    EnableSsl = true
                };
                // code in brackets above needed if authentication required

                try
                {
                    client.Send(message);
                }
                catch (SmtpException ex)
                {
                    throw ex;
                } */
            } 
            else
            {
                Response.Write("<script>alert('Oil Service Information Incorrect!')</script>");
                txtCustomerID.Text = null;
                txtCustomerName.Text = null;
                txtGrade.Text = null;
                txtMiles.Text = null;
                txtOilType.Text = null;
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtCustomerID.Text = null;
            txtCustomerName.Text = null;
            txtGrade.Text = null;
            txtMiles.Text = null;
            txtOilType.Text = null;
        }

        protected void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Search Customer from Customers table.
                //I need to put this method in a Stored Procedured.
                string ConnectionString;
                ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=LocalServiceProjectDB;Integrated Security=True";

                SqlConnection conn = new SqlConnection(ConnectionString);

                SqlDataAdapter da = new SqlDataAdapter("Select ID, Customer from dbo.Customers where ID = " + txtCustomerID.Text, conn); DataTable dt = new DataTable();

                da.Fill(dt);

                txtCustomerName.Text = dt.Rows[0][1].ToString();
            }
            catch(Exception)
            {
                Response.Write("<script>alert('This Customer dont exits!, You need the add it in the Database in Customer Page.')</script>");
                txtCustomerID.Text = null;
                txtCustomerName.Text = null;
                txtGrade.Text = null;
                txtMiles.Text = null;
                txtOilType.Text = null;
            }
        }
    }
}