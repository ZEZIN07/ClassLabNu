using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabNu
{
    public class itemPedido
    {
        //idped_ip idprod_ip valor quantidade desconto
        //atributos
        private Produto produto;
        private double valor;
        private double quantidade;
        private double desconto;


        //propriedades

        public Produto Produto { get { return produto; } set { produto = value; } }
        public double Valor { get { return valor; } set { valor = value; } }
        public double Quantidade { get { return quantidade; } set { quantidade = value; } }
        public double Desconto { get { return desconto; } set { desconto = value; } }

        //construtores

        public itemPedido()
        {

        }

        public itemPedido(Produto produto, double valor, double quantidade, double desconto)
        {
            Produto = produto;
            Valor = valor;
            Quantidade = quantidade;
            Desconto = desconto;
        }

        //métodos de classe(ações da classe)

        public void Inserir()
        {

        }
        public void Alterar(itemPedido item)
        {

        }

    }
}
