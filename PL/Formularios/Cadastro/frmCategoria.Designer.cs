namespace PL
{
    partial class frmCategoria
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
            this.idCateg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descCateg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCateg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // btnAlt
            // 
            this.btnAlt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.btnAlt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(25)))));
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.groupDados.Controls.Add(this.txtData);
            this.groupDados.Controls.Add(this.txtDesc);
            this.groupDados.Controls.Add(this.txtId);
            this.groupDados.Controls.Add(this.label4);
            this.groupDados.Controls.Add(this.label3);
            this.groupDados.Controls.Add(this.label2);
            this.groupDados.Size = new System.Drawing.Size(1101, 278);
            // 
            // gridPesq
            // 
            this.gridPesq.AllowUserToAddRows = false;
            this.gridPesq.AllowUserToDeleteRows = false;
            this.gridPesq.AllowUserToResizeColumns = false;
            this.gridPesq.AllowUserToResizeRows = false;
            this.gridPesq.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridPesq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPesq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCateg,
            this.descCateg,
            this.dataCateg});
            this.gridPesq.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPesq.Location = new System.Drawing.Point(0, 44);
            this.gridPesq.MultiSelect = false;
            this.gridPesq.Name = "gridPesq";
            this.gridPesq.ReadOnly = true;
            this.gridPesq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPesq.Size = new System.Drawing.Size(1099, 189);
            this.gridPesq.TabIndex = 5;
            this.gridPesq.Click += new System.EventHandler(this.GridPesq_Click);
            // 
            // idCateg
            // 
            this.idCateg.DataPropertyName = "idCateg";
            this.idCateg.HeaderText = "ID";
            this.idCateg.Name = "idCateg";
            this.idCateg.ReadOnly = true;
            // 
            // descCateg
            // 
            this.descCateg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descCateg.DataPropertyName = "descCateg";
            this.descCateg.HeaderText = "Descrição";
            this.descCateg.Name = "descCateg";
            this.descCateg.ReadOnly = true;
            // 
            // dataCateg
            // 
            this.dataCateg.DataPropertyName = "dataCateg";
            this.dataCateg.HeaderText = "Data Cadastro";
            this.dataCateg.Name = "dataCateg";
            this.dataCateg.ReadOnly = true;
            this.dataCateg.Width = 150;
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.SystemColors.Control;
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(225, 47);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 23);
            this.txtData.TabIndex = 13;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.SystemColors.Control;
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesc.Location = new System.Drawing.Point(88, 77);
            this.txtDesc.MaxLength = 30;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(332, 23);
            this.txtDesc.TabIndex = 12;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Control;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(88, 47);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(86, 23);
            this.txtId.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(180, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 582);
            this.Name = "frmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCategoria";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idCateg;
        private System.Windows.Forms.DataGridViewTextBoxColumn descCateg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCateg;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}