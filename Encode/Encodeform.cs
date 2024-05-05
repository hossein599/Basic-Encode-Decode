using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Encode
{
    public partial class Encodeform : Form
    {
        public Encodeform()
        {
            InitializeComponent();
        }

        private void Encodeform_Load(object sender, EventArgs e)
        {

        }

        private void Encode_Click(object sender, EventArgs e)
        {
            String_Method str = new String_Method();
            string_txt.Text = str.encode(txt.Text);
        }

        private void Caesar_Click(object sender, EventArgs e)
        {
            int shift = 3;
            Caesar_txt.Text = Caesar.Encrypt(txt.Text, shift);

        }

        private void MD5_btn_Click(object sender, EventArgs e)
        {
            MD5_txt.Text = MD5decode.GetMd5Hash(txt.Text);
            MD5decode.rainbowTable.Add(txt.Text, MD5_txt.Text);

        }

        private void AtbashCipher_btn_Click(object sender, EventArgs e)
        {
            AtbashCipher_txt.Text = AtbashCipher.EncryptDecrypt(txt.Text);
        }

        private void RC2_btn_Click(object sender, EventArgs e)
        {
            string password = "RC2PASS";
            RC2_txt.Text= RC2Encryption.Encrypt(txt.Text, password);
        }

        private void VigenereCipher_btn_Click(object sender, EventArgs e)
        {
            string key = "VigenereCipherKEY";
            VigenereCipher_txt.Text = VigenereCipher.Encrypt(txt.Text, key);
        }
    }
}
