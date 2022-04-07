using System;
using System.Collections.Generic;

namespace ClassLabNu
{
    public class Cliente
    {
        // atributos
        private int id;
        private string nome;
        private string cpf;
        private string email;
        private DateTime dataCad;
        private bool ativo;

        //propriedades

        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Cpf { get { return cpf; } set { cpf = value; } }
        public string Email { get { return email; } set { email = value; } }
        public DateTime DataCad { get { return DataCad; } set { DataCad = value; } }
        public bool Ativo { get { return ativo; } set { ativo = value; } }


        //construtores

        public Cliente()
        {
        }

        public Cliente(string nome, string cpf, string email)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            //dataCad = DateTime.Now;
            // ativo = true;
        }

        public Cliente(int id, string nome, string cpf, string email, DateTime dataCad, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            DataCad = dataCad;
            Ativo = ativo;
        }



        //métodos da classe

        public void Inserir(Cliente cliente)
        {

        }

        public bool Alterar(Cliente cliente)
        {
            return true;
        }


        public static Cliente ConsultarPorId(int _id)
        {
            Cliente cliente = new Cliente();
            // cenas dos próximos epsódios...
            return cliente;
        }

        public static Cliente ConsultarPorCpf(string _cpf)
        {
            Cliente cliente = new Cliente();
            // cenas dos próximos epsódios...

            Cliente cliente2 = new Cliente();
            cliente2 = Cliente.ConsultarPorCpf("12312312312");

            return cliente;
        }

        public static List<Cliente> Listar()
        {
            List<Cliente> cliente = new List<Cliente>();
            // cenas dos próximos epsódios...
            return cliente;
        }
    }
}
