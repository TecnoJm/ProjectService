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

                cmd.Parameters.AddWithValue("@prmPlate", objCustomer.Plate);
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

        //##################################################################//

        public bool UpdateCustomer(Customer objCustomer)
        {
            bool ok = false;

            //Connection with Database to Update Customer in the Database
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                con = DBConnection.GetInstance().ConnectionDB();
                cmd = new SqlCommand("spUpdateCustomer", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@prmID", objCustomer.ID);
                cmd.Parameters.AddWithValue("@prmPlate", objCustomer.Plate);
                cmd.Parameters.AddWithValue("@prmCustomerName", objCustomer.CustomerName);
                cmd.Parameters.AddWithValue("@prmPhone", objCustomer.Phone);
                cmd.Parameters.AddWithValue("@prmEmail", objCustomer.Email);
                con.Open();

                cmd.ExecuteNonQuery();
                ok = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return ok;
        }

        //##################################################################//

        public bool DeleteCustomer(Customer objCustomer)
        {
            bool ok = false;

            //Connection with Database to Delete Customer in the Database
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                con = DBConnection.GetInstance().ConnectionDB();
                cmd = new SqlCommand("spDeleteCustomer", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@prmID", objCustomer.ID);
                con.Open();

                cmd.ExecuteNonQuery();
                ok = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return ok;
        }

        //##################################################################//
        
        public List<Customer> ListCustomer()
        {
            List<Customer> Lista = new List<Customer>();
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;

            try
            {
                con = DBConnection.GetInstance().ConnectionDB();
                cmd = new SqlCommand("spListCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    // Creating objects of Customer Type
                    Customer objCustomer = new Customer();
                    objCustomer.ID = Convert.ToInt32(dr["ID"].ToString());
                    objCustomer.Plate = dr["Plate"].ToString();
                    objCustomer.CustomerName = dr["CustomerName"].ToString();
                    objCustomer.Phone = dr["Phone"].ToString();
                    objCustomer.Email = dr["Email"].ToString();

                    // Addind objects to the List
                    Lista.Add(objCustomer);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return Lista;
        }

        //##################################################################//

    }
}
