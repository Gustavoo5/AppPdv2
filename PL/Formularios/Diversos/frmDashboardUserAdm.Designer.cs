namespace PL.Formularios.Diversos
{
    partial class frmDashboardUserAdm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnBuscar = new Metro.PurpleButton();
            this.txtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.txtDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesq = new System.Windows.Forms.TextBox();
            this.lblAdc = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblverde = new System.Windows.Forms.Label();
            this.lblpreto = new System.Windows.Forms.Label();
            this.chartCliente = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.gridPesq = new System.Windows.Forms.DataGridView();
            this.nomeUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdeVendasEmReais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMaiorVenda = new System.Windows.Forms.TextBox();
            this.lblMenosVenda = new System.Windows.Forms.TextBox();
            this.chtGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.chartCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtGrafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBuscar.Location = new System.Drawing.Point(1122, 3);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 32);
            this.btnBuscar.TabIndex = 40;
            this.btnBuscar.Text = "Filtrar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataFinal.Location = new System.Drawing.Point(989, 9);
            this.txtDataFinal.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(117, 23);
            this.txtDataFinal.TabIndex = 44;
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataInicial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataInicial.Location = new System.Drawing.Point(782, 9);
            this.txtDataInicial.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Size = new System.Drawing.Size(114, 23);
            this.txtDataInicial.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(690, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Data Inicial";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(904, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Data Final";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(488, 443);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 34);
            this.label2.TabIndex = 38;
            this.label2.Text = "Usuário com menos\r\nvendas:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(345, 443);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 34);
            this.label1.TabIndex = 37;
            this.label1.Text = "Usuário com mais \r\nvendas:";
            // 
            // txtPesq
            // 
            this.txtPesq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPesq.Location = new System.Drawing.Point(2, 454);
            this.txtPesq.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesq.Name = "txtPesq";
            this.txtPesq.Size = new System.Drawing.Size(335, 23);
            this.txtPesq.TabIndex = 35;
            this.txtPesq.TextChanged += new System.EventHandler(this.txtPesq_TextChanged);
            // 
            // lblAdc
            // 
            this.lblAdc.AutoSize = true;
            this.lblAdc.BackColor = System.Drawing.Color.White;
            this.lblAdc.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdc.ForeColor = System.Drawing.Color.Green;
            this.lblAdc.Location = new System.Drawing.Point(198, 9);
            this.lblAdc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdc.Name = "lblAdc";
            this.lblAdc.Size = new System.Drawing.Size(17, 17);
            this.lblAdc.TabIndex = 32;
            this.lblAdc.Text = "0";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.White;
            this.lblCliente.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(360, 9);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(17, 17);
            this.lblCliente.TabIndex = 31;
            this.lblCliente.Text = "0";
            // 
            // lblverde
            // 
            this.lblverde.AutoSize = true;
            this.lblverde.BackColor = System.Drawing.Color.White;
            this.lblverde.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblverde.ForeColor = System.Drawing.Color.Green;
            this.lblverde.Location = new System.Drawing.Point(3, 9);
            this.lblverde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblverde.Name = "lblverde";
            this.lblverde.Size = new System.Drawing.Size(197, 17);
            this.lblverde.TabIndex = 30;
            this.lblverde.Text = "Clientes Adicinados no dia:";
            // 
            // lblpreto
            // 
            this.lblpreto.AutoSize = true;
            this.lblpreto.BackColor = System.Drawing.Color.White;
            this.lblpreto.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpreto.Location = new System.Drawing.Point(234, 9);
            this.lblpreto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpreto.Name = "lblpreto";
            this.lblpreto.Size = new System.Drawing.Size(129, 17);
            this.lblpreto.TabIndex = 29;
            this.lblpreto.Text = "Total de Clientes:";
            // 
            // chartCliente
            // 
            this.chartCliente.BorderlineColor = System.Drawing.Color.Black;
            this.chartCliente.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chartCliente.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCliente.Legends.Add(legend1);
            this.chartCliente.Location = new System.Drawing.Point(2, 32);
            this.chartCliente.Margin = new System.Windows.Forms.Padding(4);
            this.chartCliente.Name = "chartCliente";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.LabelBorderWidth = 10;
            series1.LabelForeColor = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCliente.Series.Add(series1);
            this.chartCliente.Size = new System.Drawing.Size(508, 295);
            this.chartCliente.TabIndex = 47;
            this.chartCliente.Text = "chart1";
            title1.Name = "Clientes Del.";
            this.chartCliente.Titles.Add(title1);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(0, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 16);
            this.label7.TabIndex = 48;
            this.label7.Text = "Filtrar por nome do Usuário.";
            // 
            // gridPesq
            // 
            this.gridPesq.AllowUserToAddRows = false;
            this.gridPesq.AllowUserToDeleteRows = false;
            this.gridPesq.AllowUserToResizeColumns = false;
            this.gridPesq.AllowUserToResizeRows = false;
            this.gridPesq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gridPesq.BackgroundColor = System.Drawing.Color.White;
            this.gridPesq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPesq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeUser,
            this.QtdeVendasEmReais});
            this.gridPesq.Location = new System.Drawing.Point(2, 480);
            this.gridPesq.Margin = new System.Windows.Forms.Padding(4);
            this.gridPesq.MultiSelect = false;
            this.gridPesq.Name = "gridPesq";
            this.gridPesq.ReadOnly = true;
            this.gridPesq.RowHeadersVisible = false;
            this.gridPesq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPesq.Size = new System.Drawing.Size(633, 228);
            this.gridPesq.TabIndex = 34;
            // 
            // nomeUser
            // 
            this.nomeUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeUser.DataPropertyName = "nomeUser";
            this.nomeUser.HeaderText = "Nome do Usuário";
            this.nomeUser.Name = "nomeUser";
            this.nomeUser.ReadOnly = true;
            // 
            // QtdeVendasEmReais
            // 
            this.QtdeVendasEmReais.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QtdeVendasEmReais.DataPropertyName = "total";
            this.QtdeVendasEmReais.HeaderText = "Valor Total das Vendas";
            this.QtdeVendasEmReais.Name = "QtdeVendasEmReais";
            this.QtdeVendasEmReais.ReadOnly = true;
            // 
            // lblMaiorVenda
            // 
            this.lblMaiorVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMaiorVenda.BackColor = System.Drawing.Color.White;
            this.lblMaiorVenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblMaiorVenda.Location = new System.Drawing.Point(407, 461);
            this.lblMaiorVenda.Name = "lblMaiorVenda";
            this.lblMaiorVenda.ReadOnly = true;
            this.lblMaiorVenda.Size = new System.Drawing.Size(75, 16);
            this.lblMaiorVenda.TabIndex = 49;
            // 
            // lblMenosVenda
            // 
            this.lblMenosVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMenosVenda.BackColor = System.Drawing.Color.White;
            this.lblMenosVenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblMenosVenda.Location = new System.Drawing.Point(550, 461);
            this.lblMenosVenda.Name = "lblMenosVenda";
            this.lblMenosVenda.ReadOnly = true;
            this.lblMenosVenda.Size = new System.Drawing.Size(66, 16);
            this.lblMenosVenda.TabIndex = 50;
            // 
            // chtGrafico
            // 
            this.chtGrafico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chtGrafico.BorderlineColor = System.Drawing.Color.Black;
            this.chtGrafico.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.chtGrafico.ChartAreas.Add(chartArea2);
            this.chtGrafico.Location = new System.Drawing.Point(653, 38);
            this.chtGrafico.Name = "chtGrafico";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.Red;
            series2.Name = "Series1";
            series2.YValuesPerPoint = 2;
            this.chtGrafico.Series.Add(series2);
            this.chtGrafico.Size = new System.Drawing.Size(578, 289);
            this.chtGrafico.TabIndex = 51;
            this.chtGrafico.Text = "chart1";
            title2.Name = "Vendas do dia";
            this.chtGrafico.Titles.Add(title2);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(439, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Gráfico de Todas as vendas efetuadas em seus respectivos Dias.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(454, 16);
            this.label4.TabIndex = 53;
            this.label4.Text = "Gráfico de Todos os clientes adicionados em seus respectivos Dias.";
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(766, 434);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Vendas";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(471, 253);
            this.chart2.TabIndex = 55;
            this.chart2.Text = "chart2";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(1240, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 647);
            this.vScrollBar1.TabIndex = 56;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // frmDashboardUserAdm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1257, 647);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chtGrafico);
            this.Controls.Add(this.lblMenosVenda);
            this.Controls.Add(this.lblMaiorVenda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chartCliente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDataFinal);
            this.Controls.Add(this.txtDataInicial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesq);
            this.Controls.Add(this.gridPesq);
            this.Controls.Add(this.lblAdc);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblverde);
            this.Controls.Add(this.lblpreto);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDashboardUserAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Para UserAdm";
            this.Load += new System.EventHandler(this.frmDashboardUserAdm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtGrafico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Metro.PurpleButton btnBuscar;
        private System.Windows.Forms.DateTimePicker txtDataFinal;
        private System.Windows.Forms.DateTimePicker txtDataInicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesq;
        private System.Windows.Forms.Label lblAdc;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblverde;
        private System.Windows.Forms.Label lblpreto;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lblMaiorVenda;
        private System.Windows.Forms.TextBox lblMenosVenda;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGrafico;
        private System.Windows.Forms.DataGridView gridPesq;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdeVendasEmReais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}