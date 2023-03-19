using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Two
{
    public class Appointment
    {
        public string Name { get; set; }

        public int Age { get; set; }
        public string Address { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public string PostalCode { get; set; }

        public string PhoneNum { get; set; }

        public string Email { get; set; }

        public DateTime AppTime { get; set; }

        public int AppDuration { get; set; }

        public string AppDesc { get; set; }

        public Appointment(string name, int age, string address, string city, string province, string postalCode, string phoneNum, string email, DateTime appTime, int appDuration, string appdDsc)
        {
            Name = name;
            Age = age;
            Address = address;
            City = city;
            Province = province;
            PostalCode = postalCode;
            PhoneNum = phoneNum;
            Email = email;
            AppTime = appTime;
            AppDuration = appDuration;
            AppDesc = appdDsc;
        }
        public string Print()
        {
            string result = $"----------------------------------------------------\r\n" +
                $"Patient Name: {Name}\r\n" +
                $"Age: {Print(Age)}\r\n" +
                $"Address: {Address}\r\n" +
                $"City: {City}\r\n" +
                $"Province: {Province}\r\n" +
                $"Postal Code: {PostalCode}\r\n" +
                $"Phone Number:{PhoneNum}\r\n" +
                $"Email: {Email}\r\n" +
                $"Appointment time: {Print(AppTime)}\r\n" +
                $"Appointment duration: {Print(AppDuration)} minutes\r\n" +
                $"Description: {AppDesc}\r\n" +
                $"----------------------------------------------------\r\n";           
            return result;
        }
        public string Print(object value)
        {
            return value.ToString();
        }
    }
}
