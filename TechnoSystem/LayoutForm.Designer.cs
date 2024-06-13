namespace TechnoSystem
{
    partial class LayoutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LayoutForm));
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            picBoxCircle1 = new PicBoxCircle();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxCircle1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(78, 76, 126);
            panel1.Controls.Add(picBoxCircle1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 1061);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(41, 720);
            button4.Name = "button4";
            button4.Size = new Size(297, 51);
            button4.TabIndex = 7;
            button4.Text = "History";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Image = Properties.Resources.power_button_sign;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(41, 938);
            button3.Name = "button3";
            button3.Size = new Size(297, 51);
            button3.TabIndex = 6;
            button3.Text = "Logout";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(41, 641);
            button2.Name = "button2";
            button2.Size = new Size(297, 51);
            button2.TabIndex = 5;
            button2.Text = "ID Card";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.home__2_1;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(41, 565);
            button1.Name = "button1";
            button1.Size = new Size(297, 51);
            button1.TabIndex = 4;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(249, 148, 23);
            label2.Location = new Point(130, 471);
            label2.Name = "label2";
            label2.Size = new Size(120, 39);
            label2.TabIndex = 3;
            label2.Text = "Admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(79, 432);
            label1.Name = "label1";
            label1.Size = new Size(220, 39);
            label1.TabIndex = 2;
            label1.Text = "Kyan Villarin";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.TravelEASE;
            pictureBox1.Location = new Point(24, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(343, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // picBoxCircle1
            // 
            picBoxCircle1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            picBoxCircle1.BorderColor = Color.RoyalBlue;
            picBoxCircle1.BorderColor2 = Color.HotPink;
            picBoxCircle1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            picBoxCircle1.BorderSize = 3;
            picBoxCircle1.GradientAngle = 50F;
            picBoxCircle1.Image = Properties.Resources.temp_removebg_preview;
            picBoxCircle1.Location = new Point(55, 162);
            picBoxCircle1.Name = "picBoxCircle1";
            picBoxCircle1.Size = new Size(283, 249);
            picBoxCircle1.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxCircle1.TabIndex = 8;
            picBoxCircle1.TabStop = false;
            // 
            // LayoutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 48, 98);
            ClientSize = new Size(1924, 1061);
            Controls.Add(panel1);
            Name = "LayoutForm";
            Text = "LayoutForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxCircle1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button4;
        private PicBoxCircle picBoxCircle1;
    }
}