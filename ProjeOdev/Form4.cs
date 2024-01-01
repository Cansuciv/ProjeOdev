using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjeOdev
{ 
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        List<TrafikCezaSistemi.CezaBilgisi> cezaListesi = TrafikCezaSistemi.CezaBilgisi.CezaListesiOlustur();
        TrafikCezaSistemi.KullaniciYetki x = new TrafikCezaSistemi.KullaniciYetki("34 ABC 123", "Hız Sınırı İhlali", 200.0m, DateTime.Now, DateTime.Now.AddMonths(1));
        
        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void SorgulaButton_Click(object sender, EventArgs e)
        {
            labelPlaka.Visible = true;
            labelCezaTuru.Visible = true;
            labelCezaMiktari.Visible = true;
            labelCezaGirisTarihi.Visible = true;
            labelCezaSonOdemeTarihi.Visible = true;

            string plakaNumarasi = textBox1.Text;
            TrafikCezaSistemi.CezaBilgisi cezaBilgisi = cezaListesi.FirstOrDefault(x => x.Plaka == plakaNumarasi);
            if (cezaBilgisi != null)
            {
                var mesaj = x.AnaBilgiMesaji();
                labelPlaka.Text = "Plaka: " + cezaBilgisi.Plaka;
                labelCezaTuru.Text = "Ceza Türü: " + cezaBilgisi.CezaTuru;
                labelCezaMiktari.Text = "Ceza Miktarı: " + cezaBilgisi.CezaMiktari.ToString("C"); // Para birimi formatı
                labelCezaGirisTarihi.Text = "Ceza Giriş Tarihi: " + cezaBilgisi.CezaGirisTarihi.ToString("dd/MM/yyyy");
                labelCezaSonOdemeTarihi.Text = "Son Ödeme Tarihi: " + cezaBilgisi.CezaSonOdemeTarihi.ToString("dd/MM/yyyy") + "\n" + mesaj;
            }
            else
            {
                labelPlaka.Visible = false;
                labelCezaTuru.Visible = false;
                labelCezaMiktari.Visible = false;
                labelCezaGirisTarihi.Visible = false;
                labelCezaSonOdemeTarihi.Visible = false;
                MessageBox.Show("Belirtilen plaka numarasına ait ceza bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OdemeYapButton_Click(object sender, EventArgs e)
        {
            SorgulaButton.Visible = false;
            labelPlaka.Visible = false;
            labelCezaTuru.Visible = false;
            labelCezaMiktari.Visible = false;
            labelCezaGirisTarihi.Visible = false;
            labelCezaSonOdemeTarihi.Visible = false;
            OdemeYapButton.Visible = false;
            Ode.Visible = true;

            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;

            textBox1.Visible = false;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;

            label3.Location = new Point(330, 300);
            label4.Location = new Point(273, 350);
            label5.Location = new Point(455, 400);
            label6.Location = new Point(445, 450);
            label7.Location = new Point(300, 230);

            textBox2.Location = new Point(540, 300);
            textBox3.Location = new Point(540, 350);
            textBox4.Location = new Point(540, 400);
            textBox5.Location = new Point(540, 450);
            Ode.Location = new Point(500, 600);

            TrafikCezaSistemi.IOdemeBilgileri bilgi = (TrafikCezaSistemi.IOdemeBilgileri)x;
            label7.Text = bilgi.OdemeMesaj();
        }

        private void Ode_Click(object sender, EventArgs e)
        { 
            x.KartNumarası = int.Parse(textBox2.Text);
            x.Skt = int.Parse(textBox3.Text);
            x.cvv = int.Parse(textBox4.Text);
            x.Tutar = float.Parse(textBox5.Text);
            MessageBox.Show("Ödemeniz yapılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(255, 230, 179), Color.FromArgb(255, 192, 203), 45f))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void AnaSayfaButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void CezaBilgisiOgrenSayfasinaDon_Click(object sender, EventArgs e)
        {
            SorgulaButton.Visible = false;
            Ode.Visible = false;

            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;

            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            SorgulaButton.Visible = true;
            OdemeYapButton.Visible = true;
            button1.Visible = true;

            textBox1.Text = "";

            label1.Location = new Point(136, 153);
            label2.Location = new Point(267, 242);
            textBox1.Location = new Point(493, 240);
            OdemeYapButton.Location = new Point(450, 640);
            button1.Location = new Point(877, 633);
        }
    }
}

