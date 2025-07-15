namespace Image
{
    partial class frMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMain));
            OFDImage = new OpenFileDialog();
            txbNomFic = new TextBox();
            btRechercher = new Button();
            toolTip1 = new ToolTip(components);
            lstbxImages = new ListBox();
            btAjouter = new Button();
            btSupprimer = new Button();
            btVider = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // OFDImage
            // 
            OFDImage.FileName = "OFDImage";
            OFDImage.Filter = "Images|*.BMP;*.JPG;*.GIF;*.PNG;|Icones|*.ico;";
            OFDImage.InitialDirectory = "C:\\WINDOWS\\Web\\Wallpaper";
            // 
            // txbNomFic
            // 
            txbNomFic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbNomFic.Location = new Point(100, 22);
            txbNomFic.Name = "txbNomFic";
            txbNomFic.ReadOnly = true;
            txbNomFic.Size = new Size(752, 27);
            txbNomFic.TabIndex = 0;
            txbNomFic.TextChanged += txbNomFic_TextChanged;
            // 
            // btRechercher
            // 
            btRechercher.Image = Properties.Resources.Age;
            btRechercher.Location = new Point(27, 22);
            btRechercher.Name = "btRechercher";
            btRechercher.Size = new Size(44, 29);
            btRechercher.TabIndex = 1;
            btRechercher.UseVisualStyleBackColor = true;
            btRechercher.Click += btRechercher_Click;
            // 
            // lstbxImages
            // 
            lstbxImages.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstbxImages.BorderStyle = BorderStyle.None;
            lstbxImages.FormattingEnabled = true;
            lstbxImages.Location = new Point(27, 73);
            lstbxImages.Name = "lstbxImages";
            lstbxImages.Size = new Size(581, 140);
            lstbxImages.TabIndex = 2;
            lstbxImages.SelectedIndexChanged += lstbxImages_SelectedIndexChanged;
            // 
            // btAjouter
            // 
            btAjouter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btAjouter.Enabled = false;
            btAjouter.Image = Properties.Resources.Ajouter_24;
            btAjouter.Location = new Point(672, 73);
            btAjouter.Name = "btAjouter";
            btAjouter.Size = new Size(128, 36);
            btAjouter.TabIndex = 3;
            btAjouter.Text = "Ajouter";
            btAjouter.TextAlign = ContentAlignment.MiddleRight;
            btAjouter.TextImageRelation = TextImageRelation.ImageBeforeText;
            btAjouter.UseVisualStyleBackColor = true;
            btAjouter.Click += btAjouter_Click;
            // 
            // btSupprimer
            // 
            btSupprimer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btSupprimer.Enabled = false;
            btSupprimer.Location = new Point(672, 127);
            btSupprimer.Name = "btSupprimer";
            btSupprimer.Size = new Size(128, 29);
            btSupprimer.TabIndex = 4;
            btSupprimer.Text = "Supprimer";
            btSupprimer.UseVisualStyleBackColor = true;
            btSupprimer.Click += btSupprimer_Click;
            // 
            // btVider
            // 
            btVider.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btVider.Enabled = false;
            btVider.Location = new Point(672, 184);
            btVider.Name = "btVider";
            btVider.Size = new Size(128, 29);
            btVider.TabIndex = 5;
            btVider.Text = "Vider";
            btVider.UseVisualStyleBackColor = true;
            btVider.Click += btVider_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, -54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(842, 347);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 301);
            panel1.Name = "panel1";
            panel1.Size = new Size(842, 296);
            panel1.TabIndex = 7;
            // 
            // frMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(864, 612);
            Controls.Add(panel1);
            Controls.Add(btVider);
            Controls.Add(btSupprimer);
            Controls.Add(btAjouter);
            Controls.Add(lstbxImages);
            Controls.Add(btRechercher);
            Controls.Add(txbNomFic);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frMain";
            Text = "images";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog OFDImage;
        private TextBox txbNomFic;
        private Button btRechercher;
        private ToolTip toolTip1;
        private ListBox lstbxImages;
        private Button btAjouter;
        private Button btSupprimer;
        private Button btVider;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}
