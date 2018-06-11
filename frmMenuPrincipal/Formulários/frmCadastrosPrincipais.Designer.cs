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
            this.components = new System.ComponentModel.Container();
            this.serviçosAtendimentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrincipal = new frmMenuPrincipal.Dados.dsPrincipal();
            this.serviços_AtendimentoTableAdapter = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.Serviços_AtendimentoTableAdapter();
            this.pnlBotões = new System.Windows.Forms.Panel();
            this.btnFrmFornecimento = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnProduto = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCliente = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnServico = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnFuncionario = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnFornecedor = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.serviçosAtendimentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            this.pnlBotões.SuspendLayout();
            this.SuspendLayout();
            // 
            // serviçosAtendimentoBindingSource
            // 
            this.serviçosAtendimentoBindingSource.DataMember = "Serviços_Atendimento";
            this.serviçosAtendimentoBindingSource.DataSource = this.dsPrincipal;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviços_AtendimentoTableAdapter
            // 
            this.serviços_AtendimentoTableAdapter.ClearBeforeFill = true;
            // 
            // pnlBotões
            // 
            this.pnlBotões.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlBotões.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBotões.Controls.Add(this.btnFrmFornecimento);
            this.pnlBotões.Controls.Add(this.btnProduto);
            this.pnlBotões.Controls.Add(this.btnCliente);
            this.pnlBotões.Controls.Add(this.btnServico);
            this.pnlBotões.Controls.Add(this.btnFuncionario);
            this.pnlBotões.Controls.Add(this.btnFornecedor);
            this.pnlBotões.Location = new System.Drawing.Point(0, -1);
            this.pnlBotões.Name = "pnlBotões";
            this.pnlBotões.Size = new System.Drawing.Size(1024, 492);
            this.pnlBotões.TabIndex = 7;
            // 
            // btnFrmFornecimento
            // 
            this.btnFrmFornecimento.AutoSize = true;
            this.btnFrmFornecimento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFrmFornecimento.BackColor = System.Drawing.Color.LightGray;
            this.btnFrmFornecimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFrmFornecimento.Depth = 0;
            this.btnFrmFornecimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmFornecimento.Location = new System.Drawing.Point(684, 288);
            this.btnFrmFornecimento.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFrmFornecimento.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFrmFornecimento.Name = "btnFrmFornecimento";
            this.btnFrmFornecimento.Primary = false;
            this.btnFrmFornecimento.Size = new System.Drawing.Size(115, 36);
            this.btnFrmFornecimento.TabIndex = 6;
            this.btnFrmFornecimento.Text = "FORNECIMENTO";
            this.btnFrmFornecimento.UseVisualStyleBackColor = false;
            this.btnFrmFornecimento.Click += new System.EventHandler(this.btnFrmFornecimento_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.AutoSize = true;
            this.btnProduto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProduto.BackColor = System.Drawing.Color.LightGray;
            this.btnProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduto.Depth = 0;
            this.btnProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduto.Location = new System.Drawing.Point(472, 288);
            this.btnProduto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProduto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Primary = false;
            this.btnProduto.Size = new System.Drawing.Size(75, 36);
            this.btnProduto.TabIndex = 5;
            this.btnProduto.Text = "PRODUTO";
            this.btnProduto.UseVisualStyleBackColor = false;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.AutoSize = true;
            this.btnCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCliente.BackColor = System.Drawing.Color.LightGray;
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.Depth = 0;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(174, 126);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Primary = false;
            this.btnCliente.Size = new System.Drawing.Size(157, 36);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "CADASTRAR CLIENTES";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnServico
            // 
            this.btnServico.AutoSize = true;
            this.btnServico.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnServico.BackColor = System.Drawing.Color.LightGray;
            this.btnServico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServico.Depth = 0;
            this.btnServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServico.Location = new System.Drawing.Point(474, 126);
            this.btnServico.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnServico.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnServico.Name = "btnServico";
            this.btnServico.Primary = false;
            this.btnServico.Size = new System.Drawing.Size(68, 36);
            this.btnServico.TabIndex = 4;
            this.btnServico.Text = "SERVIÇO";
            this.btnServico.UseVisualStyleBackColor = false;
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.AutoSize = true;
            this.btnFuncionario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFuncionario.BackColor = System.Drawing.Color.LightGray;
            this.btnFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFuncionario.Depth = 0;
            this.btnFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.Location = new System.Drawing.Point(162, 288);
            this.btnFuncionario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFuncionario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Primary = false;
            this.btnFuncionario.Size = new System.Drawing.Size(192, 36);
            this.btnFuncionario.TabIndex = 1;
            this.btnFuncionario.Text = "CADASTRAR FUNCIONÁRIOS";
            this.btnFuncionario.UseVisualStyleBackColor = false;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.AutoSize = true;
            this.btnFornecedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFornecedor.BackColor = System.Drawing.Color.BurlyWood;
            this.btnFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFornecedor.Depth = 0;
            this.btnFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedor.Location = new System.Drawing.Point(684, 126);
            this.btnFornecedor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFornecedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Padding = new System.Windows.Forms.Padding(5);
            this.btnFornecedor.Primary = false;
            this.btnFornecedor.Size = new System.Drawing.Size(99, 36);
            this.btnFornecedor.TabIndex = 3;
            this.btnFornecedor.Text = "FORNECEDOR";
            this.btnFornecedor.UseVisualStyleBackColor = false;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // frmCadPrincipais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 491);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBotões);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadPrincipais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCadastros";
            this.Load += new System.EventHandler(this.frmCadastros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serviçosAtendimentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            this.pnlBotões.ResumeLayout(false);
            this.pnlBotões.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Dados.dsPrincipal dsPrincipal;
        private System.Windows.Forms.BindingSource serviçosAtendimentoBindingSource;
        private Dados.dsPrincipalTableAdapters.Serviços_AtendimentoTableAdapter serviços_AtendimentoTableAdapter;
		private System.Windows.Forms.Panel pnlBotões;
        private MaterialSkin.Controls.MaterialFlatButton btnFrmFornecimento;
        private MaterialSkin.Controls.MaterialFlatButton btnProduto;
        private MaterialSkin.Controls.MaterialFlatButton btnCliente;
        private MaterialSkin.Controls.MaterialFlatButton btnServico;
        private MaterialSkin.Controls.MaterialFlatButton btnFuncionario;
        private MaterialSkin.Controls.MaterialFlatButton btnFornecedor;
    }
}