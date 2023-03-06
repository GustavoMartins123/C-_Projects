using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmCadastroContato : Form
    {
        public string operacao = string.Empty;
        public frmCadastroContato()
        {
            InitializeComponent();
        }

        public void AlteraBotoes(int op)
        {
            pDados.Enabled = false;
            btn_Inserir.Enabled = false;
            btn_Localizar.Enabled = false;
            btn_Alterar.Enabled = false;
            btn_Excluir.Enabled = false;
            btn_Cancelar.Enabled = false;
            btn_Salvar.Enabled = false;

            switch (op)
            {
                case 1:
                    btn_Inserir.Enabled = true;
                    btn_Localizar.Enabled = true;
                    break;
                case 2:
                    pDados.Enabled = true;
                    btn_Salvar.Enabled = true;
                    btn_Cancelar.Enabled = true;
                    break;
                case 3:
                    btn_Excluir.Enabled = true;
                    btn_Alterar.Enabled = true;
                    btn_Cancelar.Enabled = true;
                    break;
            }
        }

        public void LimpaCampos()
        {
            txt_Codigo.Clear();
            txt_Nome.Clear();
            txt_Telefone.Clear();
            txt_Estado.Clear();
            txt_Endereco.Clear();
            txt_Email.Clear();
            txt_Cidade.Clear();
            txt_CEP.Clear();
            txt_Bairro.Clear();
        }

        private void frmCadastroContato_Load(object sender, EventArgs e)
        {
            AlteraBotoes(1);
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            AlteraBotoes(1);
            LimpaCampos();
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            operacao = "inserir";
            AlteraBotoes(2);
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                string strConexao = "Data Source = DESKTOP - 15R82CJ\\SQLEXPRESS; Initial Catalog = Agenda; User ID = usuario; Password = server1234";
                Conexao conexao = new Conexao(strConexao);
                DataAcessContato dataAcess = new DataAcessContato(conexao);
                dataAcess.Excluir(Convert.ToInt32(txt_Codigo.Text));
                AlteraBotoes(1);
                LimpaCampos();
            }
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            operacao = "alterar";
            AlteraBotoes(2);
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                Contato cont = new Contato();
                if(txt_Nome.Text.Length<= 0)
                {
                    DialogResult dialog = MessageBox.Show("Deseja salvar sem um nome?", "Aviso", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {

                    }
                    else
                    {
                        return;
                    }
                }
                cont.Nome = txt_Nome.Text;
                cont.Email = txt_Email.Text;
                cont.Telefone = txt_Telefone.Text;
                cont.Endereco = txt_Endereco.Text;
                cont.Bairro = txt_Bairro.Text;
                cont.Cidade = txt_Cidade.Text;
                cont.Estado = txt_Estado.Text;
                cont.Cep = txt_CEP.Text;

                string strConexao = "Data Source=DESKTOP-15R82CJ\\SQLEXPRESS;Initial Catalog=Agenda;User ID=usuario;Password=server1234;";//"Data Source=DESKTOP-15R82CJ\\SQLEXPRESS;Initial Catalog=Agenda;Integrated Security=True";
                Conexao conexao = new Conexao(strConexao);
                DataAcessContato data = new DataAcessContato(conexao);

                if (operacao == "inserir")
                {
                    data.Incluir(cont);
                    //MessageBox.Show("O codigo gerado foi: " + cont.Codigo);
                    MessageBox.Show("Registrado com sucesso");
                }
                else
                {
                    cont.Codigo = Convert.ToInt32(txt_Codigo.Text);
                    data.Alterar(cont);
                    MessageBox.Show("Registro alterado");
                }
                AlteraBotoes(1);
                LimpaCampos();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);  
            }
        }

        private void btn_Localizar_Click(object sender, EventArgs e)
        {
            frmConsultaContato frm = new frmConsultaContato();
            frm.ShowDialog();
            if (frm.codigo != 0)
            {
                string strConexao = "Data Source = DESKTOP - 15R82CJ\\SQLEXPRESS; Initial Catalog = Agenda; User ID = usuario; Password = server1234";
                Conexao conexao = new Conexao(strConexao);
                DataAcessContato dataAcess = new DataAcessContato(conexao);
                Contato contato = dataAcess.carregaContato(frm.codigo);
                txt_Codigo.Text = contato.Codigo.ToString();
                txt_Nome.Text = contato.Nome;
                txt_Email.Text = contato.Email;
                txt_Telefone.Text = contato.Telefone;
                txt_Endereco.Text = contato.Endereco;
                txt_Bairro.Text = contato.Bairro;
                txt_Cidade.Text = contato.Cidade;
                txt_Estado.Text = contato.Estado;
                txt_CEP.Text = contato.Cep;
                AlteraBotoes(3);
            }
            frm.Dispose();
        }
    }
}
