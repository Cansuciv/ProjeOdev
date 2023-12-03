using System.Drawing.Drawing2D;

namespace ProjeOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Admin_Giriþi_Click(object sender, EventArgs e)
        {
            TrafikCezaSistemi.AdminGiris x = new TrafikCezaSistemi.AdminGiris();
            x.KullaniciAdi = textBox1.Text;
            x.Sifre=textBox2.Text;  

            Admin_Giriþi.Top = 20;
            Admin_Giriþi.Left = 450;

            Yetkili_polis_giriþi.Visible = false;
            Kullanýcý_giriþi.Visible = false;

            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            AdminGirisiYapButonu.Visible = true;

            label1.Location = new Point(377, 250);
            label2.Location = new Point(475, 350);
            textBox1.Location = new Point(580, 250);
            textBox2.Location = new Point(580, 350);
            AdminGirisiYapButonu.Location = new Point(580, 450);

        }


        private void AdminGirisiYapButonu_Click(object sender, EventArgs e)
        {
            Form2 AdminGiris = new Form2();
            AdminGiris.Show();

        }

        private void Yetkili_polis_giriþi_Click(object sender, EventArgs e)
        {
            TrafikCezaSistemi.YetkiliPolisGiriþi x = new TrafikCezaSistemi.YetkiliPolisGiriþi();
            x.YPKullaniciAdi = textBox1.Text;
            x.YPSifre = textBox2.Text;

            Yetkili_polis_giriþi.Top = 20;
            Yetkili_polis_giriþi.Left = 480;

            Admin_Giriþi.Visible = false;
            Kullanýcý_giriþi.Visible = false;

            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            YetkiliPolisGirisiYap.Visible = true;

            label1.Location = new Point(377, 250);
            label2.Location = new Point(475, 350);
            textBox1.Location = new Point(580, 250);
            textBox2.Location = new Point(580, 350);
            YetkiliPolisGirisiYap.Location = new Point(580, 450);

        }

        private void YetkiliPolisGirisiYap_Click(object sender, EventArgs e)
        {
            Form3 PolisGiris = new Form3();
            PolisGiris.Show();
        }


        private void Kullanýcý_giriþi_Click(object sender, EventArgs e)
        {
            TrafikCezaSistemi.KullaniciGiris x = new TrafikCezaSistemi.KullaniciGiris();
            x.KKullaniciAdi = textBox1.Text;
            x.KSifre = textBox2.Text;

            Kullanýcý_giriþi.Top = 20;
            Kullanýcý_giriþi.Left = 480;

            Admin_Giriþi.Visible = false;
            Yetkili_polis_giriþi.Visible = false;

            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            KullaniciÜyeOlButton.Visible = true;
            GirisYapButton.Visible = true;

            label1.Location = new Point(377, 250);
            label2.Location = new Point(475, 330);
            textBox1.Location = new Point(580, 250);
            textBox2.Location = new Point(580, 330);
            GirisYapButton.Location = new Point(580, 400);
            KullaniciÜyeOlButton.Location = new Point(580, 530);
        }

        private void GirisYapButton_Click(object sender, EventArgs e)
        {
            Form4 KullaniciGirisEkrani = new Form4();
            KullaniciGirisEkrani.Show();
        }

        private void KullaniciÜyeOlButton_Click(object sender, EventArgs e)
        {
            TrafikCezaSistemi.KullaniciUye x = new TrafikCezaSistemi.KullaniciUye();
            x.KKullaniciAdi = textBox1.Text;
            x.KSifre = textBox2.Text;   
            x.KUTelefonNo=int.Parse(textBox3.Text);

            GirisYapButton.Visible = false;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;

            label1.Location = new Point(377, 330);
            label2.Location = new Point(475, 410);
            label3.Location = new Point(312, 250);
            textBox1.Location = new Point(580, 330);
            textBox2.Location = new Point(580, 410);
            textBox3.Location = new Point(580, 250);

            KullaniciÜyeOlButton.Visible = false;
            UyeOl.Visible = true;

            UyeOl.Location = new Point(580, 530);

        }

        private void UyeOl_Click(object sender, EventArgs e)
        {
            Form4 KullaniciGirisEkrani = new Form4();
            KullaniciGirisEkrani.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(192, 128, 192), Color.FromArgb(255, 192, 0), 45f))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}


