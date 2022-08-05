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
    }
}
