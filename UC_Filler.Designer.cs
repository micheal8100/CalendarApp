namespace CalendarApp
{
    partial class UC_Filler
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
            panFiller = new Panel();
            SuspendLayout();
            // 
            // panFiller
            // 
            panFiller.BorderStyle = BorderStyle.FixedSingle;
            panFiller.Dock = DockStyle.Fill;
            panFiller.Location = new Point(0, 0);
            panFiller.Name = "panFiller";
            panFiller.Padding = new Padding(1);
            panFiller.Size = new Size(173, 142);
            panFiller.TabIndex = 0;
            // 
            // UC_Filler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panFiller);
            Name = "UC_Filler";
            Size = new Size(173, 142);
            ResumeLayout(false);
        }

        #endregion

        private Panel panFiller;
    }
}
