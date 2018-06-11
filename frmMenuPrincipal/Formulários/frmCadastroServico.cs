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
    public partial class frmCadastroServico : Form
    {
        public frmCadastroServico()
        {
            InitializeComponent();
        }

        private void servicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsPrincipal);

        }

        private void frmCadastroServico_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPrincipal.Servico' table. You can move, or remove it, as needed.
            this.servicoTableAdapter.Fill(this.dsPrincipal.Servico);

        }
    }
}
