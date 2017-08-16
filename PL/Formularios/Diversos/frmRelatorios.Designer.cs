namespace PL.Formularios.Diversos
{
    partial class frmRelatorios
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
            this.btnVendasPorData = new Metro.OrangeButton();
            this.btnFluxo = new Metro.OrangeButton();
            this.SuspendLayout();
            // 
            // btnVendasPorData
            // 
            this.btnVendasPorData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.btnVendasPorData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVendasPorData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.btnVendasPorData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(25)))));
            this.btnVendasPorData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendasPorData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendasPorData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnVendasPorData.Location = new System.Drawing.Point(12, 12);
            this.btnVendasPorData.Name = "btnVendasPorData";
            this.btnVendasPorData.Size = new System.Drawing.Size(160, 65);
            this.btnVendasPorData.TabIndex = 0;
            this.btnVendasPorData.Text = "Vendas Data1-Data2";
            this.btnVendasPorData.UseVisualStyleBackColor = false;
            this.btnVendasPorData.Click += new System.EventHandler(this.btnVendasPorData_Click);
            // 
            // btnFluxo
            // 
            this.btnFluxo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.btnFluxo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFluxo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.btnFluxo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(25)))));
            this.btnFluxo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFluxo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFluxo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFluxo.Location = new System.Drawing.Point(178, 13);
            this.btnFluxo.Name = "btnFluxo";
            this.btnFluxo.Size = new System.Drawing.Size(160, 65);
            this.btnFluxo.TabIndex = 1;
            this.btnFluxo.Text = "Fluxo Caixa Data1-Data2";
            this.btnFluxo.UseVisualStyleBackColor = false;
            this.btnFluxo.Click += new System.EventHandler(this.btnFluxo_Click);
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(805, 90);
            this.Controls.Add(this.btnFluxo);
            this.Controls.Add(this.btnVendasPorData);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRelatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelatorios";
            this.ResumeLayout(false);

        }

        #endregion

        private Metro.OrangeButton btnVendasPorData;
        private Metro.OrangeButton btnFluxo;
    }
}