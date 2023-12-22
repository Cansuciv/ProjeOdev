namespace ProjeOdev
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            CezaBilgisiOgren = new Button();
            CezaSil = new Button();
            CezaDüzenle = new Button();
            button4 = new Button();
            labelCezaSonOdemeTarihi = new Label();
            labelCezaGirisTarihi = new Label();
            labelCezaMiktari = new Label();
            labelCezaTuru = new Label();
            labelPlaka = new Label();
            SorgulaButton = new Button();
            CezaSilButton = new Button();
            AraButton = new Button();
            textBox1 = new TextBox();
            AnaSayfaButton = new Button();
            AdminSayfasinaDon = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PowderBlue;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(114, 511);
            label1.Name = "label1";
            label1.Size = new Size(243, 41);
            label1.TabIndex = 50;
            label1.Text = "Plaka Numarası : ";
            label1.Visible = false;
            // 
            // CezaBilgisiOgren
            // 
            CezaBilgisiOgren.BackColor = Color.DarkSalmon;
            CezaBilgisiOgren.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CezaBilgisiOgren.Location = new Point(294, 158);
            CezaBilgisiOgren.Name = "CezaBilgisiOgren";
            CezaBilgisiOgren.Size = new Size(274, 124);
            CezaBilgisiOgren.TabIndex = 49;
            CezaBilgisiOgren.Text = "Ceza Bilgisi Öğren";
            CezaBilgisiOgren.UseVisualStyleBackColor = false;
            CezaBilgisiOgren.Click += CezaBilgisiOgren_Click;
            // 
            // CezaSil
            // 
            CezaSil.BackColor = Color.DarkSalmon;
            CezaSil.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CezaSil.Location = new Point(474, 347);
            CezaSil.Name = "CezaSil";
            CezaSil.Size = new Size(274, 124);
            CezaSil.TabIndex = 48;
            CezaSil.Text = "Ceza Sil";
            CezaSil.UseVisualStyleBackColor = false;
            CezaSil.Click += CezaSil_Click;
            // 
            // CezaDüzenle
            // 
            CezaDüzenle.BackColor = Color.DarkSalmon;
            CezaDüzenle.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CezaDüzenle.Location = new Point(666, 155);
            CezaDüzenle.Name = "CezaDüzenle";
            CezaDüzenle.Size = new Size(274, 130);
            CezaDüzenle.TabIndex = 47;
            CezaDüzenle.Text = "Ceza Düzenle";
            CezaDüzenle.UseVisualStyleBackColor = false;
            CezaDüzenle.Click += CezaDüzenle_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightGreen;
            button4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(920, 578);
            button4.Name = "button4";
            button4.Size = new Size(113, 53);
            button4.TabIndex = 46;
            button4.Text = "KAPAT";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // labelCezaSonOdemeTarihi
            // 
            labelCezaSonOdemeTarihi.AutoSize = true;
            labelCezaSonOdemeTarihi.BackColor = SystemColors.GradientInactiveCaption;
            labelCezaSonOdemeTarihi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCezaSonOdemeTarihi.Location = new Point(241, 616);
            labelCezaSonOdemeTarihi.Name = "labelCezaSonOdemeTarihi";
            labelCezaSonOdemeTarihi.Size = new Size(65, 28);
            labelCezaSonOdemeTarihi.TabIndex = 57;
            labelCezaSonOdemeTarihi.Text = "label6";
            labelCezaSonOdemeTarihi.Visible = false;
            // 
            // labelCezaGirisTarihi
            // 
            labelCezaGirisTarihi.AutoSize = true;
            labelCezaGirisTarihi.BackColor = SystemColors.GradientInactiveCaption;
            labelCezaGirisTarihi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCezaGirisTarihi.Location = new Point(241, 567);
            labelCezaGirisTarihi.Name = "labelCezaGirisTarihi";
            labelCezaGirisTarihi.Size = new Size(65, 28);
            labelCezaGirisTarihi.TabIndex = 56;
            labelCezaGirisTarihi.Text = "label5";
            labelCezaGirisTarihi.Visible = false;
            // 
            // labelCezaMiktari
            // 
            labelCezaMiktari.AutoSize = true;
            labelCezaMiktari.BackColor = SystemColors.GradientInactiveCaption;
            labelCezaMiktari.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCezaMiktari.Location = new Point(133, 657);
            labelCezaMiktari.Name = "labelCezaMiktari";
            labelCezaMiktari.Size = new Size(65, 28);
            labelCezaMiktari.TabIndex = 55;
            labelCezaMiktari.Text = "label4";
            labelCezaMiktari.Visible = false;
            // 
            // labelCezaTuru
            // 
            labelCezaTuru.AutoSize = true;
            labelCezaTuru.BackColor = SystemColors.GradientInactiveCaption;
            labelCezaTuru.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCezaTuru.Location = new Point(133, 616);
            labelCezaTuru.Name = "labelCezaTuru";
            labelCezaTuru.Size = new Size(65, 28);
            labelCezaTuru.TabIndex = 54;
            labelCezaTuru.Text = "label3";
            labelCezaTuru.Visible = false;
            // 
            // labelPlaka
            // 
            labelPlaka.AutoSize = true;
            labelPlaka.BackColor = SystemColors.GradientInactiveCaption;
            labelPlaka.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPlaka.Location = new Point(133, 567);
            labelPlaka.Name = "labelPlaka";
            labelPlaka.Size = new Size(65, 28);
            labelPlaka.TabIndex = 53;
            labelPlaka.Text = "label2";
            labelPlaka.Visible = false;
            // 
            // SorgulaButton
            // 
            SorgulaButton.BackColor = SystemColors.GradientActiveCaption;
            SorgulaButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            SorgulaButton.Location = new Point(471, 593);
            SorgulaButton.Name = "SorgulaButton";
            SorgulaButton.Size = new Size(163, 50);
            SorgulaButton.TabIndex = 52;
            SorgulaButton.Text = "SORGULA";
            SorgulaButton.UseVisualStyleBackColor = false;
            SorgulaButton.Visible = false;
            SorgulaButton.Click += SorgulaButton_Click;
            // 
            // CezaSilButton
            // 
            CezaSilButton.BackColor = SystemColors.GradientActiveCaption;
            CezaSilButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            CezaSilButton.Location = new Point(640, 579);
            CezaSilButton.Name = "CezaSilButton";
            CezaSilButton.Size = new Size(163, 50);
            CezaSilButton.TabIndex = 59;
            CezaSilButton.Text = "CEZA SİL";
            CezaSilButton.UseVisualStyleBackColor = false;
            CezaSilButton.Visible = false;
            CezaSilButton.Click += CezaSilButton_Click;
            // 
            // AraButton
            // 
            AraButton.BackColor = SystemColors.GradientActiveCaption;
            AraButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            AraButton.Location = new Point(666, 504);
            AraButton.Name = "AraButton";
            AraButton.Size = new Size(163, 50);
            AraButton.TabIndex = 58;
            AraButton.Text = "ARA";
            AraButton.UseVisualStyleBackColor = false;
            AraButton.Visible = false;
            AraButton.Click += AraButton_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.PowderBlue;
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(363, 511);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 43);
            textBox1.TabIndex = 60;
            textBox1.Visible = false;
            // 
            // AnaSayfaButton
            // 
            AnaSayfaButton.BackColor = Color.DarkSeaGreen;
            AnaSayfaButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            AnaSayfaButton.Location = new Point(87, 22);
            AnaSayfaButton.Name = "AnaSayfaButton";
            AnaSayfaButton.Size = new Size(170, 80);
            AnaSayfaButton.TabIndex = 61;
            AnaSayfaButton.Text = "ANA SAYFA";
            AnaSayfaButton.UseVisualStyleBackColor = false;
            AnaSayfaButton.Click += AnaSayfaButton_Click;
            // 
            // AdminSayfasinaDon
            // 
            AdminSayfasinaDon.BackColor = Color.DarkSeaGreen;
            AdminSayfasinaDon.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AdminSayfasinaDon.Location = new Point(834, 21);
            AdminSayfasinaDon.Name = "AdminSayfasinaDon";
            AdminSayfasinaDon.Size = new Size(241, 85);
            AdminSayfasinaDon.TabIndex = 62;
            AdminSayfasinaDon.Text = "ADMİN SAYFASINA DÖN";
            AdminSayfasinaDon.UseVisualStyleBackColor = false;
            AdminSayfasinaDon.Click += AdminSayfasinaDon_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1206, 712);
            Controls.Add(AdminSayfasinaDon);
            Controls.Add(AnaSayfaButton);
            Controls.Add(textBox1);
            Controls.Add(CezaSilButton);
            Controls.Add(AraButton);
            Controls.Add(labelCezaSonOdemeTarihi);
            Controls.Add(labelCezaGirisTarihi);
            Controls.Add(labelCezaMiktari);
            Controls.Add(labelCezaTuru);
            Controls.Add(labelPlaka);
            Controls.Add(SorgulaButton);
            Controls.Add(label1);
            Controls.Add(CezaBilgisiOgren);
            Controls.Add(CezaSil);
            Controls.Add(CezaDüzenle);
            Controls.Add(button4);
            Name = "Form2";
            Text = "Form2";
            Paint += Form2_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button CezaBilgisiOgren;
        private Button CezaSil;
        private Button CezaDüzenle;
        private Button button4;
        private Label labelCezaSonOdemeTarihi;
        private Label labelCezaGirisTarihi;
        private Label labelCezaMiktari;
        private Label labelCezaTuru;
        private Label labelPlaka;
        private Button SorgulaButton;
        private Button CezaSilButton;
        private Button AraButton;
        private TextBox textBox1;
        private Button AnaSayfaButton;
        private Button AdminSayfasinaDon;
    }
}