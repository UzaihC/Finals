using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Finals
{
    class OTPs
    {
       

        public static string GenerateOTP(int length = 6)
        {
            Random random = new Random();
            string otp = "";
            for (int i = 0; i < length; i++)
            {
                otp += random.Next(0, 10); // only digits
            }
            return otp;
        }

        private static Dictionary<string, (string otp, DateTime expiry)> otpStorage = new();

        public static string Generate()
        {
            Random random = new Random();
            return random.Next(10000, 99999).ToString();
        }

        public static void StoreOtp(string email, string otp)
        {
            otpStorage[email] = (otp, DateTime.Now.AddMinutes(1));
        }



    }
}
