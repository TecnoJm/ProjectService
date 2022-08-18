using System;
using System.Collections.Generic;
using System.Text;

namespace LevelEntities
{
    public class OilService
    {
            public int ID { get; set; }
            public int CustomerID { get; set; }
            public String CustomerPlate { get; set; }
            public String CustomerName { get; set; }
            public String CustomerPhone { get; set; }
            public String Grade { get; set; }
            public int Miles { get; set; }
            public String OilType { get; set; }
            public int ChangeMiles { get; set; }
            public String TodayDate { get; set; }
            public String ChangeDate { get; set; }

        public OilService() { }

            public OilService(int ID, int CustomerID, String CustomerPlate, String CustomerName, String CustomerPhone, String Grade, int Miles, String OilType, int ChangeMiles, String TodayDate, String ChangeDate)
            {
                this.ID = ID;
                this.CustomerID = CustomerID;
                this.CustomerPlate = CustomerPlate;
                this.CustomerName = CustomerName;
                this.CustomerName = CustomerPhone;
                this.Grade = Grade;
                this.Miles = Miles;
                this.OilType = OilType;
                this.ChangeMiles = ChangeMiles;
                this.TodayDate = TodayDate;
                this.ChangeDate = ChangeDate;
            }
        }
    }
