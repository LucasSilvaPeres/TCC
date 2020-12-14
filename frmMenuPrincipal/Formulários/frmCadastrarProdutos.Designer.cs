﻿namespace frmMenuPrincipal.Formulários
{
    partial class frmCadastrarProdutos
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
            System.Windows.Forms.Label lblIdProdutos;
            System.Windows.Forms.Label lblIdFornecedor;
            System.Windows.Forms.Label lblNome;
            System.Windows.Forms.Label lblEstoque;
            this.pnlDataGridView = new System.Windows.Forms.Panel();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrincipal = new frmMenuPrincipal.Dados.dsPrincipal();
            this.btnLimparCampos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnConfirmar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlBotaoConfirmar = new System.Windows.Forms.Panel();
            this.pnlCampos = new System.Windows.Forms.Panel();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.txtIdFornecedor = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.pnlLimparCampos = new System.Windows.Forms.Panel();
            this.produtoTableAdapter = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.ProdutoTableAdapter();
            this.tableAdapterManager = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.TableAdapterManager();
            lblIdProdutos = new System.Windows.Forms.Label();
            lblIdFornecedor = new System.Windows.Forms.Label();
            lblNome = new System.Windows.Forms.Label();
            lblEstoque = new System.Windows.Forms.Label();
            this.pnlDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            this.pnlBotaoConfirmar.SuspendLayout();
            this.pnlCampos.SuspendLayout();
            this.pnlLimparCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdProdutos
            // 
            lblIdProdutos.AutoSize = true;
            lblIdProdutos.Location = new System.Drawing.Point(31, 14);
            lblIdProdutos.Name = "lblIdProdutos";
            lblIdProdutos.Size = new System.Drawing.Size(59, 13);
            lblIdProdutos.TabIndex = 0;
            lblIdProdutos.Text = "Id Produto:";
            // 
            // lblIdFornecedor
            // 
            lblIdFornecedor.AutoSize = true;
            lblIdFornecedor.Location = new System.Drawing.Point(76, 91);
            lblIdFornecedor.Name = "lblIdFornecedor";
            lblIdFornecedor.Size = new System.Drawing.Size(76, 13);
            lblIdFornecedor.TabIndex = 2;
            lblIdFornecedor.Text = "Id Fornecedor:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new System.Drawing.Point(76, 117);
            lblNome.Name = "lblNome";
            lblNome.Size = new System.Drawing.Size(35, 13);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome";
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Location = new System.Drawing.Point(76, 143);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new System.Drawing.Size(46, 13);
            lblEstoque.TabIndex = 6;
            lblEstoque.Text = "Estoque";
            // 
            // pnlDataGridView
            // 
            this.pnlDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDataGridView.Controls.Add(this.dgvProduto);
            this.pnlDataGridView.Location = new System.Drawing.Point(4, 326);
            this.pnlDataGridView.Name = "pnlDataGridView";
            this.pnlDataGridView.Size = new System.Drawing.Size(940, 265);
            this.pnlDataGridView.TabIndex = 7;
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AutoGenerateColumns = false;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataInfoDataGridViewTextBoxColumn});
            this.dgvProduto.DataSource = this.produtoBindingSource;
            this.dgvProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduto.Location = new System.Drawing.Point(0, 0);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(940, 265);
            this.dgvProduto.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdProduto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id do Produto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idFornecedor";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id do Fornecedor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nomeProduto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "estoqueProduto";
            this.dataGridViewTextBoxColumn4.HeaderText = "Estoque";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataInfoDataGridViewTextBoxColumn
            // 
            this.dataInfoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataInfoDataGridViewTextBoxColumn.DataPropertyName = "dataInfo";
            this.dataInfoDataGridViewTextBoxColumn.HeaderText = "Data da informação";
            this.dataInfoDataGridViewTextBoxColumn.Name = "dataInfoDataGridViewTextBoxColumn";
            this.dataInfoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.dsPrincipal;
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
            this.btnLimparCampos.Size = new System.Drawing.Size(152, 33);
            this.btnLimparCampos.TabIndex = 5;
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
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // pnlBotaoConfirmar
            // 
            this.pnlBotaoConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBotaoConfirmar.Controls.Add(this.btnConfirmar);
            this.pnlBotaoConfirmar.Location = new System.Drawing.Point(822, 288);
            this.pnlBotaoConfirmar.Name = "pnlBotaoConfirmar";
            this.pnlBotaoConfirmar.Size = new System.Drawing.Size(122, 32);
            this.pnlBotaoConfirmar.TabIndex = 10;
            // 
            // pnlCampos
            // 
            this.pnlCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCampos.Controls.Add(lblIdProdutos);
            this.pnlCampos.Controls.Add(this.txtIdProduto);
            this.pnlCampos.Controls.Add(lblIdFornecedor);
            this.pnlCampos.Controls.Add(this.txtIdFornecedor);
            this.pnlCampos.Controls.Add(lblNome);
            this.pnlCampos.Controls.Add(this.txtNome);
            this.pnlCampos.Controls.Add(lblEstoque);
            this.pnlCampos.Controls.Add(this.txtEstoque);
            this.pnlCampos.Location = new System.Drawing.Point(4, 12);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(940, 265);
            this.pnlCampos.TabIndex = 9;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Enabled = false;
            this.txtIdProduto.Location = new System.Drawing.Point(96, 11);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(826, 20);
            this.txtIdProduto.TabIndex = 111;
            // 
            // txtIdFornecedor
            // 
            this.txtIdFornecedor.Location = new System.Drawing.Point(170, 88);
            this.txtIdFornecedor.Name = "txtIdFornecedor";
            this.txtIdFornecedor.Size = new System.Drawing.Size(200, 20);
            this.txtIdFornecedor.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(170, 114);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(170, 140);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(200, 20);
            this.txtEstoque.TabIndex = 3;
            // 
            // pnlLimparCampos
            // 
            this.pnlLimparCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlLimparCampos.Controls.Add(this.btnLimparCampos);
            this.pnlLimparCampos.Location = new System.Drawing.Point(4, 287);
            this.pnlLimparCampos.Name = "pnlLimparCampos";
            this.pnlLimparCampos.Size = new System.Drawing.Size(152, 33);
            this.pnlLimparCampos.TabIndex = 8;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AtendimentoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarroTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.FornecedorTableAdapter = null;
            this.tableAdapterManager.FornecimentoTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.Produtos_AtendimentoTableAdapter = null;
            this.tableAdapterManager.Produtos_FornecimentoTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = this.produtoTableAdapter;
            this.tableAdapterManager.Serviços_AtendimentoTableAdapter = null;
            this.tableAdapterManager.ServicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = frmMenuPrincipal.Dados.dsPrincipalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmCadastrarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(948, 610);
            this.Controls.Add(this.pnlDataGridView);
            this.Controls.Add(this.pnlBotaoConfirmar);
            this.Controls.Add(this.pnlCampos);
            this.Controls.Add(this.pnlLimparCampos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCadastrarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de produtos";
            this.Load += new System.EventHandler(this.frmCadastrarProdutos_Load);
            this.pnlDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            this.pnlBotaoConfirmar.ResumeLayout(false);
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
            this.pnlLimparCampos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlDataGridView;
        public System.Windows.Forms.DataGridView dgvProduto;
        public MaterialSkin.Controls.MaterialRaisedButton btnLimparCampos;
        public MaterialSkin.Controls.MaterialRaisedButton btnConfirmar;
        public System.Windows.Forms.Panel pnlBotaoConfirmar;
        public System.Windows.Forms.Panel pnlCampos;
        public System.Windows.Forms.Panel pnlLimparCampos;
        private Dados.dsPrincipal dsPrincipal;
        private Dados.dsPrincipalTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private Dados.dsPrincipalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.TextBox txtIdFornecedor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInfoDataGridViewTextBoxColumn;
	}
}