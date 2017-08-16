namespace PL
{
    partial class frmVendasPorDatas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RetornaVendasDataPagtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AppPdvDataSet = new PL.AppPdvDataSet();
            this.darkPanel1 = new Metro.DarkPanel();
            this.lblMini = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtData2 = new System.Windows.Forms.DateTimePicker();
            this.TxtData1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPagt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.rptVendas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RetornaVendasDataPagtTableAdapter = new PL.AppPdvDataSetTableAdapters.RetornaVendasDataPagtTableAdapter();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RetornaVendasDataPagtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppPdvDataSet)).BeginInit();
            this.darkPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RetornaVendasDataPagtBindingSource
            // 
            this.RetornaVendasDataPagtBindingSource.DataMember = "RetornaVendasDataPagt";
            this.RetornaVendasDataPagtBindingSource.DataSource = this.AppPdvDataSet;
            // 
            // AppPdvDataSet
            // 
            this.AppPdvDataSet.DataSetName = "AppPdvDataSet";
            this.AppPdvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // darkPanel1
            // 
            this.darkPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.darkPanel1.Controls.Add(this.lblMini);
            this.darkPanel1.Controls.Add(this.lblClose);
            this.darkPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.darkPanel1.Location = new System.Drawing.Point(0, 0);
            this.darkPanel1.Name = "darkPanel1";
            this.darkPanel1.Size = new System.Drawing.Size(944, 29);
            this.darkPanel1.TabIndex = 10;
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
            this.lblMini.Location = new System.Drawing.Point(893, 3);
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
            this.lblClose.Location = new System.Drawing.Point(918, 3);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(23, 23);
            this.lblClose.TabIndex = 165;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.TxtData2);
            this.panel1.Controls.Add(this.TxtData1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbPagt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnMostrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 40);
            this.panel1.TabIndex = 12;
            // 
            // TxtData2
            // 
            this.TxtData2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtData2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtData2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtData2.Location = new System.Drawing.Point(179, 11);
            this.TxtData2.Name = "TxtData2";
            this.TxtData2.Size = new System.Drawing.Size(98, 21);
            this.TxtData2.TabIndex = 9;
            // 
            // TxtData1
            // 
            this.TxtData1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtData1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtData1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtData1.Location = new System.Drawing.Point(52, 11);
            this.TxtData1.Name = "TxtData1";
            this.TxtData1.Size = new System.Drawing.Size(100, 21);
            this.TxtData1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Á";
            // 
            // cmbPagt
            // 
            this.cmbPagt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPagt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPagt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPagt.FormattingEnabled = true;
            this.cmbPagt.Location = new System.Drawing.Point(365, 11);
            this.cmbPagt.Name = "cmbPagt";
            this.cmbPagt.Size = new System.Drawing.Size(153, 21);
            this.cmbPagt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Forma Pagt.";
            // 
            // btnMostrar
            // 
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(732, 11);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // rptVendas
            // 
            this.rptVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "VendasDatasPagt";
            reportDataSource1.Value = this.RetornaVendasDataPagtBindingSource;
            this.rptVendas.LocalReport.DataSources.Add(reportDataSource1);
            this.rptVendas.LocalReport.ReportEmbeddedResource = "PL.Relatorios.VendasPorData.rdlc";
            this.rptVendas.Location = new System.Drawing.Point(0, 69);
            this.rptVendas.Name = "rptVendas";
            this.rptVendas.Size = new System.Drawing.Size(944, 458);
            this.rptVendas.TabIndex = 13;
            // 
            // RetornaVendasDataPagtTableAdapter
            // 
            this.RetornaVendasDataPagtTableAdapter.ClearBeforeFill = true;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbStatus.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Concluida",
            "Cancelada"});
            this.cmbStatus.Location = new System.Drawing.Point(573, 11);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(153, 21);
            this.cmbStatus.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(524, 14);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status";
            // 
            // frmVendasPorDatas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 527);
            this.Controls.Add(this.rptVendas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.darkPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVendasPorDatas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVendasPorDatas";
            this.Load += new System.EventHandler(this.frmVendasPorDatas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RetornaVendasDataPagtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppPdvDataSet)).EndInit();
            this.darkPanel1.ResumeLayout(false);
            this.darkPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Metro.DarkPanel darkPanel1;
        private System.Windows.Forms.Label lblMini;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker TxtData2;
        private System.Windows.Forms.DateTimePicker TxtData1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPagt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMostrar;
        private Microsoft.Reporting.WinForms.ReportViewer rptVendas;
        private System.Windows.Forms.BindingSource RetornaVendasDataPagtBindingSource;
        private AppPdvDataSet AppPdvDataSet;
        private AppPdvDataSetTableAdapters.RetornaVendasDataPagtTableAdapter RetornaVendasDataPagtTableAdapter;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
    }
}