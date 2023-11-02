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

            label1.Location = new Point(350, 200);
            textBox1.Location = new Point(570, 200);

        }

        private void CezaDüzenle_Click(object sender, EventArgs e)
        {
            CezaDüzenle.Top = 20;
            CezaDüzenle.Left = 400;

            CezaBilgisiOgren.Visible = false;
            CezaSil.Visible = false;

            label1.Visible = true;
            textBox1.Visible = true;

            label1.Location = new Point(350, 200);
            textBox1.Location = new Point(570, 200);
        }

        private void CezaSil_Click(object sender, EventArgs e)
        {
            CezaSil.Top = 20;
            CezaSil.Left = 400;

            CezaBilgisiOgren.Visible = false;
            CezaDüzenle.Visible = false;

            label1.Visible = true;
            textBox1.Visible = true;

            label1.Location = new Point(350, 200);
            textBox1.Location = new Point(570, 200);
        }
    }
}
