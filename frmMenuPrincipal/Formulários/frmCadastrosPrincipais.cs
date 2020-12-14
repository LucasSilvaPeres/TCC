using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Animations;
using frmMenuPrincipal.Formulários;

namespace frmMenuPrincipal.Formulários
{
    public partial class frmCadPrincipais : Form
    {
        public frmCadPrincipais()
        {
            InitializeComponent();

        }
        private void frmCadastros_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.WindowState = FormWindowState.Normal;
            this.WindowState = FormWindowState.Maximized;

        }


        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmMenuPrincip frmMP = new frmMenuPrincip();

            frmMP.Cliente();


        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            frmMenuPrincip frmMP = new frmMenuPrincip();

            frmMP.Servico();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            frmMenuPrincip frmMP = new frmMenuPrincip();

            frmMP.Produto();
        }

        private void btnAtendimento_Click(object sender, EventArgs e)
        {
            frmMenuPrincip frmMP = new frmMenuPrincip();

            frmMP.Atendimento();
        }

        private void btnFornecimento_Click(object sender, EventArgs e)
        {
            frmMenuPrincip frmMP = new frmMenuPrincip();

            frmMP.Fornecimento();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            frmMenuPrincip frmMP = new frmMenuPrincip();

            frmMP.Fornecedor();
        }


    }
}
