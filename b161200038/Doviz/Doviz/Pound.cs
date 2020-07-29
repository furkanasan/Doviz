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
    public partial class Pound : Form
    {
        public Pound()
        {
            InitializeComponent();
        }

        private void lbl1950_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source = C:/Users/X/Desktop/data/POUND/1950-1960.xlsx;Extended Properties =\'Excel 12.0 Xml;HDR=YES\';");
            con.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from [EVDS$]", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void lbl1960_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source = C:/Users/X/Desktop/data/POUND/1960-1970.xlsx;Extended Properties =\'Excel 12.0 Xml;HDR=YES\';");
            con.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from [EVDS$]", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void lbl1970_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source = C:/Users/X/Desktop/data/POUND/1970-1980.xlsx;Extended Properties =\'Excel 12.0 Xml;HDR=YES\';");
            con.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from [EVDS$]", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void lbl1980_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source = C:/Users/X/Desktop/data/POUND/1980-1990.xlsx;Extended Properties =\'Excel 12.0 Xml;HDR=YES\';");
            con.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from [EVDS$]", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void lbl1990_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source = C:/Users/X/Desktop/data/POUND/1990-2000.xlsx;Extended Properties =\'Excel 12.0 Xml;HDR=YES\';");
            con.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from [EVDS$]", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void lbl2000_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source = C:/Users/X/Desktop/data/POUND/2000-2010.xlsx;Extended Properties =\'Excel 12.0 Xml;HDR=YES\';");
            con.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from [EVDS$]", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void lbl2010_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source = C:/Users/X/Desktop/b161200038/data/POUND/2010-2020.xlsx;Extended Properties =\'Excel 12.0 Xml;HDR=YES\';");
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

        private void Pound_Load(object sender, EventArgs e)
        {

        }
    }
}
