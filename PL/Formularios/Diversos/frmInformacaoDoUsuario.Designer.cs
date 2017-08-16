namespace PL.Formularios.Diversos
{
    partial class frmInformacaoDoUsuario
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
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.chkMSenha = new System.Windows.Forms.CheckBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAcesso = new System.Windows.Forms.ComboBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImg = new System.Windows.Forms.TextBox();
            this.darkPanel1 = new Metro.DarkPanel();
            this.btnAlt = new Metro.OrangeButton();
            this.btnCancel = new Metro.RedButton();
            this.btnSalvar = new Metro.PurpleButton();
            this.pnlBorda = new Metro.DarkPanel();
            this.lblMini = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxTitulo = new System.Windows.Forms.PictureBox();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.darkPanel1.SuspendLayout();
            this.pnlBorda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.Teal;
            this.btnSelecionar.Enabled = false;
            this.btnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionar.Location = new System.Drawing.Point(308, 217);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(33, 27);
            this.btnSelecionar.TabIndex = 1;
            this.btnSelecionar.Text = "...";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // chkMSenha
            // 
            this.chkMSenha.AutoSize = true;
            this.chkMSenha.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkMSenha.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.chkMSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.chkMSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMSenha.ForeColor = System.Drawing.Color.White;
            this.chkMSenha.Location = new System.Drawing.Point(138, 424);
            this.chkMSenha.Name = "chkMSenha";
            this.chkMSenha.Size = new System.Drawing.Size(127, 21);
            this.chkMSenha.TabIndex = 32;
            this.chkMSenha.Text = "Mostrar Senha";
            this.chkMSenha.UseVisualStyleBackColor = true;
            this.chkMSenha.CheckedChanged += new System.EventHandler(this.chkMSenha_CheckedChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Enabled = false;
            this.txtSenha.Location = new System.Drawing.Point(13, 421);
            this.txtSenha.MaxLength = 30;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(119, 24);
            this.txtSenha.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Senha";
            // 
            // cmbAcesso
            // 
            this.cmbAcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAcesso.Enabled = false;
            this.cmbAcesso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbAcesso.FormattingEnabled = true;
            this.cmbAcesso.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "USUARIO COMUM"});
            this.cmbAcesso.Location = new System.Drawing.Point(13, 468);
            this.cmbAcesso.Name = "cmbAcesso";
            this.cmbAcesso.Size = new System.Drawing.Size(299, 24);
            this.cmbAcesso.TabIndex = 29;
            // 
            // txtLogin
            // 
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogin.Enabled = false;
            this.txtLogin.Location = new System.Drawing.Point(13, 374);
            this.txtLogin.MaxLength = 30;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(119, 24);
            this.txtLogin.TabIndex = 28;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(13, 327);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(353, 24);
            this.txtNome.TabIndex = 27;
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(12, 280);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(119, 24);
            this.txtId.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Acesso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID";
            // 
            // txtImg
            // 
            this.txtImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImg.Enabled = false;
            this.txtImg.Location = new System.Drawing.Point(308, 187);
            this.txtImg.Name = "txtImg";
            this.txtImg.Size = new System.Drawing.Size(33, 24);
            this.txtImg.TabIndex = 33;
            this.txtImg.Visible = false;
            // 
            // darkPanel1
            // 
            this.darkPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.darkPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkPanel1.Controls.Add(this.btnAlt);
            this.darkPanel1.Controls.Add(this.btnCancel);
            this.darkPanel1.Controls.Add(this.btnSalvar);
            this.darkPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.darkPanel1.Location = new System.Drawing.Point(0, 512);
            this.darkPanel1.Name = "darkPanel1";
            this.darkPanel1.Size = new System.Drawing.Size(411, 78);
            this.darkPanel1.TabIndex = 161;
            // 
            // btnAlt
            // 
            this.btnAlt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.btnAlt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.btnAlt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(25)))));
            this.btnAlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlt.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.btnAlt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAlt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlt.Location = new System.Drawing.Point(149, 10);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(115, 55);
            this.btnAlt.TabIndex = 10;
            this.btnAlt.Text = "Alterar\r\nF2";
            this.btnAlt.UseVisualStyleBackColor = false;
            this.btnAlt.Click += new System.EventHandler(this.btnAlt_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(286, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 55);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancelar\r\nF5";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalvar.Location = new System.Drawing.Point(13, 10);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(115, 55);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar\r\nF4";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pnlBorda
            // 
            this.pnlBorda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnlBorda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBorda.Controls.Add(this.pictureBoxTitulo);
            this.pnlBorda.Controls.Add(this.lblMini);
            this.pnlBorda.Controls.Add(this.lblClose);
            this.pnlBorda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBorda.Location = new System.Drawing.Point(0, 0);
            this.pnlBorda.Name = "pnlBorda";
            this.pnlBorda.Size = new System.Drawing.Size(411, 28);
            this.pnlBorda.TabIndex = 162;
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
            this.lblMini.Location = new System.Drawing.Point(358, 2);
            this.lblMini.Name = "lblMini";
            this.lblMini.Size = new System.Drawing.Size(19, 23);
            this.lblMini.TabIndex = 162;
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
            this.lblClose.Location = new System.Drawing.Point(383, 2);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(23, 23);
            this.lblClose.TabIndex = 161;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBoxTitulo
            // 
            this.pictureBoxTitulo.BackgroundImage = global::PL.Properties.Resources.People_Titulo;
            this.pictureBoxTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxTitulo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTitulo.Name = "pictureBoxTitulo";
            this.pictureBoxTitulo.Size = new System.Drawing.Size(27, 26);
            this.pictureBoxTitulo.TabIndex = 163;
            this.pictureBoxTitulo.TabStop = false;
            // 
            // picbox
            // 
            this.picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbox.Location = new System.Drawing.Point(97, 39);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(205, 205);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox.TabIndex = 0;
            this.picbox.TabStop = false;
            this.picbox.Click += new System.EventHandler(this.picbox_Click);
            // 
            // frmInformacaoDoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(411, 590);
            this.Controls.Add(this.pnlBorda);
            this.Controls.Add(this.darkPanel1);
            this.Controls.Add(this.txtImg);
            this.Controls.Add(this.chkMSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbAcesso);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.picbox);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInformacaoDoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações Do Usuario";
            this.Load += new System.EventHandler(this.frmInformacaoDoUsuario_Load);
            this.darkPanel1.ResumeLayout(false);
            this.pnlBorda.ResumeLayout(false);
            this.pnlBorda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.CheckBox chkMSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbAcesso;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImg;
        private Metro.DarkPanel darkPanel1;
        public Metro.OrangeButton btnAlt;
        public Metro.RedButton btnCancel;
        public Metro.PurpleButton btnSalvar;
        private Metro.DarkPanel pnlBorda;
        private System.Windows.Forms.PictureBox pictureBoxTitulo;
        private System.Windows.Forms.Label lblMini;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.PictureBox picbox;
    }
}