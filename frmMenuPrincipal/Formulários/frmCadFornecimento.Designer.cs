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
            System.Windows.Forms.Label lblIdFornecimento;
            System.Windows.Forms.Label lblIdFornecedor;
            System.Windows.Forms.Label lblDataFornecimento;
            System.Windows.Forms.Label lblIdProduto;
            System.Windows.Forms.Label lblQuantidadeProduto;
            this.dsPrincipal = new frmMenuPrincipal.Dados.dsPrincipal();
            this.fornecimentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecimentoTableAdapter = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.FornecimentoTableAdapter();
            this.tableAdapterManager = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvFornecimento = new System.Windows.Forms.DataGridView();
            this.btnLimparCampos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnConfirmar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlBotaoConfirmar = new System.Windows.Forms.Panel();
            this.pnlCampos = new System.Windows.Forms.Panel();
            this.pnlBotaoLimparCampos = new System.Windows.Forms.Panel();
            this.txtIdFornecimento = new System.Windows.Forms.TextBox();
            this.txtIdFornecedor = new System.Windows.Forms.TextBox();
            this.dtpDataFornecimento = new System.Windows.Forms.DateTimePicker();
            this.idFornecimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFornecimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtos_FornecimentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtos_FornecimentoTableAdapter = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.Produtos_FornecimentoTableAdapter();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.txtQuantidadeProduto = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblIdFornecimento = new System.Windows.Forms.Label();
            lblIdFornecedor = new System.Windows.Forms.Label();
            lblDataFornecimento = new System.Windows.Forms.Label();
            lblIdProduto = new System.Windows.Forms.Label();
            lblQuantidadeProduto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecimentoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecimento)).BeginInit();
            this.pnlBotaoConfirmar.SuspendLayout();
            this.pnlCampos.SuspendLayout();
            this.pnlBotaoLimparCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtos_FornecimentoBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
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
            this.pnlCampos.Controls.Add(lblIdProduto);
            this.pnlCampos.Controls.Add(this.txtIdProduto);
            this.pnlCampos.Controls.Add(lblQuantidadeProduto);
            this.pnlCampos.Controls.Add(this.txtQuantidadeProduto);
            this.pnlCampos.Controls.Add(lblIdFornecimento);
            this.pnlCampos.Controls.Add(this.txtIdFornecimento);
            this.pnlCampos.Controls.Add(lblIdFornecedor);
            this.pnlCampos.Controls.Add(this.txtIdFornecedor);
            this.pnlCampos.Controls.Add(lblDataFornecimento);
            this.pnlCampos.Controls.Add(this.dtpDataFornecimento);
            this.pnlCampos.Location = new System.Drawing.Point(12, 12);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(940, 311);
            this.pnlCampos.TabIndex = 9;
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
            // lblIdFornecimento
            // 
            lblIdFornecimento.AutoSize = true;
            lblIdFornecimento.Location = new System.Drawing.Point(157, 150);
            lblIdFornecimento.Name = "lblIdFornecimento";
            lblIdFornecimento.Size = new System.Drawing.Size(83, 13);
            lblIdFornecimento.TabIndex = 0;
            lblIdFornecimento.Text = "Id Fornecimento";
            // 
            // txtIdFornecimento
            // 
            this.txtIdFornecimento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecimentoBindingSource, "idFornecimento", true));
            this.txtIdFornecimento.Location = new System.Drawing.Point(270, 147);
            this.txtIdFornecimento.Name = "txtIdFornecimento";
            this.txtIdFornecimento.Size = new System.Drawing.Size(200, 20);
            this.txtIdFornecimento.TabIndex = 1;
            // 
            // lblIdFornecedor
            // 
            lblIdFornecedor.AutoSize = true;
            lblIdFornecedor.Location = new System.Drawing.Point(157, 176);
            lblIdFornecedor.Name = "lblIdFornecedor";
            lblIdFornecedor.Size = new System.Drawing.Size(73, 13);
            lblIdFornecedor.TabIndex = 2;
            lblIdFornecedor.Text = "Id Fornecedor";
            // 
            // txtIdFornecedor
            // 
            this.txtIdFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecimentoBindingSource, "idFornecedor", true));
            this.txtIdFornecedor.Location = new System.Drawing.Point(270, 173);
            this.txtIdFornecedor.Name = "txtIdFornecedor";
            this.txtIdFornecedor.Size = new System.Drawing.Size(200, 20);
            this.txtIdFornecedor.TabIndex = 3;
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
            // dtpDataFornecimento
            // 
            this.dtpDataFornecimento.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fornecimentoBindingSource, "dataFornecimento", true));
            this.dtpDataFornecimento.Location = new System.Drawing.Point(270, 199);
            this.dtpDataFornecimento.Name = "dtpDataFornecimento";
            this.dtpDataFornecimento.Size = new System.Drawing.Size(200, 20);
            this.dtpDataFornecimento.TabIndex = 5;
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
            // produtos_FornecimentoBindingSource
            // 
            this.produtos_FornecimentoBindingSource.DataMember = "FK_Produtos_Fornecimento_Fornecimento";
            this.produtos_FornecimentoBindingSource.DataSource = this.fornecimentoBindingSource;
            // 
            // produtos_FornecimentoTableAdapter
            // 
            this.produtos_FornecimentoTableAdapter.ClearBeforeFill = true;
            // 
            // lblIdProduto
            // 
            lblIdProduto.AutoSize = true;
            lblIdProduto.Location = new System.Drawing.Point(586, 142);
            lblIdProduto.Name = "lblIdProduto";
            lblIdProduto.Size = new System.Drawing.Size(56, 13);
            lblIdProduto.TabIndex = 8;
            lblIdProduto.Text = "Id Produto";
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtos_FornecimentoBindingSource, "idProduto", true));
            this.txtIdProduto.Location = new System.Drawing.Point(717, 139);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(100, 20);
            this.txtIdProduto.TabIndex = 9;
            // 
            // lblQuantidadeProduto
            // 
            lblQuantidadeProduto.AutoSize = true;
            lblQuantidadeProduto.Location = new System.Drawing.Point(586, 194);
            lblQuantidadeProduto.Name = "lblQuantidadeProduto";
            lblQuantidadeProduto.Size = new System.Drawing.Size(62, 13);
            lblQuantidadeProduto.TabIndex = 12;
            lblQuantidadeProduto.Text = "Quantidade";
            // 
            // txtQuantidadeProduto
            // 
            this.txtQuantidadeProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtos_FornecimentoBindingSource, "quantidadeProduto", true));
            this.txtQuantidadeProduto.Location = new System.Drawing.Point(717, 191);
            this.txtQuantidadeProduto.Name = "txtQuantidadeProduto";
            this.txtQuantidadeProduto.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidadeProduto.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dgvProdutos);
            this.panel3.Location = new System.Drawing.Point(487, 372);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(465, 265);
            this.panel3.TabIndex = 8;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AutoGenerateColumns = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvProdutos.DataSource = this.fornecimentoBindingSource;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.Location = new System.Drawing.Point(0, 0);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(465, 265);
            this.dgvProdutos.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idFornecimento";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id do fornecimento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idFornecedor";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id do fornecedor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dataFornecimento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data do fornecimento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // frmCadFornecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 649);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBotaoConfirmar);
            this.Controls.Add(this.pnlCampos);
            this.Controls.Add(this.pnlBotaoLimparCampos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadFornecimento";
            this.Text = "a";
            this.Load += new System.EventHandler(this.frmCadFornecimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecimentoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecimento)).EndInit();
            this.pnlBotaoConfirmar.ResumeLayout(false);
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
            this.pnlBotaoLimparCampos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.produtos_FornecimentoBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
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
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.TextBox txtQuantidadeProduto;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}