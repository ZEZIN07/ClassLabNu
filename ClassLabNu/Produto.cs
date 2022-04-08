using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabNu
{
    public class Produto
    {

        //atributo 
        private int idprod;
        private string Descricao;
        private string unidade;
        private string codprod;
        private double valor;
        private double desconto;
        private bool Descontinuado;

        //propriedades
        public int IdProd { get { return idprod; } set { idprod = value; } }
        public string descricao { get { return Descricao; } set { Descricao = value; } }
        public string Unidade { get { return unidade; } set { unidade = value; } }
        public string Codprod { get { return codprod; } set { codprod = value; } }
        public double Valor { get { return valor; } set { valor = value; } }
        public double Desconto { get { return desconto; } set { desconto = value; } }
        public bool descontinuado { get { return descontinuado; } set { descontinuado = value; } }


        //construtores

        public Produto()
        {
        }

        public Produto(string descricao, string unidade, string codprod, double valor, double desconto)
        {
            this.descricao = descricao;
            this.Unidade = unidade;
            this.Codprod = codprod;
            this.Valor = valor;
            this.Desconto = desconto;
        }

        public Produto(int idProd, string descricao, string unidade, string codprod, double valor, double desconto, bool descontinuado)
        {
            this.IdProd = idProd;
            this.descricao = descricao;
            this.Unidade = unidade;
            this.Codprod = codprod;
            this.Valor = valor;
            this.Desconto = desconto;
            this.descontinuado = descontinuado;
        }


        //métodos de classe

        public int Inserir(Produto produto)
        {
            return idprod;
        }
        
        public static Produto ConsultaPorDescricao(int _descricao)
        {
           Produto produto = new Produto();
            return produto;
        }

       public static Produto ConsultaPorCodProd(int _codprod)
        {
            Produto produto = new Produto();
            return produto;
        }

        public static List<Produto> Listar()
        {
            List<Produto> produtos = new List<Produto>();
            return produtos;
        }


    }
}
