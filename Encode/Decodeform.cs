using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encode
{
    public partial class Decodeform : Form
    {
        public Decodeform()
        {
            InitializeComponent();
        }

        private void String_btn_Click_1(object sender, EventArgs e)
        {
            String_Method str = new String_Method();
            string_mtehod.Text = str.decode(txt.Text);
        }

        private void Caesar_Click(object sender, EventArgs e)
        {
            int shift = 3;
            Caesar_txt.Text = Caesar.Decrypt(txt.Text, shift);
        }

        private void MD5_btn_Click(object sender, EventArgs e)
        {
            string decodedValue;
            decodedValue =  MD5_txt.Text = MD5decode.DecodeMd5Hash(txt.Text, MD5decode.rainbowTable);
            if (decodedValue != null)
            {
               MD5_txt.Text = decodedValue;
            }
            else
            {
                MD5_txt.Text = "No match found in the pre-made set table.";
            }
        }

        private void AtbashCipher_btn_Click(object sender, EventArgs e)
        {
            AtbashCipher_txt.Text = AtbashCipher.EncryptDecrypt(txt.Text);
        }

        private void RSAEncryption_btn_Click(object sender, EventArgs e)
        {
            string password = "RC2PASS";
            RC2_txt.Text = RC2Encryption.Decrypt(txt.Text, password);
        }

        private void VigenereCipher_Click(object sender, EventArgs e)
        {
            string key = "VigenereCipherKEY";
            VigenereCipher_txt.Text= VigenereCipher.Decrypt(txt.Text, key);
        }
    }
}

