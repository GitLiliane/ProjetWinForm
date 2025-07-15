namespace FenetreModale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            using FenetreFillecs fen = new FenetreFillecs();
            fen.Text = tbxForm.Text;
            this.Opacity = 0.5;
            DialogResult res = fen.ShowDialog();
            this.Opacity = 1;

            if (res == DialogResult.OK)
            {
                tbxForm.Text = fen.Saisie;

            }
            else
            {
                tbxForm.Clear();
            }
        }
    }
}
