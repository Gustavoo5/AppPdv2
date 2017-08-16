namespace PL.Formularios.Diversos
{
    partial class frmDashboardUserComum
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.pnlGrafico = new System.Windows.Forms.Panel();
            this.chtGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlVendas = new System.Windows.Forms.Panel();
            this.txtTotalVendasDia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalVendas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlM7 = new System.Windows.Forms.Panel();
            this.pnlM6 = new System.Windows.Forms.Panel();
            this.pnlm5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtProdVendidos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProdTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pbProds = new System.Windows.Forms.PictureBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.pnlMagins = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlM1 = new System.Windows.Forms.Panel();
            this.pnlM2 = new System.Windows.Forms.Panel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.txtAcesso = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtNomeUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlGrafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtGrafico)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProds)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGrafico
            // 
            this.pnlGrafico.Controls.Add(this.chtGrafico);
            this.pnlGrafico.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlGrafico.Location = new System.Drawing.Point(0, 266);
            this.pnlGrafico.Name = "pnlGrafico";
            this.pnlGrafico.Size = new System.Drawing.Size(1072, 361);
            this.pnlGrafico.TabIndex = 0;
            // 
            // chtGrafico
            // 
            chartArea5.Name = "ChartArea1";
            this.chtGrafico.ChartAreas.Add(chartArea5);
            this.chtGrafico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chtGrafico.Location = new System.Drawing.Point(0, 0);
            this.chtGrafico.Name = "chtGrafico";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series5.Name = "Series1";
            series5.YValuesPerPoint = 2;
            this.chtGrafico.Series.Add(series5);
            this.chtGrafico.Size = new System.Drawing.Size(1072, 361);
            this.chtGrafico.TabIndex = 0;
            this.chtGrafico.Text = "chart1";
            title5.Name = "Vendas do dia";
            this.chtGrafico.Titles.Add(title5);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlVendas);
            this.panel1.Controls.Add(this.pnlM7);
            this.panel1.Controls.Add(this.pnlM6);
            this.panel1.Controls.Add(this.pnlm5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(423, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 266);
            this.panel1.TabIndex = 2;
            // 
            // pnlVendas
            // 
            this.pnlVendas.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.pnlVendas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVendas.Controls.Add(this.txtTotalVendasDia);
            this.pnlVendas.Controls.Add(this.label5);
            this.pnlVendas.Controls.Add(this.txtTotalVendas);
            this.pnlVendas.Controls.Add(this.label4);
            this.pnlVendas.Controls.Add(this.pictureBox1);
            this.pnlVendas.Location = new System.Drawing.Point(22, 72);
            this.pnlVendas.Name = "pnlVendas";
            this.pnlVendas.Size = new System.Drawing.Size(296, 127);
            this.pnlVendas.TabIndex = 8;
            // 
            // txtTotalVendasDia
            // 
            this.txtTotalVendasDia.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.txtTotalVendasDia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalVendasDia.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVendasDia.Location = new System.Drawing.Point(6, 68);
            this.txtTotalVendasDia.Name = "txtTotalVendasDia";
            this.txtTotalVendasDia.ReadOnly = true;
            this.txtTotalVendasDia.Size = new System.Drawing.Size(148, 16);
            this.txtTotalVendasDia.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total de Vendas do dia";
            // 
            // txtTotalVendas
            // 
            this.txtTotalVendas.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.txtTotalVendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalVendas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVendas.Location = new System.Drawing.Point(6, 30);
            this.txtTotalVendas.Name = "txtTotalVendas";
            this.txtTotalVendas.ReadOnly = true;
            this.txtTotalVendas.Size = new System.Drawing.Size(148, 16);
            this.txtTotalVendas.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total de Vendas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PL.Properties.Resources.Shopping_Ok;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(167, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 125);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnlM7
            // 
            this.pnlM7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlM7.Location = new System.Drawing.Point(22, 244);
            this.pnlM7.Name = "pnlM7";
            this.pnlM7.Size = new System.Drawing.Size(296, 22);
            this.pnlM7.TabIndex = 7;
            // 
            // pnlM6
            // 
            this.pnlM6.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlM6.Location = new System.Drawing.Point(0, 25);
            this.pnlM6.Name = "pnlM6";
            this.pnlM6.Size = new System.Drawing.Size(22, 241);
            this.pnlM6.TabIndex = 5;
            // 
            // pnlm5
            // 
            this.pnlm5.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlm5.Location = new System.Drawing.Point(0, 0);
            this.pnlm5.Name = "pnlm5";
            this.pnlm5.Size = new System.Drawing.Size(318, 25);
            this.pnlm5.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Controls.Add(this.panel14);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(741, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 266);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtProdVendidos);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtProdTotal);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.pbProds);
            this.panel4.Location = new System.Drawing.Point(22, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 126);
            this.panel4.TabIndex = 9;
            // 
            // txtProdVendidos
            // 
            this.txtProdVendidos.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.txtProdVendidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdVendidos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdVendidos.Location = new System.Drawing.Point(9, 68);
            this.txtProdVendidos.Name = "txtProdVendidos";
            this.txtProdVendidos.ReadOnly = true;
            this.txtProdVendidos.Size = new System.Drawing.Size(148, 16);
            this.txtProdVendidos.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Produtos mais vendidos";
            // 
            // txtProdTotal
            // 
            this.txtProdTotal.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.txtProdTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdTotal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdTotal.Location = new System.Drawing.Point(9, 30);
            this.txtProdTotal.Name = "txtProdTotal";
            this.txtProdTotal.ReadOnly = true;
            this.txtProdTotal.Size = new System.Drawing.Size(148, 16);
            this.txtProdTotal.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total de prod. vendido";
            // 
            // pbProds
            // 
            this.pbProds.BackgroundImage = global::PL.Properties.Resources.Shopping_Add127;
            this.pbProds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbProds.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbProds.Location = new System.Drawing.Point(171, 0);
            this.pbProds.Name = "pbProds";
            this.pbProds.Size = new System.Drawing.Size(127, 124);
            this.pbProds.TabIndex = 2;
            this.pbProds.TabStop = false;
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(22, 244);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(309, 22);
            this.panel11.TabIndex = 7;
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 25);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(22, 241);
            this.panel12.TabIndex = 5;
            // 
            // panel14
            // 
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(331, 25);
            this.panel14.TabIndex = 4;
            // 
            // pnlMagins
            // 
            this.pnlMagins.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMagins.Location = new System.Drawing.Point(0, 0);
            this.pnlMagins.Name = "pnlMagins";
            this.pnlMagins.Size = new System.Drawing.Size(423, 25);
            this.pnlMagins.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlM1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(22, 241);
            this.panel3.TabIndex = 1;
            // 
            // pnlM1
            // 
            this.pnlM1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlM1.Location = new System.Drawing.Point(0, 0);
            this.pnlM1.Name = "pnlM1";
            this.pnlM1.Size = new System.Drawing.Size(22, 241);
            this.pnlM1.TabIndex = 2;
            // 
            // pnlM2
            // 
            this.pnlM2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlM2.Location = new System.Drawing.Point(22, 244);
            this.pnlM2.Name = "pnlM2";
            this.pnlM2.Size = new System.Drawing.Size(401, 22);
            this.pnlM2.TabIndex = 3;
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.pnlUser);
            this.pnlInfo.Controls.Add(this.pnlM2);
            this.pnlInfo.Controls.Add(this.panel3);
            this.pnlInfo.Controls.Add(this.pnlMagins);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(423, 266);
            this.pnlInfo.TabIndex = 1;
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.pnlUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUser.Controls.Add(this.txtAcesso);
            this.pnlUser.Controls.Add(this.txtLogin);
            this.pnlUser.Controls.Add(this.txtNomeUser);
            this.pnlUser.Controls.Add(this.label3);
            this.pnlUser.Controls.Add(this.label2);
            this.pnlUser.Controls.Add(this.label1);
            this.pnlUser.Controls.Add(this.pbUser);
            this.pnlUser.Location = new System.Drawing.Point(92, 72);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(330, 127);
            this.pnlUser.TabIndex = 5;
            // 
            // txtAcesso
            // 
            this.txtAcesso.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.txtAcesso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAcesso.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcesso.Location = new System.Drawing.Point(6, 107);
            this.txtAcesso.Name = "txtAcesso";
            this.txtAcesso.ReadOnly = true;
            this.txtAcesso.Size = new System.Drawing.Size(148, 16);
            this.txtAcesso.TabIndex = 7;
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(6, 68);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.ReadOnly = true;
            this.txtLogin.Size = new System.Drawing.Size(148, 16);
            this.txtLogin.TabIndex = 6;
            // 
            // txtNomeUser
            // 
            this.txtNomeUser.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.txtNomeUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeUser.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUser.Location = new System.Drawing.Point(6, 30);
            this.txtNomeUser.Name = "txtNomeUser";
            this.txtNomeUser.ReadOnly = true;
            this.txtNomeUser.Size = new System.Drawing.Size(148, 16);
            this.txtNomeUser.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Acesso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário";
            // 
            // pbUser
            // 
            this.pbUser.BackgroundImage = global::PL.Properties.Resources.User_Login;
            this.pbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbUser.Location = new System.Drawing.Point(201, 0);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(127, 125);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 0;
            this.pbUser.TabStop = false;
            this.pbUser.Click += new System.EventHandler(this.pbUser_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 300;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmDashboardUserComum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 627);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlGrafico);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboardUserComum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboardUserComum";
            this.Load += new System.EventHandler(this.frmDashboardUserComum_Load);
            this.pnlGrafico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtGrafico)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlVendas.ResumeLayout(false);
            this.pnlVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProds)).EndInit();
            this.panel3.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrafico;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlM7;
        private System.Windows.Forms.Panel pnlM6;
        private System.Windows.Forms.Panel pnlm5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel pnlMagins;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlM1;
        private System.Windows.Forms.Panel pnlM2;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.TextBox txtAcesso;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtNomeUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Panel pnlVendas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTotalVendas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalVendasDia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pbProds;
        private System.Windows.Forms.TextBox txtProdVendidos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProdTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGrafico;
        private System.Windows.Forms.Timer timer;
    }
}