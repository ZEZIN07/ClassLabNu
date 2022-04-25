using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;

namespace ClassLabNu
{
    public class Produto
    {

        //atributo 
        private int idprod;
        private string Descricao;
        private string unidade;
        private string codbar;
        private double valor;
        private double desconto;
        private bool Descontinuado;

        //propriedades
        public int IdProd { get { return idprod; } set { idprod = value; } }
        public string descricao { get { return Descricao; } set { Descricao = value; } }
        public string Unidade { get { return unidade; } set { unidade = value; } }
        public string Codbar { get { return codbar; } set { codbar = value; } }
        public double Valor { get { return valor; } set { valor = value; } }
        public double Desconto { get { return desconto; } set { desconto = value; } }
        public bool descontinuado { get { return descontinuado; } set { descontinuado = value; } }


        //construtores

        public Produto()
        {
        }

        public Produto(string descricao, string unidade, string codbar, double valor, double desconto)
        {
            this.descricao = descricao;
            this.Unidade = unidade;
            this.Codbar = codbar;
            this.Valor = valor;
            this.Desconto = desconto;
        }
        public Produto(string _descricao, string unidade, string codbar, double valor)
        {
            descricao = _descricao;
            this.Unidade = unidade;
            this.Codbar = codbar;
            this.Valor = valor;
            this.Desconto = 0;
            descontinuado = false;
        }


        public Produto(int idProd, string descricao, string unidade, string codbar, double valor, double desconto, bool descontinuado)
        {
            this.IdProd = idProd;
            this.descricao = descricao;
            this.Unidade = unidade;
            this.Codbar = codbar;
            this.Valor = valor;
            this.Desconto = desconto;
            this.descontinuado = descontinuado;
        }


        //métodos de classe

        public void Inserir()
        {
            MySqlCommand cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produtos_inserir";
            cmd.Parameters.AddWithValue("_descricao", descricao);
            cmd.Parameters.AddWithValue("_unidade", unidade);
            cmd.Parameters.AddWithValue("_codbar", codbar);
            cmd.Parameters.AddWithValue("_valor", valor);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public Produto BuscarPorId(int _id)
        {
            Produto produto = new Produto();
            // conecta banco realiza consulta por Id do produto
            return produto;
        }
        public Produto BuscarPorCodBar(string _codBar)
        {
            Produto produto = new Produto();
            // conecta banco e realiza consulta por código de barras do produtos
            return produto;
        }
        public List<Produto> BuscarPorDescricao(string _descricao)
        {
            List<Produto> produtos = new List<Produto>();
            // conecta banco e realiza consulta por parte da descriação do produtos
            return produtos;
        }
        public List<Produto> ListarTodos(string descriParte = null)
        {
            List<Produto> produtos = new List<Produto>();
            // conecta banco e realiza consulta retornando todos produtos
            MySqlCommand cmd = Banco.Abrir();
            if (descriParte == null)
            { // lista produtos ativos ordenados alfabéticamente
                cmd.CommandText = "select * from produtos where descontinuado = 0 order by 2";
            }
            else
            { // lista produtos ativos, por parte da descriação e ordenados alfabéticamente
                cmd.CommandText = "select * from produtos where descontinuado = 0 and descricao like '%" + descriParte + "%' order by 2";
            }
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produtos.Add(new Produto(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDouble(4),
                    dr.GetDouble(5),
                    dr.GetBoolean(6)
                    ));
            }
            cmd.Connection.Close();
            return produtos;
        }
        public bool Alterar()
        {
            return true;
        }

    }// fim da classe produto
}
