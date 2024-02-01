using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Appvente.utils
{
   public static class Cripts
    {
       public static String GetMd5Hash(MD5 md5Hash , String input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2")); 
            }
            return sBuilder.ToString();
        }

       public static bool VerifyMd5Hash(MD5 md5Hash, String input, String hash)
        {
            String hashOfInput = GetMd5Hash(md5Hash, input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0== comparer.Compare(hashOfInput, hash))
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
