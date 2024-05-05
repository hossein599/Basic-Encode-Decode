using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Encode
{
    class RC2Encryption
    {
        public static string Encrypt(string plainText, string password)
        {
            using (RC2 rc2 = RC2.Create())
            {
                rc2.Key = Encoding.UTF8.GetBytes(password);
                rc2.IV = new byte[8];

                ICryptoTransform encryptor = rc2.CreateEncryptor(rc2.Key, rc2.IV);

                using (MemoryStream ms = new MemoryStream())
                using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter sw = new StreamWriter(cs))
                    {
                        sw.Write(plainText);
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        public static string Decrypt(string cipherText, string password)
        {
            using (RC2 rc2 = RC2.Create())
            {
                rc2.Key = Encoding.UTF8.GetBytes(password);
                rc2.IV = new byte[8];

                ICryptoTransform decryptor = rc2.CreateDecryptor(rc2.Key, rc2.IV);

                using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(cipherText)))
                using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (StreamReader reader = new StreamReader(cs))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
