using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Encode
{
    class MD5decode
    {
        public static Dictionary<string, string> rainbowTable = new Dictionary<string, string>
        {
            { "hello", GetMd5Hash("hello") },
            { "world", GetMd5Hash("world") },
            { "example", GetMd5Hash("example") }
            // ... more
        };
        public static string GetMd5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        public static string DecodeMd5Hash(string hash, Dictionary<string, string> table)
        {
            foreach (var pair in table)
            {
                if (pair.Value.Equals(hash, StringComparison.OrdinalIgnoreCase))
                {
                    return pair.Key;
                }
            }
            return null;
        }
    }
}
