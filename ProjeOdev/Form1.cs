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
            GirisYapButonu.Visible = true;

            label1.Location = new Point(350, 300);
            label2.Location = new Point(350, 400);
            textBox1.Location = new Point(560, 300);
            textBox2.Location = new Point(560, 400);
            GirisYapButonu.Location = new Point(500, 500);
        }

        private void GirisYapButonu_Click(object sender, EventArgs e)
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
            GirisYapButonu.Visible = true;

            label1.Location = new Point(350, 300);
            label2.Location = new Point(350, 400);
            textBox1.Location = new Point(560, 300);
            textBox2.Location = new Point(560, 400);
            GirisYapButonu.Location = new Point(500, 500);

            //Form3 PolisGiris = new Form3();
            //PolisGiris.Show();
        }

        private void Kullan�c�_giri�i_Click(object sender, EventArgs e)
        {
            Kullan�c�_giri�i.Top = 20;
            Kullan�c�_giri�i.Left = 400;

            Admin_Giri�i.Visible = false;
            Yetkili_polis_giri�i.Visible = false;


            button1.Visible = true;
            button2.Visible = true;

            button1.Location = new Point(450, 300);
            button2.Location = new Point(450, 430);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}