namespace PL.Formularios.Pesquisa.Base
{
    partial class frmBasePesq
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
            this.pnlGeral = new System.Windows.Forms.Panel();
            this.pnlBarra = new Metro.DarkPanel();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.cmbPesq = new System.Windows.Forms.ComboBox();
            this.txtPesq = new System.Windows.Forms.TextBox();
            this.lblMini = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.btnPesq = new Metro.PurpleButton();
            this.pnlGeral.SuspendLayout();
            this.pnlBarra.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGeral
            // 
            this.pnlGeral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGeral.Controls.Add(this.pnlGrid);
            this.pnlGeral.Controls.Add(this.pnlFiltro);
            this.pnlGeral.Controls.Add(this.pnlBarra);
            this.pnlGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeral.Location = new System.Drawing.Point(0, 0);
            this.pnlGeral.Name = "pnlGeral";
            this.pnlGeral.Size = new System.Drawing.Size(891, 545);
            this.pnlGeral.TabIndex = 0;
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnlBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBarra.Controls.Add(this.lblMini);
            this.pnlBarra.Controls.Add(this.lblClose);
            this.pnlBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarra.Location = new System.Drawing.Point(0, 0);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(889, 28);
            this.pnlBarra.TabIndex = 0;
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFiltro.Controls.Add(this.btnPesq);
            this.pnlFiltro.Controls.Add(this.cmbPesq);
            this.pnlFiltro.Controls.Add(this.txtPesq);
            this.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltro.Location = new System.Drawing.Point(0, 28);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(889, 46);
            this.pnlFiltro.TabIndex = 7;
            // 
            // cmbPesq
            // 
            this.cmbPesq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPesq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPesq.FormattingEnabled = true;
            this.cmbPesq.Location = new System.Drawing.Point(12, 12);
            this.cmbPesq.Name = "cmbPesq";
            this.cmbPesq.Size = new System.Drawing.Size(192, 21);
            this.cmbPesq.TabIndex = 3;
            // 
            // txtPesq
            // 
            this.txtPesq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesq.Location = new System.Drawing.Point(211, 12);
            this.txtPesq.Name = "txtPesq";
            this.txtPesq.Size = new System.Drawing.Size(562, 21);
            this.txtPesq.TabIndex = 4;
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
            this.lblMini.Location = new System.Drawing.Point(836, 3);
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
            this.lblClose.Location = new System.Drawing.Point(861, 3);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(23, 23);
            this.lblClose.TabIndex = 163;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // pnlGrid
            // 
            this.pnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 74);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(889, 469);
            this.pnlGrid.TabIndex = 8;
            // 
            // btnPesq
            // 
            this.btnPesq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.btnPesq.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPesq.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.btnPesq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.btnPesq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesq.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPesq.Location = new System.Drawing.Point(779, 8);
            this.btnPesq.Name = "btnPesq";
            this.btnPesq.Size = new System.Drawing.Size(100, 30);
            this.btnPesq.TabIndex = 5;
            this.btnPesq.Text = "Pesquisar";
            this.btnPesq.UseVisualStyleBackColor = false;
            this.btnPesq.Click += new System.EventHandler(this.btnPesq_Click);
            // 
            // frmBasePesq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(891, 545);
            this.Controls.Add(this.pnlGeral);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBasePesq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBasePesq";
            this.Load += new System.EventHandler(this.frmBasePesq_Load);
            this.pnlGeral.ResumeLayout(false);
            this.pnlBarra.ResumeLayout(false);
            this.pnlBarra.PerformLayout();
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox cmbPesq;
        public System.Windows.Forms.TextBox txtPesq;
        public System.Windows.Forms.Panel pnlGeral;
        public System.Windows.Forms.Panel pnlFiltro;
        public Metro.DarkPanel pnlBarra;
        public System.Windows.Forms.Panel pnlGrid;
        public Metro.PurpleButton btnPesq;
        public System.Windows.Forms.Label lblMini;
        public System.Windows.Forms.Label lblClose;

    }
}