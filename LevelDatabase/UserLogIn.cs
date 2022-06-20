using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using LevelEntities;
using LevelDatabase;

namespace LevelDatabase
{
    public class UserLogIn
    {
        #region "PATRON SINGLETON"
        private static UserLogIn userLogIn = null;
        private UserLogIn() { }
        public static UserLogIn getInstance()
        {
            if(userLogIn == null)
            {
                userLogIn = new UserLogIn();
            }
            return userLogIn;
        }
        #endregion

       public User LogIn(String user, String password)
        {
            //Local Variables for SQL Local Connection
            SqlConnection connection = null;
            SqlCommand cmd = null;
            User objUser = null;
            SqlDataReader dr = null;
            try
            {
                //connection to LocalDatabase using Stored Procedures
                connection = DBConnection.GetInstance().ConnectionDB();
                cmd = new SqlCommand("spLogIn", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmUser", user);
                cmd.Parameters.AddWithValue("@prmPass", password);

                //Open connection to recieve data for the Database
                connection.Open();

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    objUser = new User();
                    objUser.ID = Convert.ToInt32(dr["ID"].ToString());
                    objUser.UserName = dr["Username"].ToString();
                    objUser.Password = dr["Password"].ToString();
                }

            }
            catch (Exception ex)
            {
                objUser = null;
                throw ex;
            }
            finally
            {
                //Close connection with Database
                connection.Close();
            }
            return objUser;
        }
    }
}
