namespace frmMenuPrincipal.Formulários
{
	partial class frmCadastroAtendimento
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
            System.Windows.Forms.Label lblIdAtendimento;
            System.Windows.Forms.Label lblPrecoAtendimento;
            System.Windows.Forms.Label lblIdCliente;
            this.pnlDataGridView = new System.Windows.Forms.Panel();
            this.dgvAtendimento = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atendimentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrincipal = new frmMenuPrincipal.Dados.dsPrincipal();
            this.btnLimparCampos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnConfirmar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlBotaoConfirmar = new System.Windows.Forms.Panel();
            this.pnlCampos = new System.Windows.Forms.Panel();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.MaskedTextBox();
            this.grpServicos = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbServicos = new System.Windows.Forms.ComboBox();
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpProdutos = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProdutos = new System.Windows.Forms.ComboBox();
            this.produtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtIdAtendimento = new System.Windows.Forms.TextBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlBotaoLimparCampos = new System.Windows.Forms.Panel();
            this.atendimentoTableAdapter = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.AtendimentoTableAdapter();
            this.tableAdapterManager = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.TableAdapterManager();
            this.produtoTableAdapter = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.ProdutoTableAdapter();
            this.servicoTableAdapter = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.ServicoTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbProdutos = new System.Windows.Forms.ListBox();
            this.lbServicos = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            lblIdAtendimento = new System.Windows.Forms.Label();
            lblPrecoAtendimento = new System.Windows.Forms.Label();
            lblIdCliente = new System.Windows.Forms.Label();
            this.pnlDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atendimentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            this.pnlBotaoConfirmar.SuspendLayout();
            this.pnlCampos.SuspendLayout();
            this.grpServicos.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            this.grpProdutos.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.pnlBotaoLimparCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdAtendimento
            // 
            lblIdAtendimento.AutoSize = true;
            lblIdAtendimento.Location = new System.Drawing.Point(37, 15);
            lblIdAtendimento.Name = "lblIdAtendimento";
            lblIdAtendimento.Size = new System.Drawing.Size(95, 13);
            lblIdAtendimento.TabIndex = 0;
            lblIdAtendimento.Text = "Id do atendimento:";
            // 
            // lblPrecoAtendimento
            // 
            lblPrecoAtendimento.AutoSize = true;
            lblPrecoAtendimento.Location = new System.Drawing.Point(23, 282);
            lblPrecoAtendimento.Name = "lblPrecoAtendimento";
            lblPrecoAtendimento.Size = new System.Drawing.Size(114, 13);
            lblPrecoAtendimento.TabIndex = 6;
            lblPrecoAtendimento.Text = "Preço do atendimento:";
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.Location = new System.Drawing.Point(479, 15);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new System.Drawing.Size(66, 13);
            lblIdCliente.TabIndex = 12;
            lblIdCliente.Text = "Id do Cliente";
            // 
            // pnlDataGridView
            // 
            this.pnlDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDataGridView.Controls.Add(this.dgvAtendimento);
            this.pnlDataGridView.Location = new System.Drawing.Point(20, 370);
            this.pnlDataGridView.Name = "pnlDataGridView";
            this.pnlDataGridView.Size = new System.Drawing.Size(924, 248);
            this.pnlDataGridView.TabIndex = 7;
            // 
            // dgvAtendimento
            // 
            this.dgvAtendimento.AllowUserToAddRows = false;
            this.dgvAtendimento.AutoGenerateColumns = false;
            this.dgvAtendimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtendimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn9});
            this.dgvAtendimento.DataSource = this.atendimentoBindingSource;
            this.dgvAtendimento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAtendimento.Location = new System.Drawing.Point(0, 0);
            this.dgvAtendimento.Name = "dgvAtendimento";
            this.dgvAtendimento.ReadOnly = true;
            this.dgvAtendimento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAtendimento.Size = new System.Drawing.Size(924, 248);
            this.dgvAtendimento.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "idAtendimento";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id do atendimento";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "idCliente";
            this.dataGridViewTextBoxColumn11.HeaderText = "Id do Cliente";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "precoAtendimento";
            this.dataGridViewTextBoxColumn10.HeaderText = "Preço";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "dataAtendimento";
            this.dataGridViewTextBoxColumn9.HeaderText = "Data do atendimento";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // atendimentoBindingSource
            // 
            this.atendimentoBindingSource.DataMember = "Atendimento";
            this.atendimentoBindingSource.DataSource = this.dsPrincipal;
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
            this.btnLimparCampos.Size = new System.Drawing.Size(126, 36);
            this.btnLimparCampos.TabIndex = 8;
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
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // pnlBotaoConfirmar
            // 
            this.pnlBotaoConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBotaoConfirmar.Controls.Add(this.btnConfirmar);
            this.pnlBotaoConfirmar.Location = new System.Drawing.Point(822, 328);
            this.pnlBotaoConfirmar.Name = "pnlBotaoConfirmar";
            this.pnlBotaoConfirmar.Size = new System.Drawing.Size(122, 32);
            this.pnlBotaoConfirmar.TabIndex = 10;
            // 
            // pnlCampos
            // 
            this.pnlCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCampos.Controls.Add(lblIdCliente);
            this.pnlCampos.Controls.Add(this.txtIdCliente);
            this.pnlCampos.Controls.Add(this.txtPreco);
            this.pnlCampos.Controls.Add(this.grpServicos);
            this.pnlCampos.Controls.Add(this.grpProdutos);
            this.pnlCampos.Controls.Add(lblIdAtendimento);
            this.pnlCampos.Controls.Add(this.txtIdAtendimento);
            this.pnlCampos.Controls.Add(lblPrecoAtendimento);
            this.pnlCampos.Location = new System.Drawing.Point(20, 12);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(924, 310);
            this.pnlCampos.TabIndex = 111;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(600, 12);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(180, 20);
            this.txtIdCliente.TabIndex = 1;
            this.txtIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(144, 279);
            this.txtPreco.Mask = "$999,999.00";
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(773, 20);
            this.txtPreco.TabIndex = 6;
            // 
            // grpServicos
            // 
            this.grpServicos.Controls.Add(this.lbServicos);
            this.grpServicos.Controls.Add(this.panel2);
            this.grpServicos.Controls.Add(this.cmbServicos);
            this.grpServicos.Location = new System.Drawing.Point(476, 57);
            this.grpServicos.Name = "grpServicos";
            this.grpServicos.Size = new System.Drawing.Size(414, 216);
            this.grpServicos.TabIndex = 9;
            this.grpServicos.TabStop = false;
            this.grpServicos.Text = "Serviços";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(6, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 163);
            this.panel2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Consolas", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(3, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 50);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mantenha sempre um item por linha.\r\n";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 82);
            this.label2.TabIndex = 5;
            this.label2.Text = "Para retirar itens da seleção, apague a linha correspondente por completo.";
            // 
            // cmbServicos
            // 
            this.cmbServicos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "nomeServico", true));
            this.cmbServicos.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.servicoBindingSource, "precoServico", true));
            this.cmbServicos.DataSource = this.servicoBindingSource;
            this.cmbServicos.DisplayMember = "nomeServico";
            this.cmbServicos.FormattingEnabled = true;
            this.cmbServicos.Location = new System.Drawing.Point(6, 19);
            this.cmbServicos.Name = "cmbServicos";
            this.cmbServicos.Size = new System.Drawing.Size(149, 21);
            this.cmbServicos.TabIndex = 4;
            this.cmbServicos.ValueMember = "precoServico";
            this.cmbServicos.SelectedIndexChanged += new System.EventHandler(this.cmbServicos_SelectedIndexChanged);
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataMember = "Servico";
            this.servicoBindingSource.DataSource = this.dsPrincipal;
            // 
            // grpProdutos
            // 
            this.grpProdutos.Controls.Add(this.lbProdutos);
            this.grpProdutos.Controls.Add(this.panel1);
            this.grpProdutos.Controls.Add(this.cmbProdutos);
            this.grpProdutos.Location = new System.Drawing.Point(34, 57);
            this.grpProdutos.Name = "grpProdutos";
            this.grpProdutos.Size = new System.Drawing.Size(414, 216);
            this.grpProdutos.TabIndex = 8;
            this.grpProdutos.TabStop = false;
            this.grpProdutos.Text = "Produtos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(6, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 158);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mantenha sempre um item por linha.\r\n";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 82);
            this.label3.TabIndex = 5;
            this.label3.Text = "Para retirar itens da seleção, apague a linha correspondente por completo.";
            // 
            // cmbProdutos
            // 
            this.cmbProdutos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource1, "nomeProduto", true));
            this.cmbProdutos.DataSource = this.produtoBindingSource;
            this.cmbProdutos.DisplayMember = "nomeProduto";
            this.cmbProdutos.FormattingEnabled = true;
            this.cmbProdutos.Location = new System.Drawing.Point(6, 19);
            this.cmbProdutos.Name = "cmbProdutos";
            this.cmbProdutos.Size = new System.Drawing.Size(149, 21);
            this.cmbProdutos.TabIndex = 2;
            this.cmbProdutos.ValueMember = "IdProduto";
            this.cmbProdutos.SelectedIndexChanged += new System.EventHandler(this.cmbProdutos_SelectedIndexChanged);
            // 
            // produtoBindingSource1
            // 
            this.produtoBindingSource1.DataMember = "Produto";
            this.produtoBindingSource1.DataSource = this.dsPrincipal;
            // 
            // txtIdAtendimento
            // 
            this.txtIdAtendimento.Enabled = false;
            this.txtIdAtendimento.Location = new System.Drawing.Point(158, 12);
            this.txtIdAtendimento.Name = "txtIdAtendimento";
            this.txtIdAtendimento.Size = new System.Drawing.Size(180, 20);
            this.txtIdAtendimento.TabIndex = 1;
            this.txtIdAtendimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.dsPrincipal;
            // 
            // pnlBotaoLimparCampos
            // 
            this.pnlBotaoLimparCampos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBotaoLimparCampos.Controls.Add(this.btnLimparCampos);
            this.pnlBotaoLimparCampos.Location = new System.Drawing.Point(20, 328);
            this.pnlBotaoLimparCampos.Name = "pnlBotaoLimparCampos";
            this.pnlBotaoLimparCampos.Size = new System.Drawing.Size(126, 36);
            this.pnlBotaoLimparCampos.TabIndex = 8;
            // 
            // atendimentoTableAdapter
            // 
            this.atendimentoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AtendimentoTableAdapter = this.atendimentoTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarroTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.FornecedorTableAdapter = null;
            this.tableAdapterManager.FornecimentoTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.Produtos_AtendimentoTableAdapter = null;
            this.tableAdapterManager.Produtos_FornecimentoTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.Serviços_AtendimentoTableAdapter = null;
            this.tableAdapterManager.ServicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = frmMenuPrincipal.Dados.dsPrincipalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // servicoTableAdapter
            // 
            this.servicoTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(33, 137);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbProdutos
            // 
            this.lbProdutos.FormattingEnabled = true;
            this.lbProdutos.Location = new System.Drawing.Point(161, 19);
            this.lbProdutos.Name = "lbProdutos";
            this.lbProdutos.Size = new System.Drawing.Size(247, 186);
            this.lbProdutos.TabIndex = 13;
            // 
            // lbServicos
            // 
            this.lbServicos.FormattingEnabled = true;
            this.lbServicos.Location = new System.Drawing.Point(158, 19);
            this.lbServicos.Name = "lbServicos";
            this.lbServicos.Size = new System.Drawing.Size(247, 186);
            this.lbServicos.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmCadastroAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(964, 649);
            this.Controls.Add(this.pnlDataGridView);
            this.Controls.Add(this.pnlBotaoConfirmar);
            this.Controls.Add(this.pnlCampos);
            this.Controls.Add(this.pnlBotaoLimparCampos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCadastroAtendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de atendimentos";
            this.Load += new System.EventHandler(this.frmCadastroAtendimento_Load);
            this.pnlDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atendimentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            this.pnlBotaoConfirmar.ResumeLayout(false);
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
            this.grpServicos.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            this.grpProdutos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.pnlBotaoLimparCampos.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel pnlDataGridView;
		public System.Windows.Forms.DataGridView dgvAtendimento;
		public MaterialSkin.Controls.MaterialRaisedButton btnLimparCampos;
		public MaterialSkin.Controls.MaterialRaisedButton btnConfirmar;
		public System.Windows.Forms.Panel pnlBotaoConfirmar;
		public System.Windows.Forms.Panel pnlCampos;
		public System.Windows.Forms.Panel pnlBotaoLimparCampos;
		private Dados.dsPrincipal dsPrincipal;
		private Dados.dsPrincipalTableAdapters.AtendimentoTableAdapter atendimentoTableAdapter;
		private Dados.dsPrincipalTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.TextBox txtIdAtendimento;
		private System.Windows.Forms.DataGridViewTextBoxColumn idAtendimentoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idServicoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn precoAtendimentoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataAtendimentoDataGridViewTextBoxColumn;
		private Dados.dsPrincipalTableAdapters.ProdutoTableAdapter produtoTableAdapter;
		private Dados.dsPrincipalTableAdapters.ServicoTableAdapter servicoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServicoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeServicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoServicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource atendimentoBindingSource;
        private System.Windows.Forms.BindingSource servicoBindingSource;
        private System.Windows.Forms.BindingSource produtoBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.GroupBox grpServicos;
		private System.Windows.Forms.ComboBox cmbServicos;
		private System.Windows.Forms.GroupBox grpProdutos;
		private System.Windows.Forms.ComboBox cmbProdutos;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MaskedTextBox txtPreco;
		private System.Windows.Forms.TextBox txtIdCliente;
		private System.Windows.Forms.BindingSource produtoBindingSource1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbServicos;
        private System.Windows.Forms.ListBox lbProdutos;
        private System.Windows.Forms.Button button1;
    }
}