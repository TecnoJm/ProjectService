using System;
using System.Collections.Generic;
using System.Text;

namespace LevelEntities
{
    public class Customer
    {
        public int ID { get; set; }
        public String Plate { get; set; }
        public String CustomerName { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }

        public Customer() { }

        public Customer(int ID, String Plate, String CustomerName, String Phone, String Email)
        {
            this.ID = ID;
            this.Plate = Plate;
            this.CustomerName = CustomerName;
            this.Phone = Phone;
            this.Email = Email;
        }
    }
}
