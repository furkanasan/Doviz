using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Doviz
{
    public partial class Grafik : Form
    {
        public Grafik()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TNCJQ6B\\MSSQLSERVER1;Initial Catalog=Doviz;Integrated Security=True;User Id= sa; Password=furkanasan;");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Grafik_Load(object sender, EventArgs e)
        {
            

        }

        private void chart2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select CurrencyCode, ForexSelling from Kurlar", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                chart2.Series["Kurlar"].Points.AddXY(rd[0].ToString(), rd[1].ToString());

            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select CurrencyCode, ForexSelling from Kurlar where CurrencyName= 'US DOLLAR' or CurrencyName='EURO' or CurrencyName='POUND STERLING'", con);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                chart1.Series["Kurlar"].Points.AddXY(rd[0].ToString(), rd[1].ToString());

            }
            con.Close();
        }
    }
}
