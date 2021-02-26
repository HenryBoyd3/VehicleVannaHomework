using System;
using System.Collections.Generic;
using System.Text;

namespace AppFrontEnd
{
    public class VehicleData
    {
        public string make { get; set; }
        public string modle { get; set; }
        public int year { get; set; }
        public int listPrice { get; set; }
        public string vehType { get; set; }
        public enum vehicalType 
        {
            Car,
            SportsCar,
            Truck,
            Motorcycle,
            MotorHome
        }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string email { get; set; }
        public VehicleData(string Make, string Modle, int Year, int ListPrice, string LastName, string FirstName, string Email) 
        {
            make = Make;
            modle = Modle;
            year = Year;
            listPrice = ListPrice;
            lastName = LastName;
            firstName = FirstName;
            email = Email;
        
        }
    }
}
