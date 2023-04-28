namespace SYNSCAN
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            progressBar1 = new ProgressBar();
            label8 = new Label();
            label9 = new Label();
            textBox5 = new TextBox();
            label10 = new Label();
            textBox6 = new TextBox();
            label11 = new Label();
            textBox7 = new TextBox();
            label12 = new Label();
            textBox8 = new TextBox();
            label13 = new Label();
            textBox9 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(192, 9);
            label1.Name = "label1";
            label1.Size = new Size(506, 54);
            label1.TabIndex = 0;
            label1.Text = "Kekma Backend Scanner";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.PaleTurquoise;
            label2.Location = new Point(12, 111);
            label2.Name = "label2";
            label2.Size = new Size(105, 37);
            label2.TabIndex = 1;
            label2.Text = "Target";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.PaleTurquoise;
            label3.Location = new Point(12, 156);
            label3.Name = "label3";
            label3.Size = new Size(127, 37);
            label3.TabIndex = 3;
            label3.Text = "Timeout";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(145, 163);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 23);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(276, 253);
            label4.Name = "label4";
            label4.Size = new Size(152, 37);
            label4.TabIndex = 6;
            label4.Text = "Addresses";
            label4.Click += label4_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ControlDark;
            textBox3.ForeColor = SystemColors.GradientInactiveCaption;
            textBox3.Location = new Point(256, 290);
            textBox3.MaxLength = 999999999;
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ScrollBars = ScrollBars.Both;
            textBox3.Size = new Size(223, 158);
            textBox3.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(274, 63);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 9;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.AppWorkspace;
            label6.Location = new Point(274, 63);
            label6.Name = "label6";
            label6.Size = new Size(282, 15);
            label6.TabIndex = 10;
            label6.Text = "~ Find Backend Address Behind a CDN with ease!!!!";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(33, 250);
            label7.Name = "label7";
            label7.Size = new Size(181, 37);
            label7.TabIndex = 11;
            label7.Text = "Found Hosts";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ControlDark;
            textBox4.ForeColor = SystemColors.InactiveCaption;
            textBox4.Location = new Point(12, 290);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ScrollBars = ScrollBars.Both;
            textBox4.Size = new Size(217, 158);
            textBox4.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSalmon;
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(541, 352);
            button1.Name = "button1";
            button1.Size = new Size(193, 52);
            button1.TabIndex = 8;
            button1.Text = "Scan";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(625, 120);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(163, 19);
            progressBar1.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonShadow;
            label8.Location = new Point(508, 111);
            label8.Name = "label8";
            label8.Size = new Size(99, 28);
            label8.TabIndex = 14;
            label8.Text = "Progress";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonShadow;
            label9.Location = new Point(508, 137);
            label9.Name = "label9";
            label9.Size = new Size(95, 28);
            label9.TabIndex = 15;
            label9.Text = "Scanned";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(625, 147);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(163, 23);
            textBox5.TabIndex = 16;
            textBox5.Text = "0";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonShadow;
            label10.Location = new Point(508, 165);
            label10.Name = "label10";
            label10.Size = new Size(85, 28);
            label10.TabIndex = 17;
            label10.Text = "Success";
            label10.Click += label10_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(625, 176);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(163, 23);
            textBox6.TabIndex = 18;
            textBox6.Text = "0";
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = Color.PaleTurquoise;
            label11.Location = new Point(12, 193);
            label11.Name = "label11";
            label11.Size = new Size(99, 37);
            label11.TabIndex = 19;
            label11.Text = "Regex";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(145, 207);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(191, 23);
            textBox7.TabIndex = 20;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonShadow;
            label12.Location = new Point(508, 199);
            label12.Name = "label12";
            label12.Size = new Size(63, 28);
            label12.TabIndex = 21;
            label12.Text = "Total";
            label12.Click += label12_Click;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(625, 208);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(163, 23);
            textBox8.TabIndex = 22;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ButtonShadow;
            label13.Location = new Point(508, 238);
            label13.Name = "label13";
            label13.Size = new Size(72, 28);
            label13.TabIndex = 23;
            label13.Text = "Errors";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(625, 243);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(163, 23);
            textBox9.TabIndex = 24;
            textBox9.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox9);
            Controls.Add(label13);
            Controls.Add(textBox8);
            Controls.Add(label12);
            Controls.Add(textBox7);
            Controls.Add(label11);
            Controls.Add(textBox6);
            Controls.Add(label10);
            Controls.Add(textBox5);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(progressBar1);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "For Educational Purpose Only,Trust!!! |  Discord : Terminal#0666 | Telegram : rateIimits";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox4;
        private Button button1;
        private ProgressBar progressBar1;
        private Label label8;
        private Label label9;
        private TextBox textBox5;
        private Label label10;
        private TextBox textBox6;
        private Label label11;
        private TextBox textBox7;
        private Label label12;
        private TextBox textBox8;
        private Label label13;
        private TextBox textBox9;
    }
}