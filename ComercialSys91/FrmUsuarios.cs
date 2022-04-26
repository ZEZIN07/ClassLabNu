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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            if (usuario.Inserir(int.Parse(txtId.Text), txtNome.Text, txtEmail.Text))
            {
                MessageBox.Show("Usuario Alterado Com Sucesso!");
            }
            else
            {
                MessageBox.Show("Falha Na Alteração Do Cliente!");
            }

        }
    }
}
