namespace PL
{
    partial class frmProdutos
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
            this.gridPesq = new System.Windows.Forms.DataGridView();
            this.idProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idForn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCateg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descCateg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupComp = new System.Windows.Forms.GroupBox();
            this.btnDeletarComp = new Metro.RedButton();
            this.btnSalvarComp = new Metro.GreenButton();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtQtdC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbProd = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCategComp = new System.Windows.Forms.ComboBox();
            this.gridPesqComp = new System.Windows.Forms.DataGridView();
            this.idCompProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdComp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descProdC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdComp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCateg = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.darkPanel1.SuspendLayout();
            this.groupControle.SuspendLayout();
            this.groupPesq.SuspendLayout();
            this.groupDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesq)).BeginInit();
            this.groupComp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesqComp)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPesq
            // 
            this.cmbPesq.Items.AddRange(new object[] {
            "ALL",
            "ID",
            "DESCRIÇÃO",
            "CATEGORIA"});
            // 
            // darkPanel1
            // 
            this.darkPanel1.Size = new System.Drawing.Size(1101, 615);
            // 
            // groupControle
            // 
            this.groupControle.Location = new System.Drawing.Point(0, 546);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            // 
            // btnDel
            // 
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // btnAlt
            // 
            this.btnAlt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(52)))), ((int)(((byte)(0)))));
            this.btnAlt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(25)))));
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(14)))));
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(14)))));
            // 
            // groupPesq
            // 
            this.groupPesq.Controls.Add(this.gridPesq);
            this.groupPesq.Controls.SetChildIndex(this.lblFiltro, 0);
            this.groupPesq.Controls.SetChildIndex(this.cmbPesq, 0);
            this.groupPesq.Controls.SetChildIndex(this.txtPesq, 0);
            this.groupPesq.Controls.SetChildIndex(this.btnPesq, 0);
            this.groupPesq.Controls.SetChildIndex(this.gridPesq, 0);
            // 
            // btnPesq
            // 
            this.btnPesq.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPesq.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(0)))), ((int)(((byte)(76)))));
            this.btnPesq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            // 
            // groupDados
            // 
            this.groupDados.Controls.Add(this.groupComp);
            this.groupDados.Controls.Add(this.txtTotal);
            this.groupDados.Controls.Add(this.label7);
            this.groupDados.Controls.Add(this.cmbCateg);
            this.groupDados.Controls.Add(this.txtValor);
            this.groupDados.Controls.Add(this.txtQtd);
            this.groupDados.Controls.Add(this.txtDesc);
            this.groupDados.Controls.Add(this.txtIdProd);
            this.groupDados.Controls.Add(this.label6);
            this.groupDados.Controls.Add(this.label5);
            this.groupDados.Controls.Add(this.label4);
            this.groupDados.Controls.Add(this.label3);
            this.groupDados.Controls.Add(this.label2);
            this.groupDados.Size = new System.Drawing.Size(1101, 311);
            // 
            // gridPesq
            // 
            this.gridPesq.AllowUserToAddRows = false;
            this.gridPesq.AllowUserToDeleteRows = false;
            this.gridPesq.AllowUserToResizeColumns = false;
            this.gridPesq.AllowUserToResizeRows = false;
            this.gridPesq.BackgroundColor = System.Drawing.Color.White;
            this.gridPesq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPesq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPesq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProd,
            this.idForn,
            this.idCateg,
            this.descProd,
            this.qtdProd,
            this.valorProd,
            this.descCateg});
            this.gridPesq.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPesq.Location = new System.Drawing.Point(0, 42);
            this.gridPesq.MultiSelect = false;
            this.gridPesq.Name = "gridPesq";
            this.gridPesq.ReadOnly = true;
            this.gridPesq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPesq.Size = new System.Drawing.Size(1099, 191);
            this.gridPesq.TabIndex = 6;
            this.gridPesq.Click += new System.EventHandler(this.GridPesq_Click);
            // 
            // idProd
            // 
            this.idProd.DataPropertyName = "idProd";
            this.idProd.HeaderText = "ID Prod.";
            this.idProd.Name = "idProd";
            this.idProd.ReadOnly = true;
            // 
            // idForn
            // 
            this.idForn.DataPropertyName = "idForn";
            this.idForn.HeaderText = "idForn";
            this.idForn.Name = "idForn";
            this.idForn.ReadOnly = true;
            this.idForn.Visible = false;
            // 
            // idCateg
            // 
            this.idCateg.DataPropertyName = "idCateg";
            this.idCateg.HeaderText = "idCateg";
            this.idCateg.Name = "idCateg";
            this.idCateg.ReadOnly = true;
            this.idCateg.Visible = false;
            // 
            // descProd
            // 
            this.descProd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descProd.DataPropertyName = "descProd";
            this.descProd.HeaderText = "Descrição do Produto";
            this.descProd.Name = "descProd";
            this.descProd.ReadOnly = true;
            // 
            // qtdProd
            // 
            this.qtdProd.DataPropertyName = "qtdProd";
            this.qtdProd.HeaderText = "Quantidade";
            this.qtdProd.Name = "qtdProd";
            this.qtdProd.ReadOnly = true;
            // 
            // valorProd
            // 
            this.valorProd.DataPropertyName = "valorProd";
            this.valorProd.HeaderText = "Valor";
            this.valorProd.Name = "valorProd";
            this.valorProd.ReadOnly = true;
            // 
            // descCateg
            // 
            this.descCateg.DataPropertyName = "descCateg";
            this.descCateg.HeaderText = "Categoria";
            this.descCateg.Name = "descCateg";
            this.descCateg.ReadOnly = true;
            this.descCateg.Width = 150;
            // 
            // groupComp
            // 
            this.groupComp.Controls.Add(this.btnDeletarComp);
            this.groupComp.Controls.Add(this.btnSalvarComp);
            this.groupComp.Controls.Add(this.lblCod);
            this.groupComp.Controls.Add(this.txtQtdC);
            this.groupComp.Controls.Add(this.label11);
            this.groupComp.Controls.Add(this.txtProd);
            this.groupComp.Controls.Add(this.label10);
            this.groupComp.Controls.Add(this.cmbProd);
            this.groupComp.Controls.Add(this.label9);
            this.groupComp.Controls.Add(this.label8);
            this.groupComp.Controls.Add(this.cmbCategComp);
            this.groupComp.Controls.Add(this.gridPesqComp);
            this.groupComp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupComp.ForeColor = System.Drawing.SystemColors.Control;
            this.groupComp.Location = new System.Drawing.Point(0, 90);
            this.groupComp.Name = "groupComp";
            this.groupComp.Size = new System.Drawing.Size(1099, 219);
            this.groupComp.TabIndex = 49;
            this.groupComp.TabStop = false;
            this.groupComp.Text = "Componentes";
            // 
            // btnDeletarComp
            // 
            this.btnDeletarComp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeletarComp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeletarComp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeletarComp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeletarComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletarComp.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarComp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDeletarComp.Location = new System.Drawing.Point(712, 185);
            this.btnDeletarComp.Name = "btnDeletarComp";
            this.btnDeletarComp.Size = new System.Drawing.Size(100, 28);
            this.btnDeletarComp.TabIndex = 14;
            this.btnDeletarComp.Text = "Remover";
            this.btnDeletarComp.UseVisualStyleBackColor = false;
            // 
            // btnSalvarComp
            // 
            this.btnSalvarComp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(14)))));
            this.btnSalvarComp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvarComp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(14)))));
            this.btnSalvarComp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(14)))));
            this.btnSalvarComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarComp.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarComp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSalvarComp.Location = new System.Drawing.Point(712, 151);
            this.btnSalvarComp.Name = "btnSalvarComp";
            this.btnSalvarComp.Size = new System.Drawing.Size(100, 28);
            this.btnSalvarComp.TabIndex = 13;
            this.btnSalvarComp.Text = "Adicionar";
            this.btnSalvarComp.UseVisualStyleBackColor = false;
            // 
            // lblCod
            // 
            this.lblCod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(1037, 117);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(0, 16);
            this.lblCod.TabIndex = 12;
            // 
            // txtQtdC
            // 
            this.txtQtdC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQtdC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdC.Location = new System.Drawing.Point(795, 108);
            this.txtQtdC.Name = "txtQtdC";
            this.txtQtdC.Size = new System.Drawing.Size(92, 23);
            this.txtQtdC.TabIndex = 8;
            this.txtQtdC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Location = new System.Drawing.Point(710, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "Quantidade";
            // 
            // txtProd
            // 
            this.txtProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProd.Enabled = false;
            this.txtProd.Location = new System.Drawing.Point(795, 19);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(293, 23);
            this.txtProd.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Location = new System.Drawing.Point(730, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Produto";
            // 
            // cmbProd
            // 
            this.cmbProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProd.FormattingEnabled = true;
            this.cmbProd.Location = new System.Drawing.Point(796, 78);
            this.cmbProd.Name = "cmbProd";
            this.cmbProd.Size = new System.Drawing.Size(293, 24);
            this.cmbProd.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(741, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Comp.";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(711, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Categorias";
            // 
            // cmbCategComp
            // 
            this.cmbCategComp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategComp.FormattingEnabled = true;
            this.cmbCategComp.Location = new System.Drawing.Point(795, 48);
            this.cmbCategComp.Name = "cmbCategComp";
            this.cmbCategComp.Size = new System.Drawing.Size(293, 24);
            this.cmbCategComp.TabIndex = 1;
            // 
            // gridPesqComp
            // 
            this.gridPesqComp.AllowUserToAddRows = false;
            this.gridPesqComp.AllowUserToDeleteRows = false;
            this.gridPesqComp.AllowUserToResizeColumns = false;
            this.gridPesqComp.AllowUserToResizeRows = false;
            this.gridPesqComp.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridPesqComp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPesqComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPesqComp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCompProd,
            this.idProdC,
            this.idProdComp,
            this.descProdC,
            this.qtdComp});
            this.gridPesqComp.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridPesqComp.GridColor = System.Drawing.Color.Black;
            this.gridPesqComp.Location = new System.Drawing.Point(3, 19);
            this.gridPesqComp.MultiSelect = false;
            this.gridPesqComp.Name = "gridPesqComp";
            this.gridPesqComp.ReadOnly = true;
            this.gridPesqComp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPesqComp.Size = new System.Drawing.Size(706, 197);
            this.gridPesqComp.TabIndex = 0;
            // 
            // idCompProd
            // 
            this.idCompProd.DataPropertyName = "idCompProd";
            this.idCompProd.HeaderText = "IdCompProd";
            this.idCompProd.Name = "idCompProd";
            this.idCompProd.ReadOnly = true;
            this.idCompProd.Visible = false;
            // 
            // idProdC
            // 
            this.idProdC.DataPropertyName = "idProd";
            this.idProdC.HeaderText = "idProdC";
            this.idProdC.Name = "idProdC";
            this.idProdC.ReadOnly = true;
            this.idProdC.Visible = false;
            // 
            // idProdComp
            // 
            this.idProdComp.DataPropertyName = "idProdComp";
            this.idProdComp.HeaderText = "IdProdComp";
            this.idProdComp.Name = "idProdComp";
            this.idProdComp.ReadOnly = true;
            this.idProdComp.Visible = false;
            // 
            // descProdC
            // 
            this.descProdC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descProdC.DataPropertyName = "descProd";
            this.descProdC.HeaderText = "Componente";
            this.descProdC.Name = "descProdC";
            this.descProdC.ReadOnly = true;
            // 
            // qtdComp
            // 
            this.qtdComp.DataPropertyName = "qtdComp";
            this.qtdComp.HeaderText = "Quantidade";
            this.qtdComp.Name = "qtdComp";
            this.qtdComp.ReadOnly = true;
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(450, 38);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 48;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(364, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 47;
            this.label7.Text = "Valor Total";
            // 
            // cmbCateg
            // 
            this.cmbCateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCateg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCateg.FormattingEnabled = true;
            this.cmbCateg.Location = new System.Drawing.Point(88, 67);
            this.cmbCateg.Name = "cmbCateg";
            this.cmbCateg.Size = new System.Drawing.Size(270, 24);
            this.cmbCateg.TabIndex = 46;
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Location = new System.Drawing.Point(260, 38);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(98, 23);
            this.txtValor.TabIndex = 45;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQtd
            // 
            this.txtQtd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtd.Enabled = false;
            this.txtQtd.Location = new System.Drawing.Point(88, 38);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(81, 23);
            this.txtQtd.TabIndex = 44;
            this.txtQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDesc
            // 
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesc.Location = new System.Drawing.Point(260, 9);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(831, 23);
            this.txtDesc.TabIndex = 43;
            // 
            // txtIdProd
            // 
            this.txtIdProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdProd.Enabled = false;
            this.txtIdProd.Location = new System.Drawing.Point(88, 9);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Size = new System.Drawing.Size(81, 23);
            this.txtIdProd.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(15, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(191, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Valor Un";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(3, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(182, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(21, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "ID Prod.";
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 615);
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProdutosPL";
            this.darkPanel1.ResumeLayout(false);
            this.groupControle.ResumeLayout(false);
            this.groupPesq.ResumeLayout(false);
            this.groupPesq.PerformLayout();
            this.groupDados.ResumeLayout(false);
            this.groupDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesq)).EndInit();
            this.groupComp.ResumeLayout(false);
            this.groupComp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesqComp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPesq;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idForn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCateg;
        private System.Windows.Forms.DataGridViewTextBoxColumn descProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn descCateg;
        private System.Windows.Forms.GroupBox groupComp;
        private Metro.RedButton btnDeletarComp;
        private Metro.GreenButton btnSalvarComp;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TextBox txtQtdC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbProd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCategComp;
        private System.Windows.Forms.DataGridView gridPesqComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdC;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn descProdC;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdComp;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCateg;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtIdProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}