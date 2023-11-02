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
            textBox1 = new TextBox();
            label1 = new Label();
            CezaBilgisiOgren = new Button();
            CezaSil = new Button();
            CezaDüzenle = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(311, 449);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 39);
            textBox1.TabIndex = 51;
            textBox1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(67, 447);
            label1.Name = "label1";
            label1.Size = new Size(220, 37);
            label1.TabIndex = 50;
            label1.Text = "Plaka Numarası : ";
            label1.Visible = false;
            // 
            // CezaBilgisiOgren
            // 
            CezaBilgisiOgren.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CezaBilgisiOgren.Location = new Point(148, 90);
            CezaBilgisiOgren.Name = "CezaBilgisiOgren";
            CezaBilgisiOgren.Size = new Size(274, 124);
            CezaBilgisiOgren.TabIndex = 49;
            CezaBilgisiOgren.Text = "Ceza Bilgisi Öğren";
            CezaBilgisiOgren.UseVisualStyleBackColor = true;
            CezaBilgisiOgren.Click += CezaBilgisiOgren_Click;
            // 
            // CezaSil
            // 
            CezaSil.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CezaSil.Location = new Point(328, 279);
            CezaSil.Name = "CezaSil";
            CezaSil.Size = new Size(274, 124);
            CezaSil.TabIndex = 48;
            CezaSil.Text = "Ceza Sil";
            CezaSil.UseVisualStyleBackColor = true;
            CezaSil.Click += CezaSil_Click;
            // 
            // CezaDüzenle
            // 
            CezaDüzenle.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CezaDüzenle.Location = new Point(520, 87);
            CezaDüzenle.Name = "CezaDüzenle";
            CezaDüzenle.Size = new Size(274, 130);
            CezaDüzenle.TabIndex = 47;
            CezaDüzenle.Text = "Ceza Düzenle";
            CezaDüzenle.UseVisualStyleBackColor = true;
            CezaDüzenle.Click += CezaDüzenle_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(799, 553);
            button4.Name = "button4";
            button4.Size = new Size(113, 53);
            button4.TabIndex = 46;
            button4.Text = "KAPAT";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 692);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(CezaBilgisiOgren);
            Controls.Add(CezaSil);
            Controls.Add(CezaDüzenle);
            Controls.Add(button4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button CezaBilgisiOgren;
        private Button CezaSil;
        private Button CezaDüzenle;
        private Button button4;
    }
}