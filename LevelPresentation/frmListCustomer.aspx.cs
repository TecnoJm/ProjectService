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
    }
}