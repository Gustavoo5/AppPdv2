namespace PL
{
    partial class frmFluxoDeCaixa
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.darkPanel1 = new Metro.DarkPanel();
            this.lblMini = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.TxtData2 = new System.Windows.Forms.DateTimePicker();
            this.TxtData1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new Metro.PurpleButton();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.darkPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // darkPanel1
            // 
            this.darkPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.darkPanel1.Controls.Add(this.lblMini);
            this.darkPanel1.Controls.Add(this.lblClose);
            this.darkPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.darkPanel1.Location = new System.Drawing.Point(0, 0);
            this.darkPanel1.Name = "darkPanel1";
            this.darkPanel1.Size = new System.Drawing.Size(1035, 29);
            this.darkPanel1.TabIndex = 11;
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
            this.lblMini.Location = new System.Drawing.Point(984, 3);
            this.lblMini.Name = "lblMini";
            this.lblMini.Size = new System.Drawing.Size(19, 23);
            this.lblMini.TabIndex = 166;
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
            this.lblClose.Location = new System.Drawing.Point(1009, 3);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(23, 23);
            this.lblClose.TabIndex = 165;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // TxtData2
            // 
            this.TxtData2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtData2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtData2.Location = new System.Drawing.Point(182, 40);
            this.TxtData2.Name = "TxtData2";
            this.TxtData2.Size = new System.Drawing.Size(98, 24);
            this.TxtData2.TabIndex = 170;
            // 
            // TxtData1
            // 
            this.TxtData1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtData1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtData1.Location = new System.Drawing.Point(52, 39);
            this.TxtData1.Name = "TxtData1";
            this.TxtData1.Size = new System.Drawing.Size(100, 24);
            this.TxtData1.TabIndex = 169;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 167;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(158, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 17);
            this.label2.TabIndex = 168;
            this.label2.Text = "Á";
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
            this.btnBuscar.Location = new System.Drawing.Point(287, 34);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 32);
            this.btnBuscar.TabIndex = 171;
            this.btnBuscar.Text = "Filtrar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // chart
            // 
            chartArea4.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea4);
            this.chart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chart.Location = new System.Drawing.Point(0, 73);
            this.chart.Name = "chart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
            series4.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.IsValueShownAsLabel = true;
            series4.LabelForeColor = System.Drawing.Color.Red;
            series4.Name = "Series1";
            series4.YValuesPerPoint = 2;
            this.chart.Series.Add(series4);
            this.chart.Size = new System.Drawing.Size(1035, 437);
            this.chart.TabIndex = 172;
            this.chart.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(421, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(614, 17);
            this.label3.TabIndex = 173;
            this.label3.Text = "Gráfico do fluxo de caixa, nele é mostrado o saldo líquido em suas respectivas da" +
    "tas. ";
            // 
            // frmFluxoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1035, 510);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.TxtData2);
            this.Controls.Add(this.darkPanel1);
            this.Controls.Add(this.TxtData1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(6)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmFluxoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmFluxoCaixa_Load);
            this.darkPanel1.ResumeLayout(false);
            this.darkPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Metro.DarkPanel darkPanel1;
        private System.Windows.Forms.Label lblMini;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.DateTimePicker TxtData2;
        private System.Windows.Forms.DateTimePicker TxtData1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Metro.PurpleButton btnBuscar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label3;
    }
}