using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frmConsultaContato : Form
    {
        public int codigo;
        public frmConsultaContato()
        {
            InitializeComponent();
        }

        private void btn_Executar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao("Data Source = DESKTOP - 15R82CJ\\SQLEXPRESS; Initial Catalog = Agenda; User ID = usuario; Password = server1234");
            DataAcessContato dataAcess = new DataAcessContato(conexao);
            dgd_Dados.DataSource = dataAcess.Localizar(txt_Valor.Text);
        }

        private void dgd_Dados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex >= 0)
            {
                codigo = Convert.ToInt32(dgd_Dados.Rows[e.RowIndex].Cells[0].Value);
                Close();
            }
        }
    }
}
