namespace frmMenuPrincipal.Formulários
{
	partial class frmCadastroFornecedor
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
            System.Windows.Forms.Label idFornecedorLabel;
            System.Windows.Forms.Label nomeFornecedorLabel;
            System.Windows.Forms.Label enderecoFornecedorLabel;
            System.Windows.Forms.Label identidadeFornecedorLabel;
            System.Windows.Forms.Label telefoneFornecedorLabel;
            System.Windows.Forms.Label emailFornecedorLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvBancoForm = new System.Windows.Forms.DataGridView();
            this.idFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identidadeFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrincipal = new frmMenuPrincipal.Dados.dsPrincipal();
            this.btnLimparCampos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnConfirmar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlCampos = new System.Windows.Forms.Panel();
            this.pnlCPFouCNPJ = new System.Windows.Forms.Panel();
            this.rbCNPJ = new System.Windows.Forms.RadioButton();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.idFornecedorTextBox = new System.Windows.Forms.TextBox();
            this.nomeFornecedorTextBox = new System.Windows.Forms.TextBox();
            this.enderecoFornecedorTextBox = new System.Windows.Forms.TextBox();
            this.identidadeFornecedorTextBox = new System.Windows.Forms.TextBox();
            this.telefoneFornecedorTextBox = new System.Windows.Forms.TextBox();
            this.emailFornecedorTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fornecedorTableAdapter = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.FornecedorTableAdapter();
            this.tableAdapterManager = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.TableAdapterManager();
            idFornecedorLabel = new System.Windows.Forms.Label();
            nomeFornecedorLabel = new System.Windows.Forms.Label();
            enderecoFornecedorLabel = new System.Windows.Forms.Label();
            identidadeFornecedorLabel = new System.Windows.Forms.Label();
            telefoneFornecedorLabel = new System.Windows.Forms.Label();
            emailFornecedorLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBancoForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            this.panel4.SuspendLayout();
            this.pnlCampos.SuspendLayout();
            this.pnlCPFouCNPJ.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // idFornecedorLabel
            // 
            idFornecedorLabel.AutoSize = true;
            idFornecedorLabel.Location = new System.Drawing.Point(118, 26);
            idFornecedorLabel.Name = "idFornecedorLabel";
            idFornecedorLabel.Size = new System.Drawing.Size(19, 13);
            idFornecedorLabel.TabIndex = 0;
            idFornecedorLabel.Text = "Id ";
            // 
            // nomeFornecedorLabel
            // 
            nomeFornecedorLabel.AutoSize = true;
            nomeFornecedorLabel.Location = new System.Drawing.Point(118, 52);
            nomeFornecedorLabel.Name = "nomeFornecedorLabel";
            nomeFornecedorLabel.Size = new System.Drawing.Size(35, 13);
            nomeFornecedorLabel.TabIndex = 2;
            nomeFornecedorLabel.Text = "Nome";
            // 
            // enderecoFornecedorLabel
            // 
            enderecoFornecedorLabel.AutoSize = true;
            enderecoFornecedorLabel.Location = new System.Drawing.Point(118, 78);
            enderecoFornecedorLabel.Name = "enderecoFornecedorLabel";
            enderecoFornecedorLabel.Size = new System.Drawing.Size(53, 13);
            enderecoFornecedorLabel.TabIndex = 4;
            enderecoFornecedorLabel.Text = "Endereço";
            // 
            // identidadeFornecedorLabel
            // 
            identidadeFornecedorLabel.AutoSize = true;
            identidadeFornecedorLabel.Location = new System.Drawing.Point(118, 104);
            identidadeFornecedorLabel.Name = "identidadeFornecedorLabel";
            identidadeFornecedorLabel.Size = new System.Drawing.Size(59, 13);
            identidadeFornecedorLabel.TabIndex = 6;
            identidadeFornecedorLabel.Text = "CNPJ/CPF";
            // 
            // telefoneFornecedorLabel
            // 
            telefoneFornecedorLabel.AutoSize = true;
            telefoneFornecedorLabel.Location = new System.Drawing.Point(118, 130);
            telefoneFornecedorLabel.Name = "telefoneFornecedorLabel";
            telefoneFornecedorLabel.Size = new System.Drawing.Size(49, 13);
            telefoneFornecedorLabel.TabIndex = 8;
            telefoneFornecedorLabel.Text = "Telefone";
            // 
            // emailFornecedorLabel
            // 
            emailFornecedorLabel.AutoSize = true;
            emailFornecedorLabel.Location = new System.Drawing.Point(118, 156);
            emailFornecedorLabel.Name = "emailFornecedorLabel";
            emailFornecedorLabel.Size = new System.Drawing.Size(36, 13);
            emailFornecedorLabel.TabIndex = 10;
            emailFornecedorLabel.Text = "E-Mail";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvBancoForm);
            this.panel1.Location = new System.Drawing.Point(12, 372);
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
            this.idFornecedorDataGridViewTextBoxColumn,
            this.nomeFornecedorDataGridViewTextBoxColumn,
            this.enderecoFornecedorDataGridViewTextBoxColumn,
            this.identidadeFornecedorDataGridViewTextBoxColumn,
            this.telefoneFornecedorDataGridViewTextBoxColumn,
            this.emailFornecedorDataGridViewTextBoxColumn});
            this.dgvBancoForm.DataSource = this.fornecedorBindingSource;
            this.dgvBancoForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBancoForm.Location = new System.Drawing.Point(0, 0);
            this.dgvBancoForm.Name = "dgvBancoForm";
            this.dgvBancoForm.ReadOnly = true;
            this.dgvBancoForm.Size = new System.Drawing.Size(940, 265);
            this.dgvBancoForm.TabIndex = 0;
            // 
            // idFornecedorDataGridViewTextBoxColumn
            // 
            this.idFornecedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idFornecedorDataGridViewTextBoxColumn.DataPropertyName = "idFornecedor";
            this.idFornecedorDataGridViewTextBoxColumn.HeaderText = "Id do Fornecedor";
            this.idFornecedorDataGridViewTextBoxColumn.Name = "idFornecedorDataGridViewTextBoxColumn";
            this.idFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeFornecedorDataGridViewTextBoxColumn
            // 
            this.nomeFornecedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeFornecedorDataGridViewTextBoxColumn.DataPropertyName = "nomeFornecedor";
            this.nomeFornecedorDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeFornecedorDataGridViewTextBoxColumn.Name = "nomeFornecedorDataGridViewTextBoxColumn";
            this.nomeFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoFornecedorDataGridViewTextBoxColumn
            // 
            this.enderecoFornecedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.enderecoFornecedorDataGridViewTextBoxColumn.DataPropertyName = "enderecoFornecedor";
            this.enderecoFornecedorDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.enderecoFornecedorDataGridViewTextBoxColumn.Name = "enderecoFornecedorDataGridViewTextBoxColumn";
            this.enderecoFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // identidadeFornecedorDataGridViewTextBoxColumn
            // 
            this.identidadeFornecedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.identidadeFornecedorDataGridViewTextBoxColumn.DataPropertyName = "identidadeFornecedor";
            this.identidadeFornecedorDataGridViewTextBoxColumn.HeaderText = "CNPJ/CPF";
            this.identidadeFornecedorDataGridViewTextBoxColumn.Name = "identidadeFornecedorDataGridViewTextBoxColumn";
            this.identidadeFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneFornecedorDataGridViewTextBoxColumn
            // 
            this.telefoneFornecedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefoneFornecedorDataGridViewTextBoxColumn.DataPropertyName = "telefoneFornecedor";
            this.telefoneFornecedorDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneFornecedorDataGridViewTextBoxColumn.Name = "telefoneFornecedorDataGridViewTextBoxColumn";
            this.telefoneFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailFornecedorDataGridViewTextBoxColumn
            // 
            this.emailFornecedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailFornecedorDataGridViewTextBoxColumn.DataPropertyName = "emailFornecedor";
            this.emailFornecedorDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailFornecedorDataGridViewTextBoxColumn.Name = "emailFornecedorDataGridViewTextBoxColumn";
            this.emailFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "Fornecedor";
            this.fornecedorBindingSource.DataSource = this.dsPrincipal;
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
            this.panel4.Location = new System.Drawing.Point(830, 334);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(122, 32);
            this.panel4.TabIndex = 10;
            // 
            // pnlCampos
            // 
            this.pnlCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCampos.Controls.Add(this.pnlCPFouCNPJ);
            this.pnlCampos.Controls.Add(idFornecedorLabel);
            this.pnlCampos.Controls.Add(this.idFornecedorTextBox);
            this.pnlCampos.Controls.Add(nomeFornecedorLabel);
            this.pnlCampos.Controls.Add(this.nomeFornecedorTextBox);
            this.pnlCampos.Controls.Add(enderecoFornecedorLabel);
            this.pnlCampos.Controls.Add(this.enderecoFornecedorTextBox);
            this.pnlCampos.Controls.Add(identidadeFornecedorLabel);
            this.pnlCampos.Controls.Add(this.identidadeFornecedorTextBox);
            this.pnlCampos.Controls.Add(telefoneFornecedorLabel);
            this.pnlCampos.Controls.Add(this.telefoneFornecedorTextBox);
            this.pnlCampos.Controls.Add(emailFornecedorLabel);
            this.pnlCampos.Controls.Add(this.emailFornecedorTextBox);
            this.pnlCampos.Location = new System.Drawing.Point(12, 12);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(940, 311);
            this.pnlCampos.TabIndex = 9;
            // 
            // pnlCPFouCNPJ
            // 
            this.pnlCPFouCNPJ.Controls.Add(this.rbCNPJ);
            this.pnlCPFouCNPJ.Controls.Add(this.rbCPF);
            this.pnlCPFouCNPJ.Location = new System.Drawing.Point(597, 71);
            this.pnlCPFouCNPJ.Name = "pnlCPFouCNPJ";
            this.pnlCPFouCNPJ.Size = new System.Drawing.Size(58, 45);
            this.pnlCPFouCNPJ.TabIndex = 14;
            // 
            // rbCNPJ
            // 
            this.rbCNPJ.AutoSize = true;
            this.rbCNPJ.Location = new System.Drawing.Point(3, 26);
            this.rbCNPJ.Name = "rbCNPJ";
            this.rbCNPJ.Size = new System.Drawing.Size(52, 17);
            this.rbCNPJ.TabIndex = 13;
            this.rbCNPJ.TabStop = true;
            this.rbCNPJ.Text = "CNPJ";
            this.rbCNPJ.UseVisualStyleBackColor = true;
            // 
            // rbCPF
            // 
            this.rbCPF.AutoSize = true;
            this.rbCPF.Location = new System.Drawing.Point(3, 2);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(45, 17);
            this.rbCPF.TabIndex = 12;
            this.rbCPF.TabStop = true;
            this.rbCPF.Text = "CPF";
            this.rbCPF.UseVisualStyleBackColor = true;
            // 
            // idFornecedorTextBox
            // 
            this.idFornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "idFornecedor", true));
            this.idFornecedorTextBox.Location = new System.Drawing.Point(240, 23);
            this.idFornecedorTextBox.Name = "idFornecedorTextBox";
            this.idFornecedorTextBox.Size = new System.Drawing.Size(200, 20);
            this.idFornecedorTextBox.TabIndex = 1;
            // 
            // nomeFornecedorTextBox
            // 
            this.nomeFornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "nomeFornecedor", true));
            this.nomeFornecedorTextBox.Location = new System.Drawing.Point(240, 49);
            this.nomeFornecedorTextBox.Name = "nomeFornecedorTextBox";
            this.nomeFornecedorTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeFornecedorTextBox.TabIndex = 3;
            // 
            // enderecoFornecedorTextBox
            // 
            this.enderecoFornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "enderecoFornecedor", true));
            this.enderecoFornecedorTextBox.Location = new System.Drawing.Point(240, 75);
            this.enderecoFornecedorTextBox.Name = "enderecoFornecedorTextBox";
            this.enderecoFornecedorTextBox.Size = new System.Drawing.Size(200, 20);
            this.enderecoFornecedorTextBox.TabIndex = 5;
            // 
            // identidadeFornecedorTextBox
            // 
            this.identidadeFornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "identidadeFornecedor", true));
            this.identidadeFornecedorTextBox.Location = new System.Drawing.Point(240, 101);
            this.identidadeFornecedorTextBox.Name = "identidadeFornecedorTextBox";
            this.identidadeFornecedorTextBox.Size = new System.Drawing.Size(200, 20);
            this.identidadeFornecedorTextBox.TabIndex = 7;
            // 
            // telefoneFornecedorTextBox
            // 
            this.telefoneFornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "telefoneFornecedor", true));
            this.telefoneFornecedorTextBox.Location = new System.Drawing.Point(240, 127);
            this.telefoneFornecedorTextBox.Name = "telefoneFornecedorTextBox";
            this.telefoneFornecedorTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefoneFornecedorTextBox.TabIndex = 9;
            // 
            // emailFornecedorTextBox
            // 
            this.emailFornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "emailFornecedor", true));
            this.emailFornecedorTextBox.Location = new System.Drawing.Point(240, 153);
            this.emailFornecedorTextBox.Name = "emailFornecedorTextBox";
            this.emailFornecedorTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailFornecedorTextBox.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.btnLimparCampos);
            this.panel2.Location = new System.Drawing.Point(12, 333);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 33);
            this.panel2.TabIndex = 8;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AtendimentoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarroTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.FornecedorTableAdapter = this.fornecedorTableAdapter;
            this.tableAdapterManager.FornecimentoTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.Produtos_AtendimentoTableAdapter = null;
            this.tableAdapterManager.Produtos_FornecimentoTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.Serviços_AtendimentoTableAdapter = null;
            this.tableAdapterManager.ServicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = frmMenuPrincipal.Dados.dsPrincipalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 649);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlCampos);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastroFornecedor";
            this.Text = "frmCadastroFornecedor";
            this.Load += new System.EventHandler(this.frmCadastroFornecedor_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBancoForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            this.panel4.ResumeLayout(false);
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
            this.pnlCPFouCNPJ.ResumeLayout(false);
            this.pnlCPFouCNPJ.PerformLayout();
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
		private System.Windows.Forms.BindingSource fornecedorBindingSource;
		private Dados.dsPrincipalTableAdapters.FornecedorTableAdapter fornecedorTableAdapter;
		private Dados.dsPrincipalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identidadeFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel pnlCPFouCNPJ;
        private System.Windows.Forms.RadioButton rbCNPJ;
        private System.Windows.Forms.RadioButton rbCPF;
        private System.Windows.Forms.TextBox idFornecedorTextBox;
        private System.Windows.Forms.TextBox nomeFornecedorTextBox;
        private System.Windows.Forms.TextBox enderecoFornecedorTextBox;
        private System.Windows.Forms.TextBox identidadeFornecedorTextBox;
        private System.Windows.Forms.TextBox telefoneFornecedorTextBox;
        private System.Windows.Forms.TextBox emailFornecedorTextBox;
    }
}