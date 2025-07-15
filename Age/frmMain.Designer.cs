namespace Age
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
            lblNom = new Label();
            btFermer = new Button();
            txbNom = new TextBox();
            txbDateNaiss = new TextBox();
            lblDateNaissance = new Label();
            btCalculer = new Button();
            dtpNaiss = new DateTimePicker();
            SuspendLayout();
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(80, 33);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(42, 20);
            lblNom.TabIndex = 0;
            lblNom.Text = "Nom";
            // 
            // btFermer
            // 
            btFermer.Image = Properties.Resources.Quitter;
            btFermer.Location = new Point(80, 250);
            btFermer.Name = "btFermer";
            btFermer.Size = new Size(150, 59);
            btFermer.TabIndex = 1;
            btFermer.Text = "Fermer";
            btFermer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btFermer.UseVisualStyleBackColor = true;
            btFermer.Click += btFermer_Click;
            // 
            // txbNom
            // 
            txbNom.Location = new Point(345, 33);
            txbNom.Name = "txbNom";
            txbNom.PlaceholderText = "Saisir le nom";
            txbNom.Size = new Size(356, 27);
            txbNom.TabIndex = 2;
            txbNom.TextChanged += txbNom_TextChanged;
            txbNom.KeyPress += txbNom_KeyPress;
            // 
            // txbDateNaiss
            // 
            txbDateNaiss.Location = new Point(345, 155);
            txbDateNaiss.Name = "txbDateNaiss";
            txbDateNaiss.PlaceholderText = "Saisir la date (jj/mm/aaaa)";
            txbDateNaiss.Size = new Size(356, 27);
            txbDateNaiss.TabIndex = 4;
            txbDateNaiss.TextChanged += txbDateNaiss_TextChanged;
            // 
            // lblDateNaissance
            // 
            lblDateNaissance.AutoSize = true;
            lblDateNaissance.Location = new Point(80, 110);
            lblDateNaissance.Name = "lblDateNaissance";
            lblDateNaissance.Size = new Size(129, 20);
            lblDateNaissance.TabIndex = 3;
            lblDateNaissance.Text = "Date de naissance";
            // 
            // btCalculer
            // 
            btCalculer.Location = new Point(551, 250);
            btCalculer.Name = "btCalculer";
            btCalculer.Size = new Size(150, 59);
            btCalculer.TabIndex = 5;
            btCalculer.Text = "Calculer";
            btCalculer.UseVisualStyleBackColor = true;
            btCalculer.Click += btCalculer_Click;
            // 
            // dtpNaiss
            // 
            dtpNaiss.Location = new Point(345, 105);
            dtpNaiss.Name = "dtpNaiss";
            dtpNaiss.Size = new Size(356, 27);
            dtpNaiss.TabIndex = 6;
            // 
            // frmMain
            // 
            AcceptButton = btCalculer;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btFermer;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpNaiss);
            Controls.Add(btCalculer);
            Controls.Add(txbDateNaiss);
            Controls.Add(lblDateNaissance);
            Controls.Add(txbNom);
            Controls.Add(btFermer);
            Controls.Add(lblNom);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            Text = "Age";
            FormClosed += frmMain_FormClosed;
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNom;
        private Button btFermer;
        private TextBox txbNom;
        private TextBox txbDateNaiss;
        private Label lblDateNaissance;
        private Button btCalculer;
        private DateTimePicker dtpNaiss;
    }
}
