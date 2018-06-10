namespace frmMenuPrincipal.Formulários
{
    partial class frmCadPrincipais
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.serviçosAtendimentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dsPrincipal = new frmMenuPrincipal.Dados.dsPrincipal();
			this.serviços_AtendimentoTableAdapter = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.Serviços_AtendimentoTableAdapter();
			this.pnlBotões = new System.Windows.Forms.Panel();
			this.btnFrmFornecimento = new System.Windows.Forms.Button();
			this.btnProduto = new System.Windows.Forms.Button();
			this.btnCliente = new System.Windows.Forms.Button();
			this.btnServico = new System.Windows.Forms.Button();
			this.btnFuncionario = new System.Windows.Forms.Button();
			this.btnFornecedor = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.serviçosAtendimentoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
			this.pnlBotões.SuspendLayout();
			this.SuspendLayout();
			// 
			// serviçosAtendimentoBindingSource
			// 
			this.serviçosAtendimentoBindingSource.DataMember = "Serviços_Atendimento";
			this.serviçosAtendimentoBindingSource.DataSource = this.dsPrincipal;
			// 
			// dsPrincipal
			// 
			this.dsPrincipal.DataSetName = "dsPrincipal";
			this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// serviços_AtendimentoTableAdapter
			// 
			this.serviços_AtendimentoTableAdapter.ClearBeforeFill = true;
			// 
			// pnlBotões
			// 
			this.pnlBotões.BackColor = System.Drawing.Color.Navy;
			this.pnlBotões.Controls.Add(this.btnFrmFornecimento);
			this.pnlBotões.Controls.Add(this.btnProduto);
			this.pnlBotões.Controls.Add(this.btnCliente);
			this.pnlBotões.Controls.Add(this.btnServico);
			this.pnlBotões.Controls.Add(this.btnFuncionario);
			this.pnlBotões.Controls.Add(this.btnFornecedor);
			this.pnlBotões.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlBotões.Location = new System.Drawing.Point(0, 0);
			this.pnlBotões.Name = "pnlBotões";
			this.pnlBotões.Size = new System.Drawing.Size(1023, 491);
			this.pnlBotões.TabIndex = 7;
			// 
			// btnFrmFornecimento
			// 
			this.btnFrmFornecimento.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnFrmFornecimento.BackColor = System.Drawing.Color.LightSlateGray;
			this.btnFrmFornecimento.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFrmFornecimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFrmFornecimento.Location = new System.Drawing.Point(646, 244);
			this.btnFrmFornecimento.Name = "btnFrmFornecimento";
			this.btnFrmFornecimento.Size = new System.Drawing.Size(258, 153);
			this.btnFrmFornecimento.TabIndex = 6;
			this.btnFrmFornecimento.Text = "FORNECIMENTO";
			this.btnFrmFornecimento.UseVisualStyleBackColor = false;
			// 
			// btnProduto
			// 
			this.btnProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnProduto.BackColor = System.Drawing.Color.LightSlateGray;
			this.btnProduto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProduto.Location = new System.Drawing.Point(382, 244);
			this.btnProduto.Name = "btnProduto";
			this.btnProduto.Size = new System.Drawing.Size(258, 153);
			this.btnProduto.TabIndex = 5;
			this.btnProduto.Text = "PRODUTO";
			this.btnProduto.UseVisualStyleBackColor = false;
			// 
			// btnCliente
			// 
			this.btnCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnCliente.BackColor = System.Drawing.Color.LightSlateGray;
			this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCliente.Location = new System.Drawing.Point(118, 85);
			this.btnCliente.Name = "btnCliente";
			this.btnCliente.Size = new System.Drawing.Size(258, 153);
			this.btnCliente.TabIndex = 0;
			this.btnCliente.Text = "CADASTRAR CLIENTES";
			this.btnCliente.UseVisualStyleBackColor = false;
			// 
			// btnServico
			// 
			this.btnServico.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnServico.BackColor = System.Drawing.Color.LightSlateGray;
			this.btnServico.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnServico.Location = new System.Drawing.Point(382, 85);
			this.btnServico.Name = "btnServico";
			this.btnServico.Size = new System.Drawing.Size(258, 153);
			this.btnServico.TabIndex = 4;
			this.btnServico.Text = "SERVIÇO";
			this.btnServico.UseVisualStyleBackColor = false;
			// 
			// btnFuncionario
			// 
			this.btnFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnFuncionario.BackColor = System.Drawing.Color.LightSlateGray;
			this.btnFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFuncionario.Location = new System.Drawing.Point(118, 244);
			this.btnFuncionario.Name = "btnFuncionario";
			this.btnFuncionario.Size = new System.Drawing.Size(258, 153);
			this.btnFuncionario.TabIndex = 1;
			this.btnFuncionario.Text = "CADASTRAR FUNCIONÁRIOS";
			this.btnFuncionario.UseVisualStyleBackColor = false;
			// 
			// btnFornecedor
			// 
			this.btnFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnFornecedor.BackColor = System.Drawing.Color.LightSlateGray;
			this.btnFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFornecedor.Location = new System.Drawing.Point(646, 85);
			this.btnFornecedor.Name = "btnFornecedor";
			this.btnFornecedor.Size = new System.Drawing.Size(258, 153);
			this.btnFornecedor.TabIndex = 3;
			this.btnFornecedor.Text = "FORNECEDOR";
			this.btnFornecedor.UseVisualStyleBackColor = false;
			// 
			// frmCadPrincipais
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1023, 491);
			this.ControlBox = false;
			this.Controls.Add(this.pnlBotões);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmCadPrincipais";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmCadastros";
			this.Load += new System.EventHandler(this.frmCadastros_Load);
			((System.ComponentModel.ISupportInitialize)(this.serviçosAtendimentoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
			this.pnlBotões.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private Dados.dsPrincipal dsPrincipal;
        private System.Windows.Forms.BindingSource serviçosAtendimentoBindingSource;
        private Dados.dsPrincipalTableAdapters.Serviços_AtendimentoTableAdapter serviços_AtendimentoTableAdapter;
		private System.Windows.Forms.Panel pnlBotões;
		private System.Windows.Forms.Button btnFrmFornecimento;
		private System.Windows.Forms.Button btnProduto;
		private System.Windows.Forms.Button btnCliente;
		private System.Windows.Forms.Button btnServico;
		private System.Windows.Forms.Button btnFuncionario;
		private System.Windows.Forms.Button btnFornecedor;
	}
}