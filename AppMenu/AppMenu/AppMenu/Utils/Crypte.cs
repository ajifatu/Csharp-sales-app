using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AppMenu.Utils
{
    public static class Crypte
    { 
        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {

                stringBuilder.Append(data[i].ToString("x2"));
                
            }
            return stringBuilder.ToString();
        }

        //Verify  a hach against a string
        public static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            //Hash the input
            string hashOfInput = GetMd5Hash(md5Hash, input);

            //Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
