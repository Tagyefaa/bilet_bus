namespace tapsiriq_3
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            maskedTextBox3 = new MaskedTextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            listBox1 = new ListBox();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(902, 146);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.BEU_logo;
            pictureBox1.Location = new Point(12, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(424, 73);
            label1.Name = "label1";
            label1.Size = new Size(181, 38);
            label1.TabIndex = 1;
            label1.Text = "BMU Travel";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bus;
            pictureBox2.Location = new Point(749, 49);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 162);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(490, 299);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Travel information";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 36);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 0;
            label2.Text = "Haradan:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 88);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 1;
            label3.Text = "Haraya:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 141);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 2;
            label4.Text = "Tarix:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 199);
            label5.Name = "label5";
            label5.Size = new Size(56, 25);
            label5.TabIndex = 3;
            label5.Text = "Saat:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 245);
            label6.Name = "label6";
            label6.Size = new Size(44, 25);
            label6.TabIndex = 4;
            label6.Text = "Yer:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(118, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 33);
            comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(118, 88);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(213, 33);
            comboBox2.TabIndex = 6;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(118, 138);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(213, 31);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(118, 193);
            maskedTextBox2.Mask = "00:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(213, 31);
            maskedTextBox2.TabIndex = 8;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(118, 245);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 31);
            textBox1.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(524, 162);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(362, 299);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Person information";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(143, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(213, 31);
            textBox2.TabIndex = 9;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(143, 193);
            maskedTextBox3.Mask = "(994) 00 000 00 00";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(213, 31);
            maskedTextBox3.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 199);
            label8.Name = "label8";
            label8.Size = new Size(80, 25);
            label8.TabIndex = 3;
            label8.Text = "Telefon:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 141);
            label9.Name = "label9";
            label9.Size = new Size(66, 25);
            label9.TabIndex = 2;
            label9.Text = "Email:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 88);
            label10.Name = "label10";
            label10.Size = new Size(46, 25);
            label10.TabIndex = 1;
            label10.Text = "FIN:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(19, 36);
            label11.Name = "label11";
            label11.Size = new Size(122, 25);
            label11.TabIndex = 0;
            label11.Text = "Ad ve Soyad:";
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(374, 33);
            button1.Name = "button1";
            button1.Size = new Size(94, 107);
            button1.TabIndex = 11;
            button1.Text = "<\r\n>";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(143, 36);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(213, 31);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(143, 135);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(213, 31);
            textBox4.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(218, 237);
            button2.Name = "button2";
            button2.Size = new Size(138, 46);
            button2.TabIndex = 12;
            button2.Text = "Bilet al";
            button2.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 477);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(874, 104);
            listBox1.TabIndex = 13;
            // 
            // button3
            // 
            button3.BackColor = Color.LightCoral;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(18, 587);
            button3.Name = "button3";
            button3.Size = new Size(173, 45);
            button3.TabIndex = 14;
            button3.Text = "Bileti sil";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightCoral;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(707, 587);
            button4.Name = "button4";
            button4.Size = new Size(173, 45);
            button4.TabIndex = 15;
            button4.Text = "Proqram cix";
            button4.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(898, 644);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private MaskedTextBox maskedTextBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox2;
        private Button button1;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private MaskedTextBox maskedTextBox3;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox4;
        private TextBox textBox3;
        private Button button2;
        private ListBox listBox1;
        private Button button3;
        private Button button4;
    }
}
