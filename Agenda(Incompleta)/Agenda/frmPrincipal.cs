namespace Agenda
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadastroContato f = new frmCadastroContato();
            f.ShowDialog();
            f.Dispose();
        }
    }
}