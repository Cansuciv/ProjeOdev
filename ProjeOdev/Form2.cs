﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ProjeOdev
{  
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        List<TrafikCezaSistemi.CezaBilgisi> cezaListesi = TrafikCezaSistemi.CezaBilgisi.CezaListesiOlustur();
        TrafikCezaSistemi.AdminYetki x = new TrafikCezaSistemi.AdminYetki("34 ABC 123", "Hız Sınırı İhlali", 200.0m, DateTime.Now, DateTime.Now.AddMonths(1));
       
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
            textBox1.Location = new Point(550, 250);
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
                var mesaj = x.AnaBilgiMesaji();
                labelPlaka.Text = "Plaka: " + cezaBilgisi.Plaka;
                labelCezaTuru.Text = "Ceza Türü: " + cezaBilgisi.CezaTuru;
                labelCezaMiktari.Text = "Ceza Miktarı: " + cezaBilgisi.CezaMiktari.ToString("C"); // Para birimi formatı
                labelCezaGirisTarihi.Text = "Ceza Giriş Tarihi: " + cezaBilgisi.CezaGirisTarihi.ToString("dd/MM/yyyy");
                labelCezaSonOdemeTarihi.Text = "Son Ödeme Tarihi: "+ cezaBilgisi.CezaSonOdemeTarihi.ToString("dd/MM/yyyy") + "\n" + mesaj;
            }
            else
            {
                labelPlaka.Visible = false;
                labelCezaTuru.Visible = false;
                labelCezaMiktari.Visible = false;
                labelCezaGirisTarihi.Visible = false;
                labelCezaSonOdemeTarihi.Visible = false;
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
            textBox1.Location = new Point(550, 250);
            SorgulaButton.Location = new Point(450, 400);
            AraButton.Location = new Point(450, 400);

        }

        private void AraButton_Click(object sender, EventArgs e)
        {
            string plakaNumarasi = textBox1.Text;
            TrafikCezaSistemi.CezaBilgisi ceza = cezaListesi.FirstOrDefault(x => x.Plaka == plakaNumarasi);

            if (ceza != null)
            {
                // Eğer ceza bulunduysa, ilgili metin kutularını güncelleyin
                labelCezaTuru.Text = ceza.CezaTuru;
                labelCezaMiktari.Text = ceza.CezaMiktari.ToString();
                labelCezaGirisTarihi.Text = ceza.CezaGirisTarihi.ToShortDateString();
                labelCezaSonOdemeTarihi.Text = ceza.CezaSonOdemeTarihi.ToShortDateString();

                
                // Kullanıcıdan yeni bilgileri alma
                x.yeniCezaTuru = "Yeni Ceza Türü"; 
                x.yeniCezaMiktari = 300.0m; 
                x.yeniCezaGirisTarihi = DateTime.Now; 
                x.yeniCezaSonOdemeTarihi = DateTime.Now.AddMonths(3); 

                // Yeni bilgileri güncelleyin
                x.CezaTuru = x.yeniCezaTuru;
                x.CezaMiktari = x.yeniCezaMiktari;
                x.CezaGirisTarihi = x.yeniCezaGirisTarihi;
                x.CezaSonOdemeTarihi = x.yeniCezaSonOdemeTarihi;

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
            textBox1.Location = new Point(550, 250);
            SorgulaButton.Location = new Point(450, 400);
            CezaSilButton.Location = new Point(450, 400);
        }


        private void CezaSilButton_Click(object sender, EventArgs e)
        {
            string plakaNumarasi = textBox1.Text;
            TrafikCezaSistemi.CezaBilgisi ceza = cezaListesi.FirstOrDefault(x => x.Plaka == plakaNumarasi);
            if (ceza != null)
            {
                // Eğer ceza bulunduysa, listeden kaldırın
                cezaListesi.Remove(ceza);
                MessageBox.Show("Ceza başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            Application.Exit();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(255, 192, 192), Color.FromArgb(255, 255, 192), 45f))
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

        private void AdminSayfasinaDon_Click(object sender, EventArgs e)
        {
            CezaBilgisiOgren.Top = 158;
            CezaBilgisiOgren.Left = 236;

            CezaDüzenle.Top = 155;
            CezaDüzenle.Left = 608;

            CezaSil.Top = 347;
            CezaSil.Left = 416;

            CezaBilgisiOgren.Visible = true;
            CezaDüzenle.Visible = true;
            CezaSil.Visible = true;

            label1.Visible = false;
            textBox1.Visible = false;
            SorgulaButton.Visible = false;
            AraButton.Visible = false;
            CezaSilButton.Visible = false;
            labelPlaka.Visible = false;
            labelCezaTuru.Visible = false;
            labelCezaMiktari.Visible = false;
            labelCezaGirisTarihi.Visible = false;
            labelCezaSonOdemeTarihi.Visible = false;

            this.Refresh();
        }       
    }
}
