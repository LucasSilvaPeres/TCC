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
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgvBancoForm = new System.Windows.Forms.DataGridView();
			this.idAtendimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idServicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precoAtendimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataAtendimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.atendimentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dsPrincipal = new frmMenuPrincipal.Dados.dsPrincipal();
			this.btnLimparCampos = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnConfirmar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.panel4 = new System.Windows.Forms.Panel();
			this.pnlCampos = new System.Windows.Forms.Panel();
			this.pnlServicos = new System.Windows.Forms.Panel();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.idServicoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeServicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precoServicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pnlProdutos = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.estoqueProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.idAtendimentoTextBox = new System.Windows.Forms.TextBox();
			this.precoAtendimentoTextBox = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.atendimentoTableAdapter = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.AtendimentoTableAdapter();
			this.tableAdapterManager = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.TableAdapterManager();
			this.produtoTableAdapter = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.ProdutoTableAdapter();
			this.servicoTableAdapter = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.ServicoTableAdapter();
			lblIdAtendimento = new System.Windows.Forms.Label();
			lblPrecoAtendimento = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBancoForm)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.atendimentoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
			this.panel4.SuspendLayout();
			this.pnlCampos.SuspendLayout();
			this.pnlServicos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
			this.pnlProdutos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblIdAtendimento
			// 
			lblIdAtendimento.AutoSize = true;
			lblIdAtendimento.Location = new System.Drawing.Point(15, 15);
			lblIdAtendimento.Name = "lblIdAtendimento";
			lblIdAtendimento.Size = new System.Drawing.Size(81, 13);
			lblIdAtendimento.TabIndex = 0;
			lblIdAtendimento.Text = "Id Atendimento:";
			// 
			// lblPrecoAtendimento
			// 
			lblPrecoAtendimento.AutoSize = true;
			lblPrecoAtendimento.Location = new System.Drawing.Point(33, 267);
			lblPrecoAtendimento.Name = "lblPrecoAtendimento";
			lblPrecoAtendimento.Size = new System.Drawing.Size(100, 13);
			lblPrecoAtendimento.TabIndex = 6;
			lblPrecoAtendimento.Text = "Preço Atendimento:";
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel1.Controls.Add(this.dgvBancoForm);
			this.panel1.Location = new System.Drawing.Point(12, 352);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(924, 248);
			this.panel1.TabIndex = 7;
			// 
			// dgvBancoForm
			// 
			this.dgvBancoForm.AllowUserToAddRows = false;
			this.dgvBancoForm.AutoGenerateColumns = false;
			this.dgvBancoForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBancoForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAtendimentoDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.idServicoDataGridViewTextBoxColumn,
            this.precoAtendimentoDataGridViewTextBoxColumn,
            this.dataAtendimentoDataGridViewTextBoxColumn});
			this.dgvBancoForm.DataSource = this.atendimentoBindingSource;
			this.dgvBancoForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvBancoForm.Location = new System.Drawing.Point(0, 0);
			this.dgvBancoForm.Name = "dgvBancoForm";
			this.dgvBancoForm.ReadOnly = true;
			this.dgvBancoForm.Size = new System.Drawing.Size(924, 248);
			this.dgvBancoForm.TabIndex = 0;
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
			// panel4
			// 
			this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel4.Controls.Add(this.btnConfirmar);
			this.panel4.Location = new System.Drawing.Point(814, 310);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(122, 32);
			this.panel4.TabIndex = 10;
			// 
			// pnlCampos
			// 
			this.pnlCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlCampos.Controls.Add(this.pnlServicos);
			this.pnlCampos.Controls.Add(this.pnlProdutos);
			this.pnlCampos.Controls.Add(lblIdAtendimento);
			this.pnlCampos.Controls.Add(this.idAtendimentoTextBox);
			this.pnlCampos.Controls.Add(lblPrecoAtendimento);
			this.pnlCampos.Controls.Add(this.precoAtendimentoTextBox);
			this.pnlCampos.Location = new System.Drawing.Point(12, 12);
			this.pnlCampos.Name = "pnlCampos";
			this.pnlCampos.Size = new System.Drawing.Size(924, 292);
			this.pnlCampos.TabIndex = 9;
			// 
			// pnlServicos
			// 
			this.pnlServicos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlServicos.Controls.Add(this.dataGridView2);
			this.pnlServicos.Location = new System.Drawing.Point(465, 42);
			this.pnlServicos.Name = "pnlServicos";
			this.pnlServicos.Size = new System.Drawing.Size(424, 208);
			this.pnlServicos.TabIndex = 9;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idServicoDataGridViewTextBoxColumn1,
            this.nomeServicoDataGridViewTextBoxColumn,
            this.precoServicoDataGridViewTextBoxColumn});
			this.dataGridView2.DataSource = this.servicoBindingSource;
			this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView2.Location = new System.Drawing.Point(0, 0);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.Size = new System.Drawing.Size(424, 208);
			this.dataGridView2.TabIndex = 1;
			// 
			// idServicoDataGridViewTextBoxColumn1
			// 
			this.idServicoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.idServicoDataGridViewTextBoxColumn1.DataPropertyName = "idServico";
			this.idServicoDataGridViewTextBoxColumn1.HeaderText = "idServico";
			this.idServicoDataGridViewTextBoxColumn1.Name = "idServicoDataGridViewTextBoxColumn1";
			this.idServicoDataGridViewTextBoxColumn1.ReadOnly = true;
			this.idServicoDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// nomeServicoDataGridViewTextBoxColumn
			// 
			this.nomeServicoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.nomeServicoDataGridViewTextBoxColumn.DataPropertyName = "nomeServico";
			this.nomeServicoDataGridViewTextBoxColumn.HeaderText = "nomeServico";
			this.nomeServicoDataGridViewTextBoxColumn.Name = "nomeServicoDataGridViewTextBoxColumn";
			this.nomeServicoDataGridViewTextBoxColumn.ReadOnly = true;
			this.nomeServicoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// precoServicoDataGridViewTextBoxColumn
			// 
			this.precoServicoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.precoServicoDataGridViewTextBoxColumn.DataPropertyName = "precoServico";
			this.precoServicoDataGridViewTextBoxColumn.HeaderText = "precoServico";
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
			this.pnlProdutos.Controls.Add(this.dataGridView1);
			this.pnlProdutos.Location = new System.Drawing.Point(35, 42);
			this.pnlProdutos.Name = "pnlProdutos";
			this.pnlProdutos.Size = new System.Drawing.Size(424, 208);
			this.pnlProdutos.TabIndex = 8;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdutoDataGridViewTextBoxColumn,
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.estoqueProdutoDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.produtoBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(424, 208);
			this.dataGridView1.TabIndex = 0;
			// 
			// idProdutoDataGridViewTextBoxColumn
			// 
			this.idProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "IdProduto";
			this.idProdutoDataGridViewTextBoxColumn.HeaderText = "IdProduto";
			this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
			this.idProdutoDataGridViewTextBoxColumn.ReadOnly = true;
			this.idProdutoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// nomeProdutoDataGridViewTextBoxColumn
			// 
			this.nomeProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "nomeProduto";
			this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "nomeProduto";
			this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
			this.nomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
			this.nomeProdutoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// estoqueProdutoDataGridViewTextBoxColumn
			// 
			this.estoqueProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.estoqueProdutoDataGridViewTextBoxColumn.DataPropertyName = "estoqueProduto";
			this.estoqueProdutoDataGridViewTextBoxColumn.HeaderText = "estoqueProduto";
			this.estoqueProdutoDataGridViewTextBoxColumn.Name = "estoqueProdutoDataGridViewTextBoxColumn";
			this.estoqueProdutoDataGridViewTextBoxColumn.ReadOnly = true;
			this.estoqueProdutoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// produtoBindingSource
			// 
			this.produtoBindingSource.DataMember = "Produto";
			this.produtoBindingSource.DataSource = this.dsPrincipal;
			// 
			// idAtendimentoTextBox
			// 
			this.idAtendimentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.atendimentoBindingSource, "idAtendimento", true));
			this.idAtendimentoTextBox.Enabled = false;
			this.idAtendimentoTextBox.Location = new System.Drawing.Point(120, 12);
			this.idAtendimentoTextBox.Name = "idAtendimentoTextBox";
			this.idAtendimentoTextBox.Size = new System.Drawing.Size(789, 20);
			this.idAtendimentoTextBox.TabIndex = 1;
			this.idAtendimentoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// precoAtendimentoTextBox
			// 
			this.precoAtendimentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.atendimentoBindingSource, "precoAtendimento", true));
			this.precoAtendimentoTextBox.Location = new System.Drawing.Point(138, 263);
			this.precoAtendimentoTextBox.Name = "precoAtendimentoTextBox";
			this.precoAtendimentoTextBox.Size = new System.Drawing.Size(754, 20);
			this.precoAtendimentoTextBox.TabIndex = 7;
			// 
			// panel2
			// 
			this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel2.Controls.Add(this.btnLimparCampos);
			this.panel2.Location = new System.Drawing.Point(12, 310);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(126, 36);
			this.panel2.TabIndex = 8;
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
			this.ClientSize = new System.Drawing.Size(948, 612);
			this.ControlBox = false;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.pnlCampos);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmCadastroAtendimento";
			this.Text = "frmCadastroAtendimento";
			this.Load += new System.EventHandler(this.frmCadastroAtendimento_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvBancoForm)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.atendimentoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
			this.panel4.ResumeLayout(false);
			this.pnlCampos.ResumeLayout(false);
			this.pnlCampos.PerformLayout();
			this.pnlServicos.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
			this.pnlProdutos.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.DataGridView dgvBancoForm;
		public MaterialSkin.Controls.MaterialRaisedButton btnLimparCampos;
		public MaterialSkin.Controls.MaterialRaisedButton btnConfirmar;
		public System.Windows.Forms.Panel panel4;
		public System.Windows.Forms.Panel pnlCampos;
		public System.Windows.Forms.Panel panel2;
		private Dados.dsPrincipal dsPrincipal;
		private System.Windows.Forms.BindingSource atendimentoBindingSource;
		private Dados.dsPrincipalTableAdapters.AtendimentoTableAdapter atendimentoTableAdapter;
		private Dados.dsPrincipalTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.TextBox idAtendimentoTextBox;
		private System.Windows.Forms.TextBox precoAtendimentoTextBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn idAtendimentoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idServicoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn precoAtendimentoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataAtendimentoDataGridViewTextBoxColumn;
		private System.Windows.Forms.Panel pnlServicos;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Panel pnlProdutos;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource produtoBindingSource;
		private Dados.dsPrincipalTableAdapters.ProdutoTableAdapter produtoTableAdapter;
		private System.Windows.Forms.BindingSource servicoBindingSource;
		private Dados.dsPrincipalTableAdapters.ServicoTableAdapter servicoTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idServicoDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeServicoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn precoServicoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn estoqueProdutoDataGridViewTextBoxColumn;
	}
}