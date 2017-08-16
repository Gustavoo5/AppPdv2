namespace PL
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
            this.darkPanel1 = new Metro.DarkPanel();
            this.groupDados = new Metro.DarkPanel();
            this.groupControle = new Metro.DarkPanel();
            this.btnCancel = new Metro.RedButton();
            this.btnSalvar = new Metro.PurpleButton();
            this.btnDel = new Metro.RedButton();
            this.btnAlt = new Metro.OrangeButton();
            this.btnNovo = new Metro.GreenButton();
            this.groupPesq = new Metro.DarkPanel();
            this.btnPesq = new Metro.PurpleButton();
            this.txtPesq = new System.Windows.Forms.TextBox();
            this.cmbPesq = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.darkPanel1.SuspendLayout();
            this.groupControle.SuspendLayout();
            this.groupPesq.SuspendLayout();
            this.SuspendLayout();
            // 
            // darkPanel1
            // 
            this.darkPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.darkPanel1.Controls.Add(this.groupDados);
            this.darkPanel1.Controls.Add(this.groupControle);
            this.darkPanel1.Controls.Add(this.groupPesq);
            this.darkPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.darkPanel1.Location = new System.Drawing.Point(0, 0);
            this.darkPanel1.Name = "darkPanel1";
            this.darkPanel1.Size = new System.Drawing.Size(1101, 660);
            this.darkPanel1.TabIndex = 0;
            // 
            // groupDados
            // 
            this.groupDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDados.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDados.ForeColor = System.Drawing.SystemColors.Control;
            this.groupDados.Location = new System.Drawing.Point(0, 235);
            this.groupDados.Name = "groupDados";
            this.groupDados.Size = new System.Drawing.Size(1101, 356);
            this.groupDados.TabIndex = 2;
            // 
            // groupControle
            // 
            this.groupControle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupControle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupControle.Controls.Add(this.btnCancel);
            this.groupControle.Controls.Add(this.btnSalvar);
            this.groupControle.Controls.Add(this.btnDel);
            this.groupControle.Controls.Add(this.btnAlt);
            this.groupControle.Controls.Add(this.btnNovo);
            this.groupControle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControle.Location = new System.Drawing.Point(0, 591);
            this.groupControle.Name = "groupControle";
            this.groupControle.Size = new System.Drawing.Size(1101, 69);
            this.groupControle.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancel.Location = new System.Drawing.Point(996, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 55);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancelar\r\nF5";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSalvar.Location = new System.Drawing.Point(890, 9);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 55);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar\r\nF4";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDel.Location = new System.Drawing.Point(784, 9);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(100, 55);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Excluir\r\nF3";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // btnAlt
            // 
            this.btnAlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.btnAlt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.btnAlt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(25)))));
            this.btnAlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlt.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAlt.Location = new System.Drawing.Point(678, 9);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(100, 55);
            this.btnAlt.TabIndex = 1;
            this.btnAlt.Text = "Alterar\r\nF2";
            this.btnAlt.UseVisualStyleBackColor = false;
            this.btnAlt.Click += new System.EventHandler(this.BtnAlt_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(14)))));
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(14)))));
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(14)))));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNovo.Location = new System.Drawing.Point(572, 9);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 55);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo\r\nF1";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // groupPesq
            // 
            this.groupPesq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupPesq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupPesq.Controls.Add(this.btnPesq);
            this.groupPesq.Controls.Add(this.txtPesq);
            this.groupPesq.Controls.Add(this.cmbPesq);
            this.groupPesq.Controls.Add(this.lblFiltro);
            this.groupPesq.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPesq.Location = new System.Drawing.Point(0, 0);
            this.groupPesq.Name = "groupPesq";
            this.groupPesq.Size = new System.Drawing.Size(1101, 235);
            this.groupPesq.TabIndex = 0;
            // 
            // btnPesq
            // 
            this.btnPesq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.btnPesq.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPesq.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.btnPesq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.btnPesq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesq.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPesq.Location = new System.Drawing.Point(640, 3);
            this.btnPesq.Name = "btnPesq";
            this.btnPesq.Size = new System.Drawing.Size(88, 27);
            this.btnPesq.TabIndex = 7;
            this.btnPesq.Text = "Pesquisar";
            this.btnPesq.UseVisualStyleBackColor = false;
            this.btnPesq.Click += new System.EventHandler(this.BtnPesq_Click);
            // 
            // txtPesq
            // 
            this.txtPesq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesq.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesq.Location = new System.Drawing.Point(215, 6);
            this.txtPesq.Name = "txtPesq";
            this.txtPesq.Size = new System.Drawing.Size(419, 21);
            this.txtPesq.TabIndex = 6;
            this.txtPesq.TextChanged += new System.EventHandler(this.txtPesq_TextChanged);
            // 
            // cmbPesq
            // 
            this.cmbPesq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPesq.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPesq.FormattingEnabled = true;
            this.cmbPesq.Location = new System.Drawing.Point(54, 6);
            this.cmbPesq.Name = "cmbPesq";
            this.cmbPesq.Size = new System.Drawing.Size(155, 21);
            this.cmbPesq.TabIndex = 5;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFiltro.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.Color.White;
            this.lblFiltro.Location = new System.Drawing.Point(3, 5);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(45, 18);
            this.lblFiltro.TabIndex = 4;
            this.lblFiltro.Text = "Filtro";
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 660);
            this.Controls.Add(this.darkPanel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmBase";
            this.Text = "frmBase";
            this.Load += new System.EventHandler(this.FrmBase_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBase_KeyDown);
            this.darkPanel1.ResumeLayout(false);
            this.groupControle.ResumeLayout(false);
            this.groupPesq.ResumeLayout(false);
            this.groupPesq.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox txtPesq;
        public System.Windows.Forms.ComboBox cmbPesq;
        public System.Windows.Forms.Label lblFiltro;
        public Metro.DarkPanel darkPanel1;
        public Metro.DarkPanel groupControle;
        public Metro.RedButton btnCancel;
        public Metro.PurpleButton btnSalvar;
        public Metro.RedButton btnDel;
        public Metro.OrangeButton btnAlt;
        public Metro.GreenButton btnNovo;
        public Metro.DarkPanel groupPesq;
        public Metro.PurpleButton btnPesq;
        public Metro.DarkPanel groupDados;
    }
}