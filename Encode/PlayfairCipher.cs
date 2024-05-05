using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encode
{
    class PlayfairCipher
    {
        private char[,] matrix;

        public PlayfairCipher(string key)
        {
            CreateMatrix(key);
        }

        private void CreateMatrix(string key)
        {
            matrix = new char[5, 5];
            var distinctLetters = (key + "ABCDEFGHIKLMNOPQRSTUVWXYZ").ToUpper()
                                    .Distinct()
                                    .Where(c => Char.IsLetter(c)).ToList();

            int idx = 0;
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    matrix[row, col] = distinctLetters[idx++];
                }
            }
        }

        private string PrepareInput(string input)
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'J') output.Append('I'); // Treat J as I
                else if (Char.IsLetter(input[i])) output.Append(input[i]);

                if (i + 1 < input.Length && input[i] == input[i + 1])
                    output.Append('X'); // Insert X between duplicate letters
            }

            if (output.Length % 2 != 0) output.Append('X'); // Pad with X if length is odd

            return output.ToString().ToUpper();
        }

        public string Encrypt(string plaintext)
        {
            return Process(plaintext, true);
        }

        public string Decrypt(string ciphertext)
        {
            return Process(ciphertext, false);
        }

        private string Process(string text, bool encrypt)
        {
            string preparedText = PrepareInput(text);
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < preparedText.Length; i += 2)
            {
                char a = preparedText[i];
                char b = (i + 1 < preparedText.Length) ? preparedText[i + 1] : 'X';

                GetPosition(a, out int rowA, out int colA);
                GetPosition(b, out int rowB, out int colB);

                if (rowA == rowB) // Same row
                {
                    colA = (colA + (encrypt ? 1 : 4)) % 5;
                    colB = (colB + (encrypt ? 1 : 4)) % 5;
                }
                else if (colA == colB) // Same column
                {
                    rowA = (rowA + (encrypt ? 1 : 4)) % 5;
                    rowB = (rowB + (encrypt ? 1 : 4)) % 5;
                }
                else // Rectangle
                {
                    int temp = colA;
                    colA = colB;
                    colB = temp;
                }

                output.Append(matrix[rowA, colA]);
                output.Append(matrix[rowB, colB]);
            }

            return output.ToString();
        }

        private void GetPosition(char letter, out int row, out int col)
        {
            row = 0;
            col = 0;
            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if (matrix[r, c] == letter)
                    {
                        row = r;
                        col = c;
                        return;
                    }
                }
            }
        }

    }
}
