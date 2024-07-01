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
            ptbPervious = new PictureBox();
            ptbNext = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptbPervious).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbNext).BeginInit();
            SuspendLayout();
            // 
            // FLPDayContainer
            // 
            FLPDayContainer.Location = new Point(6, 75);
            FLPDayContainer.Margin = new Padding(1);
            FLPDayContainer.Name = "FLPDayContainer";
            FLPDayContainer.Size = new Size(1277, 915);
            FLPDayContainer.TabIndex = 0;
            // 
            // LBEMonday
            // 
            LBEMonday.AutoSize = true;
            LBEMonday.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBEMonday.Location = new Point(232, 51);
            LBEMonday.Name = "LBEMonday";
            LBEMonday.Size = new Size(75, 22);
            LBEMonday.TabIndex = 2;
            LBEMonday.Text = "Monday";
            // 
            // LBLSunday
            // 
            LBLSunday.AutoSize = true;
            LBLSunday.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBLSunday.Location = new Point(58, 51);
            LBLSunday.Name = "LBLSunday";
            LBLSunday.Size = new Size(70, 22);
            LBLSunday.TabIndex = 3;
            LBLSunday.Text = "Sunday";
            // 
            // LBLSaturday
            // 
            LBLSaturday.AutoSize = true;
            LBLSaturday.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBLSaturday.Location = new Point(1132, 51);
            LBLSaturday.Name = "LBLSaturday";
            LBLSaturday.Size = new Size(82, 22);
            LBLSaturday.TabIndex = 4;
            LBLSaturday.Text = "Saturday";
            // 
            // LBLFriday
            // 
            LBLFriday.AutoSize = true;
            LBLFriday.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBLFriday.Location = new Point(957, 51);
            LBLFriday.Name = "LBLFriday";
            LBLFriday.Size = new Size(64, 22);
            LBLFriday.TabIndex = 5;
            LBLFriday.Text = "Friday";
            // 
            // LBLThursday
            // 
            LBLThursday.AutoSize = true;
            LBLThursday.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBLThursday.Location = new Point(772, 52);
            LBLThursday.Name = "LBLThursday";
            LBLThursday.Size = new Size(86, 22);
            LBLThursday.TabIndex = 6;
            LBLThursday.Text = "Thursday";
            // 
            // LBLWednesday
            // 
            LBLWednesday.AutoSize = true;
            LBLWednesday.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBLWednesday.Location = new Point(582, 51);
            LBLWednesday.Name = "LBLWednesday";
            LBLWednesday.Size = new Size(101, 22);
            LBLWednesday.TabIndex = 7;
            LBLWednesday.Text = "Wednesday";
            // 
            // LBETuesday
            // 
            LBETuesday.AutoSize = true;
            LBETuesday.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBETuesday.Location = new Point(411, 51);
            LBETuesday.Name = "LBETuesday";
            LBETuesday.Size = new Size(75, 22);
            LBETuesday.TabIndex = 8;
            LBETuesday.Text = "Tuesday";
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Font = new Font("Modern No. 20", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMonth.Location = new Point(28, 9);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(95, 31);
            lblMonth.TabIndex = 9;
            lblMonth.Text = "Month";
            // 
            // ptbPervious
            // 
            ptbPervious.Image = (Image)resources.GetObject("ptbPervious.Image");
            ptbPervious.Location = new Point(286, 9);
            ptbPervious.Name = "ptbPervious";
            ptbPervious.Size = new Size(41, 31);
            ptbPervious.SizeMode = PictureBoxSizeMode.Zoom;
            ptbPervious.TabIndex = 10;
            ptbPervious.TabStop = false;
            ptbPervious.Click += ptbPervious_Click;
            // 
            // ptbNext
            // 
            ptbNext.Image = (Image)resources.GetObject("ptbNext.Image");
            ptbNext.Location = new Point(333, 9);
            ptbNext.Name = "ptbNext";
            ptbNext.Size = new Size(41, 31);
            ptbNext.SizeMode = PictureBoxSizeMode.Zoom;
            ptbNext.TabIndex = 11;
            ptbNext.TabStop = false;
            ptbNext.Click += ptbNext_Click;
            // 
            // Calnedar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1301, 1004);
            Controls.Add(ptbNext);
            Controls.Add(ptbPervious);
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
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ptbPervious).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbNext).EndInit();
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
        private PictureBox ptbPervious;
        private PictureBox ptbNext;
    }
}
