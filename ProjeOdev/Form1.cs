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

        private void Admin_Giri�i_Click(object sender, EventArgs e)
        {
            Admin_Giri�i.Top = 20;
            Admin_Giri�i.Left = 400;

            Yetkili_polis_giri�i.Visible = false;
            Kullan�c�_giri�i.Visible = false;

            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            AdminGirisiYapButonu.Visible = true;

            label1.Location = new Point(350, 300);
            label2.Location = new Point(350, 400);
            textBox1.Location = new Point(560, 300);
            textBox2.Location = new Point(560, 400);
            AdminGirisiYapButonu.Location = new Point(500, 500);
        }


        private void AdminGirisiYapButonu_Click(object sender, EventArgs e)
        {
            Form2 AdminGiris = new Form2();
            AdminGiris.Show();

        }

        private void Yetkili_polis_giri�i_Click(object sender, EventArgs e)
        {
            Yetkili_polis_giri�i.Top = 20;
            Yetkili_polis_giri�i.Left = 400;

            Admin_Giri�i.Visible = false;
            Kullan�c�_giri�i.Visible = false;

            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            YetkiliPolisGirisiYap.Visible = true;

            label1.Location = new Point(350, 300);
            label2.Location = new Point(350, 400);
            textBox1.Location = new Point(560, 300);
            textBox2.Location = new Point(560, 400);
            YetkiliPolisGirisiYap.Location = new Point(500, 500);

        }

        private void YetkiliPolisGirisiYap_Click(object sender, EventArgs e)
        {
            Form3 PolisGiris = new Form3();
            PolisGiris.Show();
        }


        private void Kullan�c�_giri�i_Click(object sender, EventArgs e)
        {
            Kullan�c�_giri�i.Top = 20;
            Kullan�c�_giri�i.Left = 400;

            Admin_Giri�i.Visible = false;
            Yetkili_polis_giri�i.Visible = false;

            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            Kullanici�yeOlButton.Visible = true;
            GirisYapButton.Visible = true;

            label1.Location = new Point(350, 250);
            label2.Location = new Point(350, 330);
            textBox1.Location = new Point(560, 250);
            textBox2.Location = new Point(560, 330);
            GirisYapButton.Location = new Point(450, 400);
            Kullanici�yeOlButton.Location = new Point(450, 530);
        }

        private void GirisYapButton_Click(object sender, EventArgs e)
        {
            Form4 KullaniciGirisEkrani = new Form4();
            KullaniciGirisEkrani.Show();
        }

        private void Kullanici�yeOlButton_Click(object sender, EventArgs e)
        {
            GirisYapButton.Visible=false;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;

            label1.Location = new Point(350, 330);
            label2.Location = new Point(350, 410);
            label3.Location = new Point(350, 250);
            textBox1.Location = new Point(560, 330);
            textBox2.Location = new Point(560, 410);
            textBox3.Location = new Point(560, 250);



        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}