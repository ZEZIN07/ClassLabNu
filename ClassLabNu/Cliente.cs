using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

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

        // propriedades
        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Cpf { get { return cpf; } set { cpf = value; } }
        public string Email { get { return email; } set { email = value; } }
        public DateTime DataCad { get { return dataCad; } set { dataCad = value; } }
        public bool Ativo { get { return ativo; } set { ativo = value; } }

        // construtores
        public Cliente()
        {
        }

        public Cliente(string nome, string cpf, string email)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            // DataCad = DateTime.Now;
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

        // métodos da classe
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_inserir";
            cmd.Parameters.AddWithValue("_nome", Nome);
            cmd.Parameters.AddWithValue("_cpf", Cpf);
            cmd.Parameters.AddWithValue("_email", Email);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }
        public bool Alterar(int _id, string _nome, string _email )
        {
            bool resultado = false; 
            try
            {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            //recebe o nome da procedure
            cmd.CommandText = "sp_cliente_alterar";
            //adiciona os parâmetros da procedure - la no mysql
            //cmd.Parameters.Add("_id", MySqlDbType.Int32).Value = _id;
            cmd.Parameters.AddWithValue("_id", _id);
            cmd.Parameters.AddWithValue("_nome", _nome);
            cmd.Parameters.AddWithValue("_email", _email);
            cmd.ExecuteNonQuery();
            resultado = true;
                cmd.Connection.Close();
            }
            catch (Exception)
            {

            }
            return resultado;

            
        }
        public static Cliente ConsultarPorId(int _id)
        {
            Cliente cliente = new Cliente();
            var cmd = Banco.Abrir();
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.CommandText = "select * from clientes where idcli = " + _id;
            MySqlDataReader dr  = cmd.ExecuteReader();
            while (dr.Read())
            {
                cliente.Id = Convert.ToInt32(dr["idcli"]);
                cliente.Nome = dr["nome"].ToString();
                cliente.cpf = dr.GetString(2);
                cliente.email = dr.GetString(3);
                cliente.dataCad = dr.GetDateTime(4);
                cliente.ativo = dr.GetBoolean(5);
            }

            return cliente;
        }
        public static Cliente ConsultarPorCpf(string _cpf)
        {
            Cliente cliente = new Cliente();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "select * from clientes where cpf= " + _cpf;
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cliente.Id = Convert.ToInt32(dr["idcli"]);
                cliente.Nome = dr["nome"].ToString();
                cliente.cpf = dr.GetString(2);
                cliente.email = dr.GetString(3);
                cliente.dataCad = dr.GetDateTime(4);
                cliente.ativo = dr.GetBoolean(5);
            }

            return cliente;
        }
        public static List<Cliente> Listar()
        {
            List<Cliente> clientes = new List<Cliente>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes where ativo = 1 order by nome";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clientes.Add(new Cliente(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDateTime(4),
                    dr.GetBoolean(5)
                    ));
            }
            return clientes;
        }
        public void Desativado(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update clientes set ativo = 0 where idcli = " + _id;
            cmd.ExecuteReader();
            cmd.Connection.Close();
        }

    }
}
