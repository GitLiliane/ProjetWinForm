namespace Diviseurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            lblNumerateur = new Label();
            txbNumerateur = new TextBox();
            txbDenominateur = new TextBox();
            lblDenominateur = new Label();
            lblSeparation = new Label();
            btCalculer = new Button();
            lblResultat = new Label();
            lblResNumerateur = new Label();
            lblSep = new Label();
            txbResDen = new TextBox();
            txbResNum = new TextBox();
            lblResDen = new Label();
            SuspendLayout();
            // 
            // lblNumerateur
            // 
            lblNumerateur.AutoSize = true;
            lblNumerateur.Location = new Point(55, 34);
            lblNumerateur.Name = "lblNumerateur";
            lblNumerateur.Size = new Size(200, 20);
            lblNumerateur.TabIndex = 0;
            lblNumerateur.Text = "Veuillez saisir le numérateur :";
            // 
            // txbNumerateur
            // 
            txbNumerateur.Location = new Point(499, 27);
            txbNumerateur.Name = "txbNumerateur";
            txbNumerateur.Size = new Size(125, 27);
            txbNumerateur.TabIndex = 1;
            // 
            // txbDenominateur
            // 
            txbDenominateur.Location = new Point(499, 90);
            txbDenominateur.Name = "txbDenominateur";
            txbDenominateur.Size = new Size(125, 27);
            txbDenominateur.TabIndex = 3;
            // 
            // lblDenominateur
            // 
            lblDenominateur.AutoSize = true;
            lblDenominateur.Location = new Point(55, 97);
            lblDenominateur.Name = "lblDenominateur";
            lblDenominateur.Size = new Size(210, 20);
            lblDenominateur.TabIndex = 2;
            lblDenominateur.Text = "Veuillez saisir le dénominateur";
            // 
            // lblSeparation
            // 
            lblSeparation.AutoSize = true;
            lblSeparation.Location = new Point(477, 57);
            lblSeparation.Name = "lblSeparation";
            lblSeparation.Size = new Size(169, 20);
            lblSeparation.TabIndex = 4;
            lblSeparation.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ ";
            // 
            // btCalculer
            // 
            btCalculer.Location = new Point(351, 175);
            btCalculer.Name = "btCalculer";
            btCalculer.Size = new Size(94, 29);
            btCalculer.TabIndex = 5;
            btCalculer.Text = "Calculer";
            btCalculer.UseVisualStyleBackColor = true;
            // 
            // lblResultat
            // 
            lblResultat.AutoSize = true;
            lblResultat.Location = new Point(55, 239);
            lblResultat.Name = "lblResultat";
            lblResultat.Size = new Size(213, 20);
            lblResultat.TabIndex = 6;
            lblResultat.Text = "Résultat après simplifications : ";
            // 
            // lblResNumerateur
            // 
            lblResNumerateur.AutoSize = true;
            lblResNumerateur.Location = new Point(55, 291);
            lblResNumerateur.Name = "lblResNumerateur";
            lblResNumerateur.Size = new Size(95, 20);
            lblResNumerateur.TabIndex = 7;
            lblResNumerateur.Text = "Numérateur :";
            // 
            // lblSep
            // 
            lblSep.AutoSize = true;
            lblSep.Location = new Point(477, 314);
            lblSep.Name = "lblSep";
            lblSep.Size = new Size(169, 20);
            lblSep.TabIndex = 10;
            lblSep.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ ";
            // 
            // txbResDen
            // 
            txbResDen.Location = new Point(499, 347);
            txbResDen.Name = "txbResDen";
            txbResDen.Size = new Size(125, 27);
            txbResDen.TabIndex = 9;
            // 
            // txbResNum
            // 
            txbResNum.Location = new Point(499, 284);
            txbResNum.Name = "txbResNum";
            txbResNum.Size = new Size(125, 27);
            txbResNum.TabIndex = 8;
            // 
            // lblResDen
            // 
            lblResDen.AutoSize = true;
            lblResDen.Location = new Point(55, 347);
            lblResDen.Name = "lblResDen";
            lblResDen.Size = new Size(111, 20);
            lblResDen.TabIndex = 11;
            lblResDen.Text = "Dénominateur :";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResDen);
            Controls.Add(lblSep);
            Controls.Add(txbResDen);
            Controls.Add(txbResNum);
            Controls.Add(lblResNumerateur);
            Controls.Add(lblResultat);
            Controls.Add(btCalculer);
            Controls.Add(lblSeparation);
            Controls.Add(txbDenominateur);
            Controls.Add(lblDenominateur);
            Controls.Add(txbNumerateur);
            Controls.Add(lblNumerateur);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(818, 497);
            MinimumSize = new Size(818, 497);
            Name = "frmMain";
            Text = "Diviseurs";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumerateur;
        private TextBox txbNumerateur;
        private TextBox txbDenominateur;
        private Label lblDenominateur;
        private Label lblSeparation;
        private Button btCalculer;
        private Label lblResultat;
        private Label lblResNumerateur;
        private Label lblSep;
        private TextBox txbResDen;
        private TextBox txbResNum;
        private Label lblResDen;
    }
}
