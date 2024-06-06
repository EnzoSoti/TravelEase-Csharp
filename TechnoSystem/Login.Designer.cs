namespace TechnoSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            button1 = new Button();
            checkBox1 = new CheckBox();
            passTextBox = new TextBox();
            PasswordTextBox = new Label();
            usernameTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(passTextBox);
            panel1.Controls.Add(PasswordTextBox);
            panel1.Controls.Add(usernameTextBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(828, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1097, 1062);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(78, 76, 126);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(350, 715);
            button1.Name = "button1";
            button1.Size = new Size(317, 87);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = SystemColors.Window;
            checkBox1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = SystemColors.ScrollBar;
            checkBox1.Location = new Point(460, 588);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(286, 43);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Show password";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // passTextBox
            // 
            passTextBox.BackColor = SystemColors.ScrollBar;
            passTextBox.BorderStyle = BorderStyle.None;
            passTextBox.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passTextBox.Location = new Point(233, 531);
            passTextBox.Name = "passTextBox";
            passTextBox.Size = new Size(665, 39);
            passTextBox.TabIndex = 4;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.AutoSize = true;
            PasswordTextBox.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordTextBox.Location = new Point(233, 465);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(207, 45);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.Text = "Username";
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = SystemColors.ScrollBar;
            usernameTextBox.BorderStyle = BorderStyle.None;
            usernameTextBox.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameTextBox.Location = new Point(233, 385);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(665, 39);
            usernameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(233, 328);
            label3.Name = "label3";
            label3.Size = new Size(207, 45);
            label3.TabIndex = 1;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(114, 120);
            label2.Name = "label2";
            label2.Size = new Size(265, 77);
            label2.TabIndex = 0;
            label2.Text = "Sign In";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(54, 48, 98);
            panel2.Location = new Point(828, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(18, 1060);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(249, 148, 23);
            panel3.Location = new Point(843, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(19, 1063);
            panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.TravelEASE;
            pictureBox1.Location = new Point(134, 208);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(582, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(182, 356);
            label1.Name = "label1";
            label1.Size = new Size(480, 42);
            label1.TabIndex = 2;
            label1.Text = "Makes traveling seamless.";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(78, 76, 126);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1924, 1061);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private TextBox usernameTextBox;
        private Label label3;
        private Label label2;
        private CheckBox checkBox1;
        private TextBox passTextBox;
        private Label PasswordTextBox;
        private Button button1;
    }
}