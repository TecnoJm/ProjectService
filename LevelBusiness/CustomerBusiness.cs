using System;
using System.Collections.Generic;
using System.Text;
using LevelEntities;
using LevelDatabase;

namespace LevelBusiness
{
    public class CustomerBusiness
    {
        #region "PATRON SINGLETON"
        private static CustomerBusiness objCustomer = null;
        private CustomerBusiness() { }
        public static CustomerBusiness getInstance()
        {
            if (objCustomer == null)
            {
                objCustomer = new CustomerBusiness();
            }
            return objCustomer;
        }
        #endregion


        //Instance for Customer Registration
        public bool RecordCustomer(Customer objCustomer)
        {
            try
            {
                //return true;
                return CustomerRegistration.getInstance().RecordCustomer(objCustomer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
