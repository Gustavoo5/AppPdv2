namespace PL.Formularios.Diversos
{
    partial class frmContato
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
            this.pbIco = new System.Windows.Forms.PictureBox();
            this.lblMini = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.txtEmailE = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.lblRazao = new System.Windows.Forms.Label();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.lblConteudo = new System.Windows.Forms.Label();
            this.btnEnviar = new Metro.GreenButton();
            this.pnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIco)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnlBarra.Controls.Add(this.lblTitulo);
            this.pnlBarra.Controls.Add(this.pbIco);
            this.pnlBarra.Controls.Add(this.lblMini);
            this.pnlBarra.Controls.Add(this.lblClose);
            this.pnlBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarra.Location = new System.Drawing.Point(0, 0);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(577, 30);
            this.pnlBarra.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblTitulo.Location = new System.Drawing.Point(38, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(150, 18);
            this.lblTitulo.TabIndex = 166;
            this.lblTitulo.Text = "Entre em contato";
            // 
            // pbIco
            // 
            this.pbIco.BackgroundImage = global::PL.Properties.Resources.Mail_Help;
            this.pbIco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbIco.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbIco.Location = new System.Drawing.Point(0, 0);
            this.pbIco.Name = "pbIco";
            this.pbIco.Size = new System.Drawing.Size(32, 30);
            this.pbIco.TabIndex = 165;
            this.pbIco.TabStop = false;
            // 
            // lblMini
            // 
            this.lblMini.AutoSize = true;
            this.lblMini.BackColor = System.Drawing.Color.Transparent;
            this.lblMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMini.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMini.ForeColor = System.Drawing.Color.White;
            this.lblMini.Location = new System.Drawing.Point(525, 3);
            this.lblMini.Name = "lblMini";
            this.lblMini.Size = new System.Drawing.Size(19, 23);
            this.lblMini.TabIndex = 164;
            this.lblMini.Text = "-";
            this.lblMini.Click += new System.EventHandler(this.lblMini_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClose.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(550, 3);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(23, 23);
            this.lblClose.TabIndex = 163;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // txtEmailE
            // 
            this.txtEmailE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailE.Enabled = false;
            this.txtEmailE.Location = new System.Drawing.Point(12, 92);
            this.txtEmailE.MaxLength = 255;
            this.txtEmailE.Name = "txtEmailE";
            this.txtEmailE.Size = new System.Drawing.Size(553, 21);
            this.txtEmailE.TabIndex = 178;
            this.txtEmailE.TextChanged += new System.EventHandler(this.txtEmailE_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEmail.Location = new System.Drawing.Point(9, 76);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 13);
            this.lblEmail.TabIndex = 177;
            this.lblEmail.Text = "E-mail E";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // txtRazao
            // 
            this.txtRazao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazao.Enabled = false;
            this.txtRazao.Location = new System.Drawing.Point(12, 52);
            this.txtRazao.MaxLength = 255;
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(553, 21);
            this.txtRazao.TabIndex = 176;
            // 
            // lblRazao
            // 
            this.lblRazao.AutoSize = true;
            this.lblRazao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRazao.ForeColor = System.Drawing.Color.White;
            this.lblRazao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRazao.Location = new System.Drawing.Point(9, 36);
            this.lblRazao.Name = "lblRazao";
            this.lblRazao.Size = new System.Drawing.Size(42, 13);
            this.lblRazao.TabIndex = 175;
            this.lblRazao.Text = "Razão";
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAssunto.ForeColor = System.Drawing.Color.White;
            this.lblAssunto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAssunto.Location = new System.Drawing.Point(12, 116);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(52, 13);
            this.lblAssunto.TabIndex = 179;
            this.lblAssunto.Text = "Assunto";
            // 
            // txtAssunto
            // 
            this.txtAssunto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAssunto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAssunto.Location = new System.Drawing.Point(12, 132);
            this.txtAssunto.MaxLength = 255;
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(553, 21);
            this.txtAssunto.TabIndex = 180;
            // 
            // txtConteudo
            // 
            this.txtConteudo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConteudo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConteudo.Location = new System.Drawing.Point(12, 172);
            this.txtConteudo.MaxLength = 255;
            this.txtConteudo.Multiline = true;
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(553, 110);
            this.txtConteudo.TabIndex = 182;
            // 
            // lblConteudo
            // 
            this.lblConteudo.AutoSize = true;
            this.lblConteudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblConteudo.ForeColor = System.Drawing.Color.White;
            this.lblConteudo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblConteudo.Location = new System.Drawing.Point(9, 156);
            this.lblConteudo.Name = "lblConteudo";
            this.lblConteudo.Size = new System.Drawing.Size(62, 13);
            this.lblConteudo.TabIndex = 181;
            this.lblConteudo.Text = "Conteudo";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(14)))));
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(14)))));
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(14)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEnviar.Location = new System.Drawing.Point(465, 288);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(100, 30);
            this.btnEnviar.TabIndex = 183;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // frmContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(577, 328);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.lblConteudo);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.lblAssunto);
            this.Controls.Add(this.txtEmailE);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtRazao);
            this.Controls.Add(this.lblRazao);
            this.Controls.Add(this.pnlBarra);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmContato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmContato";
            this.Load += new System.EventHandler(this.frmContato_Load);
            this.pnlBarra.ResumeLayout(false);
            this.pnlBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Metro.DarkPanel pnlBarra;
        private System.Windows.Forms.Label lblMini;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.TextBox txtEmailE;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtRazao;
        private System.Windows.Forms.Label lblRazao;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.PictureBox pbIco;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.Label lblConteudo;
        private Metro.GreenButton btnEnviar;
        private System.Windows.Forms.Label lblTitulo;
    }
}