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
    public partial class frmCadFornecimento : Form
    {
        public frmCadFornecimento()
        {
            InitializeComponent();
        }

        private void fornecimentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornecimentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsPrincipal);

        }

        private void frmCadFornecimento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPrincipal.Produtos_Fornecimento' table. You can move, or remove it, as needed.
            this.produtos_FornecimentoTableAdapter.Fill(this.dsPrincipal.Produtos_Fornecimento);
            // TODO: This line of code loads data into the 'dsPrincipal.Fornecimento' table. You can move, or remove it, as needed.
            this.fornecimentoTableAdapter.Fill(this.dsPrincipal.Fornecimento);

        }

        
    }
}
