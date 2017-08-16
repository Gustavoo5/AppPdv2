namespace PL
{
    partial class FrmUsuario
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
            this.idUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acessoUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.txtNomeDaUrl = new System.Windows.Forms.TextBox();
            this.btnSeleciona = new System.Windows.Forms.Button();
            this.SelecionaOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.darkPanel1.SuspendLayout();
            this.groupControle.SuspendLayout();
            this.groupPesq.SuspendLayout();
            this.groupDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
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
            this.darkPanel1.Size = new System.Drawing.Size(1101, 648);
            // 
            // groupControle
            // 
            this.groupControle.Location = new System.Drawing.Point(0, 579);
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
            this.groupDados.Controls.Add(this.btnSeleciona);
            this.groupDados.Controls.Add(this.txtNomeDaUrl);
            this.groupDados.Controls.Add(this.pbFoto);
            this.groupDados.Controls.Add(this.chkMSenha);
            this.groupDados.Controls.Add(this.txtSenha);
            this.groupDados.Controls.Add(this.label6);
            this.groupDados.Controls.Add(this.cmbAcesso);
            this.groupDados.Controls.Add(this.txtLogin);
            this.groupDados.Controls.Add(this.txtNome);
            this.groupDados.Controls.Add(this.txtId);
            this.groupDados.Controls.Add(this.label5);
            this.groupDados.Controls.Add(this.label4);
            this.groupDados.Controls.Add(this.label3);
            this.groupDados.Controls.Add(this.label2);
            this.groupDados.Size = new System.Drawing.Size(1101, 344);
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
            this.idUser,
            this.img,
            this.senha,
            this.nomeUser,
            this.loginUser,
            this.acessoUser});
            this.gridPesq.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPesq.Location = new System.Drawing.Point(0, 44);
            this.gridPesq.MultiSelect = false;
            this.gridPesq.Name = "gridPesq";
            this.gridPesq.ReadOnly = true;
            this.gridPesq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPesq.Size = new System.Drawing.Size(1099, 189);
            this.gridPesq.TabIndex = 4;
            this.gridPesq.SelectionChanged += new System.EventHandler(this.gridPesq_SelectionChanged);
            this.gridPesq.Click += new System.EventHandler(this.GridPesq_Click);
            // 
            // idUser
            // 
            this.idUser.DataPropertyName = "idUser";
            this.idUser.HeaderText = "ID";
            this.idUser.Name = "idUser";
            this.idUser.ReadOnly = true;
            this.idUser.Width = 75;
            // 
            // img
            // 
            this.img.DataPropertyName = "img";
            this.img.HeaderText = "Img";
            this.img.Name = "img";
            this.img.ReadOnly = true;
            this.img.Visible = false;
            // 
            // senha
            // 
            this.senha.DataPropertyName = "senha";
            this.senha.HeaderText = "Senha";
            this.senha.Name = "senha";
            this.senha.ReadOnly = true;
            this.senha.Visible = false;
            // 
            // nomeUser
            // 
            this.nomeUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeUser.DataPropertyName = "nomeUser";
            this.nomeUser.HeaderText = "Nome do Usuário";
            this.nomeUser.Name = "nomeUser";
            this.nomeUser.ReadOnly = true;
            // 
            // loginUser
            // 
            this.loginUser.DataPropertyName = "loginUser";
            this.loginUser.HeaderText = "Login";
            this.loginUser.Name = "loginUser";
            this.loginUser.ReadOnly = true;
            this.loginUser.Width = 200;
            // 
            // acessoUser
            // 
            this.acessoUser.DataPropertyName = "acessoUser";
            this.acessoUser.HeaderText = "Codigo de Acesso";
            this.acessoUser.Name = "acessoUser";
            this.acessoUser.ReadOnly = true;
            // 
            // chkMSenha
            // 
            this.chkMSenha.AutoSize = true;
            this.chkMSenha.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkMSenha.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.chkMSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.chkMSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMSenha.ForeColor = System.Drawing.Color.White;
            this.chkMSenha.Location = new System.Drawing.Point(506, 35);
            this.chkMSenha.Name = "chkMSenha";
            this.chkMSenha.Size = new System.Drawing.Size(120, 20);
            this.chkMSenha.TabIndex = 21;
            this.chkMSenha.Text = "Mostrar Senha";
            this.chkMSenha.UseVisualStyleBackColor = true;
            this.chkMSenha.CheckedChanged += new System.EventHandler(this.ChkMSenha_CheckedChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Location = new System.Drawing.Point(381, 32);
            this.txtSenha.MaxLength = 30;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(119, 23);
            this.txtSenha.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(326, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Senha";
            // 
            // cmbAcesso
            // 
            this.cmbAcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAcesso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbAcesso.FormattingEnabled = true;
            this.cmbAcesso.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "USUARIO COMUM"});
            this.cmbAcesso.Location = new System.Drawing.Point(201, 59);
            this.cmbAcesso.Name = "cmbAcesso";
            this.cmbAcesso.Size = new System.Drawing.Size(299, 24);
            this.cmbAcesso.TabIndex = 18;
            // 
            // txtLogin
            // 
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogin.Location = new System.Drawing.Point(201, 32);
            this.txtLogin.MaxLength = 30;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(119, 23);
            this.txtLogin.TabIndex = 17;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(381, 5);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(353, 23);
            this.txtNome.TabIndex = 16;
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(201, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(119, 23);
            this.txtId.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(145, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Acesso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(155, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(331, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(173, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNomeDaUrl
            // 
            this.txtNomeDaUrl.Location = new System.Drawing.Point(6, 174);
            this.txtNomeDaUrl.Name = "txtNomeDaUrl";
            this.txtNomeDaUrl.Size = new System.Drawing.Size(133, 23);
            this.txtNomeDaUrl.TabIndex = 23;
            this.txtNomeDaUrl.Visible = false;
            this.txtNomeDaUrl.TextChanged += new System.EventHandler(this.txtNomeDaUrl_TextChanged);
            // 
            // btnSeleciona
            // 
            this.btnSeleciona.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSeleciona.Enabled = false;
            this.btnSeleciona.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnSeleciona.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeleciona.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleciona.ForeColor = System.Drawing.Color.White;
            this.btnSeleciona.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSeleciona.Location = new System.Drawing.Point(6, 139);
            this.btnSeleciona.Name = "btnSeleciona";
            this.btnSeleciona.Size = new System.Drawing.Size(133, 29);
            this.btnSeleciona.TabIndex = 183;
            this.btnSeleciona.Text = "Add Foto";
            this.btnSeleciona.UseVisualStyleBackColor = false;
            this.btnSeleciona.Click += new System.EventHandler(this.btnSeleciona_Click);
            // 
            // SelecionaOpenFileDialog
            // 
            this.SelecionaOpenFileDialog.FileName = "openFileDialog1";
            // 
            // pbFoto
            // 
            this.pbFoto.BackgroundImage = global::PL.Properties.Resources.User_Login;
            this.pbFoto.Location = new System.Drawing.Point(11, 5);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(128, 128);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 22;
            this.pbFoto.TabStop = false;
            this.pbFoto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 648);
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsuario";
            this.darkPanel1.ResumeLayout(false);
            this.groupControle.ResumeLayout(false);
            this.groupPesq.ResumeLayout(false);
            this.groupPesq.PerformLayout();
            this.groupDados.ResumeLayout(false);
            this.groupDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPesq;
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
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TextBox txtNomeDaUrl;
        private System.Windows.Forms.Button btnSeleciona;
        private System.Windows.Forms.OpenFileDialog SelecionaOpenFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn img;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn acessoUser;
    }
}