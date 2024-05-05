using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encode
{
    class VigenereCipher
    {
        private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static string Encrypt(string text, string key)
        {
            return Cipher(text, key, true);
        }

        public static string Decrypt(string text, string key)
        {
            return Cipher(text, key, false);
        }

        private static string Cipher(string text, string key, bool encrypting)
        {
            StringBuilder output = new StringBuilder();
            int keyIndex = 0, keyLength = key.Length;

            foreach (char c in text.ToUpper())
            {
                if (Alphabet.Contains(c))
                {
                    int offset = Alphabet.IndexOf(key[keyIndex % keyLength]) * (encrypting ? 1 : -1);
                    int index = (Alphabet.IndexOf(c) + offset + Alphabet.Length) % Alphabet.Length;
                    output.Append(Alphabet[index]);

                    keyIndex++;
                }
                else
                {
                    output.Append(c);
                }
            }
            return output.ToString();
        }
    }
}
