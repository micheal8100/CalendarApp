namespace CalendarApp
{
    partial class EventForm
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
            txbDate = new TextBox();
            txbEvent = new TextBox();
            lblDate = new Label();
            butSave = new Button();
            lblEvent = new Label();
            SuspendLayout();
            // 
            // txbDate
            // 
            txbDate.Enabled = false;
            txbDate.Font = new Font("Modern No. 20", 12F);
            txbDate.Location = new Point(38, 62);
            txbDate.Name = "txbDate";
            txbDate.Size = new Size(338, 29);
            txbDate.TabIndex = 0;
            // 
            // txbEvent
            // 
            txbEvent.Font = new Font("Modern No. 20", 12F);
            txbEvent.Location = new Point(38, 126);
            txbEvent.MaxLength = 200;
            txbEvent.Name = "txbEvent";
            txbEvent.Size = new Size(338, 29);
            txbEvent.TabIndex = 1;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(38, 39);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(48, 22);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date";
            // 
            // butSave
            // 
            butSave.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            butSave.Location = new Point(282, 181);
            butSave.Name = "butSave";
            butSave.Size = new Size(94, 29);
            butSave.TabIndex = 3;
            butSave.Text = "Save";
            butSave.UseVisualStyleBackColor = true;
            butSave.Click += butSave_Click;
            // 
            // lblEvent
            // 
            lblEvent.AutoSize = true;
            lblEvent.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEvent.Location = new Point(38, 101);
            lblEvent.Name = "lblEvent";
            lblEvent.Size = new Size(65, 22);
            lblEvent.TabIndex = 4;
            lblEvent.Text = "Events";
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 263);
            Controls.Add(lblEvent);
            Controls.Add(butSave);
            Controls.Add(lblDate);
            Controls.Add(txbEvent);
            Controls.Add(txbDate);
            Name = "EventForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EventForm";
            Load += EventForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbDate;
        private TextBox txbEvent;
        private Label lblDate;
        private Button butSave;
        private Label lblEvent;
    }
}