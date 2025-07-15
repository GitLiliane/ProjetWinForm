using System.Reflection.Metadata;

namespace Age
{
    public partial class frmMain : Form
    {

        private const String MESSAGE = "Bonjour {0}, vous avez {1} ans ";
        private const String TITRE = "Age";
        public frmMain()
        {
            InitializeComponent();
        }

        private void btFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCalculer_Click(object sender, EventArgs e)
        {
            DateTime dtNaiss;

            DateTime dtJour;

            long nbAns;

            // Calcul de l'âge

            dtNaiss = Convert.ToDateTime(txbDateNaiss.Text);

            dtJour = DateTime.Today;

            nbAns = dtJour.Year - dtNaiss.Year;

            if (dtNaiss.Month > dtJour.Month || dtNaiss.Month == dtJour.Month && dtNaiss.Day > dtJour.Day)
            {
                nbAns--;
            }

            // Affichage de l'âge

            MessageBox.Show(String.Format(MESSAGE, txbNom.Text, nbAns), TITRE, MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void txbNom_TextChanged(object sender, EventArgs e)
        {
            Grisage();
        }

        private void txbDateNaiss_TextChanged(object sender, EventArgs e)
        {
            Grisage();
        }

        private void txbNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void Grisage()
        {
            DateTime dtNaiss;

            if (String.IsNullOrEmpty(txbNom.Text) || String.IsNullOrEmpty(txbDateNaiss.Text) || !DateTime.TryParse(txbDateNaiss.Text, out dtNaiss) || dtNaiss >= DateTime.Today)
            {
                btCalculer.Enabled = false;

            }
            else
            {
                btCalculer.Enabled = true;
            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ////dtpNaiss.MaxDate = DateTime.Now;
            ////dtpNaiss.MinDate = new DateTime(2000, 1, 1);

            txbNom.Text = Properties.Settings.Default.Nom;
            dtpNaiss.Value = Properties.Settings.Default.DateNaissance;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Nom = txbNom.Text;
            Properties.Settings.Default.DateNaissance = dtpNaiss.Value;
            Properties.Settings.Default.Save();
        }
    }
}
