namespace Finals
{
    class OTPs
    {
        private static Dictionary<string, (string otp, DateTime expiry)> otpStorage = new();

        public static string GenerateOTP(int length = 6)
        {
            Random random = new Random();
            string otp = "";
            for (int i = 0; i < length; i++)
            {
                otp += random.Next(0, 10);
            }
            return otp;
        }

        public static void StoreOtp(string email, string otp, DateTime expiry)
        {
            otpStorage[email] = (otp, expiry);

        }

        public static (string otp, DateTime expiry)? GetStoredOtp(string email)
        {
            if (otpStorage.ContainsKey(email))
                return otpStorage[email];
            return null;
        }
    }
}
