namespace FenetreModale
{
    partial class FenetreFillecs
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
            button1 = new Button();
            button2 = new Button();
            tbxFille = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(90, 254);
            button1.Name = "button1";
            button1.Size = new Size(230, 76);
            button1.TabIndex = 0;
            button1.Text = "Valider";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(471, 254);
            button2.Name = "button2";
            button2.Size = new Size(230, 76);
            button2.TabIndex = 1;
            button2.Text = "Annuler";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tbxFille
            // 
            tbxFille.Location = new Point(183, 136);
            tbxFille.Name = "tbxFille";
            tbxFille.Size = new Size(386, 27);
            tbxFille.TabIndex = 2;
            // 
            // FenetreFillecs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbxFille);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FenetreFillecs";
            Text = "FenetreFillecs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox tbxFille;
    }
}