using System;
using System.Collections.Generic;
using System.Text;
using LevelEntities;
using LevelDatabase;

namespace LevelBusiness
{
    public class OilServiceBusiness
    {
        #region "PATRON SINGLETON"
        private static OilServiceBusiness objOilService = null;
        private OilServiceBusiness() { }
        public static OilServiceBusiness getInstance()
        {
            if (objOilService == null)
            {
                objOilService = new OilServiceBusiness();
            }
            return objOilService;
        }
        #endregion

        //Instance for Oil Service Registration
        public bool RecordOilService(OilService objOilService)
        {
            try
            {
                //return true;
                return OilServiceRegistration.getInstance().RecordOilService(objOilService);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<OilService> ListOilService()
        {
            try
            {
                return OilServiceRegistration.getInstance().ListOilService();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
