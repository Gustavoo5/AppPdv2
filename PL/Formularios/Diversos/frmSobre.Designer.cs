namespace PL.Formularios.Diversos
{
    partial class frmSobre
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlBorda = new Metro.DarkPanel();
            this.lblMini = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContato = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBorda.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(401, 292);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema desenvolvido por Paulo Bressan \r\ncom auxilio de Gustavo Gonçalves.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(404, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "BG Sistemas agradece pela preferência!";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PL.Properties.Resources.Imagens_em_png_queroimagem_com__179_;
            this.pictureBox2.Location = new System.Drawing.Point(401, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(298, 240);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PL.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 353);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlBorda
            // 
            this.pnlBorda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnlBorda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBorda.Controls.Add(this.lblMini);
            this.pnlBorda.Controls.Add(this.lblClose);
            this.pnlBorda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBorda.Location = new System.Drawing.Point(0, 0);
            this.pnlBorda.Name = "pnlBorda";
            this.pnlBorda.Size = new System.Drawing.Size(700, 28);
            this.pnlBorda.TabIndex = 160;
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
            this.lblMini.Location = new System.Drawing.Point(644, 1);
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
            this.lblClose.Location = new System.Drawing.Point(669, 2);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(23, 23);
            this.lblClose.TabIndex = 161;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(401, 329);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 161;
            this.label3.Text = "Entre em contato :";
            // 
            // txtContato
            // 
            this.txtContato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContato.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContato.ForeColor = System.Drawing.Color.White;
            this.txtContato.Location = new System.Drawing.Point(404, 346);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(291, 17);
            this.txtContato.TabIndex = 162;
            this.txtContato.Text = "bgsoftware.bts@gmail.com";
            // 
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(700, 375);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlBorda);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBorda.ResumeLayout(false);
            this.pnlBorda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Metro.DarkPanel pnlBorda;
        private System.Windows.Forms.Label lblMini;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContato;
    }
}