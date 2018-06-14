namespace frmMenuPrincipal.Formulários
{
    partial class frmCadPrincipais
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAtendimento = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnFornecimento = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnProduto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnFornecedor = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnServico = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.btnAtendimento);
            this.panel2.Controls.Add(this.btnFornecimento);
            this.panel2.Controls.Add(this.btnProduto);
            this.panel2.Controls.Add(this.btnFornecedor);
            this.panel2.Controls.Add(this.btnServico);
            this.panel2.Controls.Add(this.btnCliente);
            this.panel2.ForeColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(-131, -89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1448, 641);
            this.panel2.TabIndex = 15;
            // 
            // btnAtendimento
            // 
            this.btnAtendimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAtendimento.Depth = 0;
            this.btnAtendimento.Location = new System.Drawing.Point(533, 294);
            this.btnAtendimento.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAtendimento.Name = "btnAtendimento";
            this.btnAtendimento.Primary = true;
            this.btnAtendimento.Size = new System.Drawing.Size(384, 187);
            this.btnAtendimento.TabIndex = 23;
            this.btnAtendimento.Text = "Atendimento";
            this.btnAtendimento.UseVisualStyleBackColor = true;
            this.btnAtendimento.Click += new System.EventHandler(this.btnAtendimento_Click);
            // 
            // btnFornecimento
            // 
            this.btnFornecimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFornecimento.Depth = 0;
            this.btnFornecimento.Location = new System.Drawing.Point(923, 294);
            this.btnFornecimento.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFornecimento.Name = "btnFornecimento";
            this.btnFornecimento.Primary = true;
            this.btnFornecimento.Size = new System.Drawing.Size(384, 187);
            this.btnFornecimento.TabIndex = 22;
            this.btnFornecimento.Text = "Fornecimento";
            this.btnFornecimento.UseVisualStyleBackColor = true;
            this.btnFornecimento.Click += new System.EventHandler(this.btnAtendimento_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProduto.Depth = 0;
            this.btnProduto.Location = new System.Drawing.Point(143, 294);
            this.btnProduto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Primary = true;
            this.btnProduto.Size = new System.Drawing.Size(384, 187);
            this.btnProduto.TabIndex = 21;
            this.btnProduto.Text = "Produto";
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFornecedor.Depth = 0;
            this.btnFornecedor.Location = new System.Drawing.Point(923, 101);
            this.btnFornecedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Primary = true;
            this.btnFornecedor.Size = new System.Drawing.Size(384, 187);
            this.btnFornecedor.TabIndex = 19;
            this.btnFornecedor.Text = "Fornecedor";
            this.btnFornecedor.UseVisualStyleBackColor = true;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // btnServico
            // 
            this.btnServico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnServico.Depth = 0;
            this.btnServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServico.Location = new System.Drawing.Point(533, 101);
            this.btnServico.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnServico.Name = "btnServico";
            this.btnServico.Primary = true;
            this.btnServico.Size = new System.Drawing.Size(384, 187);
            this.btnServico.TabIndex = 18;
            this.btnServico.Text = "Serviço";
            this.btnServico.UseVisualStyleBackColor = true;
            this.btnServico.Click += new System.EventHandler(this.btnServico_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCliente.Depth = 0;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(143, 101);
            this.btnCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Primary = true;
            this.btnCliente.Size = new System.Drawing.Size(384, 187);
            this.btnCliente.TabIndex = 17;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // frmCadPrincipais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 408);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadPrincipais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCadastros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCadastros_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public MaterialSkin.Controls.MaterialRaisedButton btnAtendimento;
        public MaterialSkin.Controls.MaterialRaisedButton btnFornecimento;
        public MaterialSkin.Controls.MaterialRaisedButton btnProduto;
        public MaterialSkin.Controls.MaterialRaisedButton btnFornecedor;
        public MaterialSkin.Controls.MaterialRaisedButton btnServico;
        public MaterialSkin.Controls.MaterialRaisedButton btnCliente;
    }
}