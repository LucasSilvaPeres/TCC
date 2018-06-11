namespace frmMenuPrincipal.Formulários
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
            System.Windows.Forms.Label idProdutoLabel;
            System.Windows.Forms.Label idFornecedorLabel;
            System.Windows.Forms.Label nomeProdutoLabel;
            System.Windows.Forms.Label estoqueProdutoLabel;
            System.Windows.Forms.Label dataInfoLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvBancoForm = new System.Windows.Forms.DataGridView();
            this.btnLimparCampos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnConfirmar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlCampos = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dsPrincipal = new frmMenuPrincipal.Dados.dsPrincipal();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.ProdutoTableAdapter();
            this.tableAdapterManager = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.TableAdapterManager();
            this.idProdutoTextBox = new System.Windows.Forms.TextBox();
            this.idFornecedorTextBox = new System.Windows.Forms.TextBox();
            this.nomeProdutoTextBox = new System.Windows.Forms.TextBox();
            this.estoqueProdutoTextBox = new System.Windows.Forms.TextBox();
            this.dataInfoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idProdutoLabel = new System.Windows.Forms.Label();
            idFornecedorLabel = new System.Windows.Forms.Label();
            nomeProdutoLabel = new System.Windows.Forms.Label();
            estoqueProdutoLabel = new System.Windows.Forms.Label();
            dataInfoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBancoForm)).BeginInit();
            this.panel4.SuspendLayout();
            this.pnlCampos.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvBancoForm);
            this.panel1.Location = new System.Drawing.Point(4, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 265);
            this.panel1.TabIndex = 7;
            // 
            // dgvBancoForm
            // 
            this.dgvBancoForm.AllowUserToAddRows = false;
            this.dgvBancoForm.AutoGenerateColumns = false;
            this.dgvBancoForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBancoForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdutoDataGridViewTextBoxColumn,
            this.idFornecedorDataGridViewTextBoxColumn,
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.estoqueProdutoDataGridViewTextBoxColumn,
            this.dataInfoDataGridViewTextBoxColumn});
            this.dgvBancoForm.DataSource = this.produtoBindingSource;
            this.dgvBancoForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBancoForm.Location = new System.Drawing.Point(0, 0);
            this.dgvBancoForm.Name = "dgvBancoForm";
            this.dgvBancoForm.ReadOnly = true;
            this.dgvBancoForm.Size = new System.Drawing.Size(940, 265);
            this.dgvBancoForm.TabIndex = 0;
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
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.btnConfirmar);
            this.panel4.Location = new System.Drawing.Point(822, 288);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(122, 32);
            this.panel4.TabIndex = 10;
            // 
            // pnlCampos
            // 
            this.pnlCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCampos.Controls.Add(idProdutoLabel);
            this.pnlCampos.Controls.Add(this.idProdutoTextBox);
            this.pnlCampos.Controls.Add(idFornecedorLabel);
            this.pnlCampos.Controls.Add(this.idFornecedorTextBox);
            this.pnlCampos.Controls.Add(nomeProdutoLabel);
            this.pnlCampos.Controls.Add(this.nomeProdutoTextBox);
            this.pnlCampos.Controls.Add(estoqueProdutoLabel);
            this.pnlCampos.Controls.Add(this.estoqueProdutoTextBox);
            this.pnlCampos.Controls.Add(dataInfoLabel);
            this.pnlCampos.Controls.Add(this.dataInfoDateTimePicker);
            this.pnlCampos.Location = new System.Drawing.Point(4, 19);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(940, 258);
            this.pnlCampos.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.btnLimparCampos);
            this.panel2.Location = new System.Drawing.Point(4, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 33);
            this.panel2.TabIndex = 8;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // idProdutoLabel
            // 
            idProdutoLabel.AutoSize = true;
            idProdutoLabel.Location = new System.Drawing.Point(113, 67);
            idProdutoLabel.Name = "idProdutoLabel";
            idProdutoLabel.Size = new System.Drawing.Size(59, 13);
            idProdutoLabel.TabIndex = 0;
            idProdutoLabel.Text = "Id Produto:";
            // 
            // idProdutoTextBox
            // 
            this.idProdutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "IdProduto", true));
            this.idProdutoTextBox.Location = new System.Drawing.Point(207, 64);
            this.idProdutoTextBox.Name = "idProdutoTextBox";
            this.idProdutoTextBox.Size = new System.Drawing.Size(200, 20);
            this.idProdutoTextBox.TabIndex = 1;
            // 
            // idFornecedorLabel
            // 
            idFornecedorLabel.AutoSize = true;
            idFornecedorLabel.Location = new System.Drawing.Point(113, 93);
            idFornecedorLabel.Name = "idFornecedorLabel";
            idFornecedorLabel.Size = new System.Drawing.Size(75, 13);
            idFornecedorLabel.TabIndex = 2;
            idFornecedorLabel.Text = "id Fornecedor:";
            // 
            // idFornecedorTextBox
            // 
            this.idFornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "idFornecedor", true));
            this.idFornecedorTextBox.Location = new System.Drawing.Point(207, 90);
            this.idFornecedorTextBox.Name = "idFornecedorTextBox";
            this.idFornecedorTextBox.Size = new System.Drawing.Size(200, 20);
            this.idFornecedorTextBox.TabIndex = 3;
            // 
            // nomeProdutoLabel
            // 
            nomeProdutoLabel.AutoSize = true;
            nomeProdutoLabel.Location = new System.Drawing.Point(113, 119);
            nomeProdutoLabel.Name = "nomeProdutoLabel";
            nomeProdutoLabel.Size = new System.Drawing.Size(76, 13);
            nomeProdutoLabel.TabIndex = 4;
            nomeProdutoLabel.Text = "nome Produto:";
            // 
            // nomeProdutoTextBox
            // 
            this.nomeProdutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "nomeProduto", true));
            this.nomeProdutoTextBox.Location = new System.Drawing.Point(207, 116);
            this.nomeProdutoTextBox.Name = "nomeProdutoTextBox";
            this.nomeProdutoTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeProdutoTextBox.TabIndex = 5;
            // 
            // estoqueProdutoLabel
            // 
            estoqueProdutoLabel.AutoSize = true;
            estoqueProdutoLabel.Location = new System.Drawing.Point(113, 145);
            estoqueProdutoLabel.Name = "estoqueProdutoLabel";
            estoqueProdutoLabel.Size = new System.Drawing.Size(88, 13);
            estoqueProdutoLabel.TabIndex = 6;
            estoqueProdutoLabel.Text = "estoque Produto:";
            // 
            // estoqueProdutoTextBox
            // 
            this.estoqueProdutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "estoqueProduto", true));
            this.estoqueProdutoTextBox.Location = new System.Drawing.Point(207, 142);
            this.estoqueProdutoTextBox.Name = "estoqueProdutoTextBox";
            this.estoqueProdutoTextBox.Size = new System.Drawing.Size(200, 20);
            this.estoqueProdutoTextBox.TabIndex = 7;
            // 
            // dataInfoLabel
            // 
            dataInfoLabel.AutoSize = true;
            dataInfoLabel.Location = new System.Drawing.Point(113, 172);
            dataInfoLabel.Name = "dataInfoLabel";
            dataInfoLabel.Size = new System.Drawing.Size(52, 13);
            dataInfoLabel.TabIndex = 8;
            dataInfoLabel.Text = "data Info:";
            // 
            // dataInfoDateTimePicker
            // 
            this.dataInfoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.produtoBindingSource, "dataInfo", true));
            this.dataInfoDateTimePicker.Location = new System.Drawing.Point(207, 168);
            this.dataInfoDateTimePicker.Name = "dataInfoDateTimePicker";
            this.dataInfoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataInfoDateTimePicker.TabIndex = 9;
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "IdProduto";
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "IdProduto";
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            this.idProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idFornecedorDataGridViewTextBoxColumn
            // 
            this.idFornecedorDataGridViewTextBoxColumn.DataPropertyName = "idFornecedor";
            this.idFornecedorDataGridViewTextBoxColumn.HeaderText = "idFornecedor";
            this.idFornecedorDataGridViewTextBoxColumn.Name = "idFornecedorDataGridViewTextBoxColumn";
            this.idFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "nomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "nomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            this.nomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estoqueProdutoDataGridViewTextBoxColumn
            // 
            this.estoqueProdutoDataGridViewTextBoxColumn.DataPropertyName = "estoqueProduto";
            this.estoqueProdutoDataGridViewTextBoxColumn.HeaderText = "estoqueProduto";
            this.estoqueProdutoDataGridViewTextBoxColumn.Name = "estoqueProdutoDataGridViewTextBoxColumn";
            this.estoqueProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataInfoDataGridViewTextBoxColumn
            // 
            this.dataInfoDataGridViewTextBoxColumn.DataPropertyName = "dataInfo";
            this.dataInfoDataGridViewTextBoxColumn.HeaderText = "dataInfo";
            this.dataInfoDataGridViewTextBoxColumn.Name = "dataInfoDataGridViewTextBoxColumn";
            this.dataInfoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmCadastrarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlCampos);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastrarProdutos";
            this.Text = "frmCadastrarProdutos";
            this.Load += new System.EventHandler(this.frmCadastrarProdutos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBancoForm)).EndInit();
            this.panel4.ResumeLayout(false);
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private Dados.dsPrincipalTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private Dados.dsPrincipalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox idProdutoTextBox;
        private System.Windows.Forms.TextBox idFornecedorTextBox;
        private System.Windows.Forms.TextBox nomeProdutoTextBox;
        private System.Windows.Forms.TextBox estoqueProdutoTextBox;
        private System.Windows.Forms.DateTimePicker dataInfoDateTimePicker;
    }
}