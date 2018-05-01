using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMenuPrincipal.Formulários
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "123" && txtSenha.Text != "123")
            {
                MessageBox.Show("Usuário ou Senha inválidos");
            }
            else
            {
                frmMenuPrincipal objFrmMenuPrincipal = new frmMenuPrincipal();
                objFrmMenuPrincipal.Show();
                //this.Close();
            }
        }
    }
}
