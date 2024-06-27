namespace CalendarApp
{
    partial class Calnedar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calnedar));
            FLPDayContainer = new FlowLayoutPanel();
            LBEMonday = new Label();
            LBLSunday = new Label();
            LBLSaturday = new Label();
            LBLFriday = new Label();
            LBLThursday = new Label();
            LBLWednesday = new Label();
            LBETuesday = new Label();
            lblMonth = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // FLPDayContainer
            // 
            FLPDayContainer.Location = new Point(12, 145);
            FLPDayContainer.Margin = new Padding(1);
            FLPDayContainer.Name = "FLPDayContainer";
            FLPDayContainer.Size = new Size(1230, 734);
            FLPDayContainer.TabIndex = 0;
            // 
            // LBEMonday
            // 
            LBEMonday.AutoSize = true;
            LBEMonday.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBEMonday.Location = new Point(55, 122);
            LBEMonday.Name = "LBEMonday";
            LBEMonday.Size = new Size(75, 22);
            LBEMonday.TabIndex = 2;
            LBEMonday.Text = "Monday";
            // 
            // LBLSunday
            // 
            LBLSunday.AutoSize = true;
            LBLSunday.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBLSunday.Location = new Point(1125, 122);
            LBLSunday.Name = "LBLSunday";
            LBLSunday.Size = new Size(70, 22);
            LBLSunday.TabIndex = 3;
            LBLSunday.Text = "Sunday";
            // 
            // LBLSaturday
            // 
            LBLSaturday.AutoSize = true;
            LBLSaturday.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBLSaturday.Location = new Point(933, 123);
            LBLSaturday.Name = "LBLSaturday";
            LBLSaturday.Size = new Size(82, 22);
            LBLSaturday.TabIndex = 4;
            LBLSaturday.Text = "Saturday";
            // 
            // LBLFriday
            // 
            LBLFriday.AutoSize = true;
            LBLFriday.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBLFriday.Location = new Point(777, 122);
            LBLFriday.Name = "LBLFriday";
            LBLFriday.Size = new Size(64, 22);
            LBLFriday.TabIndex = 5;
            LBLFriday.Text = "Friday";
            // 
            // LBLThursday
            // 
            LBLThursday.AutoSize = true;
            LBLThursday.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBLThursday.Location = new Point(583, 122);
            LBLThursday.Name = "LBLThursday";
            LBLThursday.Size = new Size(86, 22);
            LBLThursday.TabIndex = 6;
            LBLThursday.Text = "Thursday";
            // 
            // LBLWednesday
            // 
            LBLWednesday.AutoSize = true;
            LBLWednesday.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBLWednesday.Location = new Point(396, 123);
            LBLWednesday.Name = "LBLWednesday";
            LBLWednesday.Size = new Size(101, 22);
            LBLWednesday.TabIndex = 7;
            LBLWednesday.Text = "Wednesday";
            // 
            // LBETuesday
            // 
            LBETuesday.AutoSize = true;
            LBETuesday.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBETuesday.Location = new Point(235, 123);
            LBETuesday.Name = "LBETuesday";
            LBETuesday.Size = new Size(75, 22);
            LBETuesday.TabIndex = 8;
            LBETuesday.Text = "Tuesday";
            // 
            // lblMonth
            // 
            lblMonth.Font = new Font("Modern No. 20", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMonth.Location = new Point(55, 55);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(188, 41);
            lblMonth.TabIndex = 9;
            lblMonth.Text = "Month";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(202, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(249, 55);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // Calnedar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1254, 891);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblMonth);
            Controls.Add(LBETuesday);
            Controls.Add(LBLWednesday);
            Controls.Add(LBLThursday);
            Controls.Add(LBLFriday);
            Controls.Add(LBLSaturday);
            Controls.Add(LBLSunday);
            Controls.Add(LBEMonday);
            Controls.Add(FLPDayContainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Calnedar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel FLPDayContainer;
        private Label LBEMonday;
        private Label LBLSunday;
        private Label LBLSaturday;
        private Label LBLFriday;
        private Label LBLThursday;
        private Label LBLWednesday;
        private Label LBETuesday;
        private Label lblMonth;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
