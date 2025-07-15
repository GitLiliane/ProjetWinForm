namespace FenetreModale
{
    partial class Form1
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
            lblMere = new Label();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            fontDialog1 = new FontDialog();
            tbxForm = new TextBox();
            saveFileDialog1 = new SaveFileDialog();
            btn = new Button();
            SuspendLayout();
            // 
            // lblMere
            // 
            lblMere.AutoSize = true;
            lblMere.Location = new Point(130, 65);
            lblMere.Name = "lblMere";
            lblMere.Size = new Size(216, 20);
            lblMere.TabIndex = 0;
            lblMere.Text = "Veuillez saisir le titre de la Fen2";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // tbxForm
            // 
            tbxForm.Location = new Point(352, 62);
            tbxForm.Name = "tbxForm";
            tbxForm.Size = new Size(281, 27);
            tbxForm.TabIndex = 1;
            // 
            // btn
            // 
            btn.Location = new Point(317, 215);
            btn.Name = "btn";
            btn.Size = new Size(133, 46);
            btn.TabIndex = 2;
            btn.Text = "Fenêtre fille";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn);
            Controls.Add(tbxForm);
            Controls.Add(lblMere);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMere;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private FontDialog fontDialog1;
        private TextBox tbxForm;
        private SaveFileDialog saveFileDialog1;
        private Button btn;
    }
}
