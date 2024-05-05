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
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }

        private void Encode_Click(object sender, EventArgs e)
        {
            Encodeform encodeform = new Encodeform();
            encodeform.Show();
        }

        private void Decode_Click(object sender, EventArgs e)
        {
            Decodeform decodeform = new Decodeform();
            decodeform.Show();
        }
    }
}
