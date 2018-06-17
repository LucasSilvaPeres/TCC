using frmMenuPrincipal.Dados.dsPrincipalTableAdapters;
using frmMenuPrincipal.Models;
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
    public partial class frmCadastroClientes : Form
    {
        public frmCadastroClientes()
        {
            InitializeComponent();
        }

		private void frmCadastroClientes_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'dsPrincipal.Cliente'. Você pode movê-la ou removê-la conforme necessário.
			this.clienteTableAdapter.Fill(this.dsPrincipal.Cliente);
            rbCPF.Checked = true;
            

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
                    if(item is MaskedTextBox)
                    {
                        (item as MaskedTextBox).Clear();
                    }
                    if(item is DateTimePicker)
                    {
                        dtpDataNascimento.Value = DateTime.Now;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCPF.Checked)
            {
                txtIdentidade.Mask = "999,999,999-99";
                txtIdentidade.Size = new Size(80, 20);
            }
            else
            {
                txtIdentidade.Mask = "99,999,999/9999-99";
                txtIdentidade.Size = new Size(105, 20);
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
			try
			{
				DateTime datainfo = DateTime.Now;
				Clientes clientes = new Clientes(txtNome.Text, txtTelefone.Text, txtEmail.Text, txtEndereco.Text, txtBairro.Text, txtIdentidade.Text, txtCelular.Text, datainfo, dtpDataNascimento.Value, decimal.Parse(txtGastos.Text));
				ClienteTableAdapter cta = new ClienteTableAdapter();
				cta.Insert(clientes.NomeCliente, clientes.TelefoneCliente,
					clientes.EmailCliente, clientes.EnderecoCliente, clientes.BairroCliente,
					clientes.IdentidadeCliente, clientes.CelularCliente, clientes.NascCliente.ToString(), clientes.PagamentosCliente, clientes.DataInfo);
				TableRefresh();
			}catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
        }
        private void TableRefresh()
        {
            clienteTableAdapter.Fill(this.dsPrincipal.Cliente);
            dgvBancoForm.Refresh();
        }

    }
}
