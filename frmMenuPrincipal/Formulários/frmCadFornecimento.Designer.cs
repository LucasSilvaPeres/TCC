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
            System.Windows.Forms.Label dataFornecimentoLabel;
            this.dsPrincipal = new frmMenuPrincipal.Dados.dsPrincipal();
            this.fornecimentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecimentoTableAdapter = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.FornecimentoTableAdapter();
            this.tableAdapterManager = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.TableAdapterManager();
            this.fornecimentoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFornecimentoTextBox = new System.Windows.Forms.TextBox();
            this.idFornecedorTextBox = new System.Windows.Forms.TextBox();
            this.dataFornecimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            idFornecimentoLabel = new System.Windows.Forms.Label();
            idFornecedorLabel = new System.Windows.Forms.Label();
            dataFornecimentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecimentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecimentoDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.tableAdapterManager.Produtos_AtendimentoTableAdapter = null;
            this.tableAdapterManager.Produtos_FornecimentoTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.Serviços_AtendimentoTableAdapter = null;
            this.tableAdapterManager.ServicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = frmMenuPrincipal.Dados.dsPrincipalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fornecimentoDataGridView
            // 
            this.fornecimentoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fornecimentoDataGridView.AutoGenerateColumns = false;
            this.fornecimentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fornecimentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.fornecimentoDataGridView.DataSource = this.fornecimentoBindingSource;
            this.fornecimentoDataGridView.Location = new System.Drawing.Point(15, 84);
            this.fornecimentoDataGridView.Name = "fornecimentoDataGridView";
            this.fornecimentoDataGridView.Size = new System.Drawing.Size(300, 220);
            this.fornecimentoDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idFornecimento";
            this.dataGridViewTextBoxColumn1.HeaderText = "idFornecimento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idFornecedor";
            this.dataGridViewTextBoxColumn2.HeaderText = "idFornecedor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dataFornecimento";
            this.dataGridViewTextBoxColumn3.HeaderText = "dataFornecimento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // idFornecimentoLabel
            // 
            idFornecimentoLabel.AutoSize = true;
            idFornecimentoLabel.Location = new System.Drawing.Point(12, 9);
            idFornecimentoLabel.Name = "idFornecimentoLabel";
            idFornecimentoLabel.Size = new System.Drawing.Size(85, 13);
            idFornecimentoLabel.TabIndex = 1;
            idFornecimentoLabel.Text = "id Fornecimento:";
            // 
            // idFornecimentoTextBox
            // 
            this.idFornecimentoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idFornecimentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecimentoBindingSource, "idFornecimento", true));
            this.idFornecimentoTextBox.Location = new System.Drawing.Point(0, 3);
            this.idFornecimentoTextBox.Name = "idFornecimentoTextBox";
            this.idFornecimentoTextBox.Size = new System.Drawing.Size(192, 20);
            this.idFornecimentoTextBox.TabIndex = 2;
            // 
            // idFornecedorLabel
            // 
            idFornecedorLabel.AutoSize = true;
            idFornecedorLabel.Location = new System.Drawing.Point(12, 35);
            idFornecedorLabel.Name = "idFornecedorLabel";
            idFornecedorLabel.Size = new System.Drawing.Size(75, 13);
            idFornecedorLabel.TabIndex = 3;
            idFornecedorLabel.Text = "id Fornecedor:";
            // 
            // idFornecedorTextBox
            // 
            this.idFornecedorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idFornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecimentoBindingSource, "idFornecedor", true));
            this.idFornecedorTextBox.Location = new System.Drawing.Point(0, 29);
            this.idFornecedorTextBox.Name = "idFornecedorTextBox";
            this.idFornecedorTextBox.Size = new System.Drawing.Size(192, 20);
            this.idFornecedorTextBox.TabIndex = 4;
            // 
            // dataFornecimentoLabel
            // 
            dataFornecimentoLabel.AutoSize = true;
            dataFornecimentoLabel.Location = new System.Drawing.Point(12, 62);
            dataFornecimentoLabel.Name = "dataFornecimentoLabel";
            dataFornecimentoLabel.Size = new System.Drawing.Size(98, 13);
            dataFornecimentoLabel.TabIndex = 5;
            dataFornecimentoLabel.Text = "data Fornecimento:";
            // 
            // dataFornecimentoDateTimePicker
            // 
            this.dataFornecimentoDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataFornecimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fornecimentoBindingSource, "dataFornecimento", true));
            this.dataFornecimentoDateTimePicker.Location = new System.Drawing.Point(0, 55);
            this.dataFornecimentoDateTimePicker.Name = "dataFornecimentoDateTimePicker";
            this.dataFornecimentoDateTimePicker.Size = new System.Drawing.Size(192, 20);
            this.dataFornecimentoDateTimePicker.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.idFornecimentoTextBox);
            this.panel1.Controls.Add(this.idFornecedorTextBox);
            this.panel1.Controls.Add(this.dataFornecimentoDateTimePicker);
            this.panel1.Location = new System.Drawing.Point(116, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 75);
            this.panel1.TabIndex = 7;
            // 
            // frmCadFornecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 412);
            this.Controls.Add(this.panel1);
            this.Controls.Add(idFornecimentoLabel);
            this.Controls.Add(idFornecedorLabel);
            this.Controls.Add(dataFornecimentoLabel);
            this.Controls.Add(this.fornecimentoDataGridView);
            this.Name = "frmCadFornecimento";
            this.Text = "a";
            this.Load += new System.EventHandler(this.frmCadFornecimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecimentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecimentoDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dados.dsPrincipal dsPrincipal;
        private System.Windows.Forms.BindingSource fornecimentoBindingSource;
        private Dados.dsPrincipalTableAdapters.FornecimentoTableAdapter fornecimentoTableAdapter;
        private Dados.dsPrincipalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView fornecimentoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox idFornecimentoTextBox;
        private System.Windows.Forms.TextBox idFornecedorTextBox;
        private System.Windows.Forms.DateTimePicker dataFornecimentoDateTimePicker;
        private System.Windows.Forms.Panel panel1;
    }
}