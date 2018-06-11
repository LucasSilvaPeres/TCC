namespace frmMenuPrincipal
{
	partial class frmMenuPrincip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincip));
            this.tsMenuPrincipal = new System.Windows.Forms.ToolStrip();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.tslHora = new System.Windows.Forms.ToolStripLabel();
            this.dsPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrincipal = new frmMenuPrincipal.Dados.dsPrincipal();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastrosPrincipais = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastroFornecimento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geralToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geralToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizadoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geralToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizadoToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geralToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizadoToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geralToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizadoToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.atendimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geralToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizadoToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.personalizadoToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmSair = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.btnConfirmar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton5 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tsMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            this.msMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenuPrincipal
            // 
            this.tsMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSair,
            this.tslHora});
            this.tsMenuPrincipal.Location = new System.Drawing.Point(0, 531);
            this.tsMenuPrincipal.Name = "tsMenuPrincipal";
            this.tsMenuPrincipal.Size = new System.Drawing.Size(1076, 25);
            this.tsMenuPrincipal.TabIndex = 1;
            this.tsMenuPrincipal.Text = "toolStrip1";
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
            this.tsbtnSair.Click += new System.EventHandler(this.tsbtnSair_Click);
            // 
            // tslHora
            // 
            this.tslHora.Name = "tslHora";
            this.tslHora.Size = new System.Drawing.Size(62, 22);
            this.tslHora.Text = "Hora atual";
            // 
            // dsPrincipalBindingSource
            // 
            this.dsPrincipalBindingSource.DataSource = this.dsPrincipal;
            this.dsPrincipalBindingSource.Position = 0;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.tsmBackup,
            this.relatórioToolStripMenuItem,
            this.toolStripMenuItem2,
            this.tsmSair});
            this.arquivoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arquivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastrosPrincipais,
            this.tsmCadastroFornecimento});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // tsmCadastrosPrincipais
            // 
            this.tsmCadastrosPrincipais.Name = "tsmCadastrosPrincipais";
            this.tsmCadastrosPrincipais.Size = new System.Drawing.Size(152, 22);
            this.tsmCadastrosPrincipais.Text = "Principais";
            this.tsmCadastrosPrincipais.Click += new System.EventHandler(this.tsmCadastrosPrincipais_Click);
            // 
            // tsmCadastroFornecimento
            // 
            this.tsmCadastroFornecimento.Name = "tsmCadastroFornecimento";
            this.tsmCadastroFornecimento.Size = new System.Drawing.Size(152, 22);
            this.tsmCadastroFornecimento.Text = "Fornecimento";
            // 
            // tsmBackup
            // 
            this.tsmBackup.Name = "tsmBackup";
            this.tsmBackup.Size = new System.Drawing.Size(130, 22);
            this.tsmBackup.Text = "Backup";
            this.tsmBackup.Click += new System.EventHandler(this.tsmBackup_Click);
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.funcionárioToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.serviçoToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.fornecimentoToolStripMenuItem,
            this.atendimentoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.personalizadoToolStripMenuItem6});
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.relatórioToolStripMenuItem.Text = "Relatórios";
            this.relatórioToolStripMenuItem.Visible = false;
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geralToolStripMenuItem,
            this.personalizadoToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // geralToolStripMenuItem
            // 
            this.geralToolStripMenuItem.Name = "geralToolStripMenuItem";
            this.geralToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.geralToolStripMenuItem.Text = "Geral";
            // 
            // personalizadoToolStripMenuItem
            // 
            this.personalizadoToolStripMenuItem.Name = "personalizadoToolStripMenuItem";
            this.personalizadoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.personalizadoToolStripMenuItem.Text = "Personalizado";
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geralToolStripMenuItem1,
            this.personalizadoToolStripMenuItem1});
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            // 
            // geralToolStripMenuItem1
            // 
            this.geralToolStripMenuItem1.Name = "geralToolStripMenuItem1";
            this.geralToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.geralToolStripMenuItem1.Text = "Geral";
            // 
            // personalizadoToolStripMenuItem1
            // 
            this.personalizadoToolStripMenuItem1.Name = "personalizadoToolStripMenuItem1";
            this.personalizadoToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.personalizadoToolStripMenuItem1.Text = "Personalizado";
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geralToolStripMenuItem2,
            this.personalizadoToolStripMenuItem2});
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // geralToolStripMenuItem2
            // 
            this.geralToolStripMenuItem2.Name = "geralToolStripMenuItem2";
            this.geralToolStripMenuItem2.Size = new System.Drawing.Size(150, 22);
            this.geralToolStripMenuItem2.Text = "Geral";
            // 
            // personalizadoToolStripMenuItem2
            // 
            this.personalizadoToolStripMenuItem2.Name = "personalizadoToolStripMenuItem2";
            this.personalizadoToolStripMenuItem2.Size = new System.Drawing.Size(150, 22);
            this.personalizadoToolStripMenuItem2.Text = "Personalizado";
            // 
            // serviçoToolStripMenuItem
            // 
            this.serviçoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geralToolStripMenuItem3,
            this.personalizadoToolStripMenuItem3});
            this.serviçoToolStripMenuItem.Name = "serviçoToolStripMenuItem";
            this.serviçoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.serviçoToolStripMenuItem.Text = "Serviço";
            // 
            // geralToolStripMenuItem3
            // 
            this.geralToolStripMenuItem3.Name = "geralToolStripMenuItem3";
            this.geralToolStripMenuItem3.Size = new System.Drawing.Size(150, 22);
            this.geralToolStripMenuItem3.Text = "Geral";
            // 
            // personalizadoToolStripMenuItem3
            // 
            this.personalizadoToolStripMenuItem3.Name = "personalizadoToolStripMenuItem3";
            this.personalizadoToolStripMenuItem3.Size = new System.Drawing.Size(150, 22);
            this.personalizadoToolStripMenuItem3.Text = "Personalizado";
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geralToolStripMenuItem4,
            this.personalizadoToolStripMenuItem4});
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            // 
            // geralToolStripMenuItem4
            // 
            this.geralToolStripMenuItem4.Name = "geralToolStripMenuItem4";
            this.geralToolStripMenuItem4.Size = new System.Drawing.Size(150, 22);
            this.geralToolStripMenuItem4.Text = "Geral";
            // 
            // personalizadoToolStripMenuItem4
            // 
            this.personalizadoToolStripMenuItem4.Name = "personalizadoToolStripMenuItem4";
            this.personalizadoToolStripMenuItem4.Size = new System.Drawing.Size(150, 22);
            this.personalizadoToolStripMenuItem4.Text = "Personalizado";
            // 
            // fornecimentoToolStripMenuItem
            // 
            this.fornecimentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geralToolStripMenuItem5,
            this.personalizadoToolStripMenuItem5});
            this.fornecimentoToolStripMenuItem.Name = "fornecimentoToolStripMenuItem";
            this.fornecimentoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fornecimentoToolStripMenuItem.Text = "Fornecimento";
            // 
            // geralToolStripMenuItem5
            // 
            this.geralToolStripMenuItem5.Name = "geralToolStripMenuItem5";
            this.geralToolStripMenuItem5.Size = new System.Drawing.Size(150, 22);
            this.geralToolStripMenuItem5.Text = "Geral";
            // 
            // personalizadoToolStripMenuItem5
            // 
            this.personalizadoToolStripMenuItem5.Name = "personalizadoToolStripMenuItem5";
            this.personalizadoToolStripMenuItem5.Size = new System.Drawing.Size(150, 22);
            this.personalizadoToolStripMenuItem5.Text = "Personalizado";
            // 
            // atendimentoToolStripMenuItem
            // 
            this.atendimentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geralToolStripMenuItem6,
            this.personalizadoToolStripMenuItem7});
            this.atendimentoToolStripMenuItem.Name = "atendimentoToolStripMenuItem";
            this.atendimentoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.atendimentoToolStripMenuItem.Text = "Atendimento";
            // 
            // geralToolStripMenuItem6
            // 
            this.geralToolStripMenuItem6.Name = "geralToolStripMenuItem6";
            this.geralToolStripMenuItem6.Size = new System.Drawing.Size(150, 22);
            this.geralToolStripMenuItem6.Text = "Geral";
            // 
            // personalizadoToolStripMenuItem7
            // 
            this.personalizadoToolStripMenuItem7.Name = "personalizadoToolStripMenuItem7";
            this.personalizadoToolStripMenuItem7.Size = new System.Drawing.Size(150, 22);
            this.personalizadoToolStripMenuItem7.Text = "Personalizado";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // personalizadoToolStripMenuItem6
            // 
            this.personalizadoToolStripMenuItem6.Name = "personalizadoToolStripMenuItem6";
            this.personalizadoToolStripMenuItem6.Size = new System.Drawing.Size(152, 22);
            this.personalizadoToolStripMenuItem6.Text = "Personalizado";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(127, 6);
            // 
            // tsmSair
            // 
            this.tsmSair.Name = "tsmSair";
            this.tsmSair.Size = new System.Drawing.Size(130, 22);
            this.tsmSair.Text = "Sair";
            this.tsmSair.Click += new System.EventHandler(this.tsbtnSair_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajudaToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.Color.Transparent;
            this.msMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(121, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.materialRaisedButton5);
            this.panel2.Controls.Add(this.materialRaisedButton4);
            this.panel2.Controls.Add(this.materialRaisedButton3);
            this.panel2.Controls.Add(this.materialRaisedButton2);
            this.panel2.Controls.Add(this.materialRaisedButton1);
            this.panel2.Controls.Add(this.btnConfirmar);
            this.panel2.Controls.Add(this.toolStripContainer1);
            this.panel2.ForeColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1076, 556);
            this.panel2.TabIndex = 14;
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.msMenu);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(150, 22);
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(3, 3);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(150, 22);
            this.toolStripContainer1.TabIndex = 16;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Depth = 0;
            this.btnConfirmar.Location = new System.Drawing.Point(114, 142);
            this.btnConfirmar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Primary = true;
            this.btnConfirmar.Size = new System.Drawing.Size(298, 148);
            this.btnConfirmar.TabIndex = 17;
            this.btnConfirmar.Text = "Cadastro Cliente";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(418, 142);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(296, 148);
            this.materialRaisedButton1.TabIndex = 18;
            this.materialRaisedButton1.Text = "Serviço";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(720, 142);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(255, 148);
            this.materialRaisedButton2.TabIndex = 19;
            this.materialRaisedButton2.Text = "Fornecedor";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Location = new System.Drawing.Point(114, 296);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(298, 153);
            this.materialRaisedButton3.TabIndex = 20;
            this.materialRaisedButton3.Text = "Cadastro Funcionario";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Location = new System.Drawing.Point(418, 296);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(296, 153);
            this.materialRaisedButton4.TabIndex = 21;
            this.materialRaisedButton4.Text = "Produto";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton5
            // 
            this.materialRaisedButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton5.Depth = 0;
            this.materialRaisedButton5.Location = new System.Drawing.Point(720, 296);
            this.materialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton5.Name = "materialRaisedButton5";
            this.materialRaisedButton5.Primary = true;
            this.materialRaisedButton5.Size = new System.Drawing.Size(255, 153);
            this.materialRaisedButton5.TabIndex = 22;
            this.materialRaisedButton5.Text = "Fornecimento";
            this.materialRaisedButton5.UseVisualStyleBackColor = true;
            // 
            // frmMenuPrincip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1076, 556);
            this.ControlBox = false;
            this.Controls.Add(this.tsMenuPrincipal);
            this.Controls.Add(this.panel2);
            this.IsMdiContainer = true;
            this.Name = "frmMenuPrincip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.tsMenuPrincipal.ResumeLayout(false);
            this.tsMenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ToolStrip tsMenuPrincipal;
		private System.Windows.Forms.ToolStripButton tsbtnSair;
		private System.Windows.Forms.BindingSource dsPrincipalBindingSource;
		private Dados.dsPrincipal dsPrincipal;
		private System.Windows.Forms.ToolStripLabel tslHora;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastrosPrincipais;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastroFornecimento;
        private System.Windows.Forms.ToolStripMenuItem tsmBackup;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalizadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geralToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personalizadoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geralToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem personalizadoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem serviçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geralToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem personalizadoToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geralToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem personalizadoToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem fornecimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geralToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem personalizadoToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem atendimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geralToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem personalizadoToolStripMenuItem7;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personalizadoToolStripMenuItem6;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmSair;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        public MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton5;
        public MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton4;
        public MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        public MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        public MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        public MaterialSkin.Controls.MaterialRaisedButton btnConfirmar;
    }
}

