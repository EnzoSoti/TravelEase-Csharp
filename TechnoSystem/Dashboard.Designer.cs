namespace TechnoSystem
{
    partial class Dashboard
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
            panel3 = new Panel();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            panel4 = new Panel();
            panel7 = new Panel();
            label6 = new Label();
            panel6 = new Panel();
            label5 = new Label();
            panel5 = new Panel();
            label4 = new Label();
            label3 = new Label();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(cartesianChart1);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(pieChart1);
            panel3.Location = new Point(428, 44);
            panel3.Name = "panel3";
            panel3.Size = new Size(1459, 967);
            panel3.TabIndex = 1;
            // 
            // cartesianChart1
            // 
            cartesianChart1.BackColor = Color.FromArgb(78, 76, 126);
            cartesianChart1.BackgroundImageLayout = ImageLayout.None;
            cartesianChart1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cartesianChart1.ForeColor = Color.White;
            cartesianChart1.Location = new Point(42, 470);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(1342, 449);
            cartesianChart1.TabIndex = 2;
            cartesianChart1.Load += cartesianChart1_Load;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(78, 76, 126);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(42, 41);
            panel4.Name = "panel4";
            panel4.Size = new Size(797, 394);
            panel4.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(249, 148, 23);
            panel7.Controls.Add(label6);
            panel7.Location = new Point(495, 26);
            panel7.Name = "panel7";
            panel7.Size = new Size(264, 72);
            panel7.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(32, 19);
            label6.Name = "label6";
            label6.Size = new Size(185, 35);
            label6.TabIndex = 2;
            label6.Text = "Total Sales:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(249, 148, 23);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(34, 26);
            panel6.Name = "panel6";
            panel6.Size = new Size(264, 72);
            panel6.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(26, 19);
            label5.Name = "label5";
            label5.Size = new Size(211, 35);
            label5.TabIndex = 2;
            label5.Text = "Total Counts:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(34, 130);
            panel5.Name = "panel5";
            panel5.Size = new Size(725, 231);
            panel5.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(450, 73);
            label4.Name = "label4";
            label4.Size = new Size(228, 77);
            label4.TabIndex = 1;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 73);
            label3.Name = "label3";
            label3.Size = new Size(228, 77);
            label3.TabIndex = 0;
            label3.Text = "label3";
            // 
            // pieChart1
            // 
            pieChart1.BackColor = Color.FromArgb(78, 76, 126);
            pieChart1.InitialRotation = 0D;
            pieChart1.IsClockwise = true;
            pieChart1.Location = new Point(880, 41);
            pieChart1.MaxAngle = 360D;
            pieChart1.MaxValue = null;
            pieChart1.MinValue = 0D;
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(504, 394);
            pieChart1.TabIndex = 0;
            pieChart1.Total = null;
            pieChart1.Load += pieChart1_Load;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1061);
            Controls.Add(panel3);
            Name = "Dashboard";
            Text = "Dashboard";
            Controls.SetChildIndex(panel3, 0);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private Panel panel4;
        private Panel panel6;
        private Panel panel5;
        private Label label3;
        private Label label5;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private Label label4;
        private Panel panel7;
        private Label label6;
    }
}