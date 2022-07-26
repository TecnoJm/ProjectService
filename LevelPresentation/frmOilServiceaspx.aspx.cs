﻿using System;
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
            objOilService.OilType = txtOilType.Text;
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
            if (txtCustomerID.Text != "" && txtGrade.Text != "" && txtMiles.Text != "" && txtOilType.Text != ""
                && txtDate.Text != "")
            {
                response = OilServiceBusiness.getInstance().RecordOilService(objOilService);
                Response.Write("<script>alert('Oil Service Added!')</script>");
                txtCustomerID.Text = null;
                txtGrade.Text = null;
                txtMiles.Text = null;
                txtOilType.Text = null;
                txtDate.Text = null;

                //Send Email of Confirmation //Pendiente
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("jmichael1802@hotmail.com");
                    mail.To.Add("megajm701@gmail.com");
                    mail.Subject = "Hello World";
                    mail.Body = "Test 1";
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient("smtp.live.com", 587))
                    {
                        smtp.EnableSsl = true;
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new NetworkCredential("jmichael1802@hotmail.com", "$uperD@nlo86;.");
                        smtp.Send(mail);
                    }
                }
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