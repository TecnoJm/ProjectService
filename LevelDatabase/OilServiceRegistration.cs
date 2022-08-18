using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using LevelEntities;

namespace LevelDatabase
{
    public class OilServiceRegistration
    {
        #region "PATRON SINGLETON"
        private static OilServiceRegistration rOilService = null;
        private OilServiceRegistration() { }
        public static OilServiceRegistration getInstance()
        {
            if (rOilService == null)
            {
                rOilService = new OilServiceRegistration();

            }
            return rOilService;
        }
        #endregion

        //##################################################################//

        public bool RecordOilService(OilService objOilService)
        {
            //Connection with Database to Record Oil Service in the Database
            SqlConnection con = null;
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                con = DBConnection.GetInstance().ConnectionDB();
                cmd = new SqlCommand("spRecordOilService", con);

                cmd.CommandType = CommandType.StoredProcedure;

                //Parameters (Data from Text Box)
                cmd.Parameters.AddWithValue("@prmCustomerPlate", objOilService.CustomerPlate);
                cmd.Parameters.AddWithValue("@prmCustomerName", objOilService.CustomerName);
                cmd.Parameters.AddWithValue("@prmCustomerPhone", objOilService.CustomerPhone);
                cmd.Parameters.AddWithValue("@prmGrade", objOilService.Grade);
                cmd.Parameters.AddWithValue("@prmMiles", objOilService.Miles);
                cmd.Parameters.AddWithValue("@prmOilType", objOilService.OilType);
                cmd.Parameters.AddWithValue("@prmChangeMiles", objOilService.ChangeMiles);
                cmd.Parameters.AddWithValue("@prmTodayDate", objOilService.TodayDate);
                cmd.Parameters.AddWithValue("@prmChangeDate", objOilService.ChangeDate);
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

        public List<OilService> ListOilService()
        {
            List<OilService> Lista = new List<OilService>();
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;

            try
            {
                con = DBConnection.GetInstance().ConnectionDB();
                cmd = new SqlCommand("spListOilService", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    // Creating objects of OilService Type
                    OilService objOilService = new OilService();
                    objOilService.CustomerPlate = dr["CustomerPlate"].ToString();
                    objOilService.CustomerName = dr["CustomerName"].ToString();
                    objOilService.CustomerPhone = dr["CustomerPhone"].ToString();
                    objOilService.Grade = dr["Grade"].ToString();
                    objOilService.Miles = Convert.ToInt32(dr["Miles"].ToString());
                    objOilService.OilType = dr["OilType"].ToString();
                    objOilService.OilType = dr["ChangeMiles"].ToString();
                    objOilService.OilType = dr["TodayDate"].ToString();
                    objOilService.OilType = dr["ChangeDate"].ToString();

                    // Addind objects to the List
                    Lista.Add(objOilService);
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
    }
}
