using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeOdev
{
    public partial class Form2 : Form
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


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void CezaBilgisiOgren_Click(object sender, EventArgs e)
        {
            CezaBilgisiOgren.Top = 20;
            CezaBilgisiOgren.Left = 400;

            CezaDüzenle.Visible = false;
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

        private void CezaDüzenle_Click(object sender, EventArgs e)
        {
            CezaDüzenle.Top = 20;
            CezaDüzenle.Left = 400;

            CezaBilgisiOgren.Visible = false;
            CezaSil.Visible = false;
            label1.Visible = true;
            textBox1.Visible = true;
            SorgulaButton.Visible = false;
            AraButton.Visible = true;

            label1.Location = new Point(300, 250);
            textBox1.Location = new Point(520, 250);
            SorgulaButton.Location = new Point(450, 400);
            AraButton.Location = new Point(450, 400);

        }

        private void AraButton_Click(object sender, EventArgs e)
        {
            string plakaNumarasi = textBox1.Text;
            CezaBilgisi ceza = cezaListesi.FirstOrDefault(c => c.Plaka == plakaNumarasi);

            if (ceza != null)
            {
                // Eğer ceza bulunduysa, ilgili metin kutularını güncelleyin
                labelCezaTuru.Text = ceza.CezaTuru;
                labelCezaMiktari.Text = ceza.CezaMiktari.ToString();
                labelCezaGirisTarihi.Text = ceza.CezaGirisTarihi.ToShortDateString();
                labelCezaSonOdemeTarihi.Text = ceza.CezaSonOdemeTarihi.ToShortDateString();

                // Kullanıcıdan yeni bilgileri alın
                string yeniCezaTuru = "Yeni Ceza Türü"; // Yeni ceza türünü kullanıcıdan alın
                decimal yeniCezaMiktari = 300.0m; // Yeni ceza miktarını kullanıcıdan alın
                DateTime yeniCezaGirisTarihi = DateTime.Now; // Yeni ceza giriş tarihini kullanıcıdan alın
                DateTime yeniCezaSonOdemeTarihi = DateTime.Now.AddMonths(3); // Yeni ceza son ödeme tarihini kullanıcıdan alın

                // Yeni bilgileri güncelleyin
                ceza.CezaTuru = yeniCezaTuru;
                ceza.CezaMiktari = yeniCezaMiktari;
                ceza.CezaGirisTarihi = yeniCezaGirisTarihi;
                ceza.CezaSonOdemeTarihi = yeniCezaSonOdemeTarihi;

                // Kullanıcıya güncelleme başarılı mesajını gösterin
                MessageBox.Show("Ceza bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Belirtilen plaka numarasına ait ceza bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CezaSil_Click(object sender, EventArgs e)
        {
            CezaSil.Top = 20;
            CezaSil.Left = 400;

            CezaBilgisiOgren.Visible = false;
            CezaDüzenle.Visible = false;
            label1.Visible = true;
            textBox1.Visible = true;
            CezaSilButton.Visible = true;

            label1.Location = new Point(300, 250);
            textBox1.Location = new Point(520, 250);
            SorgulaButton.Location = new Point(450, 400);
            CezaSilButton.Location = new Point(450, 400);
        }


        private void CezaSilButton_Click(object sender, EventArgs e)
        {
            string plakaNumarasi = textBox1.Text;
            CezaBilgisi ceza = cezaListesi.FirstOrDefault(c => c.Plaka == plakaNumarasi);

            if (ceza != null)
            {
                // Eğer ceza bulunduysa, listeden kaldırın
                cezaListesi.Remove(ceza);

                // Kullanıcıya silme başarılı mesajını gösterin
                MessageBox.Show("Ceza başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Metin kutularını temizleyin veya gizleyin, isterseniz diğer işlemleri burada yapabilirsiniz.
                textBox1.Text = string.Empty;
                labelCezaTuru.Text = string.Empty;
                labelCezaMiktari.Text = string.Empty;
                labelCezaGirisTarihi.Text = string.Empty;
                labelCezaSonOdemeTarihi.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Belirtilen plaka numarasına ait ceza bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
