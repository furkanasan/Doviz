using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;
namespace Doviz
{
    public partial class Euro : Form
    {
        public Euro()
        {
            InitializeComponent();
        }

        private void lbl1950_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source = C:/Users/X/Desktop/b161200038/data/EURO/1999-2009.xlsx;Extended Properties =\'Excel 12.0 Xml;HDR=YES\';");
            con.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from [EVDS$]", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void lbl1960_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source = C:/Users/X/Desktop/b161200038/data/EURO/2010-2020.xlsx;Extended Properties =\'Excel 12.0 Xml;HDR=YES\';");
            con.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from [EVDS$]", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GecmisKurlar gk = new GecmisKurlar();
            gk.Show();
            this.Hide();
        }

        private void Euro_Load(object sender, EventArgs e)
        {

        }
    }
}
