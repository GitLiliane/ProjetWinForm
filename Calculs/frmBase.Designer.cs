namespace Calculs
{
    partial class frmBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBase));
            txBLigne1 = new TextBox();
            txBLigne2 = new TextBox();
            txBResultat = new TextBox();
            btCE = new Button();
            btPlus = new Button();
            btEgale = new Button();
            toolTip1 = new ToolTip(components);
            lblSeparation = new Label();
            SuspendLayout();
            // 
            // txBLigne1
            // 
            txBLigne1.Location = new Point(138, 45);
            txBLigne1.Name = "txBLigne1";
            txBLigne1.Size = new Size(292, 43);
            txBLigne1.TabIndex = 0;
            txBLigne1.TextAlign = HorizontalAlignment.Right;
            toolTip1.SetToolTip(txBLigne1, "Nombre 1");
            txBLigne1.KeyPress += txBLigne1_KeyPress;
            // 
            // txBLigne2
            // 
            txBLigne2.Location = new Point(138, 132);
            txBLigne2.Name = "txBLigne2";
            txBLigne2.Size = new Size(292, 43);
            txBLigne2.TabIndex = 1;
            txBLigne2.TextAlign = HorizontalAlignment.Right;
            toolTip1.SetToolTip(txBLigne2, "Nombre 2");
            txBLigne2.KeyPress += txBLigne2_KeyPress;
            // 
            // txBResultat
            // 
            txBResultat.Location = new Point(138, 268);
            txBResultat.Name = "txBResultat";
            txBResultat.Size = new Size(292, 43);
            txBResultat.TabIndex = 3;
            txBResultat.TextAlign = HorizontalAlignment.Right;
            toolTip1.SetToolTip(txBResultat, "Résultat");
            // 
            // btCE
            // 
            btCE.Location = new Point(490, 39);
            btCE.Name = "btCE";
            btCE.Size = new Size(62, 55);
            btCE.TabIndex = 4;
            btCE.Text = "&CE";
            toolTip1.SetToolTip(btCE, "Effacer");
            btCE.UseVisualStyleBackColor = true;
            btCE.Click += btCE_Click;
            // 
            // btPlus
            // 
            btPlus.Location = new Point(47, 126);
            btPlus.Name = "btPlus";
            btPlus.Size = new Size(55, 54);
            btPlus.TabIndex = 4;
            btPlus.Text = "+";
            btPlus.UseVisualStyleBackColor = true;
            // 
            // btEgale
            // 
            btEgale.Location = new Point(47, 262);
            btEgale.Name = "btEgale";
            btEgale.Size = new Size(55, 54);
            btEgale.TabIndex = 2;
            btEgale.Text = "=";
            toolTip1.SetToolTip(btEgale, "Calculer");
            btEgale.UseVisualStyleBackColor = true;
            btEgale.Click += btEgale_Click;
            // 
            // lblSeparation
            // 
            lblSeparation.AutoSize = true;
            lblSeparation.Location = new Point(47, 200);
            lblSeparation.Name = "lblSeparation";
            lblSeparation.Size = new Size(401, 38);
            lblSeparation.TabIndex = 5;
            lblSeparation.Text = "________________________________\r\n";
            // 
            // frmBase
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 353);
            Controls.Add(lblSeparation);
            Controls.Add(btEgale);
            Controls.Add(btPlus);
            Controls.Add(btCE);
            Controls.Add(txBResultat);
            Controls.Add(txBLigne2);
            Controls.Add(txBLigne1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(6);
            MaximumSize = new Size(600, 400);
            MinimumSize = new Size(600, 400);
            Name = "frmBase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calcul";
            KeyPress += frmBase_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txBLigne1;
        private TextBox txBLigne2;
        private TextBox txBResultat;
        private Button btCE;
        private Button btPlus;
        private Button btEgale;
        private ToolTip toolTip1;
        private Label lblSeparation;
    }
}
