namespace travel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            button4 = new Button();
            textBox1 = new TextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            textBox3 = new TextBox();
            maskedTextBox4 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            textBox2 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            listBox1 = new ListBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
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
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(59, 231);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(500, 395);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Marşrut";
            // 
            // button4
            // 
            button4.Location = new Point(385, 63);
            button4.Name = "button4";
            button4.Size = new Size(53, 103);
            button4.TabIndex = 10;
            button4.Text = "< >";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 307);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 31);
            textBox1.TabIndex = 9;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(123, 254);
            maskedTextBox2.Mask = "00:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(224, 31);
            maskedTextBox2.TabIndex = 8;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(123, 193);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(224, 31);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Moskova", "Polsa", "Italiya" });
            comboBox2.Location = new Point(123, 128);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(224, 33);
            comboBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Baki", "Istanbul", "Ankara", "Praga", "Berlin" });
            comboBox1.Location = new Point(122, 62);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(225, 33);
            comboBox1.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(57, 307);
            label6.Name = "label6";
            label6.Size = new Size(47, 22);
            label6.TabIndex = 4;
            label6.Text = "Yer:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(45, 254);
            label5.Name = "label5";
            label5.Size = new Size(59, 22);
            label5.TabIndex = 3;
            label5.Text = "Saat:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 193);
            label4.Name = "label4";
            label4.Size = new Size(62, 22);
            label4.TabIndex = 2;
            label4.Text = "Tarix:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 128);
            label3.Name = "label3";
            label3.Size = new Size(84, 22);
            label3.TabIndex = 1;
            label3.Text = "Haraya:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 62);
            label2.Name = "label2";
            label2.Size = new Size(95, 22);
            label2.TabIndex = 0;
            label2.Text = "Haradan:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(maskedTextBox4);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(706, 231);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(467, 395);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sərnişin məlumatlari";
            // 
            // button1
            // 
            button1.BackColor = Color.Violet;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(235, 336);
            button1.Name = "button1";
            button1.Size = new Size(127, 38);
            button1.TabIndex = 8;
            button1.Text = "Bileti al";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(187, 284);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(202, 31);
            textBox3.TabIndex = 7;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(192, 214);
            maskedTextBox4.Mask = "(+999) 00-000-00-00";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(197, 31);
            maskedTextBox4.TabIndex = 6;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(187, 147);
            maskedTextBox3.Mask = "0000000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(206, 31);
            maskedTextBox3.TabIndex = 5;
            maskedTextBox3.ValidatingType = typeof(int);
            // 
            // textBox2
            // 
            textBox2.Location = new Point(187, 73);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(202, 31);
            textBox2.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(92, 284);
            label10.Name = "label10";
            label10.Size = new Size(68, 22);
            label10.TabIndex = 3;
            label10.Text = "Email:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(78, 219);
            label9.Name = "label9";
            label9.Size = new Size(82, 22);
            label9.TabIndex = 2;
            label9.Text = "Telefon:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(51, 152);
            label8.Name = "label8";
            label8.Size = new Size(109, 22);
            label8.TabIndex = 1;
            label8.Text = "ŞV / Seria:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(41, 78);
            label7.Name = "label7";
            label7.Size = new Size(131, 22);
            label7.TabIndex = 0;
            label7.Text = "Ad və Soyad:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(59, 645);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1123, 129);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Plum;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(33, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1160, 185);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(47, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(435, 56);
            label1.Name = "label1";
            label1.Size = new Size(184, 38);
            label1.TabIndex = 0;
            label1.Text = "Aytac Travel";
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(101, 797);
            button2.Name = "button2";
            button2.Size = new Size(127, 38);
            button2.TabIndex = 9;
            button2.Text = "Siyahini sil";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SpringGreen;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(909, 797);
            button3.Name = "button3";
            button3.Size = new Size(190, 38);
            button3.TabIndex = 10;
            button3.Text = "Programdan çixiş";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepPink;
            ClientSize = new Size(1205, 847);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListBox listBox1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label6;
        private MaskedTextBox maskedTextBox3;
        private TextBox textBox2;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox textBox3;
        private MaskedTextBox maskedTextBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
