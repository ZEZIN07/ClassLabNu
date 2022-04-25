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

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //criar instância do formulário cliente
            FrmCliente frmCliente = new FrmCliente();
            // tornando frmCliente filho do container FrmPrincipal
            frmCliente.MdiParent = this;
            // exibe o formulário de cliente no formprincipal
            frmCliente.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmpedido frmpedido = new Frmpedido();
            frmpedido.MdiParent = this;
            frmpedido.Show();
        }
    }
}
