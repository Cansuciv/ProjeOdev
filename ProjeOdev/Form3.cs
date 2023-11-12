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
using static ProjeOdev.Form2;

namespace ProjeOdev
{
    public partial class Form3 : Form
    {
        List<TrafikCezaSistemi.CezaBilgisi> cezaListesi;
        public Form3()
        {
            InitializeComponent();
            cezaListesi = TrafikCezaSistemi.CezaBilgisi.CezaListesiOlustur();
        }

        //List<TrafikCezaSistemi.CezaBilgisi> cezaListesi = TrafikCezaSistemi.CezaBilgisi.CezaListesiOlustur();

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
            textBox1.Location = new Point(530, 250);
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
            TrafikCezaSistemi.CezaBilgisi cezaBilgisi = cezaListesi.FirstOrDefault(x => x.Plaka == plakaNumarasi);
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
            CezaEkle.Top = 20;
            CezaEkle.Left = 400;

            CezaBilgisiOgren.Visible = false;
            CezaSil.Visible = false;

            EkleButton.Visible = true;
            EkleButton.Location = new Point(550, 600);

            Sehir.Visible = true;
            Ilce.Visible = true;
            Plaka.Visible = true;
            CezaTuru.Visible = true;
            CezaMiktarı.Visible = true;
            CezaGirişTarihi.Visible = true;
            CezaSonÖdemeTarihi.Visible = true;

            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;

            Sehir.Location = new Point(525, 200);
            Ilce.Location = new Point(540, 250);
            Plaka.Location = new Point(523, 300);
            CezaTuru.Location = new Point(483, 350);
            CezaMiktarı.Location = new Point(466, 400);
            CezaGirişTarihi.Location = new Point(438, 450);
            CezaSonÖdemeTarihi.Location = new Point(375, 500);

            textBox2.Location = new Point(600, 200);
            textBox3.Location = new Point(600, 250);
            textBox4.Location = new Point(600, 300);
            textBox5.Location = new Point(600, 350);
            textBox6.Location = new Point(600, 400);
            textBox7.Location = new Point(600, 450);
            textBox8.Location = new Point(600, 500);
        }

        private void EkleButton_Click(object sender, EventArgs e)
        {
           TrafikCezaSistemi.CezaBilgisi yeniCeza = new TrafikCezaSistemi.CezaBilgisi(
                textBox4.Text,
                textBox5.Text,
                Convert.ToDecimal(textBox6.Text),
                DateTime.Parse(textBox7.Text),
                DateTime.Parse(textBox8.Text)
            );


            cezaListesi.Add(yeniCeza);
            MessageBox.Show("Ceza eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void CezaSil_Click(object sender, EventArgs e)
        {
            CezaSil.Top = 20;
            CezaSil.Left = 400;

            CezaBilgisiOgren.Visible = false;
            CezaEkle.Visible = false;

            label1.Visible = true;
            textBox1.Visible = true;
            CezaSilButton.Visible = true;

            label1.Location = new Point(300, 250);
            textBox1.Location = new Point(530, 250);
            CezaSilButton.Location = new Point(450, 400);

        }

        private void CezaSilButton_Click(object sender, EventArgs e)
        {
            string plakaNumarasi = textBox1.Text;
            TrafikCezaSistemi.CezaBilgisi cezaBilgisi = cezaListesi.FirstOrDefault(x => x.Plaka == plakaNumarasi);

            if (cezaBilgisi != null)
            {
                // Cezayı listeden kaldırın
                cezaListesi.Remove(cezaBilgisi);
                MessageBox.Show("Seçilen ceza silinmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Kullanıcının girdiği plaka numarasını temizleyin
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Plaka numarasına ait ceza bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(255, 200, 100), Color.FromArgb(100, 200, 255), 45f))
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

        private void YetkiliPolisSayfasinaDon_Click(object sender, EventArgs e)
        {
            CezaBilgisiOgren.Top = 192;
            CezaBilgisiOgren.Left = 173;

            CezaEkle.Top = 189;
            CezaEkle.Left = 545;

            CezaSil.Top = 346;
            CezaSil.Left = 357;

            CezaBilgisiOgren.Visible = true;
            CezaEkle.Visible = true;
            CezaSil.Visible = true;


            EkleButton.Visible = false;
            label1.Visible = false;
            textBox1.Visible = false;
            labelPlaka.Visible = false;
            labelCezaTuru.Visible = false;
            labelCezaMiktari.Visible = false;
            labelCezaGirisTarihi.Visible = false;
            labelCezaSonOdemeTarihi.Visible = false;
            SorgulaButton.Visible = false;
            CezaSilButton.Visible = false;
            Sehir.Visible = false;
            Ilce.Visible = false;
            Plaka.Visible = false;
            CezaTuru.Visible = false;
            CezaMiktarı.Visible = false;
            CezaGirişTarihi.Visible = false;
            CezaSonÖdemeTarihi.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;

            this.Refresh();
        }
    }
}


