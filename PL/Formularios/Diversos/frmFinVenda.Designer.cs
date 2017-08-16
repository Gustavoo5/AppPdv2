namespace PL.Formularios.Diversos
{
    partial class frmFinVenda
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
            this.pnlGeral = new Metro.DarkPanel();
            this.btnCancel = new Metro.RedButton();
            this.btnFin = new Metro.GreenButton();
            this.cmbFormPagt = new System.Windows.Forms.ComboBox();
            this.lblFormPagt = new System.Windows.Forms.Label();
            this.pnlGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGeral
            // 
            this.pnlGeral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlGeral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGeral.Controls.Add(this.btnCancel);
            this.pnlGeral.Controls.Add(this.btnFin);
            this.pnlGeral.Controls.Add(this.cmbFormPagt);
            this.pnlGeral.Controls.Add(this.lblFormPagt);
            this.pnlGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeral.Location = new System.Drawing.Point(0, 0);
            this.pnlGeral.Name = "pnlGeral";
            this.pnlGeral.Size = new System.Drawing.Size(478, 121);
            this.pnlGeral.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancel.Location = new System.Drawing.Point(296, 79);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(170, 30);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFin
            // 
            this.btnFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(14)))));
            this.btnFin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(14)))));
            this.btnFin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(14)))));
            this.btnFin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFin.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFin.Location = new System.Drawing.Point(6, 79);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(170, 30);
            this.btnFin.TabIndex = 2;
            this.btnFin.Text = "Finalizar Venda";
            this.btnFin.UseVisualStyleBackColor = false;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // cmbFormPagt
            // 
            this.cmbFormPagt.BackColor = System.Drawing.SystemColors.Control;
            this.cmbFormPagt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormPagt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFormPagt.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormPagt.ForeColor = System.Drawing.Color.Black;
            this.cmbFormPagt.FormattingEnabled = true;
            this.cmbFormPagt.Location = new System.Drawing.Point(179, 8);
            this.cmbFormPagt.Name = "cmbFormPagt";
            this.cmbFormPagt.Size = new System.Drawing.Size(287, 31);
            this.cmbFormPagt.TabIndex = 1;
            // 
            // lblFormPagt
            // 
            this.lblFormPagt.AutoSize = true;
            this.lblFormPagt.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormPagt.ForeColor = System.Drawing.Color.White;
            this.lblFormPagt.Location = new System.Drawing.Point(3, 15);
            this.lblFormPagt.Name = "lblFormPagt";
            this.lblFormPagt.Size = new System.Drawing.Size(170, 18);
            this.lblFormPagt.TabIndex = 0;
            this.lblFormPagt.Text = "Forma de pagamento";
            // 
            // frmFinVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 121);
            this.Controls.Add(this.pnlGeral);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFinVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFinVenda";
            this.Load += new System.EventHandler(this.frmFinVenda_Load);
            this.pnlGeral.ResumeLayout(false);
            this.pnlGeral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Metro.DarkPanel pnlGeral;
        private Metro.RedButton btnCancel;
        private Metro.GreenButton btnFin;
        private System.Windows.Forms.ComboBox cmbFormPagt;
        private System.Windows.Forms.Label lblFormPagt;
    }
}