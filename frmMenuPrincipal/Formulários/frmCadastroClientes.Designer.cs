namespace frmMenuPrincipal.Formulários
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
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.idClienteTextBox = new System.Windows.Forms.TextBox();
			this.nomeClienteTextBox = new System.Windows.Forms.TextBox();
			this.telefoneClienteTextBox = new System.Windows.Forms.TextBox();
			this.enderecoClienteTextBox = new System.Windows.Forms.TextBox();
			this.bairroClienteTextBox = new System.Windows.Forms.TextBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnConfirmar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnLimparCampos = new MaterialSkin.Controls.MaterialRaisedButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgvBancoForm = new System.Windows.Forms.DataGridView();
			this.dsPrincipal = new frmMenuPrincipal.Dados.dsPrincipal();
			this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.clienteTableAdapter = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.ClienteTableAdapter();
			this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.identidadeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nascClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.enderecoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bairroClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telefoneClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.celularClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pagamentosClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBancoForm)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// materialLabel7
			// 
			this.materialLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.materialLabel7.AutoSize = true;
			this.materialLabel7.Depth = 0;
			this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel7.Location = new System.Drawing.Point(649, 10);
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
			this.materialLabel8.Location = new System.Drawing.Point(649, 36);
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
			this.materialLabel9.Location = new System.Drawing.Point(649, 62);
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
			this.materialLabel10.Location = new System.Drawing.Point(648, 137);
			this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel10.Name = "materialLabel10";
			this.materialLabel10.Size = new System.Drawing.Size(57, 19);
			this.materialLabel10.TabIndex = 86;
			this.materialLabel10.Text = "Gastos";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(275, 85);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(89, 20);
			this.dateTimePicker1.TabIndex = 85;
			// 
			// materialLabel6
			// 
			this.materialLabel6.AutoSize = true;
			this.materialLabel6.Depth = 0;
			this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel6.Location = new System.Drawing.Point(12, 35);
			this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel6.Name = "materialLabel6";
			this.materialLabel6.Size = new System.Drawing.Size(50, 19);
			this.materialLabel6.TabIndex = 84;
			this.materialLabel6.Text = "Nome";
			// 
			// materialLabel5
			// 
			this.materialLabel5.AutoSize = true;
			this.materialLabel5.Depth = 0;
			this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel5.Location = new System.Drawing.Point(12, 61);
			this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel5.Name = "materialLabel5";
			this.materialLabel5.Size = new System.Drawing.Size(36, 19);
			this.materialLabel5.TabIndex = 83;
			this.materialLabel5.Text = "CPF";
			// 
			// materialLabel4
			// 
			this.materialLabel4.AutoSize = true;
			this.materialLabel4.Depth = 0;
			this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel4.Location = new System.Drawing.Point(12, 87);
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
			this.materialLabel3.Location = new System.Drawing.Point(12, 112);
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
			this.materialLabel2.Location = new System.Drawing.Point(13, 138);
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
			this.materialLabel1.Location = new System.Drawing.Point(12, 9);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(93, 19);
			this.materialLabel1.TabIndex = 79;
			this.materialLabel1.Text = "Id do Cliente";
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(736, 9);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(200, 20);
			this.textBox1.TabIndex = 75;
			// 
			// textBox2
			// 
			this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox2.Location = new System.Drawing.Point(736, 35);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(200, 20);
			this.textBox2.TabIndex = 76;
			// 
			// textBox3
			// 
			this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox3.Location = new System.Drawing.Point(736, 61);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(200, 20);
			this.textBox3.TabIndex = 77;
			// 
			// textBox4
			// 
			this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox4.Location = new System.Drawing.Point(736, 138);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(200, 20);
			this.textBox4.TabIndex = 78;
			// 
			// idClienteTextBox
			// 
			this.idClienteTextBox.Enabled = false;
			this.idClienteTextBox.Location = new System.Drawing.Point(164, 8);
			this.idClienteTextBox.Name = "idClienteTextBox";
			this.idClienteTextBox.Size = new System.Drawing.Size(200, 20);
			this.idClienteTextBox.TabIndex = 70;
			// 
			// nomeClienteTextBox
			// 
			this.nomeClienteTextBox.Location = new System.Drawing.Point(164, 34);
			this.nomeClienteTextBox.Name = "nomeClienteTextBox";
			this.nomeClienteTextBox.Size = new System.Drawing.Size(200, 20);
			this.nomeClienteTextBox.TabIndex = 71;
			// 
			// telefoneClienteTextBox
			// 
			this.telefoneClienteTextBox.Location = new System.Drawing.Point(164, 60);
			this.telefoneClienteTextBox.Name = "telefoneClienteTextBox";
			this.telefoneClienteTextBox.Size = new System.Drawing.Size(200, 20);
			this.telefoneClienteTextBox.TabIndex = 72;
			// 
			// enderecoClienteTextBox
			// 
			this.enderecoClienteTextBox.Location = new System.Drawing.Point(164, 111);
			this.enderecoClienteTextBox.Name = "enderecoClienteTextBox";
			this.enderecoClienteTextBox.Size = new System.Drawing.Size(200, 20);
			this.enderecoClienteTextBox.TabIndex = 73;
			// 
			// bairroClienteTextBox
			// 
			this.bairroClienteTextBox.Location = new System.Drawing.Point(164, 137);
			this.bairroClienteTextBox.Name = "bairroClienteTextBox";
			this.bairroClienteTextBox.Size = new System.Drawing.Size(200, 20);
			this.bairroClienteTextBox.TabIndex = 74;
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
			this.btnConfirmar.TabIndex = 2;
			this.btnConfirmar.Text = "Confirmar";
			this.btnConfirmar.UseVisualStyleBackColor = true;
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
			this.btnLimparCampos.TabIndex = 3;
			this.btnLimparCampos.Text = "Limpar Campos";
			this.btnLimparCampos.UseVisualStyleBackColor = true;
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
            this.idClienteDataGridViewTextBoxColumn,
            this.nomeClienteDataGridViewTextBoxColumn,
            this.identidadeClienteDataGridViewTextBoxColumn,
            this.nascClienteDataGridViewTextBoxColumn,
            this.enderecoClienteDataGridViewTextBoxColumn,
            this.bairroClienteDataGridViewTextBoxColumn,
            this.telefoneClienteDataGridViewTextBoxColumn,
            this.celularClienteDataGridViewTextBoxColumn,
            this.emailClienteDataGridViewTextBoxColumn,
            this.pagamentosClienteDataGridViewTextBoxColumn});
			this.dgvBancoForm.DataSource = this.clienteBindingSource;
			this.dgvBancoForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvBancoForm.Location = new System.Drawing.Point(0, 0);
			this.dgvBancoForm.Name = "dgvBancoForm";
			this.dgvBancoForm.ReadOnly = true;
			this.dgvBancoForm.Size = new System.Drawing.Size(920, 369);
			this.dgvBancoForm.TabIndex = 0;
			// 
			// dsPrincipal
			// 
			this.dsPrincipal.DataSetName = "dsPrincipal";
			this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// clienteBindingSource
			// 
			this.clienteBindingSource.DataMember = "Cliente";
			this.clienteBindingSource.DataSource = this.dsPrincipal;
			// 
			// clienteTableAdapter
			// 
			this.clienteTableAdapter.ClearBeforeFill = true;
			// 
			// idClienteDataGridViewTextBoxColumn
			// 
			this.idClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
			this.idClienteDataGridViewTextBoxColumn.HeaderText = "Id do Cliente";
			this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
			this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nomeClienteDataGridViewTextBoxColumn
			// 
			this.nomeClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.nomeClienteDataGridViewTextBoxColumn.DataPropertyName = "nomeCliente";
			this.nomeClienteDataGridViewTextBoxColumn.HeaderText = "Nome";
			this.nomeClienteDataGridViewTextBoxColumn.Name = "nomeClienteDataGridViewTextBoxColumn";
			this.nomeClienteDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// identidadeClienteDataGridViewTextBoxColumn
			// 
			this.identidadeClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.identidadeClienteDataGridViewTextBoxColumn.DataPropertyName = "identidadeCliente";
			this.identidadeClienteDataGridViewTextBoxColumn.HeaderText = "CPF";
			this.identidadeClienteDataGridViewTextBoxColumn.Name = "identidadeClienteDataGridViewTextBoxColumn";
			this.identidadeClienteDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nascClienteDataGridViewTextBoxColumn
			// 
			this.nascClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.nascClienteDataGridViewTextBoxColumn.DataPropertyName = "nascCliente";
			this.nascClienteDataGridViewTextBoxColumn.HeaderText = "Data de nascimento";
			this.nascClienteDataGridViewTextBoxColumn.Name = "nascClienteDataGridViewTextBoxColumn";
			this.nascClienteDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// enderecoClienteDataGridViewTextBoxColumn
			// 
			this.enderecoClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.enderecoClienteDataGridViewTextBoxColumn.DataPropertyName = "enderecoCliente";
			this.enderecoClienteDataGridViewTextBoxColumn.HeaderText = "Endereço";
			this.enderecoClienteDataGridViewTextBoxColumn.Name = "enderecoClienteDataGridViewTextBoxColumn";
			this.enderecoClienteDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// bairroClienteDataGridViewTextBoxColumn
			// 
			this.bairroClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.bairroClienteDataGridViewTextBoxColumn.DataPropertyName = "bairroCliente";
			this.bairroClienteDataGridViewTextBoxColumn.HeaderText = "Bairro";
			this.bairroClienteDataGridViewTextBoxColumn.Name = "bairroClienteDataGridViewTextBoxColumn";
			this.bairroClienteDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// telefoneClienteDataGridViewTextBoxColumn
			// 
			this.telefoneClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.telefoneClienteDataGridViewTextBoxColumn.DataPropertyName = "telefoneCliente";
			this.telefoneClienteDataGridViewTextBoxColumn.HeaderText = "Telefone";
			this.telefoneClienteDataGridViewTextBoxColumn.Name = "telefoneClienteDataGridViewTextBoxColumn";
			this.telefoneClienteDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// celularClienteDataGridViewTextBoxColumn
			// 
			this.celularClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.celularClienteDataGridViewTextBoxColumn.DataPropertyName = "celularCliente";
			this.celularClienteDataGridViewTextBoxColumn.HeaderText = "Celular";
			this.celularClienteDataGridViewTextBoxColumn.Name = "celularClienteDataGridViewTextBoxColumn";
			this.celularClienteDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// emailClienteDataGridViewTextBoxColumn
			// 
			this.emailClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.emailClienteDataGridViewTextBoxColumn.DataPropertyName = "emailCliente";
			this.emailClienteDataGridViewTextBoxColumn.HeaderText = "E-mail";
			this.emailClienteDataGridViewTextBoxColumn.Name = "emailClienteDataGridViewTextBoxColumn";
			this.emailClienteDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// pagamentosClienteDataGridViewTextBoxColumn
			// 
			this.pagamentosClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.pagamentosClienteDataGridViewTextBoxColumn.DataPropertyName = "pagamentosCliente";
			this.pagamentosClienteDataGridViewTextBoxColumn.HeaderText = "Gastos";
			this.pagamentosClienteDataGridViewTextBoxColumn.Name = "pagamentosClienteDataGridViewTextBoxColumn";
			this.pagamentosClienteDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// frmCadastroClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(948, 610);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.materialLabel7);
			this.Controls.Add(this.materialLabel8);
			this.Controls.Add(this.materialLabel9);
			this.Controls.Add(this.materialLabel10);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.materialLabel6);
			this.Controls.Add(this.materialLabel5);
			this.Controls.Add(this.materialLabel4);
			this.Controls.Add(this.materialLabel3);
			this.Controls.Add(this.materialLabel2);
			this.Controls.Add(this.materialLabel1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.idClienteTextBox);
			this.Controls.Add(this.nomeClienteTextBox);
			this.Controls.Add(this.telefoneClienteTextBox);
			this.Controls.Add(this.enderecoClienteTextBox);
			this.Controls.Add(this.bairroClienteTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmCadastroClientes";
			this.Text = "frmCadastroClientes";
			this.Load += new System.EventHandler(this.frmCadastroClientes_Load);
			this.panel4.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvBancoForm)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox idClienteTextBox;
        private System.Windows.Forms.TextBox nomeClienteTextBox;
        private System.Windows.Forms.TextBox telefoneClienteTextBox;
        private System.Windows.Forms.TextBox enderecoClienteTextBox;
        private System.Windows.Forms.TextBox bairroClienteTextBox;
        public System.Windows.Forms.Panel panel4;
        public MaterialSkin.Controls.MaterialRaisedButton btnConfirmar;
        public System.Windows.Forms.Panel panel2;
        public MaterialSkin.Controls.MaterialRaisedButton btnLimparCampos;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dgvBancoForm;
		private Dados.dsPrincipal dsPrincipal;
		private System.Windows.Forms.BindingSource clienteBindingSource;
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
	}
}