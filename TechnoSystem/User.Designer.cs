namespace TechnoSystem
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            panel1 = new Panel();
            label16 = new Label();
            label15 = new Label();
            txtTravelCash = new Label();
            picBoxCircle1 = new PicBoxCircle();
            label1 = new Label();
            button1 = new Button();
            txtCategory = new Label();
            pictureBox1 = new PictureBox();
            txtUsername = new Label();
            txtFirstName = new Label();
            txtLastName = new Label();
            label3 = new Label();
            txtAddress = new Label();
            txtGender = new Label();
            txtEmail = new Label();
            txtRegisterDate = new Label();
            txtCardID = new Label();
            txtMobileNumber = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxCircle1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 48, 98);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(txtTravelCash);
            panel1.Controls.Add(picBoxCircle1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtCategory);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtUsername);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(723, 941);
            panel1.TabIndex = 0;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Tahoma", 21.75F, FontStyle.Bold);
            label16.ForeColor = Color.White;
            label16.Location = new Point(119, 748);
            label16.Name = "label16";
            label16.Size = new Size(157, 35);
            label16.TabIndex = 22;
            label16.Text = "Category:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 21.75F, FontStyle.Bold);
            label15.ForeColor = Color.White;
            label15.Location = new Point(119, 614);
            label15.Name = "label15";
            label15.Size = new Size(173, 35);
            label15.TabIndex = 21;
            label15.Text = "Username:";
            // 
            // txtTravelCash
            // 
            txtTravelCash.AutoSize = true;
            txtTravelCash.Font = new Font("Tahoma", 21.75F, FontStyle.Bold);
            txtTravelCash.ForeColor = Color.White;
            txtTravelCash.Location = new Point(394, 683);
            txtTravelCash.Name = "txtTravelCash";
            txtTravelCash.Size = new Size(196, 35);
            txtTravelCash.TabIndex = 1;
            txtTravelCash.Text = "Travel Cash:";
            txtTravelCash.Click += label2_Click;
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
            picBoxCircle1.Location = new Point(196, 281);
            picBoxCircle1.Name = "picBoxCircle1";
            picBoxCircle1.Size = new Size(301, 278);
            picBoxCircle1.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxCircle1.TabIndex = 2;
            picBoxCircle1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 21.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(119, 683);
            label1.Name = "label1";
            label1.Size = new Size(196, 35);
            label1.TabIndex = 0;
            label1.Text = "Travel Cash:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(54, 48, 98);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(22, 840);
            button1.Name = "button1";
            button1.Size = new Size(67, 84);
            button1.TabIndex = 20;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtCategory
            // 
            txtCategory.AutoSize = true;
            txtCategory.Font = new Font("Tahoma", 21.75F, FontStyle.Bold);
            txtCategory.ForeColor = Color.White;
            txtCategory.Location = new Point(394, 747);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(157, 35);
            txtCategory.TabIndex = 19;
            txtCategory.Text = "Category:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.TravelEASE;
            pictureBox1.Location = new Point(119, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(471, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.AutoSize = true;
            txtUsername.Font = new Font("Tahoma", 21.75F, FontStyle.Bold);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(394, 614);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(173, 35);
            txtUsername.TabIndex = 14;
            txtUsername.Text = "Username:";
            // 
            // txtFirstName
            // 
            txtFirstName.AutoSize = true;
            txtFirstName.Font = new Font("Tahoma", 21.75F, FontStyle.Bold);
            txtFirstName.ForeColor = SystemColors.ActiveBorder;
            txtFirstName.Location = new Point(871, 240);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(185, 35);
            txtFirstName.TabIndex = 12;
            txtFirstName.Text = "First Name:";
            // 
            // txtLastName
            // 
            txtLastName.AutoSize = true;
            txtLastName.Font = new Font("Tahoma", 21.75F, FontStyle.Bold);
            txtLastName.ForeColor = SystemColors.ActiveBorder;
            txtLastName.Location = new Point(1230, 240);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(177, 35);
            txtLastName.TabIndex = 13;
            txtLastName.Text = "Last name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(845, 51);
            label3.Name = "label3";
            label3.Size = new Size(428, 45);
            label3.TabIndex = 1;
            label3.Text = " Personal Information";
            // 
            // txtAddress
            // 
            txtAddress.AutoSize = true;
            txtAddress.Font = new Font("Tahoma", 21.75F, FontStyle.Bold);
            txtAddress.ForeColor = SystemColors.AppWorkspace;
            txtAddress.Location = new Point(871, 636);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(142, 35);
            txtAddress.TabIndex = 18;
            txtAddress.Text = "Address:";
            // 
            // txtGender
            // 
            txtGender.AutoSize = true;
            txtGender.Font = new Font("Tahoma", 21.75F, FontStyle.Bold);
            txtGender.ForeColor = SystemColors.AppWorkspace;
            txtGender.Location = new Point(871, 782);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(132, 35);
            txtGender.TabIndex = 17;
            txtGender.Text = "Gender:";
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.Font = new Font("Tahoma", 21.75F, FontStyle.Bold);
            txtEmail.ForeColor = SystemColors.AppWorkspace;
            txtEmail.Location = new Point(1230, 371);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(107, 35);
            txtEmail.TabIndex = 16;
            txtEmail.Text = "Email:";
            // 
            // txtRegisterDate
            // 
            txtRegisterDate.AutoSize = true;
            txtRegisterDate.Font = new Font("Tahoma", 21.75F, FontStyle.Bold);
            txtRegisterDate.ForeColor = SystemColors.AppWorkspace;
            txtRegisterDate.Location = new Point(1230, 794);
            txtRegisterDate.Name = "txtRegisterDate";
            txtRegisterDate.Size = new Size(225, 35);
            txtRegisterDate.TabIndex = 15;
            txtRegisterDate.Text = "Register Date:";
            // 
            // txtCardID
            // 
            txtCardID.AutoSize = true;
            txtCardID.Font = new Font("Tahoma", 21.75F, FontStyle.Bold);
            txtCardID.ForeColor = SystemColors.AppWorkspace;
            txtCardID.Location = new Point(871, 371);
            txtCardID.Name = "txtCardID";
            txtCardID.Size = new Size(138, 35);
            txtCardID.TabIndex = 11;
            txtCardID.Text = "Card ID:";
            // 
            // txtMobileNumber
            // 
            txtMobileNumber.AutoSize = true;
            txtMobileNumber.Font = new Font("Tahoma", 21.75F, FontStyle.Bold);
            txtMobileNumber.ForeColor = SystemColors.AppWorkspace;
            txtMobileNumber.Location = new Point(1230, 632);
            txtMobileNumber.Name = "txtMobileNumber";
            txtMobileNumber.Size = new Size(249, 35);
            txtMobileNumber.TabIndex = 23;
            txtMobileNumber.Text = "Mobile Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 21.75F, FontStyle.Bold);
            label4.Location = new Point(871, 317);
            label4.Name = "label4";
            label4.Size = new Size(138, 35);
            label4.TabIndex = 24;
            label4.Text = "Card ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(845, 96);
            label5.Name = "label5";
            label5.Size = new Size(663, 35);
            label5.TabIndex = 25;
            label5.Text = "____________________________________";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 21.75F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(871, 181);
            label6.Name = "label6";
            label6.Size = new Size(185, 35);
            label6.TabIndex = 26;
            label6.Text = "First Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 21.75F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(1230, 181);
            label7.Name = "label7";
            label7.Size = new Size(177, 35);
            label7.TabIndex = 27;
            label7.Text = "Last name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(845, 451);
            label8.Name = "label8";
            label8.Size = new Size(663, 35);
            label8.TabIndex = 28;
            label8.Text = "____________________________________";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 21.75F, FontStyle.Bold);
            label9.Location = new Point(1230, 317);
            label9.Name = "label9";
            label9.Size = new Size(107, 35);
            label9.TabIndex = 29;
            label9.Text = "Email:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(845, 511);
            label10.Name = "label10";
            label10.Size = new Size(372, 45);
            label10.TabIndex = 30;
            label10.Text = " Other Information";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 21.75F, FontStyle.Bold);
            label11.Location = new Point(867, 588);
            label11.Name = "label11";
            label11.Size = new Size(142, 35);
            label11.TabIndex = 31;
            label11.Text = "Address:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 21.75F, FontStyle.Bold);
            label12.Location = new Point(1230, 588);
            label12.Name = "label12";
            label12.Size = new Size(249, 35);
            label12.TabIndex = 32;
            label12.Text = "Mobile Number:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 21.75F, FontStyle.Bold);
            label13.Location = new Point(871, 723);
            label13.Name = "label13";
            label13.Size = new Size(132, 35);
            label13.TabIndex = 33;
            label13.Text = "Gender:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 21.75F, FontStyle.Bold);
            label14.Location = new Point(1230, 747);
            label14.Name = "label14";
            label14.Size = new Size(225, 35);
            label14.TabIndex = 34;
            label14.Text = "Register Date:";
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1616, 936);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtMobileNumber);
            Controls.Add(txtAddress);
            Controls.Add(txtGender);
            Controls.Add(txtFirstName);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtRegisterDate);
            Controls.Add(txtCardID);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxCircle1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PicBoxCircle picBoxCircle1;
        private Label txtTravelCash;
        private Label label3;
        private Label txtCategory;
        private Label txtAddress;
        private Label txtGender;
        private Label txtEmail;
        private Label txtRegisterDate;
        private Label txtUsername;
        private Label txtLastName;
        private Label txtFirstName;
        private Label txtCardID;
        private Button button1;
        private Label txtMobileNumber;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label16;
        private Label label15;
    }
}