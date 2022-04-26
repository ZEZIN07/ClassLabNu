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
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            txtDataPed.Text = DateTime.Now.Date.ToString();
            cmbCliente.DataSource = Cliente.Listar().ToArray();
            cmbCliente.DisplayMember = "Nome";
            cmbCliente.ValueMember = "Id";
            cmbVendedor.DataSource = Usuario.Listar().ToArray();
            cmbVendedor.DisplayMember = "Nome";
            cmbVendedor.ValueMember = "Id";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
