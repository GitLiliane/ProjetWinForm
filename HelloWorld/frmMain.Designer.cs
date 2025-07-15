namespace HelloWorld
{
    partial class frmMain
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
            lblLabel = new Label();
            btButton = new Button();
            SuspendLayout();
            // 
            // lblLabel
            // 
            lblLabel.AutoSize = true;
            lblLabel.Location = new Point(142, 106);
            lblLabel.Name = "lblLabel";
            lblLabel.Size = new Size(248, 54);
            lblLabel.TabIndex = 0;
            lblLabel.Text = "Hello world !";
            // 
            // btButton
            // 
            btButton.Location = new Point(637, 92);
            btButton.Name = "btButton";
            btButton.Size = new Size(181, 82);
            btButton.TabIndex = 1;
            btButton.Text = "Quitter";
            btButton.UseVisualStyleBackColor = true;
            btButton.Click += btButton_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(22F, 54F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 338);
            Controls.Add(btButton);
            Controls.Add(lblLabel);
            Font = new Font("Segoe UI", 24F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(8);
            MinimumSize = new Size(1100, 385);
            Name = "frmMain";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Premiers pas en Winform";
            FormClosing += frmMain_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLabel;
        private Button btButton;
    }
}
