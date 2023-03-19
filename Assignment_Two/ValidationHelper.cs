using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_Two
{
    public class ValidationHelper
    {

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            Regex phoneNumVerify = new Regex(@"^\d{10}$");
            return phoneNumVerify.IsMatch(phoneNumber);
        }
        public static bool IsPostalCodeValid(string postalCode) {

            Regex postalVerify = new Regex(@"[A-Z][0-9][A-Z] ?[0-9][A-Z][0-9]+");
            return postalVerify.IsMatch(postalCode);

        }
        public static bool IsEmailValid(string email)
        {
            Regex emailVerify = new Regex(@"^([\w\.\-]+)@([gmail]+)((\.(\w){2,3})+)$");
            return emailVerify.IsMatch(email);
        }

        public static bool IsValidPatientAge(DateTime birthdate)
        {
            int age = DateTime.Today.Year - birthdate.Year;

            if (age >= 18)
            {
                
                return true;
                
            }
            else
            {
                return false;
            }
        }

        public static bool IsValidName(string name)
        {
            Regex nameVerify = new Regex(@"^[a-zA-Z']+([ ])+([a-zA-Z']+)*$");
            return nameVerify.IsMatch(name);
        }
        //IsValidPhoneNumber
    }
}
