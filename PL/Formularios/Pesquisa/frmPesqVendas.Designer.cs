namespace PL.Formularios.Pesquisa
{
    partial class frmPesqVendas
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
            this.pnlVendas = new System.Windows.Forms.Panel();
            this.gridPesqVendas = new System.Windows.Forms.DataGridView();
            this.pnlItens = new System.Windows.Forms.Panel();
            this.gridPesqItens = new System.Windows.Forms.DataGridView();
            this.idCompVendaHist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVendaHist1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descVendaHist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorItemGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorProdHist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescProdHist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClieGRID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCateg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtData2 = new System.Windows.Forms.DateTimePicker();
            this.TxtData1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFiltroDatas = new Metro.OrangeButton();
            this.idvendaHist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUserVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFormPag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeClie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdVendas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescPag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlGeral.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            this.pnlBarra.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.pnlVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesqVendas)).BeginInit();
            this.pnlItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesqItens)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPesq
            // 
            this.cmbPesq.Location = new System.Drawing.Point(10, 40);
            this.cmbPesq.Size = new System.Drawing.Size(182, 21);
            // 
            // txtPesq
            // 
            this.txtPesq.Location = new System.Drawing.Point(198, 40);
            this.txtPesq.Size = new System.Drawing.Size(313, 21);
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Controls.Add(this.btnFiltroDatas);
            this.pnlFiltro.Controls.Add(this.TxtData2);
            this.pnlFiltro.Controls.Add(this.TxtData1);
            this.pnlFiltro.Controls.Add(this.label1);
            this.pnlFiltro.Controls.Add(this.label2);
            this.pnlFiltro.Size = new System.Drawing.Size(889, 69);
            this.pnlFiltro.Controls.SetChildIndex(this.txtPesq, 0);
            this.pnlFiltro.Controls.SetChildIndex(this.cmbPesq, 0);
            this.pnlFiltro.Controls.SetChildIndex(this.btnPesq, 0);
            this.pnlFiltro.Controls.SetChildIndex(this.label2, 0);
            this.pnlFiltro.Controls.SetChildIndex(this.label1, 0);
            this.pnlFiltro.Controls.SetChildIndex(this.TxtData1, 0);
            this.pnlFiltro.Controls.SetChildIndex(this.TxtData2, 0);
            this.pnlFiltro.Controls.SetChildIndex(this.btnFiltroDatas, 0);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.pnlItens);
            this.pnlGrid.Controls.Add(this.pnlVendas);
            this.pnlGrid.Location = new System.Drawing.Point(0, 97);
            this.pnlGrid.Size = new System.Drawing.Size(889, 446);
            // 
            // btnPesq
            // 
            this.btnPesq.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPesq.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.btnPesq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.btnPesq.Location = new System.Drawing.Point(517, 36);
            // 
            // pnlVendas
            // 
            this.pnlVendas.Controls.Add(this.gridPesqVendas);
            this.pnlVendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVendas.Location = new System.Drawing.Point(0, 0);
            this.pnlVendas.Name = "pnlVendas";
            this.pnlVendas.Size = new System.Drawing.Size(887, 265);
            this.pnlVendas.TabIndex = 0;
            // 
            // gridPesqVendas
            // 
            this.gridPesqVendas.AllowUserToAddRows = false;
            this.gridPesqVendas.AllowUserToDeleteRows = false;
            this.gridPesqVendas.AllowUserToOrderColumns = true;
            this.gridPesqVendas.BackgroundColor = System.Drawing.Color.White;
            this.gridPesqVendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPesqVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPesqVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvendaHist,
            this.idclie,
            this.valorTotal,
            this.dataVenda,
            this.idUserVenda,
            this.IdFormPag,
            this.idFC,
            this.ativa,
            this.status,
            this.nomeClie,
            this.total,
            this.qtdVendas,
            this.DescPag,
            this.DescProd,
            this.nomeUser});
            this.gridPesqVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPesqVendas.Location = new System.Drawing.Point(0, 0);
            this.gridPesqVendas.MultiSelect = false;
            this.gridPesqVendas.Name = "gridPesqVendas";
            this.gridPesqVendas.ReadOnly = true;
            this.gridPesqVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPesqVendas.Size = new System.Drawing.Size(887, 265);
            this.gridPesqVendas.TabIndex = 10;
            this.gridPesqVendas.Click += new System.EventHandler(this.gridPesqVendas_Click);
            // 
            // pnlItens
            // 
            this.pnlItens.Controls.Add(this.gridPesqItens);
            this.pnlItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlItens.Location = new System.Drawing.Point(0, 265);
            this.pnlItens.Name = "pnlItens";
            this.pnlItens.Size = new System.Drawing.Size(887, 179);
            this.pnlItens.TabIndex = 1;
            // 
            // gridPesqItens
            // 
            this.gridPesqItens.AllowUserToAddRows = false;
            this.gridPesqItens.AllowUserToDeleteRows = false;
            this.gridPesqItens.AllowUserToOrderColumns = true;
            this.gridPesqItens.BackgroundColor = System.Drawing.Color.White;
            this.gridPesqItens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPesqItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPesqItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCompVendaHist,
            this.idVendaHist1,
            this.idProd,
            this.descVendaHist,
            this.QtdProd,
            this.ValorItemGrid,
            this.valorProdHist,
            this.DescProdHist,
            this.idClieGRID,
            this.qtd,
            this.idCateg});
            this.gridPesqItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPesqItens.Location = new System.Drawing.Point(0, 0);
            this.gridPesqItens.MultiSelect = false;
            this.gridPesqItens.Name = "gridPesqItens";
            this.gridPesqItens.ReadOnly = true;
            this.gridPesqItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPesqItens.Size = new System.Drawing.Size(887, 179);
            this.gridPesqItens.TabIndex = 6;
            // 
            // idCompVendaHist
            // 
            this.idCompVendaHist.DataPropertyName = "idCompVenda";
            this.idCompVendaHist.HeaderText = "idComp";
            this.idCompVendaHist.Name = "idCompVendaHist";
            this.idCompVendaHist.ReadOnly = true;
            this.idCompVendaHist.Visible = false;
            // 
            // idVendaHist1
            // 
            this.idVendaHist1.DataPropertyName = "idVenda";
            this.idVendaHist1.HeaderText = "idVenda";
            this.idVendaHist1.Name = "idVendaHist1";
            this.idVendaHist1.ReadOnly = true;
            this.idVendaHist1.Visible = false;
            // 
            // idProd
            // 
            this.idProd.DataPropertyName = "idProd";
            this.idProd.HeaderText = "IdProd";
            this.idProd.Name = "idProd";
            this.idProd.ReadOnly = true;
            this.idProd.Visible = false;
            // 
            // descVendaHist
            // 
            this.descVendaHist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descVendaHist.DataPropertyName = "descVenda";
            this.descVendaHist.HeaderText = "Desc. Venda";
            this.descVendaHist.Name = "descVendaHist";
            this.descVendaHist.ReadOnly = true;
            // 
            // QtdProd
            // 
            this.QtdProd.DataPropertyName = "QtdProd";
            this.QtdProd.HeaderText = "Qtd. Prod.";
            this.QtdProd.Name = "QtdProd";
            this.QtdProd.ReadOnly = true;
            // 
            // ValorItemGrid
            // 
            this.ValorItemGrid.DataPropertyName = "ValorItem";
            this.ValorItemGrid.HeaderText = "Valor Item";
            this.ValorItemGrid.Name = "ValorItemGrid";
            this.ValorItemGrid.ReadOnly = true;
            // 
            // valorProdHist
            // 
            this.valorProdHist.DataPropertyName = "valorProd";
            this.valorProdHist.HeaderText = "Valor P.";
            this.valorProdHist.Name = "valorProdHist";
            this.valorProdHist.ReadOnly = true;
            this.valorProdHist.Visible = false;
            this.valorProdHist.Width = 150;
            // 
            // DescProdHist
            // 
            this.DescProdHist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescProdHist.DataPropertyName = "DescProd";
            this.DescProdHist.HeaderText = "Desc. Prod.";
            this.DescProdHist.Name = "DescProdHist";
            this.DescProdHist.ReadOnly = true;
            this.DescProdHist.Visible = false;
            // 
            // idClieGRID
            // 
            this.idClieGRID.DataPropertyName = "idClie";
            this.idClieGRID.HeaderText = "idclie";
            this.idClieGRID.Name = "idClieGRID";
            this.idClieGRID.ReadOnly = true;
            this.idClieGRID.Visible = false;
            // 
            // qtd
            // 
            this.qtd.DataPropertyName = "qtd";
            this.qtd.HeaderText = "qtd";
            this.qtd.Name = "qtd";
            this.qtd.ReadOnly = true;
            this.qtd.Visible = false;
            // 
            // idCateg
            // 
            this.idCateg.DataPropertyName = "idCateg";
            this.idCateg.HeaderText = "IdCateg";
            this.idCateg.Name = "idCateg";
            this.idCateg.ReadOnly = true;
            this.idCateg.Visible = false;
            // 
            // TxtData2
            // 
            this.TxtData2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtData2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtData2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtData2.Location = new System.Drawing.Point(175, 5);
            this.TxtData2.Name = "TxtData2";
            this.TxtData2.Size = new System.Drawing.Size(98, 21);
            this.TxtData2.TabIndex = 13;
            // 
            // TxtData1
            // 
            this.TxtData1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtData1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtData1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtData1.Location = new System.Drawing.Point(48, 5);
            this.TxtData1.Name = "TxtData1";
            this.TxtData1.Size = new System.Drawing.Size(100, 21);
            this.TxtData1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(154, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Á";
            // 
            // btnFiltroDatas
            // 
            this.btnFiltroDatas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.btnFiltroDatas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltroDatas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.btnFiltroDatas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(25)))));
            this.btnFiltroDatas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroDatas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroDatas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFiltroDatas.Location = new System.Drawing.Point(279, 2);
            this.btnFiltroDatas.Name = "btnFiltroDatas";
            this.btnFiltroDatas.Size = new System.Drawing.Size(100, 30);
            this.btnFiltroDatas.TabIndex = 165;
            this.btnFiltroDatas.Text = "Filtrar Datas";
            this.btnFiltroDatas.UseVisualStyleBackColor = false;
            this.btnFiltroDatas.Click += new System.EventHandler(this.btnFiltroDatas_Click);
            // 
            // idvendaHist
            // 
            this.idvendaHist.DataPropertyName = "idvenda";
            this.idvendaHist.HeaderText = "idvenda";
            this.idvendaHist.Name = "idvendaHist";
            this.idvendaHist.ReadOnly = true;
            this.idvendaHist.Visible = false;
            // 
            // idclie
            // 
            this.idclie.DataPropertyName = "idclie";
            this.idclie.HeaderText = "idclie";
            this.idclie.Name = "idclie";
            this.idclie.ReadOnly = true;
            this.idclie.Visible = false;
            // 
            // valorTotal
            // 
            this.valorTotal.DataPropertyName = "valorTotal";
            this.valorTotal.HeaderText = "Valor T.";
            this.valorTotal.Name = "valorTotal";
            this.valorTotal.ReadOnly = true;
            // 
            // dataVenda
            // 
            this.dataVenda.DataPropertyName = "dataVenda";
            this.dataVenda.HeaderText = "Data";
            this.dataVenda.Name = "dataVenda";
            this.dataVenda.ReadOnly = true;
            this.dataVenda.Width = 150;
            // 
            // idUserVenda
            // 
            this.idUserVenda.DataPropertyName = "idUserVenda";
            this.idUserVenda.HeaderText = "idUser";
            this.idUserVenda.Name = "idUserVenda";
            this.idUserVenda.ReadOnly = true;
            this.idUserVenda.Visible = false;
            // 
            // IdFormPag
            // 
            this.IdFormPag.DataPropertyName = "IdFormPag";
            this.IdFormPag.HeaderText = "IdFormPag";
            this.IdFormPag.Name = "IdFormPag";
            this.IdFormPag.ReadOnly = true;
            this.IdFormPag.Visible = false;
            // 
            // idFC
            // 
            this.idFC.DataPropertyName = "idFC";
            this.idFC.HeaderText = "idFC";
            this.idFC.Name = "idFC";
            this.idFC.ReadOnly = true;
            this.idFC.Visible = false;
            // 
            // ativa
            // 
            this.ativa.DataPropertyName = "ativa";
            this.ativa.HeaderText = "ativa";
            this.ativa.Name = "ativa";
            this.ativa.ReadOnly = true;
            this.ativa.Visible = false;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Situação";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // nomeClie
            // 
            this.nomeClie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeClie.DataPropertyName = "nomeClie";
            this.nomeClie.HeaderText = "Cliente";
            this.nomeClie.Name = "nomeClie";
            this.nomeClie.ReadOnly = true;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Visible = false;
            // 
            // qtdVendas
            // 
            this.qtdVendas.DataPropertyName = "qtd";
            this.qtdVendas.HeaderText = "qtd";
            this.qtdVendas.Name = "qtdVendas";
            this.qtdVendas.ReadOnly = true;
            this.qtdVendas.Visible = false;
            // 
            // DescPag
            // 
            this.DescPag.DataPropertyName = "DescPag";
            this.DescPag.HeaderText = "Pagamento";
            this.DescPag.Name = "DescPag";
            this.DescPag.ReadOnly = true;
            // 
            // DescProd
            // 
            this.DescProd.DataPropertyName = "DescProd";
            this.DescProd.HeaderText = "DescProd";
            this.DescProd.Name = "DescProd";
            this.DescProd.ReadOnly = true;
            this.DescProd.Visible = false;
            // 
            // nomeUser
            // 
            this.nomeUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nomeUser.DataPropertyName = "nomeUser";
            this.nomeUser.HeaderText = "Usuario";
            this.nomeUser.Name = "nomeUser";
            this.nomeUser.ReadOnly = true;
            this.nomeUser.Width = 150;
            // 
            // frmPesqVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 545);
            this.Name = "frmPesqVendas";
            this.Text = "frmPesqVendas";
            this.pnlGeral.ResumeLayout(false);
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            this.pnlBarra.ResumeLayout(false);
            this.pnlBarra.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            this.pnlVendas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPesqVendas)).EndInit();
            this.pnlItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPesqItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVendas;
        private System.Windows.Forms.Panel pnlItens;
        private System.Windows.Forms.DataGridView gridPesqVendas;
        private System.Windows.Forms.DataGridView gridPesqItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompVendaHist;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVendaHist1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn descVendaHist;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorItemGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorProdHist;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescProdHist;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClieGRID;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCateg;
        private System.Windows.Forms.DateTimePicker TxtData2;
        private System.Windows.Forms.DateTimePicker TxtData1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Metro.OrangeButton btnFiltroDatas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvendaHist;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclie;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUserVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFormPag;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativa;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClie;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescPag;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeUser;
    }
}