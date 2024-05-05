using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encode
{
    class Caesar
    {
            private const int AlphabetSize = 26;
            private const char LowercaseStart = 'a';
            private const char UppercaseStart = 'A';

            public static string Encrypt(string input, int shift)
            {
                StringBuilder result = new StringBuilder();
                foreach (char c in input)
                {
                    if (char.IsLetter(c))
                    {
                        char start = char.IsLower(c) ? LowercaseStart : UppercaseStart;
                        result.Append((char)(((c + shift - start) % AlphabetSize) + start));
                    }
                    else
                    {
                        result.Append(c);
                    }
                }
                return result.ToString();
            }

            public static string Decrypt(string input, int shift)
            {
                return Encrypt(input, AlphabetSize - shift);
            }
    }
}
