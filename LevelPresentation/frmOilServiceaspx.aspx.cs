using System;
using LevelEntities;
using LevelBusiness;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace LevelPresentation
{
    public partial class frmOilServiceaspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //##################################################################//

        //Customer Values of the OilService.cs in Level Entities
        private OilService GetValues()
        {
            OilService objOilService = new OilService();
            objOilService.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            objOilService.Customer = "Carlos";
            objOilService.Grade = txtGrade.Text;
            objOilService.Miles = Convert.ToInt32(txtMiles.Text);
            objOilService.OilType = ddlOilType.SelectedItem.Text;
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
                txtDate.Text = null;

                //Send Email of Confirmation 

                //I need to find a method to send the emails even without professional approval.
                /*using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("Check");
                    mail.To.Add("Check");
                    mail.Subject = "Hello World";
                    mail.Body = "Test 1";
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient("smtp.live.com", 465))
                    {
                        smtp.EnableSsl = true;
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new NetworkCredential("Check", "Check");
                        smtp.Send(mail);
                    }
                } */
            } 
            else
            {
                Response.Write("<script>alert('Oil Service Information Incorrect!')</script>");
                txtCustomerID.Text = null;
                txtGrade.Text = null;
                txtMiles.Text = null;
                txtOilType.Text = null;
                txtDate.Text = null;
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtCustomerID.Text = null;
            txtGrade.Text = null;
            txtMiles.Text = null;
            txtOilType.Text = null;
            txtDate.Text = null;
        }
    }
}