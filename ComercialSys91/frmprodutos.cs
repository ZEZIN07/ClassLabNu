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
            try
            {
                Produto produto = new Produto(txtDescricao.Text, 
                    txtuni.Text, txtcodbar.Text, 
                    Double.Parse(txtvalor.Text), 
                    Double.Parse(txtdesconto.Text));

                produto.Inserir();

                MessageBox.Show("Produto inserido Com Sucesso!");
            }
            catch (Exception ex )
            {

                MessageBox.Show(Text, ex.Message);
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

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            if (produto.Alterar(int.Parse(txtId.Text), Double.Parse(txtvalor.Text), double.Parse(txtdesconto.Text)))
            {
                MessageBox.Show("Produto alterado com Sucesso!");
            }
            else
            {
                MessageBox.Show("Falha na alteração do Produto!");
            }
        }

        private void bntbuscar_Click(object sender, EventArgs e)
        {
            if (bntbuscar.Text == "...")
            {
                txtId.ReadOnly = false;
                txtId.Focus();
                bntbuscar.Text = "Buscar";
            }
            else
            {
                Produto produto = Produto.BuscarPorId(int.Parse(txtId.Text));
                if (produto.IdProd > 0)
                {

                    txtcodbar.Text = produto.Codbar.ToString();
                    txtuni.Text = produto.Unidade.ToString();
                    txtvalor.Text = produto.Valor.ToString();
                    txtdesconto.Text = produto.Desconto.ToString();
                    txtDescricao.Text = produto.descricao.ToString();

                    bntbuscar.Text = "...";
                    txtId.ReadOnly = true;
                    btnAlterar.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Esse Código De Produto Não Existe!");
                }
            }
        }
    }
}
