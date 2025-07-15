namespace Image
{
    public partial class frMain : Form
    {
        public frMain()
        {
            InitializeComponent();
        }

        private void btRechercher_Click(object sender, EventArgs e)
        {
            // On ré-initialise la propriété 'Filename' à vide
            OFDImage.FileName = String.Empty;

            // Restaure le dernier dossier ouvert par l'utilisateur
            OFDImage.RestoreDirectory = true;

            OFDImage.Filter = "Image | *.BMP; *.JPG; *.GIF; *.PNG; | Icônes | *.ico";

            // On ré-initialise le champ 'TxbNomFic' à vide avant la recherche
            txbNomFic.Text = String.Empty;

            DialogResult resultat = OFDImage.ShowDialog();

            // Test si l'utilisateur a cliqué sur 'Ouvrir

            if (resultat == DialogResult.OK)
            {
                txbNomFic.Text = OFDImage.FileName;
            }
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            if (lstbxImages.Items.Contains(txbNomFic.Text))
            {
                Grisage();

            }

            else if (!string.IsNullOrWhiteSpace(txbNomFic.Text))
            {
                lstbxImages.Items.Add(txbNomFic.Text);
                Grisage();
            }

        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            //if (lstbxImages.SelectedIndex != -1)
            //{
            //    /*int selectedIndex = lstbxImages.SelectedIndex*/;
            //    lstbxImages.Items.RemoveAt(lstbxImages.SelectedIndex);
            //}

            if (lstbxImages.SelectedItem != null)
            {
                lstbxImages.Items.Remove(lstbxImages.SelectedItem);
            }

        }

        private void btVider_Click(object sender, EventArgs e)
        {
            lstbxImages.Items.Clear();
            Grisage();
        }

        private void Grisage()
        {
            if (txbNomFic.Text.Length < 0 || lstbxImages.Items.Contains(txbNomFic.Text))
            {
                btAjouter.Enabled = false;
            }

            else
            {
                btAjouter.Enabled = true;
            }

            btSupprimer.Enabled = lstbxImages.SelectedIndex != -1;

            if (lstbxImages.Items.Count == 0)
            {
                btVider.Enabled = false;
            }
            else
            {
                btVider.Enabled = true;
            }
        }

        private void txbNomFic_TextChanged(object sender, EventArgs e)
        {
            Grisage();
        }

        private void lstbxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            Grisage();
            if (lstbxImages.SelectedIndex != null)
            {
                pictureBox1.Load(lstbxImages.SelectedItem.ToString());
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

       
    }
}
