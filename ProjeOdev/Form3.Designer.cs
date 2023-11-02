namespace ProjeOdev
{
    partial class Form3
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
            CezaBilgisiOgren = new Button();
            CezaSil = new Button();
            CezaEkle = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            labelCezaSonOdemeTarihi = new Label();
            labelCezaGirisTarihi = new Label();
            labelCezaMiktari = new Label();
            labelCezaTuru = new Label();
            labelPlaka = new Label();
            SorgulaButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // CezaBilgisiOgren
            // 
            CezaBilgisiOgren.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CezaBilgisiOgren.Location = new Point(206, 45);
            CezaBilgisiOgren.Name = "CezaBilgisiOgren";
            CezaBilgisiOgren.Size = new Size(274, 124);
            CezaBilgisiOgren.TabIndex = 52;
            CezaBilgisiOgren.Text = "Ceza Bilgisi Öğren";
            CezaBilgisiOgren.UseVisualStyleBackColor = true;
            CezaBilgisiOgren.Click += CezaBilgisiOgren_Click;
            // 
            // CezaSil
            // 
            CezaSil.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CezaSil.Location = new Point(390, 217);
            CezaSil.Name = "CezaSil";
            CezaSil.Size = new Size(274, 124);
            CezaSil.TabIndex = 51;
            CezaSil.Text = "Ceza Sil";
            CezaSil.UseVisualStyleBackColor = true;
            // 
            // CezaEkle
            // 
            CezaEkle.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CezaEkle.Location = new Point(578, 42);
            CezaEkle.Name = "CezaEkle";
            CezaEkle.Size = new Size(274, 130);
            CezaEkle.TabIndex = 50;
            CezaEkle.Text = "Ceza Ekle";
            CezaEkle.UseVisualStyleBackColor = true;
            CezaEkle.Click += CezaEkle_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(945, 646);
            button4.Name = "button4";
            button4.Size = new Size(113, 53);
            button4.TabIndex = 53;
            button4.Text = "KAPAT";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(269, 460);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 39);
            textBox1.TabIndex = 68;
            textBox1.Visible = false;
            // 
            // labelCezaSonOdemeTarihi
            // 
            labelCezaSonOdemeTarihi.AutoSize = true;
            labelCezaSonOdemeTarihi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCezaSonOdemeTarihi.Location = new Point(161, 565);
            labelCezaSonOdemeTarihi.Name = "labelCezaSonOdemeTarihi";
            labelCezaSonOdemeTarihi.Size = new Size(65, 28);
            labelCezaSonOdemeTarihi.TabIndex = 67;
            labelCezaSonOdemeTarihi.Text = "label6";
            labelCezaSonOdemeTarihi.Visible = false;
            // 
            // labelCezaGirisTarihi
            // 
            labelCezaGirisTarihi.AutoSize = true;
            labelCezaGirisTarihi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCezaGirisTarihi.Location = new Point(161, 516);
            labelCezaGirisTarihi.Name = "labelCezaGirisTarihi";
            labelCezaGirisTarihi.Size = new Size(65, 28);
            labelCezaGirisTarihi.TabIndex = 66;
            labelCezaGirisTarihi.Text = "label5";
            labelCezaGirisTarihi.Visible = false;
            // 
            // labelCezaMiktari
            // 
            labelCezaMiktari.AutoSize = true;
            labelCezaMiktari.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCezaMiktari.Location = new Point(53, 606);
            labelCezaMiktari.Name = "labelCezaMiktari";
            labelCezaMiktari.Size = new Size(65, 28);
            labelCezaMiktari.TabIndex = 65;
            labelCezaMiktari.Text = "label4";
            labelCezaMiktari.Visible = false;
            // 
            // labelCezaTuru
            // 
            labelCezaTuru.AutoSize = true;
            labelCezaTuru.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCezaTuru.Location = new Point(53, 565);
            labelCezaTuru.Name = "labelCezaTuru";
            labelCezaTuru.Size = new Size(65, 28);
            labelCezaTuru.TabIndex = 64;
            labelCezaTuru.Text = "label3";
            labelCezaTuru.Visible = false;
            // 
            // labelPlaka
            // 
            labelPlaka.AutoSize = true;
            labelPlaka.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPlaka.Location = new Point(53, 516);
            labelPlaka.Name = "labelPlaka";
            labelPlaka.Size = new Size(65, 28);
            labelPlaka.TabIndex = 63;
            labelPlaka.Text = "label2";
            labelPlaka.Visible = false;
            // 
            // SorgulaButton
            // 
            SorgulaButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            SorgulaButton.Location = new Point(295, 584);
            SorgulaButton.Name = "SorgulaButton";
            SorgulaButton.Size = new Size(163, 50);
            SorgulaButton.TabIndex = 62;
            SorgulaButton.Text = "SORGULA";
            SorgulaButton.UseVisualStyleBackColor = true;
            SorgulaButton.Visible = false;
            SorgulaButton.Click += SorgulaButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 460);
            label1.Name = "label1";
            label1.Size = new Size(220, 37);
            label1.TabIndex = 61;
            label1.Text = "Plaka Numarası : ";
            label1.Visible = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 737);
            Controls.Add(textBox1);
            Controls.Add(labelCezaSonOdemeTarihi);
            Controls.Add(labelCezaGirisTarihi);
            Controls.Add(labelCezaMiktari);
            Controls.Add(labelCezaTuru);
            Controls.Add(labelPlaka);
            Controls.Add(SorgulaButton);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(CezaBilgisiOgren);
            Controls.Add(CezaSil);
            Controls.Add(CezaEkle);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CezaBilgisiOgren;
        private Button CezaSil;
        private Button CezaEkle;
        private Button button4;
        private TextBox textBox1;
        private Label labelCezaSonOdemeTarihi;
        private Label labelCezaGirisTarihi;
        private Label labelCezaMiktari;
        private Label labelCezaTuru;
        private Label labelPlaka;
        private Button SorgulaButton;
        private Label label1;
    }
}