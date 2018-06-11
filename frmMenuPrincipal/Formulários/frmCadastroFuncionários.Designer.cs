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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvBancoForm = new System.Windows.Forms.DataGridView();
            this.idFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identidadeFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamentoFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrincipal = new frmMenuPrincipal.Dados.dsPrincipal();
            this.btnLimparCampos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnConfirmar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlCampos = new System.Windows.Forms.Panel();
            this.txtIdFuncionario = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtSalário = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.funcionarioTableAdapter = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.FuncionarioTableAdapter();
            this.tableAdapterManager = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.TableAdapterManager();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            idFuncionarioLabel = new System.Windows.Forms.Label();
            telefoneFuncionarioLabel = new System.Windows.Forms.Label();
            enderecoFuncionarioLabel = new System.Windows.Forms.Label();
            nomeFuncionarioLabel = new System.Windows.Forms.Label();
            bairroFuncionarioLabel = new System.Windows.Forms.Label();
            celularFuncionarioLabel = new System.Windows.Forms.Label();
            pagamentoFuncionarioLabel = new System.Windows.Forms.Label();
            identidadeFuncionarioLabel = new System.Windows.Forms.Label();
            nascFuncionarioLabel = new System.Windows.Forms.Label();
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
            idFuncionarioLabel.Location = new System.Drawing.Point(23, 8);
            idFuncionarioLabel.Name = "idFuncionarioLabel";
            idFuncionarioLabel.Size = new System.Drawing.Size(92, 13);
            idFuncionarioLabel.TabIndex = 0;
            idFuncionarioLabel.Text = "Id do Funcionário:";
            // 
            // telefoneFuncionarioLabel
            // 
            telefoneFuncionarioLabel.AutoSize = true;
            telefoneFuncionarioLabel.Location = new System.Drawing.Point(23, 210);
            telefoneFuncionarioLabel.Name = "telefoneFuncionarioLabel";
            telefoneFuncionarioLabel.Size = new System.Drawing.Size(49, 13);
            telefoneFuncionarioLabel.TabIndex = 2;
            telefoneFuncionarioLabel.Text = "Telefone";
            // 
            // enderecoFuncionarioLabel
            // 
            enderecoFuncionarioLabel.AutoSize = true;
            enderecoFuncionarioLabel.Location = new System.Drawing.Point(23, 148);
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
            bairroFuncionarioLabel.Location = new System.Drawing.Point(24, 179);
            bairroFuncionarioLabel.Name = "bairroFuncionarioLabel";
            bairroFuncionarioLabel.Size = new System.Drawing.Size(34, 13);
            bairroFuncionarioLabel.TabIndex = 8;
            bairroFuncionarioLabel.Text = "Bairro";
            // 
            // celularFuncionarioLabel
            // 
            celularFuncionarioLabel.AutoSize = true;
            celularFuncionarioLabel.Location = new System.Drawing.Point(24, 241);
            celularFuncionarioLabel.Name = "celularFuncionarioLabel";
            celularFuncionarioLabel.Size = new System.Drawing.Size(39, 13);
            celularFuncionarioLabel.TabIndex = 10;
            celularFuncionarioLabel.Text = "Celular";
            // 
            // pagamentoFuncionarioLabel
            // 
            pagamentoFuncionarioLabel.AutoSize = true;
            pagamentoFuncionarioLabel.Location = new System.Drawing.Point(483, 54);
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
            this.idFuncionarioDataGridViewTextBoxColumn,
            this.nomeFuncionarioDataGridViewTextBoxColumn,
            this.identidadeFuncionarioDataGridViewTextBoxColumn,
            this.nascFuncionarioDataGridViewTextBoxColumn,
            this.enderecoFuncionarioDataGridViewTextBoxColumn,
            this.bairroFuncionarioDataGridViewTextBoxColumn,
            this.telefoneFuncionarioDataGridViewTextBoxColumn,
            this.celularFuncionarioDataGridViewTextBoxColumn,
            this.pagamentoFuncionarioDataGridViewTextBoxColumn});
            this.dgvBancoForm.DataSource = this.funcionarioBindingSource;
            this.dgvBancoForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBancoForm.Location = new System.Drawing.Point(0, 0);
            this.dgvBancoForm.Name = "dgvBancoForm";
            this.dgvBancoForm.ReadOnly = true;
            this.dgvBancoForm.Size = new System.Drawing.Size(940, 253);
            this.dgvBancoForm.TabIndex = 0;
            // 
            // idFuncionarioDataGridViewTextBoxColumn
            // 
            this.idFuncionarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "idFuncionario";
            this.idFuncionarioDataGridViewTextBoxColumn.HeaderText = "Id do Funcionário";
            this.idFuncionarioDataGridViewTextBoxColumn.Name = "idFuncionarioDataGridViewTextBoxColumn";
            this.idFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeFuncionarioDataGridViewTextBoxColumn
            // 
            this.nomeFuncionarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "nomeFuncionario";
            this.nomeFuncionarioDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeFuncionarioDataGridViewTextBoxColumn.Name = "nomeFuncionarioDataGridViewTextBoxColumn";
            this.nomeFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // identidadeFuncionarioDataGridViewTextBoxColumn
            // 
            this.identidadeFuncionarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.identidadeFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "identidadeFuncionario";
            this.identidadeFuncionarioDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.identidadeFuncionarioDataGridViewTextBoxColumn.Name = "identidadeFuncionarioDataGridViewTextBoxColumn";
            this.identidadeFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nascFuncionarioDataGridViewTextBoxColumn
            // 
            this.nascFuncionarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nascFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "nascFuncionario";
            this.nascFuncionarioDataGridViewTextBoxColumn.HeaderText = "Data de nascimento";
            this.nascFuncionarioDataGridViewTextBoxColumn.Name = "nascFuncionarioDataGridViewTextBoxColumn";
            this.nascFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoFuncionarioDataGridViewTextBoxColumn
            // 
            this.enderecoFuncionarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.enderecoFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "enderecoFuncionario";
            this.enderecoFuncionarioDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.enderecoFuncionarioDataGridViewTextBoxColumn.Name = "enderecoFuncionarioDataGridViewTextBoxColumn";
            this.enderecoFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bairroFuncionarioDataGridViewTextBoxColumn
            // 
            this.bairroFuncionarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bairroFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "bairroFuncionario";
            this.bairroFuncionarioDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroFuncionarioDataGridViewTextBoxColumn.Name = "bairroFuncionarioDataGridViewTextBoxColumn";
            this.bairroFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneFuncionarioDataGridViewTextBoxColumn
            // 
            this.telefoneFuncionarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefoneFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "telefoneFuncionario";
            this.telefoneFuncionarioDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneFuncionarioDataGridViewTextBoxColumn.Name = "telefoneFuncionarioDataGridViewTextBoxColumn";
            this.telefoneFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // celularFuncionarioDataGridViewTextBoxColumn
            // 
            this.celularFuncionarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.celularFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "celularFuncionario";
            this.celularFuncionarioDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularFuncionarioDataGridViewTextBoxColumn.Name = "celularFuncionarioDataGridViewTextBoxColumn";
            this.celularFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pagamentoFuncionarioDataGridViewTextBoxColumn
            // 
            this.pagamentoFuncionarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pagamentoFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "pagamentoFuncionario";
            this.pagamentoFuncionarioDataGridViewTextBoxColumn.HeaderText = "Salário";
            this.pagamentoFuncionarioDataGridViewTextBoxColumn.Name = "pagamentoFuncionarioDataGridViewTextBoxColumn";
            this.pagamentoFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.pnlCampos.Controls.Add(this.dtpDataNascimento);
            this.pnlCampos.Controls.Add(idFuncionarioLabel);
            this.pnlCampos.Controls.Add(this.txtIdFuncionario);
            this.pnlCampos.Controls.Add(telefoneFuncionarioLabel);
            this.pnlCampos.Controls.Add(this.txtTelefone);
            this.pnlCampos.Controls.Add(enderecoFuncionarioLabel);
            this.pnlCampos.Controls.Add(this.txtEndereco);
            this.pnlCampos.Controls.Add(nomeFuncionarioLabel);
            this.pnlCampos.Controls.Add(this.txtNome);
            this.pnlCampos.Controls.Add(bairroFuncionarioLabel);
            this.pnlCampos.Controls.Add(this.txtBairro);
            this.pnlCampos.Controls.Add(celularFuncionarioLabel);
            this.pnlCampos.Controls.Add(this.txtCelular);
            this.pnlCampos.Controls.Add(pagamentoFuncionarioLabel);
            this.pnlCampos.Controls.Add(this.txtSalário);
            this.pnlCampos.Controls.Add(identidadeFuncionarioLabel);
            this.pnlCampos.Controls.Add(this.txtCPF);
            this.pnlCampos.Controls.Add(nascFuncionarioLabel);
            this.pnlCampos.Location = new System.Drawing.Point(4, 5);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(940, 299);
            this.pnlCampos.TabIndex = 9;
            // 
            // txtIdFuncionario
            // 
            this.txtIdFuncionario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "idFuncionario", true));
            this.txtIdFuncionario.Enabled = false;
            this.txtIdFuncionario.Location = new System.Drawing.Point(150, 5);
            this.txtIdFuncionario.Name = "txtIdFuncionario";
            this.txtIdFuncionario.Size = new System.Drawing.Size(782, 20);
            this.txtIdFuncionario.TabIndex = 1;
            // 
            // txtTelefone
            // 
            this.txtTelefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "telefoneFuncionario", true));
            this.txtTelefone.Location = new System.Drawing.Point(150, 206);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(200, 20);
            this.txtTelefone.TabIndex = 3;
            // 
            // txtEndereco
            // 
            this.txtEndereco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "enderecoFuncionario", true));
            this.txtEndereco.Location = new System.Drawing.Point(150, 144);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(200, 20);
            this.txtEndereco.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "nomeFuncionario", true));
            this.txtNome.Location = new System.Drawing.Point(150, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 20);
            this.txtNome.TabIndex = 7;
            // 
            // txtBairro
            // 
            this.txtBairro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "bairroFuncionario", true));
            this.txtBairro.Location = new System.Drawing.Point(151, 175);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(200, 20);
            this.txtBairro.TabIndex = 9;
            // 
            // txtCelular
            // 
            this.txtCelular.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "celularFuncionario", true));
            this.txtCelular.Location = new System.Drawing.Point(151, 237);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(200, 20);
            this.txtCelular.TabIndex = 11;
            // 
            // txtSalário
            // 
            this.txtSalário.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "pagamentoFuncionario", true));
            this.txtSalário.Location = new System.Drawing.Point(610, 51);
            this.txtSalário.Name = "txtSalário";
            this.txtSalário.Size = new System.Drawing.Size(200, 20);
            this.txtSalário.TabIndex = 13;
            // 
            // txtCPF
            // 
            this.txtCPF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "identidadeFuncionario", true));
            this.txtCPF.Location = new System.Drawing.Point(150, 82);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(200, 20);
            this.txtCPF.TabIndex = 15;
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
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(273, 111);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(77, 20);
            this.dtpDataNascimento.TabIndex = 17;
            // 
            // frmCadastroFuncionários
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlCampos);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastroFuncionários";
            this.Text = "frmCadastroFuncionários";
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
		private System.Windows.Forms.BindingSource funcionarioBindingSource;
		private Dados.dsPrincipalTableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idFuncionarioDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeFuncionarioDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn identidadeFuncionarioDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nascFuncionarioDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn enderecoFuncionarioDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bairroFuncionarioDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telefoneFuncionarioDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn celularFuncionarioDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pagamentoFuncionarioDataGridViewTextBoxColumn;
		private System.Windows.Forms.TextBox txtIdFuncionario;
		private System.Windows.Forms.TextBox txtTelefone;
		private System.Windows.Forms.TextBox txtEndereco;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtBairro;
		private System.Windows.Forms.TextBox txtCelular;
		private System.Windows.Forms.TextBox txtSalário;
		private System.Windows.Forms.TextBox txtCPF;
		private Dados.dsPrincipalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
    }
}