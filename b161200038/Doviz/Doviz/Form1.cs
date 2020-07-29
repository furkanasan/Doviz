using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Data.SqlClient;

namespace Doviz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        WebClient c = new WebClient();

        public class jsonDATA
        {
            public string buying { get; set; }
            public string selling { get; set; }
            public string latest { get; set; }
            public string change_rate { get; set; }

        }
        public void Dolar()
        {
            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            string usd = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/ForexSelling").InnerXml;
            lblDolar.Text = usd + " TL";
        }

        public void Euro()
        {
            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            string eur = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/ForexSelling").InnerXml;
            lblEur.Text = eur + " TL";
        }
        public void Yen()
        {
            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            string yen = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='JPY']/ForexSelling").InnerXml;
            lblYen.Text = yen;
            
        }

        public void Sterlin()
        {
            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            string sterlin = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/ForexSelling").InnerXml;
            lblSterlin.Text = sterlin+" TL";
        }

        public void Faiz()
        {
            XmlTextReader XMLOku = new XmlTextReader("https://www.tcmb.gov.tr/wps/wcm/connect/tr/tcmb+tr/api/faizoranlariduyuru.xml");
            string faiz;
            while (XMLOku.Read())
            {
                if (XMLOku.NodeType == XmlNodeType.Element && XMLOku.Name == "orani")
                {
                    XMLOku.Read();
                    faiz = XMLOku.Value;
                    lblEnflasyon.Text = "% "+faiz;
                }
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            lblDolar.Font = new Font("Arial Black", 15);
            lblEur.Font = new Font("Arial Black", 15);
            lblYen.Font = new Font("Arial Black", 15);
            lblSterlin.Font = new Font("Arial Black", 15);
            lblEnflasyon.Font = new Font("Arial Black", 15);


            Dolar();
            Euro();
            Yen();
            Sterlin();
            Faiz();

            DatagridviewSetting(dataGridView1);
                  
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-TNCJQ6B\\MSSQLSERVER1;Initial Catalog=Doviz;Integrated Security=True;User Id= sa; Password=furkanasan;");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select CurrencyCode, CurrencyName, ForexBuying, ForexSelling from Kurlar", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            DovizCevirici conv = new DovizCevirici();
            conv.Show();
            this.Hide();
            
        }

        public void DatagridviewSetting(DataGridView datagridview)
        {
            dataGridView1.RowHeadersVisible = false;
            datagridview.BorderStyle = BorderStyle.None;
            
        }
           
       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Grafik chart = new Grafik();
            chart.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GecmisKurlar GKur = new GecmisKurlar();
            GKur.Show();
            this.Hide();
        }
    }
}
