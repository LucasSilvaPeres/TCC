namespace frmMenuPrincipal.Formulários
{
	partial class frmCadastroFuncionários
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
			System.Windows.Forms.Label idFuncionarioLabel;
			System.Windows.Forms.Label telefoneFuncionarioLabel;
			System.Windows.Forms.Label enderecoFuncionarioLabel;
			System.Windows.Forms.Label nomeFuncionarioLabel;
			System.Windows.Forms.Label bairroFuncionarioLabel;
			System.Windows.Forms.Label celularFuncionarioLabel;
			System.Windows.Forms.Label pagamentoFuncionarioLabel;
			System.Windows.Forms.Label identidadeFuncionarioLabel;
			System.Windows.Forms.Label nascFuncionarioLabel;
			System.Windows.Forms.Label lblObs;
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgvBancoForm = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dsPrincipal = new frmMenuPrincipal.Dados.dsPrincipal();
			this.btnLimparCampos = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnConfirmar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.panel4 = new System.Windows.Forms.Panel();
			this.pnlCampos = new System.Windows.Forms.Panel();
			this.txtSalario = new System.Windows.Forms.MaskedTextBox();
			this.txtObs = new System.Windows.Forms.TextBox();
			this.txtCelular = new System.Windows.Forms.MaskedTextBox();
			this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
			this.txtIdentidade = new System.Windows.Forms.MaskedTextBox();
			this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
			this.txtIdFuncionario = new System.Windows.Forms.TextBox();
			this.txtEndereco = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.funcionarioTableAdapter = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.FuncionarioTableAdapter();
			this.tableAdapterManager = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.TableAdapterManager();
			idFuncionarioLabel = new System.Windows.Forms.Label();
			telefoneFuncionarioLabel = new System.Windows.Forms.Label();
			enderecoFuncionarioLabel = new System.Windows.Forms.Label();
			nomeFuncionarioLabel = new System.Windows.Forms.Label();
			bairroFuncionarioLabel = new System.Windows.Forms.Label();
			celularFuncionarioLabel = new System.Windows.Forms.Label();
			pagamentoFuncionarioLabel = new System.Windows.Forms.Label();
			identidadeFuncionarioLabel = new System.Windows.Forms.Label();
			nascFuncionarioLabel = new System.Windows.Forms.Label();
			lblObs = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBancoForm)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
			this.panel4.SuspendLayout();
			this.pnlCampos.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// idFuncionarioLabel
			// 
			idFuncionarioLabel.AutoSize = true;
			idFuncionarioLabel.Location = new System.Drawing.Point(24, 8);
			idFuncionarioLabel.Name = "idFuncionarioLabel";
			idFuncionarioLabel.Size = new System.Drawing.Size(92, 13);
			idFuncionarioLabel.TabIndex = 0;
			idFuncionarioLabel.Text = "Id do Funcionário:";
			// 
			// telefoneFuncionarioLabel
			// 
			telefoneFuncionarioLabel.AutoSize = true;
			telefoneFuncionarioLabel.Location = new System.Drawing.Point(24, 210);
			telefoneFuncionarioLabel.Name = "telefoneFuncionarioLabel";
			telefoneFuncionarioLabel.Size = new System.Drawing.Size(49, 13);
			telefoneFuncionarioLabel.TabIndex = 2;
			telefoneFuncionarioLabel.Text = "Telefone";
			// 
			// enderecoFuncionarioLabel
			// 
			enderecoFuncionarioLabel.AutoSize = true;
			enderecoFuncionarioLabel.Location = new System.Drawing.Point(24, 147);
			enderecoFuncionarioLabel.Name = "enderecoFuncionarioLabel";
			enderecoFuncionarioLabel.Size = new System.Drawing.Size(53, 13);
			enderecoFuncionarioLabel.TabIndex = 4;
			enderecoFuncionarioLabel.Text = "Endereço";
			// 
			// nomeFuncionarioLabel
			// 
			nomeFuncionarioLabel.AutoSize = true;
			nomeFuncionarioLabel.Location = new System.Drawing.Point(23, 55);
			nomeFuncionarioLabel.Name = "nomeFuncionarioLabel";
			nomeFuncionarioLabel.Size = new System.Drawing.Size(35, 13);
			nomeFuncionarioLabel.TabIndex = 6;
			nomeFuncionarioLabel.Text = "Nome";
			// 
			// bairroFuncionarioLabel
			// 
			bairroFuncionarioLabel.AutoSize = true;
			bairroFuncionarioLabel.Location = new System.Drawing.Point(24, 178);
			bairroFuncionarioLabel.Name = "bairroFuncionarioLabel";
			bairroFuncionarioLabel.Size = new System.Drawing.Size(34, 13);
			bairroFuncionarioLabel.TabIndex = 8;
			bairroFuncionarioLabel.Text = "Bairro";
			// 
			// celularFuncionarioLabel
			// 
			celularFuncionarioLabel.AutoSize = true;
			celularFuncionarioLabel.Location = new System.Drawing.Point(237, 210);
			celularFuncionarioLabel.Name = "celularFuncionarioLabel";
			celularFuncionarioLabel.Size = new System.Drawing.Size(39, 13);
			celularFuncionarioLabel.TabIndex = 10;
			celularFuncionarioLabel.Text = "Celular";
			// 
			// pagamentoFuncionarioLabel
			// 
			pagamentoFuncionarioLabel.AutoSize = true;
			pagamentoFuncionarioLabel.Location = new System.Drawing.Point(533, 55);
			pagamentoFuncionarioLabel.Name = "pagamentoFuncionarioLabel";
			pagamentoFuncionarioLabel.Size = new System.Drawing.Size(39, 13);
			pagamentoFuncionarioLabel.TabIndex = 12;
			pagamentoFuncionarioLabel.Text = "Salário";
			// 
			// identidadeFuncionarioLabel
			// 
			identidadeFuncionarioLabel.AutoSize = true;
			identidadeFuncionarioLabel.Location = new System.Drawing.Point(23, 86);
			identidadeFuncionarioLabel.Name = "identidadeFuncionarioLabel";
			identidadeFuncionarioLabel.Size = new System.Drawing.Size(27, 13);
			identidadeFuncionarioLabel.TabIndex = 14;
			identidadeFuncionarioLabel.Text = "CPF";
			// 
			// nascFuncionarioLabel
			// 
			nascFuncionarioLabel.AutoSize = true;
			nascFuncionarioLabel.Location = new System.Drawing.Point(24, 117);
			nascFuncionarioLabel.Name = "nascFuncionarioLabel";
			nascFuncionarioLabel.Size = new System.Drawing.Size(104, 13);
			nascFuncionarioLabel.TabIndex = 16;
			nascFuncionarioLabel.Text = "Data de Nascimento";
			// 
			// lblObs
			// 
			lblObs.AutoSize = true;
			lblObs.Location = new System.Drawing.Point(533, 120);
			lblObs.Name = "lblObs";
			lblObs.Size = new System.Drawing.Size(65, 13);
			lblObs.TabIndex = 115;
			lblObs.Text = "Observação";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.dgvBancoForm);
			this.panel1.Location = new System.Drawing.Point(4, 353);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(940, 253);
			this.panel1.TabIndex = 7;
			// 
			// dgvBancoForm
			// 
			this.dgvBancoForm.AllowUserToAddRows = false;
			this.dgvBancoForm.AutoGenerateColumns = false;
			this.dgvBancoForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBancoForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
			this.dgvBancoForm.DataSource = this.funcionarioBindingSource;
			this.dgvBancoForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvBancoForm.Location = new System.Drawing.Point(0, 0);
			this.dgvBancoForm.Name = "dgvBancoForm";
			this.dgvBancoForm.ReadOnly = true;
			this.dgvBancoForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvBancoForm.Size = new System.Drawing.Size(940, 253);
			this.dgvBancoForm.TabIndex = 0;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.dataGridViewTextBoxColumn1.DataPropertyName = "idFuncionario";
			this.dataGridViewTextBoxColumn1.Frozen = true;
			this.dataGridViewTextBoxColumn1.HeaderText = "Id do funcionário";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.dataGridViewTextBoxColumn4.DataPropertyName = "nomeFuncionario";
			this.dataGridViewTextBoxColumn4.Frozen = true;
			this.dataGridViewTextBoxColumn4.HeaderText = "Nome";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "telefoneFuncionario";
			this.dataGridViewTextBoxColumn2.Frozen = true;
			this.dataGridViewTextBoxColumn2.HeaderText = "Telefone";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.dataGridViewTextBoxColumn3.DataPropertyName = "enderecoFuncionario";
			this.dataGridViewTextBoxColumn3.Frozen = true;
			this.dataGridViewTextBoxColumn3.HeaderText = "Endereço";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.dataGridViewTextBoxColumn5.DataPropertyName = "bairroFuncionario";
			this.dataGridViewTextBoxColumn5.HeaderText = "Bairro";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn6.DataPropertyName = "celularFuncionario";
			this.dataGridViewTextBoxColumn6.HeaderText = "Celular";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn7.DataPropertyName = "pagamentoFuncionario";
			this.dataGridViewTextBoxColumn7.HeaderText = "Salário";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn8.DataPropertyName = "identidadeFuncionario";
			this.dataGridViewTextBoxColumn8.HeaderText = "CPF/RG";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "nascFuncionario";
			this.dataGridViewTextBoxColumn9.HeaderText = "Data de nascimento";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			// 
			// funcionarioBindingSource
			// 
			this.funcionarioBindingSource.DataMember = "Funcionario";
			this.funcionarioBindingSource.DataSource = this.dsPrincipal;
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
			this.btnLimparCampos.TabIndex = 11;
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
			this.btnConfirmar.TabIndex = 10;
			this.btnConfirmar.Text = "Confirmar";
			this.btnConfirmar.UseVisualStyleBackColor = true;
			this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.panel4.Controls.Add(this.btnConfirmar);
			this.panel4.Location = new System.Drawing.Point(822, 315);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(122, 32);
			this.panel4.TabIndex = 10;
			// 
			// pnlCampos
			// 
			this.pnlCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlCampos.Controls.Add(this.txtSalario);
			this.pnlCampos.Controls.Add(lblObs);
			this.pnlCampos.Controls.Add(this.txtObs);
			this.pnlCampos.Controls.Add(this.txtCelular);
			this.pnlCampos.Controls.Add(this.txtTelefone);
			this.pnlCampos.Controls.Add(this.txtIdentidade);
			this.pnlCampos.Controls.Add(this.dtpDataNascimento);
			this.pnlCampos.Controls.Add(idFuncionarioLabel);
			this.pnlCampos.Controls.Add(this.txtIdFuncionario);
			this.pnlCampos.Controls.Add(telefoneFuncionarioLabel);
			this.pnlCampos.Controls.Add(enderecoFuncionarioLabel);
			this.pnlCampos.Controls.Add(this.txtEndereco);
			this.pnlCampos.Controls.Add(nomeFuncionarioLabel);
			this.pnlCampos.Controls.Add(this.txtNome);
			this.pnlCampos.Controls.Add(bairroFuncionarioLabel);
			this.pnlCampos.Controls.Add(this.txtBairro);
			this.pnlCampos.Controls.Add(celularFuncionarioLabel);
			this.pnlCampos.Controls.Add(pagamentoFuncionarioLabel);
			this.pnlCampos.Controls.Add(identidadeFuncionarioLabel);
			this.pnlCampos.Controls.Add(nascFuncionarioLabel);
			this.pnlCampos.Location = new System.Drawing.Point(4, 5);
			this.pnlCampos.Name = "pnlCampos";
			this.pnlCampos.Size = new System.Drawing.Size(940, 299);
			this.pnlCampos.TabIndex = 9;
			// 
			// txtSalario
			// 
			this.txtSalario.Location = new System.Drawing.Point(610, 55);
			this.txtSalario.Mask = "$999,999.99";
			this.txtSalario.Name = "txtSalario";
			this.txtSalario.Size = new System.Drawing.Size(200, 20);
			this.txtSalario.TabIndex = 8;
			// 
			// txtObs
			// 
			this.txtObs.Location = new System.Drawing.Point(610, 114);
			this.txtObs.Multiline = true;
			this.txtObs.Name = "txtObs";
			this.txtObs.Size = new System.Drawing.Size(200, 110);
			this.txtObs.TabIndex = 9;
			// 
			// txtCelular
			// 
			this.txtCelular.Location = new System.Drawing.Point(282, 207);
			this.txtCelular.Mask = "(99)09999-9999";
			this.txtCelular.Name = "txtCelular";
			this.txtCelular.Size = new System.Drawing.Size(80, 20);
			this.txtCelular.TabIndex = 7;
			// 
			// txtTelefone
			// 
			this.txtTelefone.Location = new System.Drawing.Point(151, 207);
			this.txtTelefone.Mask = "(00)0000-0000";
			this.txtTelefone.Name = "txtTelefone";
			this.txtTelefone.Size = new System.Drawing.Size(80, 20);
			this.txtTelefone.TabIndex = 6;
			// 
			// txtIdentidade
			// 
			this.txtIdentidade.Location = new System.Drawing.Point(282, 79);
			this.txtIdentidade.Mask = "999,999,999-99";
			this.txtIdentidade.Name = "txtIdentidade";
			this.txtIdentidade.Size = new System.Drawing.Size(80, 20);
			this.txtIdentidade.TabIndex = 2;
			// 
			// dtpDataNascimento
			// 
			this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDataNascimento.Location = new System.Drawing.Point(267, 110);
			this.dtpDataNascimento.Name = "dtpDataNascimento";
			this.dtpDataNascimento.Size = new System.Drawing.Size(95, 20);
			this.dtpDataNascimento.TabIndex = 3;
			// 
			// txtIdFuncionario
			// 
			this.txtIdFuncionario.Enabled = false;
			this.txtIdFuncionario.Location = new System.Drawing.Point(150, 5);
			this.txtIdFuncionario.Name = "txtIdFuncionario";
			this.txtIdFuncionario.Size = new System.Drawing.Size(782, 20);
			this.txtIdFuncionario.TabIndex = 111;
			// 
			// txtEndereco
			// 
			this.txtEndereco.Location = new System.Drawing.Point(150, 144);
			this.txtEndereco.Name = "txtEndereco";
			this.txtEndereco.Size = new System.Drawing.Size(212, 20);
			this.txtEndereco.TabIndex = 4;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(150, 51);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(212, 20);
			this.txtNome.TabIndex = 1;
			// 
			// txtBairro
			// 
			this.txtBairro.Location = new System.Drawing.Point(151, 175);
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(212, 20);
			this.txtBairro.TabIndex = 5;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.panel2.Controls.Add(this.btnLimparCampos);
			this.panel2.Location = new System.Drawing.Point(4, 314);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(152, 33);
			this.panel2.TabIndex = 8;
			// 
			// funcionarioTableAdapter
			// 
			this.funcionarioTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.AtendimentoTableAdapter = null;
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CarroTableAdapter = null;
			this.tableAdapterManager.ClienteTableAdapter = null;
			this.tableAdapterManager.FornecedorTableAdapter = null;
			this.tableAdapterManager.FornecimentoTableAdapter = null;
			this.tableAdapterManager.FuncionarioTableAdapter = this.funcionarioTableAdapter;
			this.tableAdapterManager.Produtos_AtendimentoTableAdapter = null;
			this.tableAdapterManager.Produtos_FornecimentoTableAdapter = null;
			this.tableAdapterManager.ProdutoTableAdapter = null;
			this.tableAdapterManager.Serviços_AtendimentoTableAdapter = null;
			this.tableAdapterManager.ServicoTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = frmMenuPrincipal.Dados.dsPrincipalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// frmCadastroFuncionários
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(948, 610);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.pnlCampos);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmCadastroFuncionários";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de funcionários";
			this.Load += new System.EventHandler(this.frmCadastroFuncionários_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvBancoForm)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
			this.panel4.ResumeLayout(false);
			this.pnlCampos.ResumeLayout(false);
			this.pnlCampos.PerformLayout();
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
		private Dados.dsPrincipalTableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
		private System.Windows.Forms.TextBox txtIdFuncionario;
		private System.Windows.Forms.TextBox txtEndereco;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtBairro;
		private Dados.dsPrincipalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.MaskedTextBox txtIdentidade;
		private System.Windows.Forms.MaskedTextBox txtCelular;
		private System.Windows.Forms.MaskedTextBox txtTelefone;
		private System.Windows.Forms.TextBox txtObs;
		private System.Windows.Forms.DataGridViewTextBoxColumn idFuncionarioDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeFuncionarioDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn identidadeFuncionarioDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nascFuncionarioDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn enderecoFuncionarioDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bairroFuncionarioDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telefoneFuncionarioDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn celularFuncionarioDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pagamentoFuncionarioDataGridViewTextBoxColumn;
		private System.Windows.Forms.MaskedTextBox txtSalario;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}