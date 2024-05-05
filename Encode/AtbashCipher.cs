using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encode
{
    class AtbashCipher
    {
        private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static string ReversedAlphabet = new string(Alphabet.Reverse().ToArray());

        public static string EncryptDecrypt(string input)
        {
            StringBuilder output = new StringBuilder();
            foreach (char c in input.ToUpper())
            {
                int index = Alphabet.IndexOf(c);
                output.Append(index >= 0 ? ReversedAlphabet[index] : c);
            }
            return output.ToString();
        }
    }
}
