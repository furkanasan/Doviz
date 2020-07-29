using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace Doviz
{
    public partial class DovizCevirici : Form
    {
        public DovizCevirici()
        {
            InitializeComponent();
          
        }
        private void textbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        public void Dolar()
        {
            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            string dolar = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/ForexSelling").InnerXml;
            int miktar;
            miktar = Convert.ToInt32(textBox1.Text);
            double conv;
            conv = miktar * Convert.ToDouble(dolar);
            label1.Text=miktar+ " Dolar "+ string.Format("{0:N4}", Convert.ToDecimal(conv) / 10000)+" TL'dir";
            
            
        }
        public void AUD()
        {
            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            string aud = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='AUD']/ForexSelling").InnerXml;
            int miktar;
            miktar = Convert.ToInt32(textBox1.Text);
            double conv;
            conv = miktar * Convert.ToDouble(aud);
            label1.Text = miktar + " Avustralya Doları " + string.Format("{0:N4}", Convert.ToDecimal(conv) / 10000) + " TL'dir";


        }
        public void DKK()
        {
            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            string dkk = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='DKK']/ForexSelling").InnerXml;
            int miktar;
            miktar = Convert.ToInt32(textBox1.Text);
            double conv;
            conv = miktar * Convert.ToDouble(dkk);
            label1.Text = miktar + " Danimarka Kronu " + string.Format("{0:N4}", Convert.ToDecimal(conv) / 10000) + " TL'dir";


        }

        public void Euro()
        {
            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            string euro = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/ForexSelling").InnerXml;
            int miktar;
            miktar = Convert.ToInt32(textBox1.Text);
            double conv;
            conv = miktar * Convert.ToDouble(euro);
            label1.Text = miktar + " Euro " + string.Format("{0:N4}", Convert.ToDecimal(conv) / 10000) + " TL'dir";


        }

        public void Sterlin()
        {
            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            string sterlin = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/ForexSelling").InnerXml;
            int miktar;
            miktar = Convert.ToInt32(textBox1.Text);
            double conv;
            conv = miktar * Convert.ToDouble(sterlin);
            label1.Text = miktar + " İngiliz Sterlini " + string.Format("{0:N4}", Convert.ToDecimal(conv) / 10000) + " TL'dir";


        }
        public void CHF()
        {
            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            string chf = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CHF']/ForexSelling").InnerXml;
            int miktar;
            miktar = Convert.ToInt32(textBox1.Text);
            double conv;
            conv = miktar * Convert.ToDouble(chf);
            label1.Text = miktar + " İsviçre Frangı " + string.Format("{0:N4}", Convert.ToDecimal(conv) / 10000) + " TL'dir";


        }
        public void SEK()
        {
            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            string sek = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SEK']/ForexSelling").InnerXml;
            int miktar;
            miktar = Convert.ToInt32(textBox1.Text);
            double conv;
            conv = miktar * Convert.ToDouble(sek);
            label1.Text = miktar + " İsveç Kronu " + string.Format("{0:N4}", Convert.ToDecimal(conv) / 100000) + " TL'dir";


        }
        public void CAD()
        {
            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            string cad = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CAD']/ForexSelling").InnerXml;
            int miktar;
            miktar = Convert.ToInt32(textBox1.Text);
            double conv;
            conv = miktar * Convert.ToDouble(cad);
            label1.Text = miktar + " Kanada Doları " + string.Format("{0:N4}", Convert.ToDecimal(conv) / 10000) + " TL'dir";


        }
        public void KWD()
        {
            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            string kwd = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='KWD']/ForexSelling").InnerXml;
            int miktar;
            miktar = Convert.ToInt32(textBox1.Text);
            double conv;
            conv = miktar * Convert.ToDouble(kwd);
            label1.Text = miktar + " Kuveyt Dinarı " + string.Format("{0:N4}", Convert.ToDecimal(conv) / 10000) + " TL'dir";


        }
        public void NOK()
        {
            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            string nok = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='NOK']/ForexSelling").InnerXml;
            int miktar;
            miktar = Convert.ToInt32(textBox1.Text);
            double conv;
            conv = miktar * Convert.ToDouble(nok);
            label1.Text = miktar + " Norveç Kronu " + string.Format("{0:N4}", Convert.ToDecimal(conv) / 100000) + " TL'dir";


        }
        public void SAR()
        {
            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            string sar = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SAR']/ForexSelling").InnerXml;
            int miktar;
            miktar = Convert.ToInt32(textBox1.Text);
            double conv;
            conv = miktar * Convert.ToDouble(sar);
            label1.Text = miktar + " Suudi Arabistan Riyali " + string.Format("{0:N4}", Convert.ToDecimal(conv) / 10000) + " TL'dir";


        }
        public void Yen()
        {
            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            string yen = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='JPY']/ForexSelling").InnerXml;
            int miktar;
            miktar = Convert.ToInt32(textBox1.Text);
            double conv;
            conv = miktar * Convert.ToDouble(yen);
            label1.Text = miktar + " Japon Yeni " + string.Format("{0:N4}", Convert.ToDecimal(conv) / 1000000) + " TL'dir";

        }
        public void BGN()
        {
            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            string bgn = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='BGN']/ForexSelling").InnerXml;
            int miktar;
            miktar = Convert.ToInt32(textBox1.Text);
            double conv;
            conv = miktar * Convert.ToDouble(bgn);
            label1.Text = miktar + " Bulgar Levası " + string.Format("{0:N4}", Convert.ToDecimal(conv) / 10000) + " TL'dir";


        }
        public void RON()
        {
            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            string ron = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='RON']/ForexSelling").InnerXml;
            int miktar;
            miktar = Convert.ToInt32(textBox1.Text);
            double conv;
            conv = miktar * Convert.ToDouble(ron);
            label1.Text = miktar + " Rumen Leyi " + string.Format("{0:N4}", Convert.ToDecimal(conv) / 10000) + " TL'dir";


        }
        public void RUB()
        {
            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            string rub = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='RUB']/ForexSelling").InnerXml;
            int miktar;
            miktar = Convert.ToInt32(textBox1.Text);
            double conv;
            conv = miktar * Convert.ToDouble(rub);
            label1.Text = miktar + " Rus Rublesi " + string.Format("{0:N4}", Convert.ToDecimal(conv) / 10000) + " TL'dir";


        }
        public void IRR()
        {
            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            string irr = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='IRR']/ForexSelling").InnerXml;
            int miktar;
            miktar = Convert.ToInt32(textBox1.Text);
            double conv;
            conv = miktar * Convert.ToDouble(irr);
            label1.Text = miktar + " İran Riyali " + string.Format("{0:N4}", Convert.ToDecimal(conv) / 1000000) + " TL'dir";


        }
        public void CNY()
        {
            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            string cny = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CNY']/ForexSelling").InnerXml;
            int miktar;
            miktar = Convert.ToInt32(textBox1.Text);
            double conv;
            conv = miktar * Convert.ToDouble(cny);
            label1.Text = miktar + " Çin Yuanı " + string.Format("{0:N4}", Convert.ToDecimal(conv) / 100000) + " TL'dir";


        }
        public void PKR()
        {
            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            string pkr = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='PKR']/ForexSelling").InnerXml;
            int miktar;
            miktar = Convert.ToInt32(textBox1.Text);
            double conv;
            conv = miktar * Convert.ToDouble(pkr);
            label1.Text = miktar + "Pakistan Rupisi" + string.Format("{0:N4}", Convert.ToDecimal(conv) / 10000) + " TL'dir";


        }
        public void QAR()
        {
            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            string QAR = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='QAR']/ForexSelling").InnerXml;
            int miktar;
            miktar = Convert.ToInt32(textBox1.Text);
            double conv;
            conv = miktar * Convert.ToDouble(QAR);
            label1.Text = miktar + " Katar Riyali " + string.Format("{0:N4}", Convert.ToDecimal(conv) / 10000) + " TL'dir";


        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void DovizCevirici_Load(object sender, EventArgs e)
        {
            
            label1.Font = new Font("Arial Black", 10);
            label2.Font = new Font("Arial", 10);
            label3.Font = new Font("Arial", 8);

            comboBox1.Items.Add("ABD DOLARI");
            comboBox1.Items.Add("AVUSTRALYA DOLARI");
            comboBox1.Items.Add("DANİMARKA KRONU");
            comboBox1.Items.Add("EURO");
            comboBox1.Items.Add("İNGİLİZ STERLİNİ");
            comboBox1.Items.Add("İSVİÇRE FRANGI");
            comboBox1.Items.Add("İSVEÇ KRONU");
            comboBox1.Items.Add("KANADA DOLARI");
            comboBox1.Items.Add("KUVEYT DİNARI");
            comboBox1.Items.Add("NORVEÇ KRONU");
            comboBox1.Items.Add("SUUDİ ARABİSTAN RİYALİ");
            comboBox1.Items.Add("JAPON YENİ");
            comboBox1.Items.Add("BULGAR LEVASI");
            comboBox1.Items.Add("RUMEN LEYİ");
            comboBox1.Items.Add("RUS RUBLESİ");
            comboBox1.Items.Add("İRAN RİYALİ");
            comboBox1.Items.Add("ÇİN YUANI");
            comboBox1.Items.Add("PAKİSTAN RUPİSİ");
            comboBox1.Items.Add("KATAR RİYALİ");



        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Miktar Boş Geçilemez Lütfen Bir Değer Giriniz.");
            }
            else if (comboBox1.SelectedText == string.Empty)
            {
                MessageBox.Show("Para Birimi Boş Geçilemez Lütfen Seçim Yapınız.");

            }
            else
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case ("ABD DOLARI"):
                        Dolar();
                        break;

                    case ("AVUSTRALYA DOLARI"):
                        AUD();
                        break;

                    case ("DANİMARKA KRONU"):
                        DKK();
                        break;

                    case ("EURO"):
                        Euro();
                        break;

                    case ("İNGİLİZ STERLİNİ"):
                        Sterlin();
                        break;

                    case ("İSVİÇRE FRANGI"):
                        CHF();
                        break;

                    case ("İSVEÇ KRONU"):
                        SEK();
                        break;

                    case ("KANADA DOLARI"):
                        CAD();
                        break;

                    case ("KUVEYT DİNARI"):
                        KWD();
                        break;

                    case ("NORVEÇ KRONU"):
                        NOK();
                        break;

                    case ("SUUDİ ARABİSTAN RİYALİ"):
                        SAR();
                        break;

                    case ("JAPON YENİ"):
                        Yen();
                        break;

                    case ("BULGAR LEVASI"):
                        BGN();
                        break;

                    case ("RUMEN LEYİ"):
                        RON();
                        break;

                    case ("RUS RUBLESİ"):
                        RUB();
                        break;

                    case ("İRAN RİYALİ"):
                        IRR();
                        break;

                    case ("ÇİN YUANI"):
                        CNY();
                        break;

                    case ("PAKİSTAN RUPİSİ"):
                        PKR();
                        break;

                    case ("KATAR RİYALİ"):
                        QAR();
                        break;

                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close();
        }
    }
    }
