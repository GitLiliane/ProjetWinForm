namespace ProjetWinForm
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
            btTest = new Button();
            vScrollBar1 = new VScrollBar();
            SuspendLayout();
            // 
            // btTest
            // 
            btTest.Location = new Point(340, 140);
            btTest.Name = "btTest";
            btTest.Size = new Size(94, 29);
            btTest.TabIndex = 0;
            btTest.Text = "Cliquez ici";
            btTest.UseVisualStyleBackColor = true;
            btTest.Click += btTest_Click;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(562, 425);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 125);
            vScrollBar1.TabIndex = 1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(800, 600);
            Controls.Add(vScrollBar1);
            Controls.Add(btTest);
            Name = "frmMain";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btTest;
        private VScrollBar vScrollBar1;
    }
}
