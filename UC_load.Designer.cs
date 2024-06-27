namespace CalendarApp
{
    partial class UC_load
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
            Panel = new Panel();
            chb = new CheckBox();
            lblDays = new Label();
            Panel.SuspendLayout();
            SuspendLayout();
            // 
            // Panel
            // 
            Panel.BackColor = Color.White;
            Panel.Controls.Add(chb);
            Panel.Controls.Add(lblDays);
            Panel.Dock = DockStyle.Fill;
            Panel.Location = new Point(1, 1);
            Panel.Name = "Panel";
            Panel.Size = new Size(171, 140);
            Panel.TabIndex = 0;
            // 
            // chb
            // 
            chb.AutoSize = true;
            chb.Location = new Point(12, 20);
            chb.Name = "chb";
            chb.Size = new Size(18, 17);
            chb.TabIndex = 1;
            chb.UseVisualStyleBackColor = true;
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
            // UC_load
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Panel);
            Name = "UC_load";
            Padding = new Padding(1);
            Size = new Size(173, 142);
            Load += this.UC_Load_1;
            Panel.ResumeLayout(false);
            Panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel;
        private Label lblDays;
        private CheckBox chb;
    }
}
