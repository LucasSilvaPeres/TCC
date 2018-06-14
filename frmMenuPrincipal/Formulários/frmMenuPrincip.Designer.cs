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
			this.tsmCadastroCliente = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmCadastroAtendimento = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmCadastroServiço = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmCadastroFornecedor = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmCadastroFornecimento = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmCadastroProduto = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmCadastroFuncionario = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmBackup = new System.Windows.Forms.ToolStripMenuItem();
			this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmSair = new System.Windows.Forms.ToolStripMenuItem();
			this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.msMenu = new System.Windows.Forms.MenuStrip();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnAtendimento = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnFornecimento = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnProduto = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnFornecedor = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnServico = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnCliente = new MaterialSkin.Controls.MaterialRaisedButton();
			this.timerHora = new System.Windows.Forms.Timer(this.components);
			this.tsMenuPrincipal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dsPrincipalBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
			this.msMenu.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tsMenuPrincipal
			// 
			this.tsMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tsMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSair,
            this.tslHora});
			this.tsMenuPrincipal.Location = new System.Drawing.Point(0, 747);
			this.tsMenuPrincipal.Name = "tsMenuPrincipal";
			this.tsMenuPrincipal.Size = new System.Drawing.Size(1320, 25);
			this.tsMenuPrincipal.TabIndex = 1;
			this.tsMenuPrincipal.Text = "toolStrip1";
			// 
			// tsbtnSair
			// 
			this.tsbtnSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.tsbtnSair.BackColor = System.Drawing.SystemColors.Control;
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
			this.arquivoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
			this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
			this.arquivoToolStripMenuItem.Text = "Arquivo";
			// 
			// cadastrosToolStripMenuItem
			// 
			this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastroCliente,
            this.tsmCadastroAtendimento,
            this.tsmCadastroServiço,
            this.tsmCadastroFornecedor,
            this.tsmCadastroFornecimento,
            this.tsmCadastroProduto,
            this.tsmCadastroFuncionario});
			this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
			this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
			this.cadastrosToolStripMenuItem.Text = "Cadastros";
			// 
			// tsmCadastroCliente
			// 
			this.tsmCadastroCliente.Name = "tsmCadastroCliente";
			this.tsmCadastroCliente.Size = new System.Drawing.Size(152, 22);
			this.tsmCadastroCliente.Text = "Cliente";
			this.tsmCadastroCliente.Click += new System.EventHandler(this.tsmCadastrosPrincipais_Click);
			// 
			// tsmCadastroAtendimento
			// 
			this.tsmCadastroAtendimento.Name = "tsmCadastroAtendimento";
			this.tsmCadastroAtendimento.Size = new System.Drawing.Size(152, 22);
			this.tsmCadastroAtendimento.Text = "Atendimento";
			// 
			// tsmCadastroServiço
			// 
			this.tsmCadastroServiço.Name = "tsmCadastroServiço";
			this.tsmCadastroServiço.Size = new System.Drawing.Size(152, 22);
			this.tsmCadastroServiço.Text = "Serviço";
			// 
			// tsmCadastroFornecedor
			// 
			this.tsmCadastroFornecedor.Name = "tsmCadastroFornecedor";
			this.tsmCadastroFornecedor.Size = new System.Drawing.Size(152, 22);
			this.tsmCadastroFornecedor.Text = "Fornecedor";
			// 
			// tsmCadastroFornecimento
			// 
			this.tsmCadastroFornecimento.Name = "tsmCadastroFornecimento";
			this.tsmCadastroFornecimento.Size = new System.Drawing.Size(152, 22);
			this.tsmCadastroFornecimento.Text = "Fornecimento";
			// 
			// tsmCadastroProduto
			// 
			this.tsmCadastroProduto.Name = "tsmCadastroProduto";
			this.tsmCadastroProduto.Size = new System.Drawing.Size(152, 22);
			this.tsmCadastroProduto.Text = "Produto";
			// 
			// tsmCadastroFuncionario
			// 
			this.tsmCadastroFuncionario.Name = "tsmCadastroFuncionario";
			this.tsmCadastroFuncionario.Size = new System.Drawing.Size(152, 22);
			this.tsmCadastroFuncionario.Text = "Funcionário";
			// 
			// tsmBackup
			// 
			this.tsmBackup.Name = "tsmBackup";
			this.tsmBackup.Size = new System.Drawing.Size(219, 22);
			this.tsmBackup.Text = "Backup";
			this.tsmBackup.Click += new System.EventHandler(this.tsmBackup_Click);
			// 
			// relatórioToolStripMenuItem
			// 
			this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
			this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
			this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
			this.relatórioToolStripMenuItem.Text = "Relatório de Atendimento";
			this.relatórioToolStripMenuItem.Visible = false;
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 6);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(216, 6);
			// 
			// tsmSair
			// 
			this.tsmSair.Name = "tsmSair";
			this.tsmSair.Size = new System.Drawing.Size(219, 22);
			this.tsmSair.Text = "Sair";
			this.tsmSair.Click += new System.EventHandler(this.tsbtnSair_Click);
			// 
			// ajudaToolStripMenuItem
			// 
			this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.sobreToolStripMenuItem});
			this.ajudaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ajudaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
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
			// sobreToolStripMenuItem
			// 
			this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
			this.sobreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.sobreToolStripMenuItem.Text = "Sobre";
			// 
			// msMenu
			// 
			this.msMenu.BackColor = System.Drawing.Color.White;
			this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
			this.msMenu.Location = new System.Drawing.Point(0, 0);
			this.msMenu.Name = "msMenu";
			this.msMenu.Size = new System.Drawing.Size(1320, 24);
			this.msMenu.TabIndex = 0;
			this.msMenu.Text = "menuStrip1";
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
			this.panel2.Controls.Add(this.msMenu);
			this.panel2.Controls.Add(this.btnAtendimento);
			this.panel2.Controls.Add(this.btnFornecimento);
			this.panel2.Controls.Add(this.btnProduto);
			this.panel2.Controls.Add(this.btnFornecedor);
			this.panel2.Controls.Add(this.btnServico);
			this.panel2.Controls.Add(this.btnCliente);
			this.panel2.ForeColor = System.Drawing.Color.Silver;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1320, 744);
			this.panel2.TabIndex = 14;
			// 
			// btnAtendimento
			// 
			this.btnAtendimento.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnAtendimento.Depth = 0;
			this.btnAtendimento.Location = new System.Drawing.Point(435, 375);
			this.btnAtendimento.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnAtendimento.Name = "btnAtendimento";
			this.btnAtendimento.Primary = true;
			this.btnAtendimento.Size = new System.Drawing.Size(450, 250);
			this.btnAtendimento.TabIndex = 23;
			this.btnAtendimento.Text = "Atendimento";
			this.btnAtendimento.UseVisualStyleBackColor = true;
			// 
			// btnFornecimento
			// 
			this.btnFornecimento.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnFornecimento.Depth = 0;
			this.btnFornecimento.Location = new System.Drawing.Point(891, 375);
			this.btnFornecimento.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnFornecimento.Name = "btnFornecimento";
			this.btnFornecimento.Primary = true;
			this.btnFornecimento.Size = new System.Drawing.Size(450, 250);
			this.btnFornecimento.TabIndex = 22;
			this.btnFornecimento.Text = "Fornecimento";
			this.btnFornecimento.UseVisualStyleBackColor = true;
			// 
			// btnProduto
			// 
			this.btnProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnProduto.Depth = 0;
			this.btnProduto.Location = new System.Drawing.Point(-21, 375);
			this.btnProduto.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnProduto.Name = "btnProduto";
			this.btnProduto.Primary = true;
			this.btnProduto.Size = new System.Drawing.Size(450, 250);
			this.btnProduto.TabIndex = 21;
			this.btnProduto.Text = "Produto";
			this.btnProduto.UseVisualStyleBackColor = true;
			// 
			// btnFornecedor
			// 
			this.btnFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnFornecedor.Depth = 0;
			this.btnFornecedor.Location = new System.Drawing.Point(891, 119);
			this.btnFornecedor.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnFornecedor.Name = "btnFornecedor";
			this.btnFornecedor.Primary = true;
			this.btnFornecedor.Size = new System.Drawing.Size(450, 250);
			this.btnFornecedor.TabIndex = 19;
			this.btnFornecedor.Text = "Fornecedor";
			this.btnFornecedor.UseVisualStyleBackColor = true;
			// 
			// btnServico
			// 
			this.btnServico.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnServico.Depth = 0;
			this.btnServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnServico.Location = new System.Drawing.Point(435, 119);
			this.btnServico.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnServico.Name = "btnServico";
			this.btnServico.Primary = true;
			this.btnServico.Size = new System.Drawing.Size(450, 250);
			this.btnServico.TabIndex = 18;
			this.btnServico.Text = "Serviço";
			this.btnServico.UseVisualStyleBackColor = true;
			// 
			// btnCliente
			// 
			this.btnCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnCliente.Depth = 0;
			this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCliente.Location = new System.Drawing.Point(-21, 119);
			this.btnCliente.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnCliente.Name = "btnCliente";
			this.btnCliente.Primary = true;
			this.btnCliente.Size = new System.Drawing.Size(450, 250);
			this.btnCliente.TabIndex = 17;
			this.btnCliente.Text = "Cliente";
			this.btnCliente.UseVisualStyleBackColor = true;
			// 
			// timerHora
			// 
			this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
			// 
			// frmMenuPrincip
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1320, 772);
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
			this.panel2.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem tsmCadastroCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastroAtendimento;
        private System.Windows.Forms.ToolStripMenuItem tsmBackup;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmSair;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.Panel panel2;
        public MaterialSkin.Controls.MaterialRaisedButton btnFornecimento;
        public MaterialSkin.Controls.MaterialRaisedButton btnProduto;
        public MaterialSkin.Controls.MaterialRaisedButton btnFornecedor;
        public MaterialSkin.Controls.MaterialRaisedButton btnServico;
        public MaterialSkin.Controls.MaterialRaisedButton btnCliente;
		private System.Windows.Forms.ToolStripMenuItem tsmCadastroServiço;
		private System.Windows.Forms.ToolStripMenuItem tsmCadastroFornecedor;
		private System.Windows.Forms.ToolStripMenuItem tsmCadastroFornecimento;
		private System.Windows.Forms.ToolStripMenuItem tsmCadastroProduto;
		private System.Windows.Forms.ToolStripMenuItem tsmCadastroFuncionario;
		private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
		public MaterialSkin.Controls.MaterialRaisedButton btnAtendimento;
		private System.Windows.Forms.Timer timerHora;
	}
}

