﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LevelEntities;
using LevelBusiness;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace LevelPresentation
{
    public partial class frmListCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGV();
        }

        //Load Data from SQL Table in GridView
        private void LoadGV()
        {
            DataTable GV = new DataTable();
            GV.Columns.AddRange(new DataColumn[]{
                new DataColumn("ID",typeof(int)),
                new DataColumn("Plate",typeof(string)),
                new DataColumn("CustomerName",typeof(string)),
                new DataColumn("Phone",typeof(string)),
                new DataColumn("Email",typeof(string))
            });

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=LocalServiceProjectDB;Integrated Security=True";
            SqlCommand cmd = null;
            SqlDataReader dr = null;

            cmd = new SqlCommand("spListCustomer", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    GV.Rows.Add(
                        dr["ID"].ToString(),
                        dr["Plate"].ToString(),
                        dr["CustomerName"].ToString(),
                        dr["Phone"].ToString(),
                        dr["Email"].ToString()
                        );
                }
            }
            con.Close();

            tblcustomers.DataSource = GV;
            tblcustomers.DataBind();
        }

        private void getCustomers(string searchBy, string searchVal)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=LocalServiceProjectDB;Integrated Security=True";

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                cmd = new SqlCommand("spSearchCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmSearchBy", searchBy);
                cmd.Parameters.AddWithValue("@prmValue", searchVal);
                adp.SelectCommand = cmd;
                adp.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    tblcustomers.DataSource = dt;
                    tblcustomers.DataBind();
                }
                else
                {
                    tblcustomers.DataSource = dt;
                    tblcustomers.DataBind();
                }
            }
            catch (Exception)
            {

            }
        }

        [WebMethod]
        public static bool UpdateCustomer(String id, String Plate, String Name, String Phone, String Email)
        {
            Customer objCustomer = new Customer()
            {
                ID = Convert.ToInt32(id),
                Plate = Plate,
                CustomerName = Name,
                Phone = Phone,
                Email = Email
            };

            bool ok = CustomerBusiness.getInstance().UpdateCustomer(objCustomer);
            return ok;

        }

        [WebMethod]
        public static bool DeleteCustomer(String id)
        {
            Customer objCustomer = new Customer()
            {
                ID = Convert.ToInt32(id)
            };

            bool ok = CustomerBusiness.getInstance().DeleteCustomer(objCustomer);
            return ok;

        }

        [WebMethod]
        public static List<Customer> ListCustomer()
        {
            List<Customer> Lista = null;
            try
            {
                Lista = CustomerBusiness.getInstance().ListCustomer();
            }
            catch (Exception)
            {
                Lista = null;
            }

            return Lista;
        }

        //##########################################################//

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (ddlSearchBy.SelectedItem.Text == "Plate")
                {
                    getCustomers(ddlSearchBy.SelectedItem.Text, txtSearch.Text.Trim());
                }
                else if (ddlSearchBy.SelectedItem.Text == "Name")
                {
                    getCustomers(ddlSearchBy.SelectedItem.Text, txtSearch.Text.Trim());
                }
                else if (ddlSearchBy.SelectedItem.Text == "Phone")
                {
                    getCustomers(ddlSearchBy.SelectedItem.Text, txtSearch.Text.Trim());
                }
                else if (ddlSearchBy.SelectedItem.Text == "Email")
                {
                    getCustomers(ddlSearchBy.SelectedItem.Text, txtSearch.Text.Trim());
                }
                else
                {
                    getCustomers(ddlSearchBy.SelectedItem.Text, txtSearch.Text.Trim());
                    txtSearch.Text = null;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}