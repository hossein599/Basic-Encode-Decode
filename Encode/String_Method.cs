using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encode
{
    class String_Method
    {
        List<char> CharList = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n','o','p',
            'q','r','s','t','u','v','w','x','y','z'};

        List<string> CodedString = new List<string>() { "EDGkdg", "DFs84k", "ikJ821", "ISk987", "Asd123", "sDd812", "SdW125",
            "Ssd189","Df981a","LM122n","r911lK","MGW8a5","sFD111","Fga25X","wSa25G","Zx2Agf","ht2XqW","dYv7ac","ByOa2S"
            ,"Xmo2aS","vQa10V","p0Z1YH","Q0Xvqf","pl30Az","ok2xva","bPq2X5"};

        string Text, CodedText = null;
        int Index;
        string DivideString = null;

        public string encode(string input)
        {
            Text = input.ToLower();
            var CharText = Text.ToCharArray();

            foreach (var item in CharText)
            {
                Index = CharList.IndexOf(item);

                if (Index != -1)
                    CodedText += CodedString[Index];

                else
                    CodedText += "-";
            }
            return CodedText;
        }

        public string decode(string input)
        {
            string EncodedText = input;

            for (int i = 0; i < EncodedText.Length; i++)
            {
                if (EncodedText[i] != '-')
                {
                    DivideString += EncodedText[i];

                    if ((DivideString.Length % 6) == 0)
                    {
                        Index = CodedString.IndexOf(DivideString);

                        if (Index != -1)
                        {
                            CodedText += CharList[Index];
                        }
                        DivideString = null;
                    }
                }
                else

                    CodedText += " ";
            }
            return CodedText;
        }
    }
}

