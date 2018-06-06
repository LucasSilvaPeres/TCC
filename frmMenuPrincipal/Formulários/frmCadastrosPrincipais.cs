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
    public partial class frmCadPrincipais : Form
    {
        public frmCadPrincipais()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (tcPrincipal.Visible != true)
            {
                tcPrincipal.Visible = true;
            }
            tpLista.Text = "Clientes";

        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            if (tcPrincipal.Visible != true)
            {
                tcPrincipal.Visible = true;
            }
            tpLista.Text = "Funcionários";
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            if (tcPrincipal.Visible != true)
            {
                tcPrincipal.Visible = true;
            }
            tpLista.Text = "Fornecedores";
        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            if (tcPrincipal.Visible != true)
            {
                tcPrincipal.Visible = true;
            }
            tpLista.Text = "Serviços";
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            if (tcPrincipal.Visible != true)
            {
                tcPrincipal.Visible = true;
            }
            tpLista.Text = "Produtos";
        }

        private void btnConfirmarCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void tcPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tpLista.Text)
            {
                #region Cliente
                case "Clientes":
                    //
                    lblCad1.Text = "CPF/RG";
                    lblCad2.Text = "Telefone";
                    lblCad3.Text = "Celular";
                    lblCad4.Text = "E-mail";
                    lblCad5.Text = "Endereço";
                    lblCad6.Text = "Bairro";
                    //
                    lblEd1.Text = "CPF/RG";
                    lblEd2.Text = "Telefone";
                    lblEd3.Text = "Celular";
                    lblEd4.Text = "E-mail";
                    lblEd5.Text = "Endereço";
                    lblEd6.Text = "Bairro";
                    //

                    break;
                #endregion
                #region Funcionario
                case "Funcionários":
                    //
                    lblCad1.Text = "CPF/RG";
                    lblCad2.Text = "Telefone";
                    lblCad3.Text = "Celular";
                    lblCad4.Text = "Endereço";
                    lblCad5.Text = "Bairro";
                    lblCad6.Text = "Pagamento";
                    //
                    lblEd1.Text = "CPF/RG";
                    lblEd2.Text = "Telefone";
                    lblEd3.Text = "Celular";
                    lblEd4.Text = "Endereço";
                    lblEd5.Text = "Bairro";
                    lblEd6.Text = "Pagamento";
                    //


                    break;
                #endregion
                #region Fornecedor
                case "Fornecedor":
                    //
                    lblCad1.Text = "CNPJ";
                    lblCad2.Text = "Telefone";
                    lblCad3.Text = "Endereço";
                    lblCad4.Text = "Bairro";
                    lblCad5.Text = "Pagamento";
                    lblCad6.Visible = false;
                    //
                    lblEd1.Text = "CPF/RG";
                    lblEd2.Text = "Telefone";
                    lblEd3.Text = "Endereço";
                    lblEd4.Text = "Bairro";
                    lblEd5.Text = "Pagamento";
                    lblEd6.Visible = false;
                    //


                    break;
                #endregion
                #region Serviço
                case "Serviços":
                    //
                    lblEd1.Text = "Preço";
                    lblEd2.Visible = false;
                    lblEd3.Visible = false;
                    lblEd4.Visible = false;
                    lblEd5.Visible = false;
                    lblEd6.Visible = false;
                    //
                    lblCad1.Text = "Preço";
                    lblCad2.Visible = false;
                    lblCad3.Visible = false;
                    lblCad4.Visible = false;
                    lblCad5.Visible = false;
                    lblCad6.Visible = false;
                    //

                    break;
                #endregion
                #region Produto
                case "Produtos":
                    //
                    lblCad1.Text = "Nome do Fornecedor:";
                    lblCad2.Text = "Quantidade em estoque:";
                    lblCad3.Visible = false;
                    lblCad4.Visible = false;
                    lblCad5.Visible = false;
                    lblCad6.Visible = false;
                    //
                    lblEd1.Text = "Nome do Fornecedor:";
                    lblEd2.Text = "Quantidade em estoque:";
                    lblEd3.Visible = false;
                    lblEd4.Visible = false;
                    lblEd5.Visible = false;
                    lblEd6.Visible = false;
                    //

                    break;
                #endregion
                #region Default
                default:
                    break;
                    #endregion
            }
        }

        private void frmCadastros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPrincipal.Serviços_Atendimento' table. You can move, or remove it, as needed.
            this.serviços_AtendimentoTableAdapter.Fill(this.dsPrincipal.Serviços_Atendimento);
            WindowState = FormWindowState.Maximized;


        }
    }
}
