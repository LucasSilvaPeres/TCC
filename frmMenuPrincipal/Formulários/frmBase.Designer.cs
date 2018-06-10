namespace frmMenuPrincipal.Formulários
{
    partial class frmBase
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgvBancoForm = new System.Windows.Forms.DataGridView();
			this.btnLimparCampos = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnConfirmar = new MaterialSkin.Controls.MaterialRaisedButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pnlCampos = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBancoForm)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.dgvBancoForm);
			this.panel1.Location = new System.Drawing.Point(12, 372);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(940, 265);
			this.panel1.TabIndex = 0;
			// 
			// dgvBancoForm
			// 
			this.dgvBancoForm.AllowUserToAddRows = false;
			this.dgvBancoForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBancoForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvBancoForm.Location = new System.Drawing.Point(0, 0);
			this.dgvBancoForm.Name = "dgvBancoForm";
			this.dgvBancoForm.ReadOnly = true;
			this.dgvBancoForm.Size = new System.Drawing.Size(940, 265);
			this.dgvBancoForm.TabIndex = 0;
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
			this.btnLimparCampos.TabIndex = 3;
			this.btnLimparCampos.Text = "Limpar Campos";
			this.btnLimparCampos.UseVisualStyleBackColor = true;
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
			this.btnConfirmar.TabIndex = 2;
			this.btnConfirmar.Text = "Confirmar";
			this.btnConfirmar.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.panel2.Controls.Add(this.btnLimparCampos);
			this.panel2.Location = new System.Drawing.Point(12, 333);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(152, 33);
			this.panel2.TabIndex = 4;
			// 
			// pnlCampos
			// 
			this.pnlCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlCampos.Location = new System.Drawing.Point(12, 12);
			this.pnlCampos.Name = "pnlCampos";
			this.pnlCampos.Size = new System.Drawing.Size(940, 311);
			this.pnlCampos.TabIndex = 5;
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.panel4.Controls.Add(this.btnConfirmar);
			this.panel4.Location = new System.Drawing.Point(830, 334);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(122, 32);
			this.panel4.TabIndex = 6;
			// 
			// frmBase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(964, 649);
			this.ControlBox = false;
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.pnlCampos);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmBase";
			this.Text = "frmBase";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvBancoForm)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dgvBancoForm;
        public MaterialSkin.Controls.MaterialRaisedButton btnConfirmar;
        public MaterialSkin.Controls.MaterialRaisedButton btnLimparCampos;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel pnlCampos;
        public System.Windows.Forms.Panel panel4;
    }
}