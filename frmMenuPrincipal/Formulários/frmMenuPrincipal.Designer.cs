﻿namespace frmMenuPrincipal
{
	partial class frmMenuPrincipal
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
			this.msMenu = new System.Windows.Forms.MenuStrip();
			this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsMenuPrincipal = new System.Windows.Forms.ToolStrip();
			this.tslUsuario = new System.Windows.Forms.ToolStripLabel();
			this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
			this.grpBotões = new System.Windows.Forms.GroupBox();
			this.tcPrincipal = new System.Windows.Forms.TabControl();
			this.tpLista = new System.Windows.Forms.TabPage();
			this.tpCadastrar = new System.Windows.Forms.TabPage();
			this.btnCliente = new System.Windows.Forms.Button();
			this.btnFuncionario = new System.Windows.Forms.Button();
			this.btnFornecedor = new System.Windows.Forms.Button();
			this.btnServico = new System.Windows.Forms.Button();
			this.btnProduto = new System.Windows.Forms.Button();
			this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tpEditar = new System.Windows.Forms.TabPage();
			this.dgvLista = new System.Windows.Forms.DataGridView();
			this.dsPrincipal = new frmMenuPrincipal.Dados.dsPrincipal();
			this.dsPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lblTarefas = new System.Windows.Forms.Label();
			this.dgvTarefas = new System.Windows.Forms.DataGridView();
			this.txtCadId = new System.Windows.Forms.TextBox();
			this.lblCadID = new System.Windows.Forms.Label();
			this.txtCadNome = new System.Windows.Forms.TextBox();
			this.txtCad1 = new System.Windows.Forms.TextBox();
			this.txtCad2 = new System.Windows.Forms.TextBox();
			this.txtCad3 = new System.Windows.Forms.TextBox();
			this.txtCad6 = new System.Windows.Forms.TextBox();
			this.txtCad5 = new System.Windows.Forms.TextBox();
			this.txtCad4 = new System.Windows.Forms.TextBox();
			this.lblCadNome = new System.Windows.Forms.Label();
			this.lblCad2 = new System.Windows.Forms.Label();
			this.lblCad1 = new System.Windows.Forms.Label();
			this.lblCad5 = new System.Windows.Forms.Label();
			this.lblCad6 = new System.Windows.Forms.Label();
			this.lblCad4 = new System.Windows.Forms.Label();
			this.lblCad3 = new System.Windows.Forms.Label();
			this.lblEd5 = new System.Windows.Forms.Label();
			this.lblEd6 = new System.Windows.Forms.Label();
			this.lblEd4 = new System.Windows.Forms.Label();
			this.lblEd3 = new System.Windows.Forms.Label();
			this.lblEd1 = new System.Windows.Forms.Label();
			this.lblEd2 = new System.Windows.Forms.Label();
			this.lblEdNome = new System.Windows.Forms.Label();
			this.txtEd6 = new System.Windows.Forms.TextBox();
			this.txtEd5 = new System.Windows.Forms.TextBox();
			this.txtEd4 = new System.Windows.Forms.TextBox();
			this.txtEd3 = new System.Windows.Forms.TextBox();
			this.txtEd2 = new System.Windows.Forms.TextBox();
			this.txtEd1 = new System.Windows.Forms.TextBox();
			this.txtEdNome = new System.Windows.Forms.TextBox();
			this.lblEdId = new System.Windows.Forms.Label();
			this.txtEdId = new System.Windows.Forms.TextBox();
			this.msMenu.SuspendLayout();
			this.tsMenuPrincipal.SuspendLayout();
			this.grpBotões.SuspendLayout();
			this.tcPrincipal.SuspendLayout();
			this.tpLista.SuspendLayout();
			this.tpCadastrar.SuspendLayout();
			this.tpEditar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsPrincipalBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).BeginInit();
			this.SuspendLayout();
			// 
			// msMenu
			// 
			this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
			this.msMenu.Location = new System.Drawing.Point(0, 0);
			this.msMenu.Name = "msMenu";
			this.msMenu.Size = new System.Drawing.Size(964, 24);
			this.msMenu.TabIndex = 0;
			this.msMenu.Text = "menuStrip1";
			// 
			// arquivoToolStripMenuItem
			// 
			this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioToolStripMenuItem,
            this.sairToolStripMenuItem});
			this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
			this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.arquivoToolStripMenuItem.Text = "Arquivo";
			// 
			// relatórioToolStripMenuItem
			// 
			this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
			this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.relatórioToolStripMenuItem.Text = "Relatório";
			// 
			// sairToolStripMenuItem
			// 
			this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			this.sairToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.sairToolStripMenuItem.Text = "Sair";
			// 
			// ajudaToolStripMenuItem
			// 
			this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.sobreToolStripMenuItem});
			this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
			this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.ajudaToolStripMenuItem.Text = "Ajuda";
			// 
			// manualToolStripMenuItem
			// 
			this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
			this.manualToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.manualToolStripMenuItem.Text = "Manual";
			// 
			// tsMenuPrincipal
			// 
			this.tsMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tsMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslUsuario,
            this.tsbtnSair});
			this.tsMenuPrincipal.Location = new System.Drawing.Point(0, 531);
			this.tsMenuPrincipal.Name = "tsMenuPrincipal";
			this.tsMenuPrincipal.Size = new System.Drawing.Size(964, 25);
			this.tsMenuPrincipal.TabIndex = 1;
			this.tsMenuPrincipal.Text = "toolStrip1";
			// 
			// tslUsuario
			// 
			this.tslUsuario.Name = "tslUsuario";
			this.tslUsuario.Size = new System.Drawing.Size(90, 22);
			this.tslUsuario.Text = "Usuário logado:";
			// 
			// tsbtnSair
			// 
			this.tsbtnSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.tsbtnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbtnSair.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSair.Image")));
			this.tsbtnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnSair.Name = "tsbtnSair";
			this.tsbtnSair.Size = new System.Drawing.Size(23, 22);
			this.tsbtnSair.Text = "toolStripButton1";
			// 
			// grpBotões
			// 
			this.grpBotões.Controls.Add(this.btnProduto);
			this.grpBotões.Controls.Add(this.btnServico);
			this.grpBotões.Controls.Add(this.btnFornecedor);
			this.grpBotões.Controls.Add(this.btnFuncionario);
			this.grpBotões.Controls.Add(this.btnCliente);
			this.grpBotões.Location = new System.Drawing.Point(22, 54);
			this.grpBotões.Name = "grpBotões";
			this.grpBotões.Size = new System.Drawing.Size(161, 354);
			this.grpBotões.TabIndex = 2;
			this.grpBotões.TabStop = false;
			// 
			// tcPrincipal
			// 
			this.tcPrincipal.Controls.Add(this.tpLista);
			this.tcPrincipal.Controls.Add(this.tpCadastrar);
			this.tcPrincipal.Controls.Add(this.tpEditar);
			this.tcPrincipal.Location = new System.Drawing.Point(219, 62);
			this.tcPrincipal.Name = "tcPrincipal";
			this.tcPrincipal.SelectedIndex = 0;
			this.tcPrincipal.Size = new System.Drawing.Size(435, 346);
			this.tcPrincipal.TabIndex = 3;
			// 
			// tpLista
			// 
			this.tpLista.Controls.Add(this.dgvLista);
			this.tpLista.Location = new System.Drawing.Point(4, 22);
			this.tpLista.Name = "tpLista";
			this.tpLista.Padding = new System.Windows.Forms.Padding(3);
			this.tpLista.Size = new System.Drawing.Size(427, 320);
			this.tpLista.TabIndex = 0;
			this.tpLista.UseVisualStyleBackColor = true;
			// 
			// tpCadastrar
			// 
			this.tpCadastrar.Controls.Add(this.lblCad5);
			this.tpCadastrar.Controls.Add(this.lblCad6);
			this.tpCadastrar.Controls.Add(this.lblCad4);
			this.tpCadastrar.Controls.Add(this.lblCad3);
			this.tpCadastrar.Controls.Add(this.lblCad1);
			this.tpCadastrar.Controls.Add(this.lblCad2);
			this.tpCadastrar.Controls.Add(this.lblCadNome);
			this.tpCadastrar.Controls.Add(this.txtCad6);
			this.tpCadastrar.Controls.Add(this.txtCad5);
			this.tpCadastrar.Controls.Add(this.txtCad4);
			this.tpCadastrar.Controls.Add(this.txtCad3);
			this.tpCadastrar.Controls.Add(this.txtCad2);
			this.tpCadastrar.Controls.Add(this.txtCad1);
			this.tpCadastrar.Controls.Add(this.txtCadNome);
			this.tpCadastrar.Controls.Add(this.lblCadID);
			this.tpCadastrar.Controls.Add(this.txtCadId);
			this.tpCadastrar.Location = new System.Drawing.Point(4, 22);
			this.tpCadastrar.Name = "tpCadastrar";
			this.tpCadastrar.Padding = new System.Windows.Forms.Padding(3);
			this.tpCadastrar.Size = new System.Drawing.Size(427, 320);
			this.tpCadastrar.TabIndex = 1;
			this.tpCadastrar.Text = "Cadastrar";
			this.tpCadastrar.UseVisualStyleBackColor = true;
			// 
			// btnCliente
			// 
			this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCliente.Location = new System.Drawing.Point(6, 10);
			this.btnCliente.Name = "btnCliente";
			this.btnCliente.Size = new System.Drawing.Size(149, 63);
			this.btnCliente.TabIndex = 0;
			this.btnCliente.Text = "CLIENTE";
			this.btnCliente.UseVisualStyleBackColor = true;
			// 
			// btnFuncionario
			// 
			this.btnFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFuncionario.Location = new System.Drawing.Point(6, 79);
			this.btnFuncionario.Name = "btnFuncionario";
			this.btnFuncionario.Size = new System.Drawing.Size(149, 63);
			this.btnFuncionario.TabIndex = 1;
			this.btnFuncionario.Text = "FUNCIONÁRIO";
			this.btnFuncionario.UseVisualStyleBackColor = true;
			// 
			// btnFornecedor
			// 
			this.btnFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFornecedor.Location = new System.Drawing.Point(6, 148);
			this.btnFornecedor.Name = "btnFornecedor";
			this.btnFornecedor.Size = new System.Drawing.Size(149, 63);
			this.btnFornecedor.TabIndex = 3;
			this.btnFornecedor.Text = "FORNECEDOR";
			this.btnFornecedor.UseVisualStyleBackColor = true;
			// 
			// btnServico
			// 
			this.btnServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnServico.Location = new System.Drawing.Point(6, 217);
			this.btnServico.Name = "btnServico";
			this.btnServico.Size = new System.Drawing.Size(149, 63);
			this.btnServico.TabIndex = 4;
			this.btnServico.Text = "SERVIÇO";
			this.btnServico.UseVisualStyleBackColor = true;
			// 
			// btnProduto
			// 
			this.btnProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProduto.Location = new System.Drawing.Point(6, 286);
			this.btnProduto.Name = "btnProduto";
			this.btnProduto.Size = new System.Drawing.Size(149, 63);
			this.btnProduto.TabIndex = 5;
			this.btnProduto.Text = "PRODUTO";
			this.btnProduto.UseVisualStyleBackColor = true;
			// 
			// sobreToolStripMenuItem
			// 
			this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
			this.sobreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.sobreToolStripMenuItem.Text = "Sobre";
			// 
			// tpEditar
			// 
			this.tpEditar.Controls.Add(this.lblEd5);
			this.tpEditar.Controls.Add(this.lblEd6);
			this.tpEditar.Controls.Add(this.lblEd4);
			this.tpEditar.Controls.Add(this.lblEd3);
			this.tpEditar.Controls.Add(this.lblEd1);
			this.tpEditar.Controls.Add(this.lblEd2);
			this.tpEditar.Controls.Add(this.lblEdNome);
			this.tpEditar.Controls.Add(this.txtEd6);
			this.tpEditar.Controls.Add(this.txtEd5);
			this.tpEditar.Controls.Add(this.txtEd4);
			this.tpEditar.Controls.Add(this.txtEd3);
			this.tpEditar.Controls.Add(this.txtEd2);
			this.tpEditar.Controls.Add(this.txtEd1);
			this.tpEditar.Controls.Add(this.txtEdNome);
			this.tpEditar.Controls.Add(this.lblEdId);
			this.tpEditar.Controls.Add(this.txtEdId);
			this.tpEditar.Location = new System.Drawing.Point(4, 22);
			this.tpEditar.Name = "tpEditar";
			this.tpEditar.Size = new System.Drawing.Size(427, 320);
			this.tpEditar.TabIndex = 2;
			this.tpEditar.Text = "Editar";
			this.tpEditar.UseVisualStyleBackColor = true;
			// 
			// dgvLista
			// 
			this.dgvLista.AllowUserToAddRows = false;
			this.dgvLista.AllowUserToDeleteRows = false;
			this.dgvLista.AutoGenerateColumns = false;
			this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLista.DataSource = this.dsPrincipalBindingSource;
			this.dgvLista.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvLista.Location = new System.Drawing.Point(3, 3);
			this.dgvLista.Name = "dgvLista";
			this.dgvLista.ReadOnly = true;
			this.dgvLista.Size = new System.Drawing.Size(421, 314);
			this.dgvLista.TabIndex = 0;
			// 
			// dsPrincipal
			// 
			this.dsPrincipal.DataSetName = "dsPrincipal";
			this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dsPrincipalBindingSource
			// 
			this.dsPrincipalBindingSource.DataSource = this.dsPrincipal;
			this.dsPrincipalBindingSource.Position = 0;
			// 
			// lblTarefas
			// 
			this.lblTarefas.AutoSize = true;
			this.lblTarefas.Location = new System.Drawing.Point(688, 62);
			this.lblTarefas.Name = "lblTarefas";
			this.lblTarefas.Size = new System.Drawing.Size(79, 13);
			this.lblTarefas.TabIndex = 4;
			this.lblTarefas.Text = "Ultimas tarefas:";
			// 
			// dgvTarefas
			// 
			this.dgvTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTarefas.Location = new System.Drawing.Point(691, 84);
			this.dgvTarefas.Name = "dgvTarefas";
			this.dgvTarefas.Size = new System.Drawing.Size(247, 320);
			this.dgvTarefas.TabIndex = 5;
			// 
			// txtCadId
			// 
			this.txtCadId.Enabled = false;
			this.txtCadId.Location = new System.Drawing.Point(168, 62);
			this.txtCadId.Name = "txtCadId";
			this.txtCadId.Size = new System.Drawing.Size(100, 20);
			this.txtCadId.TabIndex = 0;
			// 
			// lblCadID
			// 
			this.lblCadID.AutoSize = true;
			this.lblCadID.Location = new System.Drawing.Point(103, 65);
			this.lblCadID.Name = "lblCadID";
			this.lblCadID.Size = new System.Drawing.Size(18, 13);
			this.lblCadID.TabIndex = 1;
			this.lblCadID.Text = "ID";
			// 
			// txtCadNome
			// 
			this.txtCadNome.Location = new System.Drawing.Point(168, 89);
			this.txtCadNome.Name = "txtCadNome";
			this.txtCadNome.Size = new System.Drawing.Size(100, 20);
			this.txtCadNome.TabIndex = 2;
			// 
			// txtCad1
			// 
			this.txtCad1.Location = new System.Drawing.Point(168, 115);
			this.txtCad1.Name = "txtCad1";
			this.txtCad1.Size = new System.Drawing.Size(100, 20);
			this.txtCad1.TabIndex = 3;
			// 
			// txtCad2
			// 
			this.txtCad2.Location = new System.Drawing.Point(168, 141);
			this.txtCad2.Name = "txtCad2";
			this.txtCad2.Size = new System.Drawing.Size(100, 20);
			this.txtCad2.TabIndex = 4;
			// 
			// txtCad3
			// 
			this.txtCad3.Location = new System.Drawing.Point(168, 167);
			this.txtCad3.Name = "txtCad3";
			this.txtCad3.Size = new System.Drawing.Size(100, 20);
			this.txtCad3.TabIndex = 5;
			// 
			// txtCad6
			// 
			this.txtCad6.Location = new System.Drawing.Point(168, 245);
			this.txtCad6.Name = "txtCad6";
			this.txtCad6.Size = new System.Drawing.Size(100, 20);
			this.txtCad6.TabIndex = 8;
			// 
			// txtCad5
			// 
			this.txtCad5.Location = new System.Drawing.Point(168, 219);
			this.txtCad5.Name = "txtCad5";
			this.txtCad5.Size = new System.Drawing.Size(100, 20);
			this.txtCad5.TabIndex = 7;
			// 
			// txtCad4
			// 
			this.txtCad4.Location = new System.Drawing.Point(168, 193);
			this.txtCad4.Name = "txtCad4";
			this.txtCad4.Size = new System.Drawing.Size(100, 20);
			this.txtCad4.TabIndex = 6;
			// 
			// lblCadNome
			// 
			this.lblCadNome.AutoSize = true;
			this.lblCadNome.Location = new System.Drawing.Point(103, 92);
			this.lblCadNome.Name = "lblCadNome";
			this.lblCadNome.Size = new System.Drawing.Size(35, 13);
			this.lblCadNome.TabIndex = 9;
			this.lblCadNome.Text = "Nome";
			// 
			// lblCad2
			// 
			this.lblCad2.AutoSize = true;
			this.lblCad2.Location = new System.Drawing.Point(103, 144);
			this.lblCad2.Name = "lblCad2";
			this.lblCad2.Size = new System.Drawing.Size(29, 13);
			this.lblCad2.TabIndex = 10;
			this.lblCad2.Text = "label";
			// 
			// lblCad1
			// 
			this.lblCad1.AutoSize = true;
			this.lblCad1.Location = new System.Drawing.Point(103, 118);
			this.lblCad1.Name = "lblCad1";
			this.lblCad1.Size = new System.Drawing.Size(29, 13);
			this.lblCad1.TabIndex = 11;
			this.lblCad1.Text = "label";
			// 
			// lblCad5
			// 
			this.lblCad5.AutoSize = true;
			this.lblCad5.Location = new System.Drawing.Point(103, 223);
			this.lblCad5.Name = "lblCad5";
			this.lblCad5.Size = new System.Drawing.Size(29, 13);
			this.lblCad5.TabIndex = 15;
			this.lblCad5.Text = "label";
			// 
			// lblCad6
			// 
			this.lblCad6.AutoSize = true;
			this.lblCad6.Location = new System.Drawing.Point(103, 249);
			this.lblCad6.Name = "lblCad6";
			this.lblCad6.Size = new System.Drawing.Size(29, 13);
			this.lblCad6.TabIndex = 14;
			this.lblCad6.Text = "label";
			// 
			// lblCad4
			// 
			this.lblCad4.AutoSize = true;
			this.lblCad4.Location = new System.Drawing.Point(103, 197);
			this.lblCad4.Name = "lblCad4";
			this.lblCad4.Size = new System.Drawing.Size(29, 13);
			this.lblCad4.TabIndex = 13;
			this.lblCad4.Text = "label";
			// 
			// lblCad3
			// 
			this.lblCad3.AutoSize = true;
			this.lblCad3.Location = new System.Drawing.Point(103, 170);
			this.lblCad3.Name = "lblCad3";
			this.lblCad3.Size = new System.Drawing.Size(29, 13);
			this.lblCad3.TabIndex = 12;
			this.lblCad3.Text = "label";
			// 
			// lblEd5
			// 
			this.lblEd5.AutoSize = true;
			this.lblEd5.Location = new System.Drawing.Point(103, 223);
			this.lblEd5.Name = "lblEd5";
			this.lblEd5.Size = new System.Drawing.Size(29, 13);
			this.lblEd5.TabIndex = 31;
			this.lblEd5.Text = "label";
			// 
			// lblEd6
			// 
			this.lblEd6.AutoSize = true;
			this.lblEd6.Location = new System.Drawing.Point(103, 249);
			this.lblEd6.Name = "lblEd6";
			this.lblEd6.Size = new System.Drawing.Size(29, 13);
			this.lblEd6.TabIndex = 30;
			this.lblEd6.Text = "label";
			// 
			// lblEd4
			// 
			this.lblEd4.AutoSize = true;
			this.lblEd4.Location = new System.Drawing.Point(103, 197);
			this.lblEd4.Name = "lblEd4";
			this.lblEd4.Size = new System.Drawing.Size(29, 13);
			this.lblEd4.TabIndex = 29;
			this.lblEd4.Text = "label";
			// 
			// lblEd3
			// 
			this.lblEd3.AutoSize = true;
			this.lblEd3.Location = new System.Drawing.Point(103, 170);
			this.lblEd3.Name = "lblEd3";
			this.lblEd3.Size = new System.Drawing.Size(29, 13);
			this.lblEd3.TabIndex = 28;
			this.lblEd3.Text = "label";
			// 
			// lblEd1
			// 
			this.lblEd1.AutoSize = true;
			this.lblEd1.Location = new System.Drawing.Point(103, 118);
			this.lblEd1.Name = "lblEd1";
			this.lblEd1.Size = new System.Drawing.Size(29, 13);
			this.lblEd1.TabIndex = 27;
			this.lblEd1.Text = "label";
			// 
			// lblEd2
			// 
			this.lblEd2.AutoSize = true;
			this.lblEd2.Location = new System.Drawing.Point(103, 144);
			this.lblEd2.Name = "lblEd2";
			this.lblEd2.Size = new System.Drawing.Size(29, 13);
			this.lblEd2.TabIndex = 26;
			this.lblEd2.Text = "label";
			// 
			// lblEdNome
			// 
			this.lblEdNome.AutoSize = true;
			this.lblEdNome.Location = new System.Drawing.Point(103, 92);
			this.lblEdNome.Name = "lblEdNome";
			this.lblEdNome.Size = new System.Drawing.Size(35, 13);
			this.lblEdNome.TabIndex = 25;
			this.lblEdNome.Text = "Nome";
			// 
			// txtEd6
			// 
			this.txtEd6.Location = new System.Drawing.Point(168, 245);
			this.txtEd6.Name = "txtEd6";
			this.txtEd6.Size = new System.Drawing.Size(100, 20);
			this.txtEd6.TabIndex = 24;
			// 
			// txtEd5
			// 
			this.txtEd5.Location = new System.Drawing.Point(168, 219);
			this.txtEd5.Name = "txtEd5";
			this.txtEd5.Size = new System.Drawing.Size(100, 20);
			this.txtEd5.TabIndex = 23;
			// 
			// txtEd4
			// 
			this.txtEd4.Location = new System.Drawing.Point(168, 193);
			this.txtEd4.Name = "txtEd4";
			this.txtEd4.Size = new System.Drawing.Size(100, 20);
			this.txtEd4.TabIndex = 22;
			// 
			// txtEd3
			// 
			this.txtEd3.Location = new System.Drawing.Point(168, 167);
			this.txtEd3.Name = "txtEd3";
			this.txtEd3.Size = new System.Drawing.Size(100, 20);
			this.txtEd3.TabIndex = 21;
			// 
			// txtEd2
			// 
			this.txtEd2.Location = new System.Drawing.Point(168, 141);
			this.txtEd2.Name = "txtEd2";
			this.txtEd2.Size = new System.Drawing.Size(100, 20);
			this.txtEd2.TabIndex = 20;
			// 
			// txtEd1
			// 
			this.txtEd1.Location = new System.Drawing.Point(168, 115);
			this.txtEd1.Name = "txtEd1";
			this.txtEd1.Size = new System.Drawing.Size(100, 20);
			this.txtEd1.TabIndex = 19;
			// 
			// txtEdNome
			// 
			this.txtEdNome.Location = new System.Drawing.Point(168, 89);
			this.txtEdNome.Name = "txtEdNome";
			this.txtEdNome.Size = new System.Drawing.Size(100, 20);
			this.txtEdNome.TabIndex = 18;
			// 
			// lblEdId
			// 
			this.lblEdId.AutoSize = true;
			this.lblEdId.Location = new System.Drawing.Point(103, 65);
			this.lblEdId.Name = "lblEdId";
			this.lblEdId.Size = new System.Drawing.Size(18, 13);
			this.lblEdId.TabIndex = 17;
			this.lblEdId.Text = "ID";
			// 
			// txtEdId
			// 
			this.txtEdId.Enabled = false;
			this.txtEdId.Location = new System.Drawing.Point(168, 62);
			this.txtEdId.Name = "txtEdId";
			this.txtEdId.Size = new System.Drawing.Size(100, 20);
			this.txtEdId.TabIndex = 16;
			// 
			// frmMenuPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(964, 556);
			this.Controls.Add(this.dgvTarefas);
			this.Controls.Add(this.lblTarefas);
			this.Controls.Add(this.tcPrincipal);
			this.Controls.Add(this.grpBotões);
			this.Controls.Add(this.tsMenuPrincipal);
			this.Controls.Add(this.msMenu);
			this.MainMenuStrip = this.msMenu;
			this.Name = "frmMenuPrincipal";
			this.Text = "Menu Principal";
			this.msMenu.ResumeLayout(false);
			this.msMenu.PerformLayout();
			this.tsMenuPrincipal.ResumeLayout(false);
			this.tsMenuPrincipal.PerformLayout();
			this.grpBotões.ResumeLayout(false);
			this.tcPrincipal.ResumeLayout(false);
			this.tpLista.ResumeLayout(false);
			this.tpCadastrar.ResumeLayout(false);
			this.tpCadastrar.PerformLayout();
			this.tpEditar.ResumeLayout(false);
			this.tpEditar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsPrincipalBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip msMenu;
		private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
		private System.Windows.Forms.ToolStrip tsMenuPrincipal;
		private System.Windows.Forms.ToolStripLabel tslUsuario;
		private System.Windows.Forms.ToolStripButton tsbtnSair;
		private System.Windows.Forms.GroupBox grpBotões;
		private System.Windows.Forms.Button btnServico;
		private System.Windows.Forms.Button btnFornecedor;
		private System.Windows.Forms.Button btnFuncionario;
		private System.Windows.Forms.Button btnCliente;
		private System.Windows.Forms.TabControl tcPrincipal;
		private System.Windows.Forms.TabPage tpLista;
		private System.Windows.Forms.TabPage tpCadastrar;
		private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
		private System.Windows.Forms.Button btnProduto;
		private System.Windows.Forms.TabPage tpEditar;
		private System.Windows.Forms.DataGridView dgvLista;
		private System.Windows.Forms.BindingSource dsPrincipalBindingSource;
		private frmMenuPrincipal.Dados.dsPrincipal dsPrincipal;
		private System.Windows.Forms.Label lblCad5;
		private System.Windows.Forms.Label lblCad6;
		private System.Windows.Forms.Label lblCad4;
		private System.Windows.Forms.Label lblCad3;
		private System.Windows.Forms.Label lblCad1;
		private System.Windows.Forms.Label lblCad2;
		private System.Windows.Forms.Label lblCadNome;
		private System.Windows.Forms.TextBox txtCad6;
		private System.Windows.Forms.TextBox txtCad5;
		private System.Windows.Forms.TextBox txtCad4;
		private System.Windows.Forms.TextBox txtCad3;
		private System.Windows.Forms.TextBox txtCad2;
		private System.Windows.Forms.TextBox txtCad1;
		private System.Windows.Forms.TextBox txtCadNome;
		private System.Windows.Forms.Label lblCadID;
		private System.Windows.Forms.TextBox txtCadId;
		private System.Windows.Forms.Label lblEd5;
		private System.Windows.Forms.Label lblEd6;
		private System.Windows.Forms.Label lblEd4;
		private System.Windows.Forms.Label lblEd3;
		private System.Windows.Forms.Label lblEd1;
		private System.Windows.Forms.Label lblEd2;
		private System.Windows.Forms.Label lblEdNome;
		private System.Windows.Forms.TextBox txtEd6;
		private System.Windows.Forms.TextBox txtEd5;
		private System.Windows.Forms.TextBox txtEd4;
		private System.Windows.Forms.TextBox txtEd3;
		private System.Windows.Forms.TextBox txtEd2;
		private System.Windows.Forms.TextBox txtEd1;
		private System.Windows.Forms.TextBox txtEdNome;
		private System.Windows.Forms.Label lblEdId;
		private System.Windows.Forms.TextBox txtEdId;
		private System.Windows.Forms.Label lblTarefas;
		private System.Windows.Forms.DataGridView dgvTarefas;
	}
}

