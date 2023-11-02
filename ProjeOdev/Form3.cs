using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjeOdev.Form2;

namespace ProjeOdev
{
    public partial class Form3 : Form
    {
        public class CezaBilgisi
        {
            public string Plaka { get; set; }
            public string CezaTuru { get; set; }
            public decimal CezaMiktari { get; set; }
            public DateTime CezaGirisTarihi { get; set; }
            public DateTime CezaSonOdemeTarihi { get; set; }
        }

        List<CezaBilgisi> cezaListesi = new List<CezaBilgisi>
        {

        new CezaBilgisi
        {
            Plaka = "34 ABC 123",
            CezaTuru = "Hız Sınırı İhlali",
            CezaMiktari = 200.0m,
            CezaGirisTarihi = DateTime.Now,
            CezaSonOdemeTarihi = DateTime.Now.AddMonths(1)
        },
        new CezaBilgisi
        {
            Plaka = "06 XYZ 789",
            CezaTuru = "Park Yasağı",
            CezaMiktari = 100.0m,
            CezaGirisTarihi = DateTime.Now.AddDays(-15),
            CezaSonOdemeTarihi = DateTime.Now.AddMonths(2)
        },
    };

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void CezaBilgisiOgren_Click(object sender, EventArgs e)
        {
            CezaBilgisiOgren.Top = 20;
            CezaBilgisiOgren.Left = 400;

            CezaEkle.Visible = false;
            CezaSil.Visible = false;
            label1.Visible = true;
            textBox1.Visible = true;
            SorgulaButton.Visible = true;

            label1.Location = new Point(300, 250);
            textBox1.Location = new Point(520, 250);
            SorgulaButton.Location = new Point(450, 400);
        }

        private void SorgulaButton_Click(object sender, EventArgs e)
        {
            SorgulaButton.Visible = false;
            labelPlaka.Visible = true;
            labelCezaTuru.Visible = true;
            labelCezaMiktari.Visible = true;
            labelCezaGirisTarihi.Visible = true;
            labelCezaSonOdemeTarihi.Visible = true;

            labelPlaka.Location = new Point(400, 300);
            labelCezaTuru.Location = new Point(400, 350);
            labelCezaMiktari.Location = new Point(400, 400);
            labelCezaGirisTarihi.Location = new Point(400, 450);
            labelCezaSonOdemeTarihi.Location = new Point(400, 500);

            string plakaNumarasi = textBox1.Text;
            CezaBilgisi cezaBilgisi = cezaListesi.FirstOrDefault(x => x.Plaka == plakaNumarasi);
            if (cezaBilgisi != null)
            {
                labelPlaka.Text = "Plaka: " + cezaBilgisi.Plaka;
                labelCezaTuru.Text = "Ceza Türü: " + cezaBilgisi.CezaTuru;
                labelCezaMiktari.Text = "Ceza Miktarı: " + cezaBilgisi.CezaMiktari.ToString("C"); // Para birimi formatı
                labelCezaGirisTarihi.Text = "Ceza Giriş Tarihi: " + cezaBilgisi.CezaGirisTarihi.ToString("dd/MM/yyyy");
                labelCezaSonOdemeTarihi.Text = "Son Ödeme Tarihi: " + cezaBilgisi.CezaSonOdemeTarihi.ToString("dd/MM/yyyy");
            }
            else
            {
                MessageBox.Show("Plakaya ait bilgi bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CezaEkle_Click(object sender, EventArgs e)
        {


        }
    }
}
