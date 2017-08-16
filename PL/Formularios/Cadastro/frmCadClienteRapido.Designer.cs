namespace PL.Formularios.Cadastro
{
    partial class frmCadClienteRapido
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
            this.pnlBarra = new Metro.DarkPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMini = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.pnlBtns = new Metro.DarkPanel();
            this.btnCancelar = new Metro.RedButton();
            this.btnSalvar = new Metro.GreenButton();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlBarra.SuspendLayout();
            this.pnlBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnlBarra.Controls.Add(this.lblTitulo);
            this.pnlBarra.Controls.Add(this.lblMini);
            this.pnlBarra.Controls.Add(this.lblClose);
            this.pnlBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarra.Location = new System.Drawing.Point(0, 0);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(496, 31);
            this.pnlBarra.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblTitulo.Location = new System.Drawing.Point(46, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(221, 18);
            this.lblTitulo.TabIndex = 167;
            this.lblTitulo.Text = "Cadastro de cliente rapido";
            // 
            // lblMini
            // 
            this.lblMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMini.AutoSize = true;
            this.lblMini.BackColor = System.Drawing.Color.Transparent;
            this.lblMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMini.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMini.ForeColor = System.Drawing.Color.White;
            this.lblMini.Location = new System.Drawing.Point(445, 4);
            this.lblMini.Name = "lblMini";
            this.lblMini.Size = new System.Drawing.Size(19, 23);
            this.lblMini.TabIndex = 164;
            this.lblMini.Text = "-";
            this.lblMini.Click += new System.EventHandler(this.lblMini_Click);
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClose.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(470, 4);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(23, 23);
            this.lblClose.TabIndex = 163;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // pnlBtns
            // 
            this.pnlBtns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnlBtns.Controls.Add(this.btnCancelar);
            this.pnlBtns.Controls.Add(this.btnSalvar);
            this.pnlBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBtns.Location = new System.Drawing.Point(0, 204);
            this.pnlBtns.Name = "pnlBtns";
            this.pnlBtns.Size = new System.Drawing.Size(496, 69);
            this.pnlBtns.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelar.Location = new System.Drawing.Point(283, 8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 54);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(14)))));
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(14)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(14)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSalvar.Location = new System.Drawing.Point(389, 8);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 54);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(29, 80);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Endereço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bairro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cidade";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(75, 77);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(413, 21);
            this.txtNome.TabIndex = 0;
            // 
            // txtEnd
            // 
            this.txtEnd.BackColor = System.Drawing.Color.White;
            this.txtEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEnd.Location = new System.Drawing.Point(75, 104);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(413, 21);
            this.txtEnd.TabIndex = 1;
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.White;
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(75, 131);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(157, 21);
            this.txtBairro.TabIndex = 2;
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.White;
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Location = new System.Drawing.Point(75, 158);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(157, 21);
            this.txtCidade.TabIndex = 3;
            this.txtCidade.Text = "BATATAIS";
            // 
            // txtNumero
            // 
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(75, 50);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(77, 21);
            this.txtNumero.TabIndex = 88;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 87;
            this.label8.Text = "Telefone";
            // 
            // frmCadClienteRapido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(496, 273);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pnlBtns);
            this.Controls.Add(this.pnlBarra);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadClienteRapido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadClienteRapido";
            this.Load += new System.EventHandler(this.frmCadClienteRapido_Load);
            this.pnlBarra.ResumeLayout(false);
            this.pnlBarra.PerformLayout();
            this.pnlBtns.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Metro.DarkPanel pnlBarra;
        private System.Windows.Forms.Label lblMini;
        private System.Windows.Forms.Label lblClose;
        private Metro.DarkPanel pnlBtns;
        private Metro.RedButton btnCancelar;
        private Metro.GreenButton btnSalvar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.TextBox txtNumero;
    }
}