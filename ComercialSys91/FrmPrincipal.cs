using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialSys91
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // criar instância do Formulário Cliente
            FrmCliente frmCliente = new FrmCliente();
            // tornando frmCliente filho do Container FrmPrincipal (this)
            frmCliente.MdiParent = this;
            // exibe o formulário de cliente no formprincipal
            frmCliente.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedidos frmPedidos = new FrmPedidos();
            frmPedidos.MdiParent = this;
            frmPedidos.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            login Login = new login();
            Login.ShowDialog();
                
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuario = new FrmUsuarios();
            frmUsuario.MdiParent = this;
            frmUsuario.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void nomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmprodutos frmProduto = new frmprodutos();
            frmProduto.MdiParent = this;
            frmProduto.Show();
        }
    }
}