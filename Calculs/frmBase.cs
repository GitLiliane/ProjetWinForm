namespace Calculs
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
        }

        private void btEgale_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txBLigne1.Text, out float nb1))
            {
                MessageBox.Show("Saisie invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txBLigne1.Clear();
                txBLigne1.Focus();
                return;
            }

            if (!float.TryParse(txBLigne2.Text, out float nb2))
            {
                MessageBox.Show("Saisie invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txBLigne2.Clear();
                txBLigne2.Focus();
                return;
            }
            float res = float.Parse(txBLigne1.Text) + float.Parse(txBLigne2.Text);
            txBResultat.Text = res.ToString();

        }

        private void btCE_Click(object sender, EventArgs e)
        {
            txBLigne1.Clear();
            txBLigne2.Clear();
            txBResultat.Clear();

            txBLigne1.Focus();
        }

        private void frmBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'c' || e.KeyChar == 'C')
            {
                btCE.PerformClick();
                e.Handled = true;
            }

            // On transforme le '.' en ','
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txBLigne1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',' && txBLigne1.Text.Contains(','))
                e.Handled = true;

        }

        private void txBLigne2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',' && txBLigne2.Text.Contains(','))
                e.Handled = true;
        }
    }
}
