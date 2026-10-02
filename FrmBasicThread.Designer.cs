namespace Basic_Thread
{
    partial class FrmBasicThread
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
            lblStatus = new Label();
            btnRun = new Button();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(12, 19);
            lblStatus.Margin = new Padding(3, 10, 3, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(379, 110);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Before Starting Thread";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRun
            // 
            btnRun.BackColor = SystemColors.ActiveCaption;
            btnRun.FlatAppearance.BorderSize = 0;
            btnRun.FlatStyle = FlatStyle.Flat;
            btnRun.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRun.Location = new Point(107, 132);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(191, 61);
            btnRun.TabIndex = 1;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = false;
            btnRun.Click += btnRun_Click;
            // 
            // FrmBasicThread
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 222);
            Controls.Add(btnRun);
            Controls.Add(lblStatus);
            Name = "FrmBasicThread";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FrmBasicThread_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblStatus;
        private Button btnRun;
    }
}
