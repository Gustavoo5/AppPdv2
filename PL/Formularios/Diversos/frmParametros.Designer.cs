namespace PL.Formularios.Diversos
{
    partial class frmParametros
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
            this.SelecionaOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pnlBorda = new Metro.DarkPanel();
            this.pictureBoxTitulo = new System.Windows.Forms.PictureBox();
            this.lblMini = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.darkPanel1 = new Metro.DarkPanel();
            this.btnAlt = new Metro.OrangeButton();
            this.btnCancel = new Metro.RedButton();
            this.btnSalvar = new Metro.PurpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNomeImagem = new System.Windows.Forms.TextBox();
            this.btnSeleciona = new System.Windows.Forms.Button();
            this.FotoPictureBox = new System.Windows.Forms.PictureBox();
            this.lblCont = new System.Windows.Forms.Label();
            this.lblDt = new System.Windows.Forms.Label();
            this.txtcont = new System.Windows.Forms.TextBox();
            this.dtvalidade = new System.Windows.Forms.MaskedTextBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtEmailE = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtInscE = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.lblInsc = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblENd = new System.Windows.Forms.Label();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblRazao = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.pnlBorda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).BeginInit();
            this.darkPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SelecionaOpenFileDialog
            // 
            this.SelecionaOpenFileDialog.FileName = "openFileDialog1";
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
            this.pnlBorda.Size = new System.Drawing.Size(415, 28);
            this.pnlBorda.TabIndex = 159;
            // 
            // pictureBoxTitulo
            // 
            this.pictureBoxTitulo.BackgroundImage = global::PL.Properties.Resources.Office;
            this.pictureBoxTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxTitulo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTitulo.Name = "pictureBoxTitulo";
            this.pictureBoxTitulo.Size = new System.Drawing.Size(27, 26);
            this.pictureBoxTitulo.TabIndex = 163;
            this.pictureBoxTitulo.TabStop = false;
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
            this.lblMini.Location = new System.Drawing.Point(362, 2);
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
            this.lblClose.Location = new System.Drawing.Point(387, 2);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(23, 23);
            this.lblClose.TabIndex = 161;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click_1);
            // 
            // darkPanel1
            // 
            this.darkPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.darkPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkPanel1.Controls.Add(this.btnAlt);
            this.darkPanel1.Controls.Add(this.btnCancel);
            this.darkPanel1.Controls.Add(this.btnSalvar);
            this.darkPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.darkPanel1.Location = new System.Drawing.Point(0, 634);
            this.darkPanel1.Name = "darkPanel1";
            this.darkPanel1.Size = new System.Drawing.Size(415, 78);
            this.darkPanel1.TabIndex = 160;
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtNomeImagem);
            this.panel1.Controls.Add(this.btnSeleciona);
            this.panel1.Controls.Add(this.FotoPictureBox);
            this.panel1.Controls.Add(this.lblCont);
            this.panel1.Controls.Add(this.lblDt);
            this.panel1.Controls.Add(this.txtcont);
            this.panel1.Controls.Add(this.dtvalidade);
            this.panel1.Controls.Add(this.txtTel);
            this.panel1.Controls.Add(this.lblTel);
            this.panel1.Controls.Add(this.txtEmailE);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtInscE);
            this.panel1.Controls.Add(this.txtCnpj);
            this.panel1.Controls.Add(this.lblInsc);
            this.panel1.Controls.Add(this.lblCnpj);
            this.panel1.Controls.Add(this.txtCep);
            this.panel1.Controls.Add(this.txtBairro);
            this.panel1.Controls.Add(this.txtEnd);
            this.panel1.Controls.Add(this.lblCep);
            this.panel1.Controls.Add(this.lblBairro);
            this.panel1.Controls.Add(this.lblENd);
            this.panel1.Controls.Add(this.txtRazao);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.lblRazao);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 606);
            this.panel1.TabIndex = 161;
            // 
            // txtNomeImagem
            // 
            this.txtNomeImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeImagem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeImagem.Location = new System.Drawing.Point(149, 140);
            this.txtNomeImagem.MaxLength = 255;
            this.txtNomeImagem.Name = "txtNomeImagem";
            this.txtNomeImagem.Size = new System.Drawing.Size(128, 23);
            this.txtNomeImagem.TabIndex = 183;
            this.txtNomeImagem.Visible = false;
            // 
            // btnSeleciona
            // 
            this.btnSeleciona.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSeleciona.Enabled = false;
            this.btnSeleciona.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnSeleciona.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeleciona.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.btnSeleciona.ForeColor = System.Drawing.Color.White;
            this.btnSeleciona.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSeleciona.Location = new System.Drawing.Point(283, 105);
            this.btnSeleciona.Name = "btnSeleciona";
            this.btnSeleciona.Size = new System.Drawing.Size(34, 29);
            this.btnSeleciona.TabIndex = 182;
            this.btnSeleciona.Text = "...";
            this.btnSeleciona.UseVisualStyleBackColor = false;
            this.btnSeleciona.Click += new System.EventHandler(this.btnSeleciona_Click);
            // 
            // FotoPictureBox
            // 
            this.FotoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FotoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FotoPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FotoPictureBox.Location = new System.Drawing.Point(148, 6);
            this.FotoPictureBox.Name = "FotoPictureBox";
            this.FotoPictureBox.Size = new System.Drawing.Size(128, 128);
            this.FotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoPictureBox.TabIndex = 181;
            this.FotoPictureBox.TabStop = false;
            // 
            // lblCont
            // 
            this.lblCont.AutoSize = true;
            this.lblCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCont.ForeColor = System.Drawing.Color.White;
            this.lblCont.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCont.Location = new System.Drawing.Point(216, 558);
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(68, 16);
            this.lblCont.TabIndex = 180;
            this.lblCont.Text = "Contador";
            // 
            // lblDt
            // 
            this.lblDt.AutoSize = true;
            this.lblDt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDt.ForeColor = System.Drawing.Color.White;
            this.lblDt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDt.Location = new System.Drawing.Point(128, 558);
            this.lblDt.Name = "lblDt";
            this.lblDt.Size = new System.Drawing.Size(85, 16);
            this.lblDt.TabIndex = 179;
            this.lblDt.Text = "Dt_Validade";
            // 
            // txtcont
            // 
            this.txtcont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcont.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcont.Enabled = false;
            this.txtcont.Location = new System.Drawing.Point(219, 577);
            this.txtcont.MaxLength = 20;
            this.txtcont.Name = "txtcont";
            this.txtcont.Size = new System.Drawing.Size(89, 23);
            this.txtcont.TabIndex = 178;
            // 
            // dtvalidade
            // 
            this.dtvalidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtvalidade.Enabled = false;
            this.dtvalidade.Location = new System.Drawing.Point(129, 577);
            this.dtvalidade.Mask = "00/00/0000";
            this.dtvalidade.Name = "dtvalidade";
            this.dtvalidade.Size = new System.Drawing.Size(84, 23);
            this.dtvalidade.TabIndex = 177;
            // 
            // txtTel
            // 
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTel.Enabled = false;
            this.txtTel.Location = new System.Drawing.Point(12, 577);
            this.txtTel.Mask = "(00)0000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(111, 23);
            this.txtTel.TabIndex = 176;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTel.ForeColor = System.Drawing.Color.White;
            this.lblTel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTel.Location = new System.Drawing.Point(9, 558);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(27, 16);
            this.lblTel.TabIndex = 175;
            this.lblTel.Text = "Tel";
            // 
            // txtEmailE
            // 
            this.txtEmailE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailE.Enabled = false;
            this.txtEmailE.Location = new System.Drawing.Point(12, 525);
            this.txtEmailE.MaxLength = 255;
            this.txtEmailE.Name = "txtEmailE";
            this.txtEmailE.Size = new System.Drawing.Size(338, 23);
            this.txtEmailE.TabIndex = 174;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEmail.Location = new System.Drawing.Point(9, 506);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(61, 16);
            this.lblEmail.TabIndex = 173;
            this.lblEmail.Text = "E-mail E";
            // 
            // txtInscE
            // 
            this.txtInscE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInscE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInscE.Enabled = false;
            this.txtInscE.Location = new System.Drawing.Point(12, 380);
            this.txtInscE.MaxLength = 20;
            this.txtInscE.Name = "txtInscE";
            this.txtInscE.Size = new System.Drawing.Size(330, 23);
            this.txtInscE.TabIndex = 172;
            // 
            // txtCnpj
            // 
            this.txtCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCnpj.Enabled = false;
            this.txtCnpj.Location = new System.Drawing.Point(12, 329);
            this.txtCnpj.Mask = "00,000,000/0000-00";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(193, 23);
            this.txtCnpj.TabIndex = 171;
            // 
            // lblInsc
            // 
            this.lblInsc.AutoSize = true;
            this.lblInsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInsc.ForeColor = System.Drawing.Color.White;
            this.lblInsc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblInsc.Location = new System.Drawing.Point(9, 361);
            this.lblInsc.Name = "lblInsc";
            this.lblInsc.Size = new System.Drawing.Size(59, 16);
            this.lblInsc.TabIndex = 170;
            this.lblInsc.Text = "Insc. E.";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCnpj.ForeColor = System.Drawing.Color.White;
            this.lblCnpj.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCnpj.Location = new System.Drawing.Point(9, 310);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(40, 16);
            this.lblCnpj.TabIndex = 169;
            this.lblCnpj.Text = "CNPJ";
            // 
            // txtCep
            // 
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCep.Enabled = false;
            this.txtCep.Location = new System.Drawing.Point(12, 278);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(87, 23);
            this.txtCep.TabIndex = 168;
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(12, 480);
            this.txtBairro.MaxLength = 30;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(176, 23);
            this.txtBairro.TabIndex = 167;
            // 
            // txtEnd
            // 
            this.txtEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEnd.Enabled = false;
            this.txtEnd.Location = new System.Drawing.Point(12, 431);
            this.txtEnd.MaxLength = 255;
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(338, 23);
            this.txtEnd.TabIndex = 166;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCep.ForeColor = System.Drawing.Color.White;
            this.lblCep.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCep.Location = new System.Drawing.Point(9, 259);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(33, 16);
            this.lblCep.TabIndex = 165;
            this.lblCep.Text = "CEP";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBairro.ForeColor = System.Drawing.Color.White;
            this.lblBairro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBairro.Location = new System.Drawing.Point(9, 461);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(45, 16);
            this.lblBairro.TabIndex = 164;
            this.lblBairro.Text = "Bairro";
            // 
            // lblENd
            // 
            this.lblENd.AutoSize = true;
            this.lblENd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblENd.ForeColor = System.Drawing.Color.White;
            this.lblENd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblENd.Location = new System.Drawing.Point(9, 412);
            this.lblENd.Name = "lblENd";
            this.lblENd.Size = new System.Drawing.Size(69, 16);
            this.lblENd.TabIndex = 163;
            this.lblENd.Text = "Endereço";
            // 
            // txtRazao
            // 
            this.txtRazao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazao.Enabled = false;
            this.txtRazao.Location = new System.Drawing.Point(12, 229);
            this.txtRazao.MaxLength = 255;
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(387, 23);
            this.txtRazao.TabIndex = 162;
            // 
            // txtid
            // 
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(12, 184);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(87, 23);
            this.txtid.TabIndex = 161;
            // 
            // lblRazao
            // 
            this.lblRazao.AutoSize = true;
            this.lblRazao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRazao.ForeColor = System.Drawing.Color.White;
            this.lblRazao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRazao.Location = new System.Drawing.Point(8, 210);
            this.lblRazao.Name = "lblRazao";
            this.lblRazao.Size = new System.Drawing.Size(47, 16);
            this.lblRazao.TabIndex = 160;
            this.lblRazao.Text = "Razão";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblID.Location = new System.Drawing.Point(9, 165);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(22, 16);
            this.lblID.TabIndex = 159;
            this.lblID.Text = "ID";
            // 
            // frmParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(415, 712);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.darkPanel1);
            this.Controls.Add(this.pnlBorda);
            this.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmParametros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametros de Empresa";
            this.Load += new System.EventHandler(this.frmParametros_Load);
            this.pnlBorda.ResumeLayout(false);
            this.pnlBorda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).EndInit();
            this.darkPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog SelecionaOpenFileDialog;
        private Metro.DarkPanel pnlBorda;
        private System.Windows.Forms.Label lblMini;
        private System.Windows.Forms.Label lblClose;
        private Metro.DarkPanel darkPanel1;
        public Metro.OrangeButton btnAlt;
        public Metro.RedButton btnCancel;
        public Metro.PurpleButton btnSalvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNomeImagem;
        private System.Windows.Forms.Button btnSeleciona;
        private System.Windows.Forms.Label lblCont;
        private System.Windows.Forms.Label lblDt;
        private System.Windows.Forms.TextBox txtcont;
        private System.Windows.Forms.MaskedTextBox dtvalidade;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtEmailE;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtInscE;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.Label lblInsc;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblENd;
        private System.Windows.Forms.TextBox txtRazao;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblRazao;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.PictureBox pictureBoxTitulo;
        private System.Windows.Forms.PictureBox FotoPictureBox;
    }
}