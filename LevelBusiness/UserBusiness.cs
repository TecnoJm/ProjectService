using System;
using System.Collections.Generic;
using System.Text;
using LevelEntities;
using LevelDatabase;

namespace LevelBusiness
{
    public class UserBusiness
    {
        #region "PATRON SINGLETON"
        private static UserBusiness objUser = null;
        private UserBusiness() { }
        public static UserBusiness getInstance()
        {
            if (objUser == null)
            {
                objUser = new UserBusiness();
            }
            return objUser;
        }
        #endregion

        public User LogIn(String user, String password)
        {
            //Instance with UserLogIn class with LevelDatabase
            try
            {
                return UserLogIn.getInstance().LogIn(user, password);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
