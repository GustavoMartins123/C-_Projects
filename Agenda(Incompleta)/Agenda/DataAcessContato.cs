using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Agenda
{
    internal class DataAcessContato
    {
        Conexao conexao;

        public DataAcessContato(Conexao conexao)
        {
            this.conexao = conexao;
        }

        public void Incluir(Contato contato)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = conexao.ObjetoConexao;
            cm.CommandText = "insert into Contato (con_nome, con_email, con_telefone, con_endereco, con_bairro, con_cidade, con_estado, con_cep) " +
                 "values (@nome, @email, @telefone, @endereco, @bairro, @cidade, @estado, @cep)" + " select @@IDENTITY";


            cm.Parameters.AddWithValue("@nome", contato.Nome);
            cm.Parameters.AddWithValue("@email", contato.Email);
            cm.Parameters.AddWithValue("@telefone", contato.Telefone);
            cm.Parameters.AddWithValue("@endereco", contato.Endereco);
            cm.Parameters.AddWithValue("@bairro", contato.Bairro);
            cm.Parameters.AddWithValue("@cidade", contato.Cidade);
            cm.Parameters.AddWithValue("@estado", contato.Estado);
            cm.Parameters.AddWithValue("@cep", contato.Cep);
            conexao.Conectar();
            object obj = cm.ExecuteScalar();
            if (obj != null && obj != DBNull.Value)
            {
                contato.Codigo = Convert.ToInt32(obj);
            }
            conexao.Desconectar();
        }
        public void Alterar(Contato contato)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = conexao.ObjetoConexao;
            cm.CommandText = "update Contato set con_nome = @nome, con_email = @email, con_telefone = @telefone, " +
                 "con_endereco = @endereco, con_bairro = @bairro, con_cidade = @cidade, " +
                 "con_estado = @estado, con_cep = @cep " +
                 "where con_cod = @cod";

            cm.Parameters.AddWithValue("@cod", contato.Codigo);
            cm.Parameters.AddWithValue("@nome", contato.Nome);
            cm.Parameters.AddWithValue("@email", contato.Email);
            cm.Parameters.AddWithValue("@telefone", contato.Telefone);
            cm.Parameters.AddWithValue("@endereco", contato.Endereco);
            cm.Parameters.AddWithValue("@bairro", contato.Bairro);
            cm.Parameters.AddWithValue("@cidade", contato.Cidade);
            cm.Parameters.AddWithValue("@estado", contato.Estado);
            cm.Parameters.AddWithValue("@cep", contato.Cep);
            conexao.Conectar();
            cm.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = conexao.ObjetoConexao;
            cm.CommandText = "delete from Contato " + "where con_cod = @cod";
            cm.Parameters.AddWithValue("@cod", codigo);
            conexao.Conectar();
            cm.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public DataTable Localizar(string valor)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Contato where con_nome like '%" +
                valor + "%'", conexao.StringConexao);
            adapter.Fill(table);
            return table;
        }
        public Contato carregaContato(int codigo) 
        {
            Contato contato = new Contato();
            SqlCommand command = new SqlCommand();
            command.Connection = conexao.ObjetoConexao;
            command.CommandText = "select * from Contato where con_cod = @codigo";
            command.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows && dataReader != null)
            {
                if (dataReader.Read())
                {
                    contato.Codigo = Convert.ToInt32(dataReader["con_cod"]);
                    contato.Nome = Convert.ToString(dataReader["con_nome"]);
                    contato.Email = Convert.ToString(dataReader["con_email"]);
                    contato.Telefone = Convert.ToString(dataReader["con_telefone"]);
                    contato.Endereco = Convert.ToString(dataReader["con_endereco"]);
                    contato.Bairro = Convert.ToString(dataReader["con_bairro"]);
                    contato.Cidade = Convert.ToString(dataReader["con_cidade"]);
                    contato.Estado = Convert.ToString(dataReader["con_estado"]);
                    contato.Cep = Convert.ToString(dataReader["con_cep"]);
                }
            }
            conexao.Desconectar();
            return contato;
        }
    }
}
