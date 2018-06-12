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
    public partial class frmCadastrarProdutos : Form
    {
        public frmCadastrarProdutos()
        {
            InitializeComponent();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsPrincipal);

        }

        private void frmCadastrarProdutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPrincipal.Produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.dsPrincipal.Produto);

        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control item in pnlCampos.Controls)
                {
                    if (item is TextBox)
                    {
                        (item as TextBox).Clear();
                    }
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }
    }
}
