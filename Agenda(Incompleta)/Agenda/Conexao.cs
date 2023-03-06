using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    internal class Conexao
    {
        string stringConexao = string.Empty;
        SqlConnection conexao;

        public Conexao(string dadosConexao)
        {
            this.conexao = new SqlConnection(dadosConexao);
            stringConexao = dadosConexao;
            conexao.ConnectionString = dadosConexao;
        }

        public string StringConexao
        {
            get { return stringConexao; }
            set { stringConexao = value; }
        }

        public SqlConnection ObjetoConexao 
        {
            get { return conexao; }
            set { conexao = value; }
        }
        public void Conectar()
        {
            conexao.Open();
        }
        public void Desconectar()
        {
            conexao.Close();
        }
    }
}
