using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace SpinToWin
{
    public class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert the byte array to a hexadecimal string
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    stringBuilder.Append(hashedBytes[i].ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            // Hash the provided password and compare it with the stored hash
            bool res;
            Console.WriteLine($"Hashed password: {HashPassword(password)}");
            Console.WriteLine($"Stored hash: {hashedPassword}");
            
            res = HashPassword(password).Equals(hashedPassword);
            Console.WriteLine(res);
            return res;
        }
    }

    
}
