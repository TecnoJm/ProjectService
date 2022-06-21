using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using LevelEntities;

namespace LevelDatabase
{
    public class CustomerRegistration
    {
        #region "PATRON SINGLETON"
        private static CustomerRegistration rCustomer = null;
        private CustomerRegistration() { }
        public static CustomerRegistration getInstance()
        {
            if (rCustomer == null)
            {
                rCustomer = new CustomerRegistration();

            }
                return rCustomer;
        }
        #endregion

        public bool RecordCustomer(Customer objCustomer)
        {
            //Connection with Database to Record Customer in the Database
            SqlConnection con = null;
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                con = DBConnection.GetInstance().ConnectionDB();
                cmd = new SqlCommand("spRecordCustomer", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@prmCustomerName", objCustomer.CustomerName);
                cmd.Parameters.AddWithValue("@prmPhone", objCustomer.Phone);
                cmd.Parameters.AddWithValue("@prmEmail", objCustomer.Email);
                con.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0) response = true;

            }
            catch (Exception ex)
            {
                response = false;
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return response;
        }

    }
}
