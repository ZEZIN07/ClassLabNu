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
    public partial class Frmpedido : Form
    {
        public Frmpedido()
        {
            InitializeComponent();
        }

        private void Frmpedido_Load(object sender, EventArgs e)
        {
            var lista = Cliente.Listar();
            comboBox1.DataSource = lista;
            comboBox1.DisplayMember = "Descricao";
        }
    }
}
