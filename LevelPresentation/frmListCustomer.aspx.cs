using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using LevelEntities;
using LevelBusiness;

namespace LevelPresentation
{
    public partial class frmListCustomer : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGV();
        }

        private void LoadGV()
        {
            DataTable GV = new DataTable();
            GV.Columns.AddRange(new DataColumn[]{
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

        private void ClearTextBox()
        {
            txtID.Text = null;
            txtName.Text = null;
            txtPhone.Text = null;
            txtEmail.Text = null;
        }

        private void EnabledFalseTextBox()
        {
            txtID.Enabled = false;
            txtName.Enabled = false;
            txtPhone.Enabled = false;
            txtEmail.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void EnabledTrueTextBox()
        {
            txtID.Enabled = true;
            txtName.Enabled = true;
            txtPhone.Enabled = true;
            txtEmail.Enabled = true;
            btnUpdate.Enabled = true;
        }

        //##########################################################//

        private void getCustomers(string searchBy, string searchVal)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=LocalServiceProjectDB;Integrated Security=True";

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                cmd = new SqlCommand("spSearchCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmSearchBy", searchBy);
                cmd.Parameters.AddWithValue("@prmValue", searchVal);
                da.SelectCommand = cmd;
                da.Fill(dt);

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

        protected void tblcustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Text = tblcustomers.SelectedRow.Cells[1].Text;
            txtName.Text = tblcustomers.SelectedRow.Cells[2].Text;
            txtPhone.Text = tblcustomers.SelectedRow.Cells[3].Text;
            txtEmail.Text = tblcustomers.SelectedRow.Cells[4].Text;
            EnabledTrueTextBox();
            btnSearchVehicle.Enabled = true;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=LocalServiceProjectDB;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();

            cmd = new SqlCommand("Update Customer set CustomerName = '" + txtName.Text + "', Phone = '" + txtPhone.Text + "' where ID = " + Convert.ToInt32(txtID.Text), con);
            /*cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@prmPlate", txtPlate.Text);
            cmd.Parameters.AddWithValue("@prmCustomerName", txtName.Text);
            cmd.Parameters.AddWithValue("@prmPhone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@prmEmail", txtEmail.Text);*/

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            ClearTextBox();
            EnabledFalseTextBox();
            LoadGV();

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            EnabledFalseTextBox();
            ClearTextBox();
        }

        protected void btnSearchVehicle_Click(object sender, EventArgs e)
        {

            //SQL Variables to procedure
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=LocalServiceProjectDB;Integrated Security=True";

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();

            cmd = new SqlCommand("spListCustomerVehicles", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@prmCustomerName", txtName.Text);
            da.SelectCommand = cmd;
            da.Fill(dt);

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

            btnSearchVehicle.Enabled = false;
            btnSearchVehicle.Visible = false;
            btnBack.Enabled = true;
            btnBack.Visible = true;
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            LoadGV();
            btnSearchVehicle.Enabled = false;
            btnSearchVehicle.Visible = true;
            btnBack.Enabled = false;
            btnBack.Visible = false;
        }
    }
}