using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using LevelEntities;
using LevelBusiness;

namespace LevelPresentation
{
    public partial class frmListOilService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGV();
        }

        private void LoadGV()
        {
            DataTable GV = new DataTable();
            GV.Columns.AddRange(new DataColumn[]{
                new DataColumn("CustomerPlate",typeof(string)),
                new DataColumn("CustomerName",typeof(string)),
                new DataColumn("CustomerPhone",typeof(string)),
                new DataColumn("Grade",typeof(string)),
                new DataColumn("Miles",typeof(string)),
                new DataColumn("OilType",typeof(string)),
                new DataColumn("TodayDate",typeof(string)),
                new DataColumn("ChangeDate",typeof(string))
            });

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=LocalServiceProjectDB;Integrated Security=True";
            SqlCommand cmd = null;
            SqlDataReader dr = null;

            cmd = new SqlCommand("spListOilService", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    GV.Rows.Add(
                        dr["CustomerPlate"].ToString(),
                        dr["CustomerName"].ToString(),
                        dr["CustomerPhone"].ToString(),
                        dr["Grade"].ToString(),
                        dr["Miles"].ToString(),
                        dr["OilType"].ToString(),
                        dr["TodayDate"].ToString(),
                        dr["ChangeDate"].ToString()
                        );
                }
            }
            con.Close();

            tbloilservice.DataSource = GV;
            tbloilservice.DataBind();
        }

        private void getOilService(string searchBy, string searchVal)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=LocalServiceProjectDB;Integrated Security=True";

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adp = new SqlDataAdapter();
            try
            {
                cmd = new SqlCommand("spSearchOilService", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmSearchBy", searchBy);
                cmd.Parameters.AddWithValue("@prmValue", searchVal);
                adp.SelectCommand = cmd;
                adp.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    tbloilservice.DataSource = dt;
                    tbloilservice.DataBind();
                }
                else
                {
                    tbloilservice.DataSource = dt;
                    tbloilservice.DataBind();
                }
            }
            catch (Exception)
            {

            }
        }

        [WebMethod]
        public static List<OilService> ListOilService()
        {
            List<OilService> Lista = null;
            try
            {
                Lista = OilServiceBusiness.getInstance().ListOilService();
            }
            catch (Exception)
            {
                Lista = null;
            }

            return Lista;
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (ddlSearchBy.SelectedItem.Text == "Plate")
                {
                    getOilService(ddlSearchBy.SelectedItem.Text, txtSearch.Text.Trim());
                }
                else if (ddlSearchBy.SelectedItem.Text == "Name")
                {
                    getOilService(ddlSearchBy.SelectedItem.Text, txtSearch.Text.Trim());
                }
                else if (ddlSearchBy.SelectedItem.Text == "Phone")
                {
                    getOilService(ddlSearchBy.SelectedItem.Text, txtSearch.Text.Trim());
                }
                else if (ddlSearchBy.SelectedItem.Text == "Grade")
                {
                    getOilService(ddlSearchBy.SelectedItem.Text, txtSearch.Text.Trim());
                }
                else if (ddlSearchBy.SelectedItem.Text == "Miles")
                {
                    getOilService(ddlSearchBy.SelectedItem.Text, txtSearch.Text.Trim());
                }

                else if (ddlSearchBy.SelectedItem.Text == "Oil Type")
                {
                    getOilService(ddlSearchBy.SelectedItem.Text, txtSearch.Text.Trim());
                }
                else
                {
                    getOilService(ddlSearchBy.SelectedItem.Text, txtSearch.Text.Trim());
                    txtSearch.Text = null;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}