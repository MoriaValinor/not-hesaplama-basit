namespace Not_hesaplama
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.CharacterCasing = CharacterCasing.Upper;
            textBox1.Location = new Point(169, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(331, 23);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.CharacterCasing = CharacterCasing.Upper;
            textBox2.Location = new Point(169, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(331, 23);
            textBox2.TabIndex = 1;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(169, 80);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(106, 23);
            textBox3.TabIndex = 2;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(169, 109);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(106, 23);
            textBox4.TabIndex = 3;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(169, 138);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(106, 23);
            textBox5.TabIndex = 4;
            textBox5.KeyPress += textBox5_KeyPress;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(280, 78);
            button1.Name = "button1";
            button1.Size = new Size(220, 85);
            button1.TabIndex = 5;
            button1.Text = "HESAPLA VE GÖSTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 24);
            label1.Name = "label1";
            label1.Size = new Size(112, 16);
            label1.TabIndex = 6;
            label1.Text = "ÖĞRENCİ ADI :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(20, 48);
            label2.Name = "label2";
            label2.Size = new Size(143, 16);
            label2.TabIndex = 7;
            label2.Text = "ÖĞRENCİ SOYADI :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(68, 77);
            label3.Name = "label3";
            label3.Size = new Size(95, 16);
            label3.TabIndex = 8;
            label3.Text = "VİZE NOTU :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(106, 106);
            label4.Name = "label4";
            label4.Size = new Size(57, 16);
            label4.TabIndex = 9;
            label4.Text = "FİNAL :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(59, 135);
            label5.Name = "label5";
            label5.Size = new Size(104, 16);
            label5.TabIndex = 10;
            label5.Text = "ÖDEV NOTU :";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(582, 195);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}