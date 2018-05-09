namespace frmMenuPrincipal.Formulários
{
    partial class frmCadFornecimento
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
            System.Windows.Forms.Label idFornecimentoLabel;
            System.Windows.Forms.Label idFornecedorLabel;
            this.dsPrincipal = new Dados.dsPrincipal();
            this.fornecimentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecimentoTableAdapter = new Dados.dsPrincipalTableAdapters.FornecimentoTableAdapter();
            this.tableAdapterManager = new Dados.dsPrincipalTableAdapters.TableAdapterManager();
            this.idFornecimentoTextBox = new System.Windows.Forms.TextBox();
            this.idFornecedorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            idFornecimentoLabel = new System.Windows.Forms.Label();
            idFornecedorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecimentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecimentoBindingSource
            // 
            this.fornecimentoBindingSource.DataMember = "Fornecimento";
            this.fornecimentoBindingSource.DataSource = this.dsPrincipal;
            // 
            // fornecimentoTableAdapter
            // 
            this.fornecimentoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AtendimentoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.FornecedorTableAdapter = null;
            this.tableAdapterManager.FornecimentoTableAdapter = this.fornecimentoTableAdapter;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.ServicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Dados.dsPrincipalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // idFornecimentoLabel
            // 
            idFornecimentoLabel.AutoSize = true;
            idFornecimentoLabel.Location = new System.Drawing.Point(179, 94);
            idFornecimentoLabel.Name = "idFornecimentoLabel";
            idFornecimentoLabel.Size = new System.Drawing.Size(85, 13);
            idFornecimentoLabel.TabIndex = 0;
            idFornecimentoLabel.Text = "id Fornecimento:";
            // 
            // idFornecimentoTextBox
            // 
            this.idFornecimentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecimentoBindingSource, "idFornecimento", true));
            this.idFornecimentoTextBox.Location = new System.Drawing.Point(283, 91);
            this.idFornecimentoTextBox.Name = "idFornecimentoTextBox";
            this.idFornecimentoTextBox.Size = new System.Drawing.Size(200, 20);
            this.idFornecimentoTextBox.TabIndex = 1;
            // 
            // idFornecedorLabel
            // 
            idFornecedorLabel.AutoSize = true;
            idFornecedorLabel.Location = new System.Drawing.Point(179, 120);
            idFornecedorLabel.Name = "idFornecedorLabel";
            idFornecedorLabel.Size = new System.Drawing.Size(75, 13);
            idFornecedorLabel.TabIndex = 2;
            idFornecedorLabel.Text = "id Fornecedor:";
            // 
            // idFornecedorTextBox
            // 
            this.idFornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecimentoBindingSource, "idFornecedor", true));
            this.idFornecedorTextBox.Location = new System.Drawing.Point(283, 117);
            this.idFornecedorTextBox.Name = "idFornecedorTextBox";
            this.idFornecedorTextBox.Size = new System.Drawing.Size(200, 20);
            this.idFornecedorTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fornecimento";
            // 
            // frmCadFornecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(idFornecimentoLabel);
            this.Controls.Add(this.idFornecimentoTextBox);
            this.Controls.Add(idFornecedorLabel);
            this.Controls.Add(this.idFornecedorTextBox);
            this.Name = "frmCadFornecimento";
            this.Text = "frmCadFornecimento";
            this.Load += new System.EventHandler(this.frmCadFornecimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecimentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dados.dsPrincipal dsPrincipal;
        private System.Windows.Forms.BindingSource fornecimentoBindingSource;
        private Dados.dsPrincipalTableAdapters.FornecimentoTableAdapter fornecimentoTableAdapter;
        private Dados.dsPrincipalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idFornecimentoTextBox;
        private System.Windows.Forms.TextBox idFornecedorTextBox;
        private System.Windows.Forms.Label label1;
    }
}