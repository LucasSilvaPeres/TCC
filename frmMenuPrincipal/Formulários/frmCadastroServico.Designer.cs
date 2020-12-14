﻿namespace frmMenuPrincipal.Formulários
{
    partial class frmCadastroServico
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
			System.Windows.Forms.Label idServicoLabel;
			System.Windows.Forms.Label nomeServicoLabel;
			System.Windows.Forms.Label precoServicoLabel;
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgvBancoForm = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataInfoServicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dsPrincipal = new frmMenuPrincipal.Dados.dsPrincipal();
			this.btnLimparCampos = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnConfirmar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.panel4 = new System.Windows.Forms.Panel();
			this.pnlCampos = new System.Windows.Forms.Panel();
			this.txtPreco = new System.Windows.Forms.MaskedTextBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtServico = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.servicoTableAdapter = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.ServicoTableAdapter();
			this.tableAdapterManager = new frmMenuPrincipal.Dados.dsPrincipalTableAdapters.TableAdapterManager();
			idServicoLabel = new System.Windows.Forms.Label();
			nomeServicoLabel = new System.Windows.Forms.Label();
			precoServicoLabel = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBancoForm)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
			this.panel4.SuspendLayout();
			this.pnlCampos.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// idServicoLabel
			// 
			idServicoLabel.AutoSize = true;
			idServicoLabel.Location = new System.Drawing.Point(21, 13);
			idServicoLabel.Name = "idServicoLabel";
			idServicoLabel.Size = new System.Drawing.Size(68, 13);
			idServicoLabel.TabIndex = 0;
			idServicoLabel.Text = "Id do serviço";
			// 
			// nomeServicoLabel
			// 
			nomeServicoLabel.AutoSize = true;
			nomeServicoLabel.Location = new System.Drawing.Point(216, 127);
			nomeServicoLabel.Name = "nomeServicoLabel";
			nomeServicoLabel.Size = new System.Drawing.Size(35, 13);
			nomeServicoLabel.TabIndex = 2;
			nomeServicoLabel.Text = "Nome";
			// 
			// precoServicoLabel
			// 
			precoServicoLabel.AutoSize = true;
			precoServicoLabel.Location = new System.Drawing.Point(216, 153);
			precoServicoLabel.Name = "precoServicoLabel";
			precoServicoLabel.Size = new System.Drawing.Size(35, 13);
			precoServicoLabel.TabIndex = 4;
			precoServicoLabel.Text = "Preço";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.dgvBancoForm);
			this.panel1.Location = new System.Drawing.Point(4, 326);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(940, 265);
			this.panel1.TabIndex = 7;
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
            this.dataInfoServicoDataGridViewTextBoxColumn});
			this.dgvBancoForm.DataSource = this.servicoBindingSource;
			this.dgvBancoForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvBancoForm.Location = new System.Drawing.Point(0, 0);
			this.dgvBancoForm.Name = "dgvBancoForm";
			this.dgvBancoForm.ReadOnly = true;
			this.dgvBancoForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvBancoForm.Size = new System.Drawing.Size(940, 265);
			this.dgvBancoForm.TabIndex = 0;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.DataPropertyName = "idServico";
			this.dataGridViewTextBoxColumn1.HeaderText = "Id do Serviço";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeServico";
			this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn3.DataPropertyName = "precoServico";
			this.dataGridViewTextBoxColumn3.HeaderText = "Preço";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataInfoServicoDataGridViewTextBoxColumn
			// 
			this.dataInfoServicoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataInfoServicoDataGridViewTextBoxColumn.DataPropertyName = "dataInfoServico";
			this.dataInfoServicoDataGridViewTextBoxColumn.HeaderText = "Data da informação";
			this.dataInfoServicoDataGridViewTextBoxColumn.Name = "dataInfoServicoDataGridViewTextBoxColumn";
			this.dataInfoServicoDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// servicoBindingSource
			// 
			this.servicoBindingSource.DataMember = "Servico";
			this.servicoBindingSource.DataSource = this.dsPrincipal;
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
			this.btnLimparCampos.Size = new System.Drawing.Size(152, 33);
			this.btnLimparCampos.TabIndex = 4;
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
			this.btnConfirmar.TabIndex = 3;
			this.btnConfirmar.Text = "Confirmar";
			this.btnConfirmar.UseVisualStyleBackColor = true;
			this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.panel4.Controls.Add(this.btnConfirmar);
			this.panel4.Location = new System.Drawing.Point(822, 288);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(122, 32);
			this.panel4.TabIndex = 10;
			// 
			// pnlCampos
			// 
			this.pnlCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlCampos.Controls.Add(this.txtPreco);
			this.pnlCampos.Controls.Add(idServicoLabel);
			this.pnlCampos.Controls.Add(this.txtId);
			this.pnlCampos.Controls.Add(nomeServicoLabel);
			this.pnlCampos.Controls.Add(this.txtServico);
			this.pnlCampos.Controls.Add(precoServicoLabel);
			this.pnlCampos.Location = new System.Drawing.Point(4, 19);
			this.pnlCampos.Name = "pnlCampos";
			this.pnlCampos.Size = new System.Drawing.Size(940, 258);
			this.pnlCampos.TabIndex = 9;
			// 
			// txtPreco
			// 
			this.txtPreco.Location = new System.Drawing.Point(313, 150);
			this.txtPreco.Mask = "$999,999.00";
			this.txtPreco.Name = "txtPreco";
			this.txtPreco.Size = new System.Drawing.Size(200, 20);
			this.txtPreco.TabIndex = 2;
			// 
			// txtId
			// 
			this.txtId.Enabled = false;
			this.txtId.Location = new System.Drawing.Point(118, 10);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(814, 20);
			this.txtId.TabIndex = 111;
			// 
			// txtServico
			// 
			this.txtServico.Location = new System.Drawing.Point(313, 124);
			this.txtServico.Name = "txtServico";
			this.txtServico.Size = new System.Drawing.Size(200, 20);
			this.txtServico.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.panel2.Controls.Add(this.btnLimparCampos);
			this.panel2.Location = new System.Drawing.Point(4, 287);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(152, 33);
			this.panel2.TabIndex = 8;
			// 
			// servicoTableAdapter
			// 
			this.servicoTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.AtendimentoTableAdapter = null;
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
			this.tableAdapterManager.ServicoTableAdapter = this.servicoTableAdapter;
			this.tableAdapterManager.UpdateOrder = frmMenuPrincipal.Dados.dsPrincipalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// frmCadastroServico
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(948, 610);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.pnlCampos);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmCadastroServico";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de serviços";
			this.Load += new System.EventHandler(this.frmCadastroServico_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvBancoForm)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
			this.panel4.ResumeLayout(false);
			this.pnlCampos.ResumeLayout(false);
			this.pnlCampos.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dgvBancoForm;
        public MaterialSkin.Controls.MaterialRaisedButton btnLimparCampos;
        public MaterialSkin.Controls.MaterialRaisedButton btnConfirmar;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Panel pnlCampos;
        public System.Windows.Forms.Panel panel2;
        private Dados.dsPrincipal dsPrincipal;
        private Dados.dsPrincipalTableAdapters.ServicoTableAdapter servicoTableAdapter;
        private Dados.dsPrincipalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeServicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoServicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource servicoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInfoServicoDataGridViewTextBoxColumn;
		private System.Windows.Forms.MaskedTextBox txtPreco;
	}
}