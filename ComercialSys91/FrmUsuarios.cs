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
            Usuario usuario = new Usuario(txtNome.Text, txtEmail.Text, txtSenha.Text);
            usuario.Inserir();
            if (usuario.Id > 0)
            {
                MessageBox.Show("Usuario inserido Com Sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao inserir Usuario!");
            }

        }

        private void btnListar_Click_1(object sender, EventArgs e)
        {
            dgvUsuarios.Rows.Clear();
            List<Usuario> listadeusuarios = Usuario.Listar();
            int cont = 0;
            foreach(Usuario usuario in listadeusuarios)
            {
                dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[cont].Cells[0].Value = usuario.Id.ToString();
                dgvUsuarios.Rows[cont].Cells[1].Value = usuario.Nome.ToString();
                dgvUsuarios.Rows[cont].Cells[2].Value = usuario.Email.ToString();
                dgvUsuarios.Rows[cont].Cells[3].Value = usuario.Password.ToString();
                dgvUsuarios.Rows[cont].Cells[4].Value = usuario.Ativo;

                cont++;

            }
        }
    }
}
