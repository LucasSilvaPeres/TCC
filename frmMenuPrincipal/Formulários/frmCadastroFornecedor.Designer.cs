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
            this.dsPrincipal = new frmMenuPrincipal.Dados.dsPrincipal();
            this.btnLimparCampos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnConfirmar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlCampos = new System.Windows.Forms.Panel();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtIdentidade = new System.Windows.Forms.MaskedTextBox();
            this.pnlCPFouCNPJ = new System.Windows.Forms.Panel();
            this.rbCNPJ = new System.Windows.Forms.RadioButton();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.idFornecedorTextBox = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fornecedorTableAdapter = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.FornecedorTableAdapter();
            this.tableAdapterManager = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.TableAdapterManager();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInfoFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idFornecedorLabel = new System.Windows.Forms.Label();
            nomeFornecedorLabel = new System.Windows.Forms.Label();
            enderecoFornecedorLabel = new System.Windows.Forms.Label();
            identidadeFornecedorLabel = new System.Windows.Forms.Label();
            telefoneFornecedorLabel = new System.Windows.Forms.Label();
            emailFornecedorLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBancoForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            this.panel4.SuspendLayout();
            this.pnlCampos.SuspendLayout();
            this.pnlCPFouCNPJ.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idFornecedorLabel
            // 
            idFornecedorLabel.AutoSize = true;
            idFornecedorLabel.Location = new System.Drawing.Point(26, 13);
            idFornecedorLabel.Name = "idFornecedorLabel";
            idFornecedorLabel.Size = new System.Drawing.Size(19, 13);
            idFornecedorLabel.TabIndex = 0;
            idFornecedorLabel.Text = "Id ";
            // 
            // nomeFornecedorLabel
            // 
            nomeFornecedorLabel.AutoSize = true;
            nomeFornecedorLabel.Location = new System.Drawing.Point(321, 93);
            nomeFornecedorLabel.Name = "nomeFornecedorLabel";
            nomeFornecedorLabel.Size = new System.Drawing.Size(35, 13);
            nomeFornecedorLabel.TabIndex = 2;
            nomeFornecedorLabel.Text = "Nome";
            // 
            // enderecoFornecedorLabel
            // 
            enderecoFornecedorLabel.AutoSize = true;
            enderecoFornecedorLabel.Location = new System.Drawing.Point(321, 147);
            enderecoFornecedorLabel.Name = "enderecoFornecedorLabel";
            enderecoFornecedorLabel.Size = new System.Drawing.Size(53, 13);
            enderecoFornecedorLabel.TabIndex = 4;
            enderecoFornecedorLabel.Text = "Endereço";
            // 
            // identidadeFornecedorLabel
            // 
            identidadeFornecedorLabel.AutoSize = true;
            identidadeFornecedorLabel.Location = new System.Drawing.Point(321, 120);
            identidadeFornecedorLabel.Name = "identidadeFornecedorLabel";
            identidadeFornecedorLabel.Size = new System.Drawing.Size(59, 13);
            identidadeFornecedorLabel.TabIndex = 6;
            identidadeFornecedorLabel.Text = "CNPJ/CPF";
            // 
            // telefoneFornecedorLabel
            // 
            telefoneFornecedorLabel.AutoSize = true;
            telefoneFornecedorLabel.Location = new System.Drawing.Point(321, 171);
            telefoneFornecedorLabel.Name = "telefoneFornecedorLabel";
            telefoneFornecedorLabel.Size = new System.Drawing.Size(49, 13);
            telefoneFornecedorLabel.TabIndex = 8;
            telefoneFornecedorLabel.Text = "Telefone";
            // 
            // emailFornecedorLabel
            // 
            emailFornecedorLabel.AutoSize = true;
            emailFornecedorLabel.Location = new System.Drawing.Point(321, 197);
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
            this.dgvBancoForm.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvBancoForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBancoForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataInfoFornecedorDataGridViewTextBoxColumn});
            this.dgvBancoForm.DataSource = this.fornecedorBindingSource;
            this.dgvBancoForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBancoForm.Location = new System.Drawing.Point(0, 0);
            this.dgvBancoForm.Name = "dgvBancoForm";
            this.dgvBancoForm.ReadOnly = true;
            this.dgvBancoForm.Size = new System.Drawing.Size(940, 265);
            this.dgvBancoForm.TabIndex = 0;
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
            this.pnlCampos.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCampos.Controls.Add(this.txtTelefone);
            this.pnlCampos.Controls.Add(this.txtIdentidade);
            this.pnlCampos.Controls.Add(this.pnlCPFouCNPJ);
            this.pnlCampos.Controls.Add(idFornecedorLabel);
            this.pnlCampos.Controls.Add(this.idFornecedorTextBox);
            this.pnlCampos.Controls.Add(nomeFornecedorLabel);
            this.pnlCampos.Controls.Add(this.txtNome);
            this.pnlCampos.Controls.Add(enderecoFornecedorLabel);
            this.pnlCampos.Controls.Add(this.txtEndereco);
            this.pnlCampos.Controls.Add(identidadeFornecedorLabel);
            this.pnlCampos.Controls.Add(telefoneFornecedorLabel);
            this.pnlCampos.Controls.Add(emailFornecedorLabel);
            this.pnlCampos.Controls.Add(this.txtEmail);
            this.pnlCampos.Location = new System.Drawing.Point(12, 12);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(940, 311);
            this.pnlCampos.TabIndex = 9;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(402, 173);
            this.txtTelefone.Mask = "(99)09999-9999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(92, 20);
            this.txtTelefone.TabIndex = 16;
            // 
            // txtIdentidade
            // 
            this.txtIdentidade.Location = new System.Drawing.Point(402, 120);
            this.txtIdentidade.Mask = "999,999,999-99";
            this.txtIdentidade.Name = "txtIdentidade";
            this.txtIdentidade.Size = new System.Drawing.Size(80, 20);
            this.txtIdentidade.TabIndex = 15;
            // 
            // pnlCPFouCNPJ
            // 
            this.pnlCPFouCNPJ.Controls.Add(this.rbCNPJ);
            this.pnlCPFouCNPJ.Controls.Add(this.rbCPF);
            this.pnlCPFouCNPJ.Location = new System.Drawing.Point(513, 120);
            this.pnlCPFouCNPJ.Name = "pnlCPFouCNPJ";
            this.pnlCPFouCNPJ.Size = new System.Drawing.Size(107, 22);
            this.pnlCPFouCNPJ.TabIndex = 14;
            // 
            // rbCNPJ
            // 
            this.rbCNPJ.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbCNPJ.AutoSize = true;
            this.rbCNPJ.Checked = true;
            this.rbCNPJ.Location = new System.Drawing.Point(52, 2);
            this.rbCNPJ.Name = "rbCNPJ";
            this.rbCNPJ.Size = new System.Drawing.Size(52, 17);
            this.rbCNPJ.TabIndex = 13;
            this.rbCNPJ.TabStop = true;
            this.rbCNPJ.Text = "CNPJ";
            this.rbCNPJ.UseVisualStyleBackColor = true;
            // 
            // rbCPF
            // 
            this.rbCPF.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbCPF.AutoSize = true;
            this.rbCPF.Location = new System.Drawing.Point(3, 2);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(45, 17);
            this.rbCPF.TabIndex = 12;
            this.rbCPF.Text = "CPF";
            this.rbCPF.UseVisualStyleBackColor = true;
            this.rbCPF.CheckedChanged += new System.EventHandler(this.rbCPF_CheckedChanged);
            // 
            // idFornecedorTextBox
            // 
            this.idFornecedorTextBox.Enabled = false;
            this.idFornecedorTextBox.Location = new System.Drawing.Point(51, 10);
            this.idFornecedorTextBox.Name = "idFornecedorTextBox";
            this.idFornecedorTextBox.Size = new System.Drawing.Size(853, 20);
            this.idFornecedorTextBox.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(402, 93);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(218, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(402, 147);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(218, 20);
            this.txtEndereco.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(402, 197);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(218, 20);
            this.txtEmail.TabIndex = 11;
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
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "Fornecedor";
            this.fornecedorBindingSource.DataSource = this.dsPrincipal;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idFornecedor";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id do fornecedor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeFornecedor";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "enderecoFornecedor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Endereço";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "identidadeFornecedor";
            this.dataGridViewTextBoxColumn4.HeaderText = "CPF/CNPJ";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "telefoneFornecedor";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "emailFornecedor";
            this.dataGridViewTextBoxColumn6.HeaderText = "E-mail";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataInfoFornecedorDataGridViewTextBoxColumn
            // 
            this.dataInfoFornecedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataInfoFornecedorDataGridViewTextBoxColumn.DataPropertyName = "dataInfoFornecedor";
            this.dataInfoFornecedorDataGridViewTextBoxColumn.HeaderText = "Data da informação";
            this.dataInfoFornecedorDataGridViewTextBoxColumn.Name = "dataInfoFornecedorDataGridViewTextBoxColumn";
            this.dataInfoFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(964, 649);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlCampos);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmCadastroFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroFornecedor";
            this.Load += new System.EventHandler(this.frmCadastroFornecedor_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBancoForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            this.panel4.ResumeLayout(false);
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
            this.pnlCPFouCNPJ.ResumeLayout(false);
            this.pnlCPFouCNPJ.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.MaskedTextBox txtIdentidade;
		private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInfoFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
    }
}