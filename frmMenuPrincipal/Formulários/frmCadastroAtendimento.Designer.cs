namespace frmMenuPrincipal.Formulários
{
	partial class frmCadastroAtendimento
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
            System.Windows.Forms.Label lblIdAtendimento;
            System.Windows.Forms.Label lblPrecoAtendimento;
            this.pnlDataGridView = new System.Windows.Forms.Panel();
            this.dgvAtendimento = new System.Windows.Forms.DataGridView();
            this.idAtendimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idServicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoAtendimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAtendimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atendimentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrincipal = new frmMenuPrincipal.Dados.dsPrincipal();
            this.btnLimparCampos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnConfirmar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlBotaoConfirmar = new System.Windows.Forms.Panel();
            this.pnlCampos = new System.Windows.Forms.Panel();
            this.lblServico = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.pnlServicos = new System.Windows.Forms.Panel();
            this.dgvServico = new System.Windows.Forms.DataGridView();
            this.idServicoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeServicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoServicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlProdutos = new System.Windows.Forms.Panel();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPreço = new System.Windows.Forms.TextBox();
            this.pnlBotaoLimparCampos = new System.Windows.Forms.Panel();
            this.atendimentoTableAdapter = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.AtendimentoTableAdapter();
            this.tableAdapterManager = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.TableAdapterManager();
            this.produtoTableAdapter = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.ProdutoTableAdapter();
            this.servicoTableAdapter = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.ServicoTableAdapter();
            lblIdAtendimento = new System.Windows.Forms.Label();
            lblPrecoAtendimento = new System.Windows.Forms.Label();
            this.pnlDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atendimentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            this.pnlBotaoConfirmar.SuspendLayout();
            this.pnlCampos.SuspendLayout();
            this.pnlServicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            this.pnlProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.pnlBotaoLimparCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdAtendimento
            // 
            lblIdAtendimento.AutoSize = true;
            lblIdAtendimento.Location = new System.Drawing.Point(23, 15);
            lblIdAtendimento.Name = "lblIdAtendimento";
            lblIdAtendimento.Size = new System.Drawing.Size(81, 13);
            lblIdAtendimento.TabIndex = 0;
            lblIdAtendimento.Text = "Id Atendimento:";
            // 
            // lblPrecoAtendimento
            // 
            lblPrecoAtendimento.AutoSize = true;
            lblPrecoAtendimento.Location = new System.Drawing.Point(41, 283);
            lblPrecoAtendimento.Name = "lblPrecoAtendimento";
            lblPrecoAtendimento.Size = new System.Drawing.Size(100, 13);
            lblPrecoAtendimento.TabIndex = 6;
            lblPrecoAtendimento.Text = "Preço Atendimento:";
            // 
            // pnlDataGridView
            // 
            this.pnlDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDataGridView.Controls.Add(this.dgvAtendimento);
            this.pnlDataGridView.Location = new System.Drawing.Point(20, 370);
            this.pnlDataGridView.Name = "pnlDataGridView";
            this.pnlDataGridView.Size = new System.Drawing.Size(924, 248);
            this.pnlDataGridView.TabIndex = 7;
            // 
            // dgvAtendimento
            // 
            this.dgvAtendimento.AllowUserToAddRows = false;
            this.dgvAtendimento.AutoGenerateColumns = false;
            this.dgvAtendimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtendimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAtendimentoDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.idServicoDataGridViewTextBoxColumn,
            this.precoAtendimentoDataGridViewTextBoxColumn,
            this.dataAtendimentoDataGridViewTextBoxColumn});
            this.dgvAtendimento.DataSource = this.atendimentoBindingSource;
            this.dgvAtendimento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAtendimento.Location = new System.Drawing.Point(0, 0);
            this.dgvAtendimento.Name = "dgvAtendimento";
            this.dgvAtendimento.ReadOnly = true;
            this.dgvAtendimento.Size = new System.Drawing.Size(924, 248);
            this.dgvAtendimento.TabIndex = 0;
            // 
            // idAtendimentoDataGridViewTextBoxColumn
            // 
            this.idAtendimentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idAtendimentoDataGridViewTextBoxColumn.DataPropertyName = "idAtendimento";
            this.idAtendimentoDataGridViewTextBoxColumn.HeaderText = "Id do Atendimento";
            this.idAtendimentoDataGridViewTextBoxColumn.Name = "idAtendimentoDataGridViewTextBoxColumn";
            this.idAtendimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "Id do Cliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idServicoDataGridViewTextBoxColumn
            // 
            this.idServicoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idServicoDataGridViewTextBoxColumn.DataPropertyName = "idServico";
            this.idServicoDataGridViewTextBoxColumn.HeaderText = "Id do Serviço";
            this.idServicoDataGridViewTextBoxColumn.Name = "idServicoDataGridViewTextBoxColumn";
            this.idServicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precoAtendimentoDataGridViewTextBoxColumn
            // 
            this.precoAtendimentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.precoAtendimentoDataGridViewTextBoxColumn.DataPropertyName = "precoAtendimento";
            this.precoAtendimentoDataGridViewTextBoxColumn.HeaderText = "Total";
            this.precoAtendimentoDataGridViewTextBoxColumn.Name = "precoAtendimentoDataGridViewTextBoxColumn";
            this.precoAtendimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataAtendimentoDataGridViewTextBoxColumn
            // 
            this.dataAtendimentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataAtendimentoDataGridViewTextBoxColumn.DataPropertyName = "dataAtendimento";
            this.dataAtendimentoDataGridViewTextBoxColumn.HeaderText = "Data do atendimento";
            this.dataAtendimentoDataGridViewTextBoxColumn.Name = "dataAtendimentoDataGridViewTextBoxColumn";
            this.dataAtendimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // atendimentoBindingSource
            // 
            this.atendimentoBindingSource.DataMember = "Atendimento";
            this.atendimentoBindingSource.DataSource = this.dsPrincipal;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Depth = 0;
            this.btnLimparCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLimparCampos.Location = new System.Drawing.Point(0, 0);
            this.btnLimparCampos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Primary = true;
            this.btnLimparCampos.Size = new System.Drawing.Size(126, 36);
            this.btnLimparCampos.TabIndex = 3;
            this.btnLimparCampos.Text = "Limpar Campos";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Depth = 0;
            this.btnConfirmar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfirmar.Location = new System.Drawing.Point(0, 0);
            this.btnConfirmar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Primary = true;
            this.btnConfirmar.Size = new System.Drawing.Size(122, 32);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // pnlBotaoConfirmar
            // 
            this.pnlBotaoConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBotaoConfirmar.Controls.Add(this.btnConfirmar);
            this.pnlBotaoConfirmar.Location = new System.Drawing.Point(822, 328);
            this.pnlBotaoConfirmar.Name = "pnlBotaoConfirmar";
            this.pnlBotaoConfirmar.Size = new System.Drawing.Size(122, 32);
            this.pnlBotaoConfirmar.TabIndex = 10;
            // 
            // pnlCampos
            // 
            this.pnlCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCampos.Controls.Add(this.lblServico);
            this.pnlCampos.Controls.Add(this.lblProduto);
            this.pnlCampos.Controls.Add(this.pnlServicos);
            this.pnlCampos.Controls.Add(this.pnlProdutos);
            this.pnlCampos.Controls.Add(lblIdAtendimento);
            this.pnlCampos.Controls.Add(this.txtId);
            this.pnlCampos.Controls.Add(lblPrecoAtendimento);
            this.pnlCampos.Controls.Add(this.txtPreço);
            this.pnlCampos.Location = new System.Drawing.Point(20, 12);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(924, 310);
            this.pnlCampos.TabIndex = 9;
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Location = new System.Drawing.Point(669, 49);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(48, 13);
            this.lblServico.TabIndex = 11;
            this.lblServico.Text = "Serviços";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(205, 49);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(49, 13);
            this.lblProduto.TabIndex = 10;
            this.lblProduto.Text = "Produtos";
            // 
            // pnlServicos
            // 
            this.pnlServicos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlServicos.Controls.Add(this.dgvServico);
            this.pnlServicos.Location = new System.Drawing.Point(465, 65);
            this.pnlServicos.Name = "pnlServicos";
            this.pnlServicos.Size = new System.Drawing.Size(424, 203);
            this.pnlServicos.TabIndex = 9;
            // 
            // dgvServico
            // 
            this.dgvServico.AllowUserToAddRows = false;
            this.dgvServico.AllowUserToDeleteRows = false;
            this.dgvServico.AutoGenerateColumns = false;
            this.dgvServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idServicoDataGridViewTextBoxColumn1,
            this.nomeServicoDataGridViewTextBoxColumn,
            this.precoServicoDataGridViewTextBoxColumn});
            this.dgvServico.DataSource = this.servicoBindingSource;
            this.dgvServico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServico.Location = new System.Drawing.Point(0, 0);
            this.dgvServico.Name = "dgvServico";
            this.dgvServico.ReadOnly = true;
            this.dgvServico.Size = new System.Drawing.Size(424, 203);
            this.dgvServico.TabIndex = 1;
            // 
            // idServicoDataGridViewTextBoxColumn1
            // 
            this.idServicoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idServicoDataGridViewTextBoxColumn1.DataPropertyName = "idServico";
            this.idServicoDataGridViewTextBoxColumn1.HeaderText = "Id do Serviço";
            this.idServicoDataGridViewTextBoxColumn1.Name = "idServicoDataGridViewTextBoxColumn1";
            this.idServicoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idServicoDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nomeServicoDataGridViewTextBoxColumn
            // 
            this.nomeServicoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeServicoDataGridViewTextBoxColumn.DataPropertyName = "nomeServico";
            this.nomeServicoDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeServicoDataGridViewTextBoxColumn.Name = "nomeServicoDataGridViewTextBoxColumn";
            this.nomeServicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeServicoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // precoServicoDataGridViewTextBoxColumn
            // 
            this.precoServicoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.precoServicoDataGridViewTextBoxColumn.DataPropertyName = "precoServico";
            this.precoServicoDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.precoServicoDataGridViewTextBoxColumn.Name = "precoServicoDataGridViewTextBoxColumn";
            this.precoServicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.precoServicoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataMember = "Servico";
            this.servicoBindingSource.DataSource = this.dsPrincipal;
            // 
            // pnlProdutos
            // 
            this.pnlProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlProdutos.Controls.Add(this.dgvProduto);
            this.pnlProdutos.Location = new System.Drawing.Point(35, 65);
            this.pnlProdutos.Name = "pnlProdutos";
            this.pnlProdutos.Size = new System.Drawing.Size(424, 203);
            this.pnlProdutos.TabIndex = 8;
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.AutoGenerateColumns = false;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdutoDataGridViewTextBoxColumn,
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.estoqueProdutoDataGridViewTextBoxColumn});
            this.dgvProduto.DataSource = this.produtoBindingSource;
            this.dgvProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduto.Location = new System.Drawing.Point(0, 0);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.Size = new System.Drawing.Size(424, 203);
            this.dgvProduto.TabIndex = 0;
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "IdProduto";
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "Id do produto";
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            this.idProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProdutoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "nomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            this.nomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeProdutoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // estoqueProdutoDataGridViewTextBoxColumn
            // 
            this.estoqueProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estoqueProdutoDataGridViewTextBoxColumn.DataPropertyName = "estoqueProduto";
            this.estoqueProdutoDataGridViewTextBoxColumn.HeaderText = "Estoque";
            this.estoqueProdutoDataGridViewTextBoxColumn.Name = "estoqueProdutoDataGridViewTextBoxColumn";
            this.estoqueProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estoqueProdutoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.dsPrincipal;
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.atendimentoBindingSource, "idAtendimento", true));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(128, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(789, 20);
            this.txtId.TabIndex = 1;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPreço
            // 
            this.txtPreço.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.atendimentoBindingSource, "precoAtendimento", true));
            this.txtPreço.Location = new System.Drawing.Point(146, 279);
            this.txtPreço.Name = "txtPreço";
            this.txtPreço.Size = new System.Drawing.Size(754, 20);
            this.txtPreço.TabIndex = 7;
            // 
            // pnlBotaoLimparCampos
            // 
            this.pnlBotaoLimparCampos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBotaoLimparCampos.Controls.Add(this.btnLimparCampos);
            this.pnlBotaoLimparCampos.Location = new System.Drawing.Point(20, 328);
            this.pnlBotaoLimparCampos.Name = "pnlBotaoLimparCampos";
            this.pnlBotaoLimparCampos.Size = new System.Drawing.Size(126, 36);
            this.pnlBotaoLimparCampos.TabIndex = 8;
            // 
            // atendimentoTableAdapter
            // 
            this.atendimentoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AtendimentoTableAdapter = this.atendimentoTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarroTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.FornecedorTableAdapter = null;
            this.tableAdapterManager.FornecimentoTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.Produtos_AtendimentoTableAdapter = null;
            this.tableAdapterManager.Produtos_FornecimentoTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.Serviços_AtendimentoTableAdapter = null;
            this.tableAdapterManager.ServicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = frmMenuPrincipal.Dados.dsPrincipalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // servicoTableAdapter
            // 
            this.servicoTableAdapter.ClearBeforeFill = true;
            // 
            // frmCadastroAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 649);
            this.ControlBox = false;
            this.Controls.Add(this.pnlDataGridView);
            this.Controls.Add(this.pnlBotaoConfirmar);
            this.Controls.Add(this.pnlCampos);
            this.Controls.Add(this.pnlBotaoLimparCampos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastroAtendimento";
            this.Text = "frmCadastroAtendimento";
            this.Load += new System.EventHandler(this.frmCadastroAtendimento_Load);
            this.pnlDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atendimentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            this.pnlBotaoConfirmar.ResumeLayout(false);
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
            this.pnlServicos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            this.pnlProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.pnlBotaoLimparCampos.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlDataGridView;
		public System.Windows.Forms.DataGridView dgvAtendimento;
		public MaterialSkin.Controls.MaterialRaisedButton btnLimparCampos;
		public MaterialSkin.Controls.MaterialRaisedButton btnConfirmar;
		public System.Windows.Forms.Panel pnlBotaoConfirmar;
		public System.Windows.Forms.Panel pnlCampos;
		public System.Windows.Forms.Panel pnlBotaoLimparCampos;
		private Dados.dsPrincipal dsPrincipal;
		private System.Windows.Forms.BindingSource atendimentoBindingSource;
		private Dados.dsPrincipalTableAdapters.AtendimentoTableAdapter atendimentoTableAdapter;
		private Dados.dsPrincipalTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.TextBox txtPreço;
		private System.Windows.Forms.DataGridViewTextBoxColumn idAtendimentoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idServicoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn precoAtendimentoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataAtendimentoDataGridViewTextBoxColumn;
		private System.Windows.Forms.Panel pnlServicos;
		private System.Windows.Forms.DataGridView dgvServico;
		private System.Windows.Forms.Panel pnlProdutos;
		private System.Windows.Forms.DataGridView dgvProduto;
		private System.Windows.Forms.BindingSource produtoBindingSource;
		private Dados.dsPrincipalTableAdapters.ProdutoTableAdapter produtoTableAdapter;
		private System.Windows.Forms.BindingSource servicoBindingSource;
		private Dados.dsPrincipalTableAdapters.ServicoTableAdapter servicoTableAdapter;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServicoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeServicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoServicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueProdutoDataGridViewTextBoxColumn;
    }
}