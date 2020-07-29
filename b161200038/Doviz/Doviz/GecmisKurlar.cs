using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Doviz
{
    public partial class GecmisKurlar : Form
    {
        public GecmisKurlar()
        {
            InitializeComponent();
        }

        private void GecmisKurlar_Load(object sender, EventArgs e)
        {
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dolar dolar = new Dolar();
            dolar.Show();
            this.Hide();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Euro euro = new Euro();
            euro.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Pound pound = new Pound();
            pound.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
