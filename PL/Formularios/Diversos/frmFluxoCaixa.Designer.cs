namespace PL.Formularios.Diversos
{
    partial class frmFluxoCaixa
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
            this.pnlBtn = new Metro.DarkPanel();
            this.btnCancel = new Metro.RedButton();
            this.btnAbrir = new Metro.GreenButton();
            this.pnlBarra = new Metro.DarkPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSaldoIni = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtSaldoIni = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.pnlBtn.SuspendLayout();
            this.pnlBarra.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtn
            // 
            this.pnlBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnlBtn.Controls.Add(this.btnCancel);
            this.pnlBtn.Controls.Add(this.btnAbrir);
            this.pnlBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBtn.Location = new System.Drawing.Point(0, 148);
            this.pnlBtn.Name = "pnlBtn";
            this.pnlBtn.Size = new System.Drawing.Size(334, 68);
            this.pnlBtn.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancel.Location = new System.Drawing.Point(12, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 45);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(14)))));
            this.btnAbrir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAbrir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(14)))));
            this.btnAbrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(14)))));
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAbrir.Location = new System.Drawing.Point(222, 11);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(100, 45);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnlBarra.Controls.Add(this.lblTitulo);
            this.pnlBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarra.Location = new System.Drawing.Point(0, 0);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(334, 26);
            this.pnlBarra.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(3, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(126, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Abertura de Caixa";
            // 
            // lblSaldoIni
            // 
            this.lblSaldoIni.AutoSize = true;
            this.lblSaldoIni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSaldoIni.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoIni.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSaldoIni.Location = new System.Drawing.Point(3, 62);
            this.lblSaldoIni.Name = "lblSaldoIni";
            this.lblSaldoIni.Size = new System.Drawing.Size(87, 16);
            this.lblSaldoIni.TabIndex = 2;
            this.lblSaldoIni.Text = "Saldo Inicial";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblData.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.Control;
            this.lblData.Location = new System.Drawing.Point(51, 99);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(39, 16);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data";
            // 
            // txtSaldoIni
            // 
            this.txtSaldoIni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaldoIni.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoIni.Location = new System.Drawing.Point(96, 54);
            this.txtSaldoIni.Name = "txtSaldoIni";
            this.txtSaldoIni.Size = new System.Drawing.Size(135, 31);
            this.txtSaldoIni.TabIndex = 4;
            this.txtSaldoIni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtData
            // 
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtData.Enabled = false;
            this.txtData.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(96, 91);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(135, 31);
            this.txtData.TabIndex = 5;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // frmFluxoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(334, 216);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtSaldoIni);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblSaldoIni);
            this.Controls.Add(this.pnlBarra);
            this.Controls.Add(this.pnlBtn);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFluxoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fluxo Caixa";
            this.Load += new System.EventHandler(this.frmFluxoCaixa_Load);
            this.pnlBtn.ResumeLayout(false);
            this.pnlBarra.ResumeLayout(false);
            this.pnlBarra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Metro.DarkPanel pnlBtn;
        private Metro.RedButton btnCancel;
        private Metro.GreenButton btnAbrir;
        private Metro.DarkPanel pnlBarra;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSaldoIni;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.MaskedTextBox txtData;
        public System.Windows.Forms.TextBox txtSaldoIni;
    }
}