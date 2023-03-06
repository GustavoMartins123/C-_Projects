using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    internal class Contato
    {
        public Contato()
        {
            Codigo = 0;
            Nome = string.Empty;
            Email = string.Empty;
            Telefone = string.Empty;
            Endereco = string.Empty;
            Bairro = string.Empty;
            Cidade = string.Empty;
            Estado = string.Empty;
            Cep = string.Empty;
        }

        public Contato(int codigo, string nome, string email, string telefone, string endereco, string bairro, string cidade, string estado, string cep)
        {
            Codigo = codigo;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
        }

        int con_cod;
        public int Codigo
        {
            get
            {
                return this.con_cod;
            }
            set 
            {
                this.con_cod = value;
            }
        }

        string con_nome = string.Empty;
        public string Nome
        {
            get { return this.con_nome; }
            set { this.con_nome = value; }
        }

        string con_email = string.Empty;
        public string Email
        {
            get { return this.con_email; }
            set { this.con_email = value; }
        }

        string con_fone = string.Empty;
        public string Telefone
        {
            get { return this.con_fone; }
            set { this.con_fone = value; }
        }

        string con_rua = string.Empty;
        public string Endereco
        {
            get { return this.con_rua; }
            set { this.con_rua = value; }
        }

        string con_bairro = string.Empty;
        public string Bairro
        {
            get { return this.con_bairro; }
            set { this.con_bairro = value; }
        }

        string con_cidade = string.Empty;
        public string Cidade 
        {
            get { return this.con_cidade;}
            set
            {
                this.con_cidade = value;
            }
        }

        string con_estado = string.Empty;
        public string Estado
        {
            get { return this.con_estado; }
            set
            {
                this.con_estado = value;
            }
        }

        string con_cep = string.Empty;
        public string Cep
        {
            get { return this.con_cep; }
            set
            {
                this.con_cep = value;
            }
        }

    }
}
