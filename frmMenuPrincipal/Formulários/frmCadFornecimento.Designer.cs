namespace frmMenuPrincipal.Formulários
{
    partial class frmCadFornecimento
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
			System.Windows.Forms.Label lblId;
			System.Windows.Forms.Label lblFornecedor;
			System.Windows.Forms.Label lblDataFornecimento;
			System.Windows.Forms.Label lblProduto;
			System.Windows.Forms.Label lblQuantidadeProduto;
			this.dsPrincipal = new frmMenuPrincipal.Dados.dsPrincipal();
			this.fornecimentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.fornecimentoTableAdapter = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.FornecimentoTableAdapter();
			this.tableAdapterManager = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.TableAdapterManager();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgvFornecimento = new System.Windows.Forms.DataGridView();
			this.idFornecimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataFornecimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnLimparCampos = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnConfirmar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.pnlBotaoConfirmar = new System.Windows.Forms.Panel();
			this.pnlCampos = new System.Windows.Forms.Panel();
			this.txtProduto = new System.Windows.Forms.TextBox();
			this.txtQuantidade = new System.Windows.Forms.TextBox();
			this.txtIdFornecimento = new System.Windows.Forms.TextBox();
			this.txtIdFornecedor = new System.Windows.Forms.TextBox();
			this.dtpDataFornecimento = new System.Windows.Forms.DateTimePicker();
			this.produtos_FornecimentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pnlBotaoLimparCampos = new System.Windows.Forms.Panel();
			this.produtos_FornecimentoTableAdapter = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.Produtos_FornecimentoTableAdapter();
			this.pnlDgvFornecedor = new System.Windows.Forms.Panel();
			this.dgvProduto = new System.Windows.Forms.DataGridView();
			this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.produtoTableAdapter = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.ProdutoTableAdapter();
			this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idFornecedorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.estoqueProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pnlCadProduto = new System.Windows.Forms.Panel();
			this.txtCadProduto = new MaterialSkin.Controls.MaterialRaisedButton();
			lblId = new System.Windows.Forms.Label();
			lblFornecedor = new System.Windows.Forms.Label();
			lblDataFornecimento = new System.Windows.Forms.Label();
			lblProduto = new System.Windows.Forms.Label();
			lblQuantidadeProduto = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fornecimentoBindingSource)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFornecimento)).BeginInit();
			this.pnlBotaoConfirmar.SuspendLayout();
			this.pnlCampos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.produtos_FornecimentoBindingSource)).BeginInit();
			this.pnlBotaoLimparCampos.SuspendLayout();
			this.pnlDgvFornecedor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
			this.pnlCadProduto.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblId
			// 
			lblId.AutoSize = true;
			lblId.Location = new System.Drawing.Point(21, 19);
			lblId.Name = "lblId";
			lblId.Size = new System.Drawing.Size(83, 13);
			lblId.TabIndex = 0;
			lblId.Text = "Id Fornecimento";
			// 
			// lblFornecedor
			// 
			lblFornecedor.AutoSize = true;
			lblFornecedor.Location = new System.Drawing.Point(157, 151);
			lblFornecedor.Name = "lblFornecedor";
			lblFornecedor.Size = new System.Drawing.Size(61, 13);
			lblFornecedor.TabIndex = 2;
			lblFornecedor.Text = "Fornecedor";
			// 
			// lblDataFornecimento
			// 
			lblDataFornecimento.AutoSize = true;
			lblDataFornecimento.Location = new System.Drawing.Point(157, 203);
			lblDataFornecimento.Name = "lblDataFornecimento";
			lblDataFornecimento.Size = new System.Drawing.Size(109, 13);
			lblDataFornecimento.TabIndex = 4;
			lblDataFornecimento.Text = "Data do fornecimento";
			// 
			// lblProduto
			// 
			lblProduto.AutoSize = true;
			lblProduto.Location = new System.Drawing.Point(586, 151);
			lblProduto.Name = "lblProduto";
			lblProduto.Size = new System.Drawing.Size(44, 13);
			lblProduto.TabIndex = 8;
			lblProduto.Text = "Produto";
			// 
			// lblQuantidadeProduto
			// 
			lblQuantidadeProduto.AutoSize = true;
			lblQuantidadeProduto.Location = new System.Drawing.Point(586, 203);
			lblQuantidadeProduto.Name = "lblQuantidadeProduto";
			lblQuantidadeProduto.Size = new System.Drawing.Size(62, 13);
			lblQuantidadeProduto.TabIndex = 12;
			lblQuantidadeProduto.Text = "Quantidade";
			// 
			// dsPrincipal
			// 
			this.dsPrincipal.DataSetName = "dsPrincipal";
			this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// fornecimentoBindingSource
			// 
			this.fornecimentoBindingSource.DataMember = "Fornecimento";
			this.fornecimentoBindingSource.DataSource = this.dsPrincipal;
			// 
			// fornecimentoTableAdapter
			// 
			this.fornecimentoTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.AtendimentoTableAdapter = null;
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CarroTableAdapter = null;
			this.tableAdapterManager.ClienteTableAdapter = null;
			this.tableAdapterManager.FornecedorTableAdapter = null;
			this.tableAdapterManager.FornecimentoTableAdapter = this.fornecimentoTableAdapter;
			this.tableAdapterManager.FuncionarioTableAdapter = null;
			this.tableAdapterManager.Produtos_AtendimentoTableAdapter = null;
			this.tableAdapterManager.Produtos_FornecimentoTableAdapter = null;
			this.tableAdapterManager.ProdutoTableAdapter = null;
			this.tableAdapterManager.Serviços_AtendimentoTableAdapter = null;
			this.tableAdapterManager.ServicoTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = frmMenuPrincipal.Dados.dsPrincipalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.dgvFornecimento);
			this.panel1.Location = new System.Drawing.Point(12, 372);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(465, 265);
			this.panel1.TabIndex = 7;
			// 
			// dgvFornecimento
			// 
			this.dgvFornecimento.AllowUserToAddRows = false;
			this.dgvFornecimento.AutoGenerateColumns = false;
			this.dgvFornecimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFornecimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFornecimentoDataGridViewTextBoxColumn,
            this.idFornecedorDataGridViewTextBoxColumn,
            this.dataFornecimentoDataGridViewTextBoxColumn});
			this.dgvFornecimento.DataSource = this.fornecimentoBindingSource;
			this.dgvFornecimento.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvFornecimento.Location = new System.Drawing.Point(0, 0);
			this.dgvFornecimento.Name = "dgvFornecimento";
			this.dgvFornecimento.ReadOnly = true;
			this.dgvFornecimento.Size = new System.Drawing.Size(465, 265);
			this.dgvFornecimento.TabIndex = 0;
			// 
			// idFornecimentoDataGridViewTextBoxColumn
			// 
			this.idFornecimentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.idFornecimentoDataGridViewTextBoxColumn.DataPropertyName = "idFornecimento";
			this.idFornecimentoDataGridViewTextBoxColumn.HeaderText = "Id do fornecimento";
			this.idFornecimentoDataGridViewTextBoxColumn.Name = "idFornecimentoDataGridViewTextBoxColumn";
			this.idFornecimentoDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// idFornecedorDataGridViewTextBoxColumn
			// 
			this.idFornecedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.idFornecedorDataGridViewTextBoxColumn.DataPropertyName = "idFornecedor";
			this.idFornecedorDataGridViewTextBoxColumn.HeaderText = "Id do fornecedor";
			this.idFornecedorDataGridViewTextBoxColumn.Name = "idFornecedorDataGridViewTextBoxColumn";
			this.idFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dataFornecimentoDataGridViewTextBoxColumn
			// 
			this.dataFornecimentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.dataFornecimentoDataGridViewTextBoxColumn.DataPropertyName = "dataFornecimento";
			this.dataFornecimentoDataGridViewTextBoxColumn.HeaderText = "Data do fornecimento";
			this.dataFornecimentoDataGridViewTextBoxColumn.Name = "dataFornecimentoDataGridViewTextBoxColumn";
			this.dataFornecimentoDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// btnLimparCampos
			// 
			this.btnLimparCampos.Depth = 0;
			this.btnLimparCampos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnLimparCampos.Location = new System.Drawing.Point(0, 0);
			this.btnLimparCampos.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnLimparCampos.Name = "btnLimparCampos";
			this.btnLimparCampos.Primary = true;
			this.btnLimparCampos.Size = new System.Drawing.Size(152, 33);
			this.btnLimparCampos.TabIndex = 3;
			this.btnLimparCampos.Text = "Limpar Campos";
			this.btnLimparCampos.UseVisualStyleBackColor = true;
			this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
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
			this.pnlBotaoConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlBotaoConfirmar.Controls.Add(this.btnConfirmar);
			this.pnlBotaoConfirmar.Location = new System.Drawing.Point(830, 334);
			this.pnlBotaoConfirmar.Name = "pnlBotaoConfirmar";
			this.pnlBotaoConfirmar.Size = new System.Drawing.Size(122, 32);
			this.pnlBotaoConfirmar.TabIndex = 10;
			// 
			// pnlCampos
			// 
			this.pnlCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlCampos.Controls.Add(this.pnlCadProduto);
			this.pnlCampos.Controls.Add(lblProduto);
			this.pnlCampos.Controls.Add(this.txtProduto);
			this.pnlCampos.Controls.Add(lblQuantidadeProduto);
			this.pnlCampos.Controls.Add(this.txtQuantidade);
			this.pnlCampos.Controls.Add(lblId);
			this.pnlCampos.Controls.Add(this.txtIdFornecimento);
			this.pnlCampos.Controls.Add(lblFornecedor);
			this.pnlCampos.Controls.Add(this.txtIdFornecedor);
			this.pnlCampos.Controls.Add(lblDataFornecimento);
			this.pnlCampos.Controls.Add(this.dtpDataFornecimento);
			this.pnlCampos.Location = new System.Drawing.Point(12, 12);
			this.pnlCampos.Name = "pnlCampos";
			this.pnlCampos.Size = new System.Drawing.Size(940, 311);
			this.pnlCampos.TabIndex = 9;
			// 
			// txtProduto
			// 
			this.txtProduto.Location = new System.Drawing.Point(717, 147);
			this.txtProduto.Name = "txtProduto";
			this.txtProduto.Size = new System.Drawing.Size(100, 20);
			this.txtProduto.TabIndex = 9;
			// 
			// txtQuantidade
			// 
			this.txtQuantidade.Location = new System.Drawing.Point(717, 199);
			this.txtQuantidade.Name = "txtQuantidade";
			this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
			this.txtQuantidade.TabIndex = 13;
			// 
			// txtIdFornecimento
			// 
			this.txtIdFornecimento.Enabled = false;
			this.txtIdFornecimento.Location = new System.Drawing.Point(134, 15);
			this.txtIdFornecimento.Name = "txtIdFornecimento";
			this.txtIdFornecimento.Size = new System.Drawing.Size(788, 20);
			this.txtIdFornecimento.TabIndex = 1;
			// 
			// txtIdFornecedor
			// 
			this.txtIdFornecedor.Location = new System.Drawing.Point(270, 147);
			this.txtIdFornecedor.Name = "txtIdFornecedor";
			this.txtIdFornecedor.Size = new System.Drawing.Size(200, 20);
			this.txtIdFornecedor.TabIndex = 3;
			// 
			// dtpDataFornecimento
			// 
			this.dtpDataFornecimento.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fornecimentoBindingSource, "dataFornecimento", true));
			this.dtpDataFornecimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDataFornecimento.Location = new System.Drawing.Point(392, 197);
			this.dtpDataFornecimento.Name = "dtpDataFornecimento";
			this.dtpDataFornecimento.Size = new System.Drawing.Size(78, 20);
			this.dtpDataFornecimento.TabIndex = 5;
			// 
			// produtos_FornecimentoBindingSource
			// 
			this.produtos_FornecimentoBindingSource.DataMember = "FK_Produtos_Fornecimento_Fornecimento";
			this.produtos_FornecimentoBindingSource.DataSource = this.fornecimentoBindingSource;
			// 
			// pnlBotaoLimparCampos
			// 
			this.pnlBotaoLimparCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pnlBotaoLimparCampos.Controls.Add(this.btnLimparCampos);
			this.pnlBotaoLimparCampos.Location = new System.Drawing.Point(12, 333);
			this.pnlBotaoLimparCampos.Name = "pnlBotaoLimparCampos";
			this.pnlBotaoLimparCampos.Size = new System.Drawing.Size(152, 33);
			this.pnlBotaoLimparCampos.TabIndex = 8;
			// 
			// produtos_FornecimentoTableAdapter
			// 
			this.produtos_FornecimentoTableAdapter.ClearBeforeFill = true;
			// 
			// pnlDgvFornecedor
			// 
			this.pnlDgvFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlDgvFornecedor.Controls.Add(this.dgvProduto);
			this.pnlDgvFornecedor.Location = new System.Drawing.Point(487, 372);
			this.pnlDgvFornecedor.Name = "pnlDgvFornecedor";
			this.pnlDgvFornecedor.Size = new System.Drawing.Size(465, 265);
			this.pnlDgvFornecedor.TabIndex = 8;
			// 
			// dgvProduto
			// 
			this.dgvProduto.AllowUserToAddRows = false;
			this.dgvProduto.AutoGenerateColumns = false;
			this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdutoDataGridViewTextBoxColumn,
            this.idFornecedorDataGridViewTextBoxColumn1,
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.estoqueProdutoDataGridViewTextBoxColumn});
			this.dgvProduto.DataSource = this.produtoBindingSource;
			this.dgvProduto.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvProduto.Location = new System.Drawing.Point(0, 0);
			this.dgvProduto.Name = "dgvProduto";
			this.dgvProduto.ReadOnly = true;
			this.dgvProduto.Size = new System.Drawing.Size(465, 265);
			this.dgvProduto.TabIndex = 0;
			// 
			// produtoBindingSource
			// 
			this.produtoBindingSource.DataMember = "Produto";
			this.produtoBindingSource.DataSource = this.dsPrincipal;
			// 
			// produtoTableAdapter
			// 
			this.produtoTableAdapter.ClearBeforeFill = true;
			// 
			// idProdutoDataGridViewTextBoxColumn
			// 
			this.idProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "IdProduto";
			this.idProdutoDataGridViewTextBoxColumn.HeaderText = "Id do Produto";
			this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
			this.idProdutoDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// idFornecedorDataGridViewTextBoxColumn1
			// 
			this.idFornecedorDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.idFornecedorDataGridViewTextBoxColumn1.DataPropertyName = "idFornecedor";
			this.idFornecedorDataGridViewTextBoxColumn1.HeaderText = "Id do Fornecedor";
			this.idFornecedorDataGridViewTextBoxColumn1.Name = "idFornecedorDataGridViewTextBoxColumn1";
			this.idFornecedorDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// nomeProdutoDataGridViewTextBoxColumn
			// 
			this.nomeProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "nomeProduto";
			this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "Nome";
			this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
			this.nomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// estoqueProdutoDataGridViewTextBoxColumn
			// 
			this.estoqueProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.estoqueProdutoDataGridViewTextBoxColumn.DataPropertyName = "estoqueProduto";
			this.estoqueProdutoDataGridViewTextBoxColumn.HeaderText = "Estoque";
			this.estoqueProdutoDataGridViewTextBoxColumn.Name = "estoqueProdutoDataGridViewTextBoxColumn";
			this.estoqueProdutoDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// pnlCadProduto
			// 
			this.pnlCadProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pnlCadProduto.Controls.Add(this.txtCadProduto);
			this.pnlCadProduto.Location = new System.Drawing.Point(755, 265);
			this.pnlCadProduto.Name = "pnlCadProduto";
			this.pnlCadProduto.Size = new System.Drawing.Size(167, 33);
			this.pnlCadProduto.TabIndex = 9;
			// 
			// txtCadProduto
			// 
			this.txtCadProduto.Depth = 0;
			this.txtCadProduto.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtCadProduto.Location = new System.Drawing.Point(0, 0);
			this.txtCadProduto.MouseState = MaterialSkin.MouseState.HOVER;
			this.txtCadProduto.Name = "txtCadProduto";
			this.txtCadProduto.Primary = true;
			this.txtCadProduto.Size = new System.Drawing.Size(167, 33);
			this.txtCadProduto.TabIndex = 3;
			this.txtCadProduto.Text = "Cadastrar Produto";
			this.txtCadProduto.UseVisualStyleBackColor = true;
			this.txtCadProduto.Click += new System.EventHandler(this.txtCadProduto_Click);
			// 
			// frmCadFornecimento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(964, 649);
			this.Controls.Add(this.pnlDgvFornecedor);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnlBotaoConfirmar);
			this.Controls.Add(this.pnlCampos);
			this.Controls.Add(this.pnlBotaoLimparCampos);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmCadFornecimento";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "a";
			this.Load += new System.EventHandler(this.frmCadFornecimento_Load);
			((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fornecimentoBindingSource)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvFornecimento)).EndInit();
			this.pnlBotaoConfirmar.ResumeLayout(false);
			this.pnlCampos.ResumeLayout(false);
			this.pnlCampos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.produtos_FornecimentoBindingSource)).EndInit();
			this.pnlBotaoLimparCampos.ResumeLayout(false);
			this.pnlDgvFornecedor.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
			this.pnlCadProduto.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private Dados.dsPrincipal dsPrincipal;
        private System.Windows.Forms.BindingSource fornecimentoBindingSource;
        private Dados.dsPrincipalTableAdapters.FornecimentoTableAdapter fornecimentoTableAdapter;
        private Dados.dsPrincipalTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dgvFornecimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFornecimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFornecimentoDataGridViewTextBoxColumn;
        public MaterialSkin.Controls.MaterialRaisedButton btnLimparCampos;
        public MaterialSkin.Controls.MaterialRaisedButton btnConfirmar;
        public System.Windows.Forms.Panel pnlBotaoConfirmar;
        public System.Windows.Forms.Panel pnlCampos;
        private System.Windows.Forms.TextBox txtIdFornecimento;
        private System.Windows.Forms.TextBox txtIdFornecedor;
        private System.Windows.Forms.DateTimePicker dtpDataFornecimento;
        public System.Windows.Forms.Panel pnlBotaoLimparCampos;
        private System.Windows.Forms.BindingSource produtos_FornecimentoBindingSource;
        private Dados.dsPrincipalTableAdapters.Produtos_FornecimentoTableAdapter produtos_FornecimentoTableAdapter;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        public System.Windows.Forms.Panel pnlDgvFornecedor;
        private System.Windows.Forms.DataGridView dgvProduto;
		private System.Windows.Forms.BindingSource produtoBindingSource;
		private Dados.dsPrincipalTableAdapters.ProdutoTableAdapter produtoTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idFornecedorDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn estoqueProdutoDataGridViewTextBoxColumn;
		public System.Windows.Forms.Panel pnlCadProduto;
		public MaterialSkin.Controls.MaterialRaisedButton txtCadProduto;
	}
}