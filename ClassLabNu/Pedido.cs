using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabNu
{
    public class Pedido
    {
        // idped    data    status_ped  desconto    idcli_ped iduser_ped
        
        //atributos

            //método usado em Pedido, foi sem atributos, direto na propriedades

        //propriedades

        public int Id { get; set; }
        public DateTime DataPed { get; set; }
        public string Status { get; set; }
        public double Desconto { get; set; }
        public Cliente Cliente { get; set; }
        public Usuario Usuario { get; set; }    
        public List<itemPedido> Itens { get; set; }


        //construtores

        public Pedido()
        {

        }

        public Pedido(DateTime dataPed, string status, double desconto, Cliente cliente, Usuario usuario, List<itemPedido> itens)
        {
            DataPed = dataPed;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            Itens = itens;
        }

        public Pedido(int id, DateTime dataPed, string status, double desconto, Cliente cliente, Usuario usuario, List<itemPedido> itens)
        {
            Id = id;
            DataPed = dataPed;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            Itens = itens;
        }


        //métodos de classe - operações/ações/funções

        public void Inserir()
        {

        }

        public bool Alterar()
        {
            return false;
        }

        public static List<Pedido> ConsultarPorClienteId(int _id)
        {
            List<Pedido> pedidos = new List<Pedido>();
            // graça... conecta ao banco e realiza a consulta pedo id do cliente
            return pedidos;
        }
    }
}
