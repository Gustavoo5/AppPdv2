namespace PL.Formularios.Cadastro
{
    partial class frmPagamento
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
            this.gridPesq = new System.Windows.Forms.DataGridView();
            this.idFormPag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descPag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtDesc = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.darkPanel1.SuspendLayout();
            this.groupControle.SuspendLayout();
            this.groupPesq.SuspendLayout();
            this.groupDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesq)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPesq
            // 
            this.cmbPesq.Items.AddRange(new object[] {
            "ALL",
            "ID",
            "DESCRIÇÃO"});
            // 
            // darkPanel1
            // 
            this.darkPanel1.Size = new System.Drawing.Size(1101, 582);
            // 
            // groupControle
            // 
            this.groupControle.Location = new System.Drawing.Point(0, 513);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            // 
            // btnDel
            // 
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // btnAlt
            // 
            this.btnAlt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.btnAlt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(25)))));
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(14)))));
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(14)))));
            // 
            // groupPesq
            // 
            this.groupPesq.Controls.Add(this.gridPesq);
            this.groupPesq.Controls.SetChildIndex(this.lblFiltro, 0);
            this.groupPesq.Controls.SetChildIndex(this.cmbPesq, 0);
            this.groupPesq.Controls.SetChildIndex(this.txtPesq, 0);
            this.groupPesq.Controls.SetChildIndex(this.btnPesq, 0);
            this.groupPesq.Controls.SetChildIndex(this.gridPesq, 0);
            // 
            // btnPesq
            // 
            this.btnPesq.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPesq.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.btnPesq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            // 
            // groupDados
            // 
            this.groupDados.Controls.Add(this.TxtDesc);
            this.groupDados.Controls.Add(this.TxtId);
            this.groupDados.Controls.Add(this.label3);
            this.groupDados.Controls.Add(this.label2);
            this.groupDados.Size = new System.Drawing.Size(1101, 278);
            this.groupDados.Paint += new System.Windows.Forms.PaintEventHandler(this.groupDados_Paint);
            // 
            // gridPesq
            // 
            this.gridPesq.AllowUserToAddRows = false;
            this.gridPesq.AllowUserToDeleteRows = false;
            this.gridPesq.AllowUserToResizeColumns = false;
            this.gridPesq.AllowUserToResizeRows = false;
            this.gridPesq.BackgroundColor = System.Drawing.Color.White;
            this.gridPesq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPesq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFormPag,
            this.descPag});
            this.gridPesq.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPesq.Location = new System.Drawing.Point(0, 42);
            this.gridPesq.MultiSelect = false;
            this.gridPesq.Name = "gridPesq";
            this.gridPesq.ReadOnly = true;
            this.gridPesq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPesq.Size = new System.Drawing.Size(1099, 191);
            this.gridPesq.TabIndex = 4;
            this.gridPesq.Click += new System.EventHandler(this.gridPesq_Click);
            // 
            // idFormPag
            // 
            this.idFormPag.DataPropertyName = "idFormPag";
            this.idFormPag.HeaderText = "ID";
            this.idFormPag.Name = "idFormPag";
            this.idFormPag.ReadOnly = true;
            // 
            // descPag
            // 
            this.descPag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descPag.DataPropertyName = "descPag";
            this.descPag.HeaderText = "Descrição";
            this.descPag.Name = "descPag";
            this.descPag.ReadOnly = true;
            // 
            // TxtDesc
            // 
            this.TxtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDesc.Location = new System.Drawing.Point(82, 55);
            this.TxtDesc.MaxLength = 50;
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Size = new System.Drawing.Size(512, 23);
            this.TxtDesc.TabIndex = 7;
            // 
            // TxtId
            // 
            this.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(82, 23);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(64, 23);
            this.TxtId.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // frmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 582);
            this.Name = "frmPagamento";
            this.Text = "frmPagamento";
            this.Load += new System.EventHandler(this.frmPagamento_Load);
            this.darkPanel1.ResumeLayout(false);
            this.groupControle.ResumeLayout(false);
            this.groupPesq.ResumeLayout(false);
            this.groupPesq.PerformLayout();
            this.groupDados.ResumeLayout(false);
            this.groupDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPesq;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFormPag;
        private System.Windows.Forms.DataGridViewTextBoxColumn descPag;
        private System.Windows.Forms.TextBox TxtDesc;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}