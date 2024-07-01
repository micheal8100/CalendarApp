namespace CalendarApp
{
    partial class UC_Day
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Panel = new Panel();
            lblEventHolder = new Label();
            lblDays = new Label();
            tmeCheck = new System.Windows.Forms.Timer(components);
            Panel.SuspendLayout();
            SuspendLayout();
            // 
            // Panel
            // 
            Panel.BackColor = Color.White;
            Panel.BorderStyle = BorderStyle.FixedSingle;
            Panel.Controls.Add(lblEventHolder);
            Panel.Controls.Add(lblDays);
            Panel.Dock = DockStyle.Fill;
            Panel.Location = new Point(1, 1);
            Panel.Name = "Panel";
            Panel.Size = new Size(171, 140);
            Panel.TabIndex = 0;
            Panel.Click += UC_DaysClick;
            // 
            // lblEventHolder
            // 
            lblEventHolder.Location = new Point(2, 57);
            lblEventHolder.Name = "lblEventHolder";
            lblEventHolder.Size = new Size(164, 81);
            lblEventHolder.TabIndex = 1;
            lblEventHolder.TextAlign = ContentAlignment.MiddleCenter;
            lblEventHolder.Click += UC_DaysClick;
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Font = new Font("Modern No. 20", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDays.Location = new Point(132, 16);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(26, 21);
            lblDays.TabIndex = 0;
            lblDays.Text = "00";
            // 
            // tmeCheck
            // 
            tmeCheck.Tick += timCheck_tick;
            // 
            // UC_Day
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Panel);
            Name = "UC_Day";
            Padding = new Padding(1);
            Size = new Size(173, 142);
            Load += UC_Load_1;
            Panel.ResumeLayout(false);
            Panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel;
        private Label lblDays;
        private Label lblEventHolder;
        private System.Windows.Forms.Timer tmeCheck;
    }
}
