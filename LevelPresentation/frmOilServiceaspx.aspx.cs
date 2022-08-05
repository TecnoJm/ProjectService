﻿using System;
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
            txtDate.Enabled = false;
            txtCustomerName.Enabled = false;
            txtCustomerPhone.Enabled = false;
        }

        //##################################################################//

        public void ClearTextBox()
        {
            txtCustomerID.Text = null;
            txtCustomerName.Text = null;
            txtCustomerPhone.Text = null;
            txtGrade.Text = null;
            txtMiles.Text = null;
            txtOilType.Text = null;
            txtDate.Text = null;
        }

        //##################################################################//

        //Customer Values of the OilService.cs in Level Entities
        private OilService GetValues()
        {
            OilService objOilService = new OilService();
            objOilService.CustomerPlate = txtCustomerID.Text;
            objOilService.CustomerName = txtCustomerName.Text;
            objOilService.CustomerPhone = txtCustomerPhone.Text;
            objOilService.Grade = txtGrade.Text;
            objOilService.Miles = Convert.ToInt32(txtMiles.Text);
            objOilService.OilType = ddlOilType.SelectedItem.Text;

            //Take the Client PC date in real time.
            objOilService.TodayDate = DateTime.Now.ToString();
            objOilService.ChangeDate = txtDate.Text;

            return objOilService;
        }

        //##################################################################//

        protected void btnRecord_Click(object sender, EventArgs e)
        {
            //Oil Service Registration
            if (txtCustomerID.Text != "" && txtCustomerName.Text != "" && txtCustomerPhone.Text != "" && txtGrade.Text != "" && txtMiles.Text != "" && txtDate.Text != "")
            {
                OilService objOilService = GetValues();
               //Send the information to Level Business
                bool response = OilServiceBusiness.getInstance().RecordOilService(objOilService);
                Response.Write("<script>alert('Oil Service Added!')</script>");
                ClearTextBox();

                //Send Email of Confirmation 

                //I need to find a method to send the emails even without professional approval.
            } 
            else
            {
                Response.Write("<script>alert('Oil Service Information Incorrect!')</script>");
                ClearTextBox();
            }
        }

        //##################################################################//

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        //##################################################################//

        //Its CustomerPlate but Visual Studio is.....
        protected void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Search Customer from Customers table.
                //I need to put this method in a Stored Procedured.
                string ConnectionString;
                ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=LocalServiceProjectDB;Integrated Security=True";

                SqlConnection conn = new SqlConnection(ConnectionString);

                SqlDataAdapter da = new SqlDataAdapter("Select ID, CustomerName, Phone from dbo.Customer where Plate = '" + txtCustomerID.Text + "'", conn); DataTable dt = new DataTable();

                da.Fill(dt);

                txtCustomerName.Text = dt.Rows[0][1].ToString();
                txtCustomerPhone.Text = dt.Rows[0][2].ToString();

            }
            catch(Exception)
            {
                Response.Write("<script>alert('This Customer dont exits!, You need the add it in the Database in Customer Page.')</script>");
                ClearTextBox();
            }
        }

        protected void ddlOilType_SelectedIndexChanged(object sender, EventArgs e)
        {

            DateTime nextMonth = DateTime.Now;

            //Create new Date for Oil Service
            if (ddlOilType.SelectedValue == "Standard")
            {
                DateTime newDate = nextMonth.AddMonths(3);
                txtDate.Text = newDate.ToString("yyyy-MM-dd");
            }
            else if (ddlOilType.SelectedValue == "Synthetic")
            {
                DateTime newDate = nextMonth.AddMonths(5);
                txtDate.Text = newDate.ToString("yyyy-MM-dd");
            }
        }
    }
}