using System.Security.Cryptography;

namespace BaremAbroad.Core.Helpers
{
    public static class PasswordHashHelper
    {
        public static void CreatePasswordHash(string passsword, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac
                    .ComputeHash(System.Text.Encoding.UTF8.GetBytes(passsword));
            }
        }
    }
}
