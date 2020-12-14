﻿namespace frmMenuPrincipal.Formulários
{
    partial class frmCadastroClientes
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
			this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
			this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
			this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
			this.lblCPFouCNPJ = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtEndereco = new System.Windows.Forms.TextBox();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnConfirmar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnLimparCampos = new MaterialSkin.Controls.MaterialRaisedButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgvBancoForm = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataInfoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dsPrincipal = new frmMenuPrincipal.Dados.dsPrincipal();
			this.clienteTableAdapter = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.ClienteTableAdapter();
			this.pnlIdentidade = new System.Windows.Forms.Panel();
			this.rbCNPJ = new System.Windows.Forms.RadioButton();
			this.rbCPF = new System.Windows.Forms.RadioButton();
			this.pnlCampos = new System.Windows.Forms.Panel();
			this.txtGastos = new System.Windows.Forms.MaskedTextBox();
			this.txtCelular = new System.Windows.Forms.MaskedTextBox();
			this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
			this.txtIdentidade = new System.Windows.Forms.MaskedTextBox();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBancoForm)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
			this.pnlIdentidade.SuspendLayout();
			this.pnlCampos.SuspendLayout();
			this.SuspendLayout();
			// 
			// materialLabel7
			// 
			this.materialLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.materialLabel7.AutoSize = true;
			this.materialLabel7.Depth = 0;
			this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel7.Location = new System.Drawing.Point(613, 38);
			this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel7.Name = "materialLabel7";
			this.materialLabel7.Size = new System.Drawing.Size(68, 19);
			this.materialLabel7.TabIndex = 89;
			this.materialLabel7.Text = "Telefone";
			// 
			// materialLabel8
			// 
			this.materialLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.materialLabel8.AutoSize = true;
			this.materialLabel8.Depth = 0;
			this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel8.Location = new System.Drawing.Point(613, 64);
			this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel8.Name = "materialLabel8";
			this.materialLabel8.Size = new System.Drawing.Size(56, 19);
			this.materialLabel8.TabIndex = 88;
			this.materialLabel8.Text = "Celular";
			// 
			// materialLabel9
			// 
			this.materialLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.materialLabel9.AutoSize = true;
			this.materialLabel9.Depth = 0;
			this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel9.Location = new System.Drawing.Point(613, 90);
			this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel9.Name = "materialLabel9";
			this.materialLabel9.Size = new System.Drawing.Size(51, 19);
			this.materialLabel9.TabIndex = 87;
			this.materialLabel9.Text = "E-Mail";
			// 
			// materialLabel10
			// 
			this.materialLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.materialLabel10.AutoSize = true;
			this.materialLabel10.Depth = 0;
			this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel10.Location = new System.Drawing.Point(613, 140);
			this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel10.Name = "materialLabel10";
			this.materialLabel10.Size = new System.Drawing.Size(57, 19);
			this.materialLabel10.TabIndex = 86;
			this.materialLabel10.Text = "Gastos";
			// 
			// dtpDataNascimento
			// 
			this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDataNascimento.Location = new System.Drawing.Point(268, 88);
			this.dtpDataNascimento.Name = "dtpDataNascimento";
			this.dtpDataNascimento.Size = new System.Drawing.Size(108, 20);
			this.dtpDataNascimento.TabIndex = 4;
			// 
			// materialLabel6
			// 
			this.materialLabel6.AutoSize = true;
			this.materialLabel6.Depth = 0;
			this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel6.Location = new System.Drawing.Point(5, 38);
			this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel6.Name = "materialLabel6";
			this.materialLabel6.Size = new System.Drawing.Size(50, 19);
			this.materialLabel6.TabIndex = 84;
			this.materialLabel6.Text = "Nome";
			// 
			// lblCPFouCNPJ
			// 
			this.lblCPFouCNPJ.AutoSize = true;
			this.lblCPFouCNPJ.Depth = 0;
			this.lblCPFouCNPJ.Font = new System.Drawing.Font("Roboto", 11F);
			this.lblCPFouCNPJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblCPFouCNPJ.Location = new System.Drawing.Point(5, 64);
			this.lblCPFouCNPJ.MouseState = MaterialSkin.MouseState.HOVER;
			this.lblCPFouCNPJ.Name = "lblCPFouCNPJ";
			this.lblCPFouCNPJ.Size = new System.Drawing.Size(80, 19);
			this.lblCPFouCNPJ.TabIndex = 83;
			this.lblCPFouCNPJ.Text = "CPF/CNPJ";
			// 
			// materialLabel4
			// 
			this.materialLabel4.AutoSize = true;
			this.materialLabel4.Depth = 0;
			this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel4.Location = new System.Drawing.Point(5, 90);
			this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel4.Name = "materialLabel4";
			this.materialLabel4.Size = new System.Drawing.Size(146, 19);
			this.materialLabel4.TabIndex = 82;
			this.materialLabel4.Text = "Data de Nascimento";
			// 
			// materialLabel3
			// 
			this.materialLabel3.AutoSize = true;
			this.materialLabel3.Depth = 0;
			this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel3.Location = new System.Drawing.Point(5, 115);
			this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel3.Name = "materialLabel3";
			this.materialLabel3.Size = new System.Drawing.Size(72, 19);
			this.materialLabel3.TabIndex = 81;
			this.materialLabel3.Text = "Endereço";
			// 
			// materialLabel2
			// 
			this.materialLabel2.AutoSize = true;
			this.materialLabel2.Depth = 0;
			this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel2.Location = new System.Drawing.Point(6, 141);
			this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel2.Name = "materialLabel2";
			this.materialLabel2.Size = new System.Drawing.Size(49, 19);
			this.materialLabel2.TabIndex = 80;
			this.materialLabel2.Text = "Bairro";
			// 
			// materialLabel1
			// 
			this.materialLabel1.AutoSize = true;
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel1.Location = new System.Drawing.Point(5, 12);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(93, 19);
			this.materialLabel1.TabIndex = 79;
			this.materialLabel1.Text = "Id do Cliente";
			// 
			// txtEmail
			// 
			this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtEmail.Location = new System.Drawing.Point(709, 89);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(200, 20);
			this.txtEmail.TabIndex = 9;
			// 
			// txtId
			// 
			this.txtId.Enabled = false;
			this.txtId.Location = new System.Drawing.Point(157, 11);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(753, 20);
			this.txtId.TabIndex = 111;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(157, 37);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(219, 20);
			this.txtNome.TabIndex = 1;
			// 
			// txtEndereco
			// 
			this.txtEndereco.Location = new System.Drawing.Point(157, 114);
			this.txtEndereco.Name = "txtEndereco";
			this.txtEndereco.Size = new System.Drawing.Size(219, 20);
			this.txtEndereco.TabIndex = 5;
			// 
			// txtBairro
			// 
			this.txtBairro.Location = new System.Drawing.Point(157, 140);
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(219, 20);
			this.txtBairro.TabIndex = 6;
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.panel4.Controls.Add(this.btnConfirmar);
			this.panel4.Location = new System.Drawing.Point(814, 191);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(122, 32);
			this.panel4.TabIndex = 92;
			// 
			// btnConfirmar
			// 
			this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnConfirmar.Depth = 0;
			this.btnConfirmar.Location = new System.Drawing.Point(0, 0);
			this.btnConfirmar.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnConfirmar.Name = "btnConfirmar";
			this.btnConfirmar.Primary = true;
			this.btnConfirmar.Size = new System.Drawing.Size(122, 32);
			this.btnConfirmar.TabIndex = 11;
			this.btnConfirmar.Text = "Confirmar";
			this.btnConfirmar.UseVisualStyleBackColor = true;
			this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.panel2.Controls.Add(this.btnLimparCampos);
			this.panel2.Location = new System.Drawing.Point(17, 187);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(126, 36);
			this.panel2.TabIndex = 91;
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
			this.btnLimparCampos.TabIndex = 12;
			this.btnLimparCampos.Text = "Limpar Campos";
			this.btnLimparCampos.UseVisualStyleBackColor = true;
			this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.dgvBancoForm);
			this.panel1.Location = new System.Drawing.Point(16, 229);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(920, 369);
			this.panel1.TabIndex = 90;
			// 
			// dgvBancoForm
			// 
			this.dgvBancoForm.AllowUserToAddRows = false;
			this.dgvBancoForm.AutoGenerateColumns = false;
			this.dgvBancoForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBancoForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataInfoClienteDataGridViewTextBoxColumn});
			this.dgvBancoForm.DataSource = this.clienteBindingSource;
			this.dgvBancoForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvBancoForm.Location = new System.Drawing.Point(0, 0);
			this.dgvBancoForm.Name = "dgvBancoForm";
			this.dgvBancoForm.ReadOnly = true;
			this.dgvBancoForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvBancoForm.Size = new System.Drawing.Size(920, 369);
			this.dgvBancoForm.TabIndex = 0;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.DataPropertyName = "idCliente";
			this.dataGridViewTextBoxColumn1.HeaderText = "Id do Cliente";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeCliente";
			this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn3.DataPropertyName = "telefoneCliente";
			this.dataGridViewTextBoxColumn3.HeaderText = "Telefone";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn4.DataPropertyName = "emailCliente";
			this.dataGridViewTextBoxColumn4.HeaderText = "E-mail";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn5.DataPropertyName = "enderecoCliente";
			this.dataGridViewTextBoxColumn5.HeaderText = "Endereço";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn6.DataPropertyName = "bairroCliente";
			this.dataGridViewTextBoxColumn6.HeaderText = "Bairro";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn7.DataPropertyName = "identidadeCliente";
			this.dataGridViewTextBoxColumn7.HeaderText = "CPF/CNPJ";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn8.DataPropertyName = "celularCliente";
			this.dataGridViewTextBoxColumn8.HeaderText = "Celular";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn9.DataPropertyName = "nascCliente";
			this.dataGridViewTextBoxColumn9.HeaderText = "Data de nascimento";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "pagamentosCliente";
			this.dataGridViewTextBoxColumn10.HeaderText = "Gastos";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.ReadOnly = true;
			// 
			// dataInfoClienteDataGridViewTextBoxColumn
			// 
			this.dataInfoClienteDataGridViewTextBoxColumn.DataPropertyName = "dataInfoCliente";
			this.dataInfoClienteDataGridViewTextBoxColumn.HeaderText = "Data da informação";
			this.dataInfoClienteDataGridViewTextBoxColumn.Name = "dataInfoClienteDataGridViewTextBoxColumn";
			this.dataInfoClienteDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// clienteBindingSource
			// 
			this.clienteBindingSource.DataMember = "Cliente";
			this.clienteBindingSource.DataSource = this.dsPrincipal;
			// 
			// dsPrincipal
			// 
			this.dsPrincipal.DataSetName = "dsPrincipal";
			this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// clienteTableAdapter
			// 
			this.clienteTableAdapter.ClearBeforeFill = true;
			// 
			// pnlIdentidade
			// 
			this.pnlIdentidade.Controls.Add(this.rbCNPJ);
			this.pnlIdentidade.Controls.Add(this.rbCPF);
			this.pnlIdentidade.Location = new System.Drawing.Point(268, 61);
			this.pnlIdentidade.Name = "pnlIdentidade";
			this.pnlIdentidade.Size = new System.Drawing.Size(108, 21);
			this.pnlIdentidade.TabIndex = 3;
			// 
			// rbCNPJ
			// 
			this.rbCNPJ.AutoSize = true;
			this.rbCNPJ.Location = new System.Drawing.Point(54, 2);
			this.rbCNPJ.Name = "rbCNPJ";
			this.rbCNPJ.Size = new System.Drawing.Size(52, 17);
			this.rbCNPJ.TabIndex = 13;
			this.rbCNPJ.Text = "CNPJ";
			this.rbCNPJ.UseVisualStyleBackColor = true;
			// 
			// rbCPF
			// 
			this.rbCPF.AutoSize = true;
			this.rbCPF.Checked = true;
			this.rbCPF.Location = new System.Drawing.Point(3, 2);
			this.rbCPF.Name = "rbCPF";
			this.rbCPF.Size = new System.Drawing.Size(45, 17);
			this.rbCPF.TabIndex = 3;
			this.rbCPF.TabStop = true;
			this.rbCPF.Text = "CPF";
			this.rbCPF.UseVisualStyleBackColor = true;
			this.rbCPF.CheckedChanged += new System.EventHandler(this.rbCPF_CheckedChanged);
			// 
			// pnlCampos
			// 
			this.pnlCampos.Controls.Add(this.txtGastos);
			this.pnlCampos.Controls.Add(this.txtCelular);
			this.pnlCampos.Controls.Add(this.txtTelefone);
			this.pnlCampos.Controls.Add(this.txtIdentidade);
			this.pnlCampos.Controls.Add(this.pnlIdentidade);
			this.pnlCampos.Controls.Add(this.materialLabel7);
			this.pnlCampos.Controls.Add(this.materialLabel8);
			this.pnlCampos.Controls.Add(this.materialLabel9);
			this.pnlCampos.Controls.Add(this.materialLabel10);
			this.pnlCampos.Controls.Add(this.dtpDataNascimento);
			this.pnlCampos.Controls.Add(this.materialLabel6);
			this.pnlCampos.Controls.Add(this.lblCPFouCNPJ);
			this.pnlCampos.Controls.Add(this.materialLabel4);
			this.pnlCampos.Controls.Add(this.materialLabel3);
			this.pnlCampos.Controls.Add(this.materialLabel2);
			this.pnlCampos.Controls.Add(this.materialLabel1);
			this.pnlCampos.Controls.Add(this.txtEmail);
			this.pnlCampos.Controls.Add(this.txtId);
			this.pnlCampos.Controls.Add(this.txtNome);
			this.pnlCampos.Controls.Add(this.txtEndereco);
			this.pnlCampos.Controls.Add(this.txtBairro);
			this.pnlCampos.Location = new System.Drawing.Point(16, 12);
			this.pnlCampos.Name = "pnlCampos";
			this.pnlCampos.Size = new System.Drawing.Size(920, 169);
			this.pnlCampos.TabIndex = 94;
			// 
			// txtGastos
			// 
			this.txtGastos.Location = new System.Drawing.Point(709, 139);
			this.txtGastos.Mask = "$999,999.00";
			this.txtGastos.Name = "txtGastos";
			this.txtGastos.Size = new System.Drawing.Size(200, 20);
			this.txtGastos.TabIndex = 10;
			// 
			// txtCelular
			// 
			this.txtCelular.Location = new System.Drawing.Point(709, 63);
			this.txtCelular.Mask = "(99)90000-0000";
			this.txtCelular.Name = "txtCelular";
			this.txtCelular.Size = new System.Drawing.Size(85, 20);
			this.txtCelular.TabIndex = 8;
			// 
			// txtTelefone
			// 
			this.txtTelefone.Location = new System.Drawing.Point(709, 39);
			this.txtTelefone.Mask = "(99)0000-0000";
			this.txtTelefone.Name = "txtTelefone";
			this.txtTelefone.Size = new System.Drawing.Size(85, 20);
			this.txtTelefone.TabIndex = 7;
			// 
			// txtIdentidade
			// 
			this.txtIdentidade.Location = new System.Drawing.Point(157, 64);
			this.txtIdentidade.Mask = "999,999,999-99";
			this.txtIdentidade.Name = "txtIdentidade";
			this.txtIdentidade.Size = new System.Drawing.Size(82, 20);
			this.txtIdentidade.TabIndex = 2;
			// 
			// frmCadastroClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(948, 610);
			this.Controls.Add(this.pnlCampos);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmCadastroClientes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de clientes";
			this.Load += new System.EventHandler(this.frmCadastroClientes_Load);
			this.panel4.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvBancoForm)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
			this.pnlIdentidade.ResumeLayout(false);
			this.pnlIdentidade.PerformLayout();
			this.pnlCampos.ResumeLayout(false);
			this.pnlCampos.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel lblCPFouCNPJ;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.Panel panel4;
        public MaterialSkin.Controls.MaterialRaisedButton btnConfirmar;
        public System.Windows.Forms.Panel panel2;
        public MaterialSkin.Controls.MaterialRaisedButton btnLimparCampos;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dgvBancoForm;
		private Dados.dsPrincipal dsPrincipal;
		private Dados.dsPrincipalTableAdapters.ClienteTableAdapter clienteTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn identidadeClienteDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nascClienteDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn enderecoClienteDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bairroClienteDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telefoneClienteDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn celularClienteDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailClienteDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pagamentosClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel pnlIdentidade;
        private System.Windows.Forms.RadioButton rbCNPJ;
        private System.Windows.Forms.RadioButton rbCPF;
        private System.Windows.Forms.Panel pnlCampos;
        private System.Windows.Forms.MaskedTextBox txtIdentidade;
        private System.Windows.Forms.MaskedTextBox txtGastos;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInfoClienteDataGridViewTextBoxColumn;
	}
}