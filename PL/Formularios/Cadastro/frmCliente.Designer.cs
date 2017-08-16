namespace PL
{
    partial class frmCliente
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
            this.idClie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeClie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfClie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endClie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroClie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeClie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obsClie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
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
            "NOME"});
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
            this.groupDados.Controls.Add(this.txtNumero);
            this.groupDados.Controls.Add(this.txtObs);
            this.groupDados.Controls.Add(this.label16);
            this.groupDados.Controls.Add(this.txtCidade);
            this.groupDados.Controls.Add(this.label14);
            this.groupDados.Controls.Add(this.txtBairro);
            this.groupDados.Controls.Add(this.label11);
            this.groupDados.Controls.Add(this.txtEnd);
            this.groupDados.Controls.Add(this.label10);
            this.groupDados.Controls.Add(this.txtCpf);
            this.groupDados.Controls.Add(this.label9);
            this.groupDados.Controls.Add(this.label6);
            this.groupDados.Controls.Add(this.txtNome);
            this.groupDados.Controls.Add(this.txtId);
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
            this.gridPesq.BackgroundColor = System.Drawing.Color.White;
            this.gridPesq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPesq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClie,
            this.nomeClie,
            this.cpfClie,
            this.endClie,
            this.bairroClie,
            this.cidadeClie,
            this.obsClie,
            this.telNumero,
            this.qtd});
            this.gridPesq.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPesq.Location = new System.Drawing.Point(0, 44);
            this.gridPesq.MultiSelect = false;
            this.gridPesq.Name = "gridPesq";
            this.gridPesq.ReadOnly = true;
            this.gridPesq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPesq.Size = new System.Drawing.Size(1099, 189);
            this.gridPesq.TabIndex = 4;
            this.gridPesq.Click += new System.EventHandler(this.GridPesq_Click);
            // 
            // idClie
            // 
            this.idClie.DataPropertyName = "idClie";
            this.idClie.HeaderText = "ID";
            this.idClie.Name = "idClie";
            this.idClie.ReadOnly = true;
            this.idClie.Width = 50;
            // 
            // nomeClie
            // 
            this.nomeClie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeClie.DataPropertyName = "nomeClie";
            this.nomeClie.HeaderText = "Nome Cliente";
            this.nomeClie.Name = "nomeClie";
            this.nomeClie.ReadOnly = true;
            // 
            // cpfClie
            // 
            this.cpfClie.DataPropertyName = "cpfClie";
            this.cpfClie.HeaderText = "CPF";
            this.cpfClie.Name = "cpfClie";
            this.cpfClie.ReadOnly = true;
            // 
            // endClie
            // 
            this.endClie.DataPropertyName = "endClie";
            this.endClie.HeaderText = "Endereço";
            this.endClie.Name = "endClie";
            this.endClie.ReadOnly = true;
            // 
            // bairroClie
            // 
            this.bairroClie.DataPropertyName = "bairroClie";
            this.bairroClie.HeaderText = "Bairro";
            this.bairroClie.Name = "bairroClie";
            this.bairroClie.ReadOnly = true;
            // 
            // cidadeClie
            // 
            this.cidadeClie.DataPropertyName = "cidadeClie";
            this.cidadeClie.HeaderText = "Cidade";
            this.cidadeClie.Name = "cidadeClie";
            this.cidadeClie.ReadOnly = true;
            // 
            // obsClie
            // 
            this.obsClie.DataPropertyName = "obsClie";
            this.obsClie.HeaderText = "Observação";
            this.obsClie.Name = "obsClie";
            this.obsClie.ReadOnly = true;
            // 
            // telNumero
            // 
            this.telNumero.DataPropertyName = "telNumero";
            this.telNumero.HeaderText = "Numero";
            this.telNumero.Name = "telNumero";
            this.telNumero.ReadOnly = true;
            // 
            // qtd
            // 
            this.qtd.DataPropertyName = "qtd";
            this.qtd.HeaderText = "qtd";
            this.qtd.Name = "qtd";
            this.qtd.ReadOnly = true;
            this.qtd.Visible = false;
            // 
            // txtObs
            // 
            this.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObs.Location = new System.Drawing.Point(97, 107);
            this.txtObs.MaxLength = 500;
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(434, 102);
            this.txtObs.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(7, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 16);
            this.label16.TabIndex = 83;
            this.label16.Text = "Observação";
            // 
            // txtCidade
            // 
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Location = new System.Drawing.Point(97, 78);
            this.txtCidade.MaxLength = 30;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(77, 23);
            this.txtCidade.TabIndex = 4;
            this.txtCidade.Text = "BATATAIS";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(44, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 16);
            this.label14.TabIndex = 80;
            this.label14.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(226, 78);
            this.txtBairro.MaxLength = 30;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(120, 23);
            this.txtBairro.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(179, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 74;
            this.label11.Text = "Bairro";
            // 
            // txtEnd
            // 
            this.txtEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEnd.Location = new System.Drawing.Point(427, 48);
            this.txtEnd.MaxLength = 255;
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(434, 23);
            this.txtEnd.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(352, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 72;
            this.label10.Text = "Endereço";
            // 
            // txtCpf
            // 
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpf.Location = new System.Drawing.Point(226, 49);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(120, 23);
            this.txtCpf.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(191, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 16);
            this.label9.TabIndex = 67;
            this.label9.Text = "CPF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 64;
            this.label6.Text = "Telefone";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(226, 20);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(635, 23);
            this.txtNome.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(97, 20);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(77, 23);
            this.txtId.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(180, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 57;
            this.label3.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "ID";
            // 
            // txtNumero
            // 
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumero.Location = new System.Drawing.Point(97, 49);
            this.txtNumero.MaxLength = 9;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(77, 23);
            this.txtNumero.TabIndex = 1;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 582);
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCliente";
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
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClie;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfClie;
        private System.Windows.Forms.DataGridViewTextBoxColumn endClie;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroClie;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeClie;
        private System.Windows.Forms.DataGridViewTextBoxColumn obsClie;
        private System.Windows.Forms.DataGridViewTextBoxColumn telNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd;
        private System.Windows.Forms.TextBox txtNumero;
    }
}