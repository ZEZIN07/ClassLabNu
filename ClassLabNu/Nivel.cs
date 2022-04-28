using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabNu
{
    public class Nivel
    {
        // atributos - campos
        private int id;
        private string nome;
        private string sigla;
        public readonly bool ativo;

        // criando propriedades
        public int Id { get { return id; } }
        public string Nome { get { return nome; } private set { nome = value; } }
        public string Sigla { get { return sigla; } }



        // métodos construtores
        public Nivel(int _id = 0)
        {
            id = _id;
        }
        public Nivel(string nome, string sigla)
        {
            this.nome = nome;
            this.sigla = sigla;
            ativo = true;
        }
        public Nivel(int id, string nome, string sigla, bool ativo)
        {
            this.id = id;
            this.nome = nome;
            this.sigla = sigla;
            this.ativo = ativo;
        }
        // Métodos da classe
        public void InserirNovo()
        {
            // inserir um novo nível

        }
        /// <summary>
        /// Altera a sigla do nível indicado. Apenas administradores.
        /// </summary>
        /// <param name="id">identificação do nível</param>
        /// <param name="sigla">valor literal da nova sigla</param>
        /// <returns>Retorna valor par teste lógico, confirmando a alteração</returns>
        public bool Alterar(int id, string sigla)
        {
            return true;
        }
        public static Nivel ObterPorId(int _id)
        {
            Nivel nivel = null;
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from niveis where idnv = " + _id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nivel = new Nivel(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetBoolean(3));
            }
            return nivel;
        }
        public static List<Nivel> Listar()
        {
            List<Nivel> niveis = new List<Nivel>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from niveis";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                niveis.Add(new Nivel(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), true));
            }
            return niveis;
        }
    }

}