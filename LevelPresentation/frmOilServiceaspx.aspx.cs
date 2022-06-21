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
            objOilService.ID = 0;
            objOilService.CustomerID = 0;
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
            bool response = OilServiceBusiness.getInstance().RecordOilService(objOilService);
            if (response == true)
            {
                Response.Write("<script>alert('Oil Service Added!')</script>");
            }
            else
            {
                Response.Write("<script>alert('Oil Service Information Incorrect!')</script>");
            }
        }
    }
}