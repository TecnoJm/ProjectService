using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using LevelEntities;
using LevelBusiness;

namespace LevelPresentation
{
    public partial class frmListOilService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
    }
}