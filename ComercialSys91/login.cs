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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (Usuario.EfetuarLogin(txtEmail.Text, txtSenha.Text))
            {
                this.Close();
            }
            else
            {
                lblMensagem.Text = "Email Ou Senha Incorretos!";
            }
        }
    }
}
