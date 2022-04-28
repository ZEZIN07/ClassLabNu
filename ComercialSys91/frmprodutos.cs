using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLabNu;

namespace ComercialSys91
{
    public partial class frmprodutos : Form
    {
        public frmprodutos()
        {
            InitializeComponent();
        }

        private void frmprodutos_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
           Produto produto = new Produto(txtDescricao.Text, txtCod.Text, txtUnidade.Text, Double.Parse(txtValor.Text), Double.Parse(txtDesconto.Text));

            produto.Inserir();

            if (produto.IdProd > 0)
            {
                MessageBox.Show("Produto inserido Com Sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao inserir Produto!");
            }

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvProdutos.Rows.Clear();
            List<Produto> listadeprodutos = Produto.ListarTodos();
            int cont = 0;
            foreach (Produto produto in listadeprodutos)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[cont].Cells[0].Value = produto.IdProd.ToString();
                dgvProdutos.Rows[cont].Cells[1].Value = produto.descricao.ToString();
                dgvProdutos.Rows[cont].Cells[2].Value = produto.Unidade.ToString();
                dgvProdutos.Rows[cont].Cells[3].Value = produto.Codbar.ToString();
                dgvProdutos.Rows[cont].Cells[4].Value = produto.Valor.ToString();
                dgvProdutos.Rows[cont].Cells[5].Value = produto.Desconto.ToString();

                cont++;

            }
        }
    }
}
