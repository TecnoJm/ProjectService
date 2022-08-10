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
                return CustomerRegistration.getInstance().RecordCustomer(objCustomer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //##################################################################//

        //Instance for Customer Updating
        public bool UpdateCustomer(Customer objCustomer)
        {
            try
            {
                return CustomerRegistration.getInstance().UpdateCustomer(objCustomer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //##################################################################//

        public bool DeleteCustomer(Customer objCustomer)
        {
            try
            {
                return CustomerRegistration.getInstance().DeleteCustomer(objCustomer);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //##################################################################//
        public List<Customer> ListCustomer()
        {
            try
            {
                return CustomerRegistration.getInstance().ListCustomer();
            } 
            catch(Exception ex) 
            {
                throw ex;
            }
        }
    }
}
