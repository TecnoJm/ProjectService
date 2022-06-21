using System;
using System.Collections.Generic;
using System.Text;

namespace LevelEntities
{
    public class OilService
    {
            public int ID { get; set; }
            public int CustomerID { get; set; }
            public String Customer { get; set; }
            public String Grade { get; set; }
            public int Miles { get; set; }
            public String OilType { get; set; }
            public String Date { get; set; }

            public OilService() { }

            public OilService(int ID, int CustomerID, String Customer, String Grade, int Miles, String OilType, String Date)
            {
                this.ID = ID;
                this.CustomerID = CustomerID;
                this.Customer = Customer;
                this.Grade = Grade;
                this.Miles = Miles;
                this.OilType = OilType;
                this.Date = Date;
            }
        }
    }
