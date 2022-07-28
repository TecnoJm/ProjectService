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
    public partial class frmListCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /*[WebMethod]
        public static List<Customer> ListCustomer()
        {
            List<Customer> Lista = null;
            try
            {
                Lista = CustomerBusiness.getInstance().ListCustomer();
            }
            catch (Exception ex)
            {
                Lista = null;
            }

            return Lista;
        }*/
    }
}