namespace PL
{
    partial class FrmMenu
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
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblNome = new System.Windows.Forms.Label();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogof = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minhaContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuContato = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbTitle = new System.Windows.Forms.PictureBox();
            this.lblMini = new System.Windows.Forms.Label();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.lblEmp = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnPesquisas = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnAtivacao = new System.Windows.Forms.Button();
            this.btnParametros = new System.Windows.Forms.Button();
            this.btnFormasPagt = new System.Windows.Forms.Button();
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlForms = new System.Windows.Forms.Panel();
            this.lblTituloSerial = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogof)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).BeginInit();
            this.pnlHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlForms.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmr
            // 
            this.tmr.Enabled = true;
            this.tmr.Tick += new System.EventHandler(this.Tmr_Tick);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.Control;
            this.pnlHeader.Controls.Add(this.lblNome);
            this.pnlHeader.Controls.Add(this.picbox);
            this.pnlHeader.Controls.Add(this.pictureBoxLogof);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.menuStrip1);
            this.pnlHeader.Controls.Add(this.pbTitle);
            this.pnlHeader.Controls.Add(this.lblMini);
            this.pnlHeader.Controls.Add(this.pnlHome);
            this.pnlHeader.Controls.Add(this.lblClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(982, 49);
            this.pnlHeader.TabIndex = 3;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNome.AutoSize = true;
            this.lblNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNome.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Gray;
            this.lblNome.Location = new System.Drawing.Point(642, 18);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(22, 18);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "--";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picbox
            // 
            this.picbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbox.Location = new System.Drawing.Point(586, 0);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(50, 50);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox.TabIndex = 6;
            this.picbox.TabStop = false;
            // 
            // pictureBoxLogof
            // 
            this.pictureBoxLogof.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxLogof.BackgroundImage = global::PL.Properties.Resources.Logout;
            this.pictureBoxLogof.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogof.Location = new System.Drawing.Point(869, 9);
            this.pictureBoxLogof.Name = "pictureBoxLogof";
            this.pictureBoxLogof.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxLogof.TabIndex = 4;
            this.pictureBoxLogof.TabStop = false;
            this.pictureBoxLogof.Click += new System.EventHandler(this.pictureBoxLogof_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTitle.Location = new System.Drawing.Point(255, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(96, 18);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Dashboard";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Location = new System.Drawing.Point(535, 11);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(50, 40);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minhaContaToolStripMenuItem,
            this.stripMenuContato,
            this.configToolStripMenuItem});
            this.toolStripMenuItem1.Image = global::PL.Properties.Resources.Branch_Engineering;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 36);
            // 
            // minhaContaToolStripMenuItem
            // 
            this.minhaContaToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minhaContaToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.minhaContaToolStripMenuItem.Name = "minhaContaToolStripMenuItem";
            this.minhaContaToolStripMenuItem.Padding = new System.Windows.Forms.Padding(2);
            this.minhaContaToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.minhaContaToolStripMenuItem.Text = "Editar Perfil";
            this.minhaContaToolStripMenuItem.Click += new System.EventHandler(this.minhaContaToolStripMenuItem_Click);
            // 
            // stripMenuContato
            // 
            this.stripMenuContato.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripMenuContato.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.stripMenuContato.Name = "stripMenuContato";
            this.stripMenuContato.Padding = new System.Windows.Forms.Padding(2);
            this.stripMenuContato.Size = new System.Drawing.Size(150, 24);
            this.stripMenuContato.Text = "Contato";
            this.stripMenuContato.Click += new System.EventHandler(this.stripMenuContato_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Padding = new System.Windows.Forms.Padding(2);
            this.configToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.configToolStripMenuItem.Text = "Sobre";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // pbTitle
            // 
            this.pbTitle.Location = new System.Drawing.Point(217, 9);
            this.pbTitle.Name = "pbTitle";
            this.pbTitle.Size = new System.Drawing.Size(32, 32);
            this.pbTitle.TabIndex = 2;
            this.pbTitle.TabStop = false;
            // 
            // lblMini
            // 
            this.lblMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMini.AutoSize = true;
            this.lblMini.BackColor = System.Drawing.Color.Transparent;
            this.lblMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMini.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMini.Location = new System.Drawing.Point(916, 11);
            this.lblMini.Name = "lblMini";
            this.lblMini.Size = new System.Drawing.Size(24, 29);
            this.lblMini.TabIndex = 1;
            this.lblMini.Text = "-";
            this.lblMini.Click += new System.EventHandler(this.lblMini_Click);
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHome.Controls.Add(this.lblEmp);
            this.pnlHome.Controls.Add(this.pbLogo);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHome.Location = new System.Drawing.Point(0, 0);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(211, 49);
            this.pnlHome.TabIndex = 0;
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmp.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmp.Location = new System.Drawing.Point(53, 14);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(22, 18);
            this.lblEmp.TabIndex = 2;
            this.lblEmp.Text = "--";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(47, 47);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClose.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(946, 10);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(29, 29);
            this.lblClose.TabIndex = 0;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlMenu.Controls.Add(this.btnPesquisas);
            this.pnlMenu.Controls.Add(this.btnRelatorios);
            this.pnlMenu.Controls.Add(this.btnUser);
            this.pnlMenu.Controls.Add(this.btnAtivacao);
            this.pnlMenu.Controls.Add(this.btnParametros);
            this.pnlMenu.Controls.Add(this.btnFormasPagt);
            this.pnlMenu.Controls.Add(this.btnFornecedores);
            this.pnlMenu.Controls.Add(this.btnClientes);
            this.pnlMenu.Controls.Add(this.btnProdutos);
            this.pnlMenu.Controls.Add(this.btnCategorias);
            this.pnlMenu.Controls.Add(this.btnVendas);
            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 49);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(210, 557);
            this.pnlMenu.TabIndex = 4;
            // 
            // btnPesquisas
            // 
            this.btnPesquisas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPesquisas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPesquisas.FlatAppearance.BorderSize = 0;
            this.btnPesquisas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPesquisas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnPesquisas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisas.ForeColor = System.Drawing.Color.White;
            this.btnPesquisas.Location = new System.Drawing.Point(0, 430);
            this.btnPesquisas.Margin = new System.Windows.Forms.Padding(0);
            this.btnPesquisas.Name = "btnPesquisas";
            this.btnPesquisas.Padding = new System.Windows.Forms.Padding(40, 5, 5, 5);
            this.btnPesquisas.Size = new System.Drawing.Size(210, 43);
            this.btnPesquisas.TabIndex = 19;
            this.btnPesquisas.Text = "Pesquisas";
            this.btnPesquisas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisas.UseVisualStyleBackColor = true;
            this.btnPesquisas.Click += new System.EventHandler(this.btnPesquisas_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelatorios.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRelatorios.FlatAppearance.BorderSize = 0;
            this.btnRelatorios.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnRelatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.ForeColor = System.Drawing.Color.White;
            this.btnRelatorios.Location = new System.Drawing.Point(0, 387);
            this.btnRelatorios.Margin = new System.Windows.Forms.Padding(0);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Padding = new System.Windows.Forms.Padding(40, 5, 5, 5);
            this.btnRelatorios.Size = new System.Drawing.Size(210, 43);
            this.btnRelatorios.TabIndex = 18;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnUser
            // 
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Location = new System.Drawing.Point(0, 344);
            this.btnUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(40, 5, 5, 5);
            this.btnUser.Size = new System.Drawing.Size(210, 43);
            this.btnUser.TabIndex = 17;
            this.btnUser.Text = "Usuários";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.CadUser_Click);
            // 
            // btnAtivacao
            // 
            this.btnAtivacao.BackColor = System.Drawing.Color.Yellow;
            this.btnAtivacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtivacao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAtivacao.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAtivacao.FlatAppearance.BorderSize = 0;
            this.btnAtivacao.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAtivacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnAtivacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtivacao.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtivacao.ForeColor = System.Drawing.Color.Black;
            this.btnAtivacao.Location = new System.Drawing.Point(0, 495);
            this.btnAtivacao.Margin = new System.Windows.Forms.Padding(0);
            this.btnAtivacao.Name = "btnAtivacao";
            this.btnAtivacao.Padding = new System.Windows.Forms.Padding(40, 5, 5, 5);
            this.btnAtivacao.Size = new System.Drawing.Size(210, 62);
            this.btnAtivacao.TabIndex = 16;
            this.btnAtivacao.Text = "Ativação Necessaria!";
            this.btnAtivacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtivacao.UseVisualStyleBackColor = false;
            this.btnAtivacao.Click += new System.EventHandler(this.btnAtivacao_Click);
            // 
            // btnParametros
            // 
            this.btnParametros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParametros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnParametros.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnParametros.FlatAppearance.BorderSize = 0;
            this.btnParametros.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnParametros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnParametros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParametros.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParametros.ForeColor = System.Drawing.Color.White;
            this.btnParametros.Location = new System.Drawing.Point(0, 301);
            this.btnParametros.Margin = new System.Windows.Forms.Padding(0);
            this.btnParametros.Name = "btnParametros";
            this.btnParametros.Padding = new System.Windows.Forms.Padding(40, 5, 5, 5);
            this.btnParametros.Size = new System.Drawing.Size(210, 43);
            this.btnParametros.TabIndex = 15;
            this.btnParametros.Text = "Parametros de Em.";
            this.btnParametros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParametros.UseVisualStyleBackColor = true;
            this.btnParametros.Click += new System.EventHandler(this.btnParametros_Click);
            // 
            // btnFormasPagt
            // 
            this.btnFormasPagt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFormasPagt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFormasPagt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFormasPagt.FlatAppearance.BorderSize = 0;
            this.btnFormasPagt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnFormasPagt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnFormasPagt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormasPagt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormasPagt.ForeColor = System.Drawing.Color.White;
            this.btnFormasPagt.Location = new System.Drawing.Point(0, 258);
            this.btnFormasPagt.Margin = new System.Windows.Forms.Padding(0);
            this.btnFormasPagt.Name = "btnFormasPagt";
            this.btnFormasPagt.Padding = new System.Windows.Forms.Padding(40, 5, 5, 5);
            this.btnFormasPagt.Size = new System.Drawing.Size(210, 43);
            this.btnFormasPagt.TabIndex = 14;
            this.btnFormasPagt.Text = "Formas Pag.";
            this.btnFormasPagt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormasPagt.UseVisualStyleBackColor = true;
            this.btnFormasPagt.Click += new System.EventHandler(this.btnFormasPagt_Click);
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFornecedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFornecedores.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFornecedores.FlatAppearance.BorderSize = 0;
            this.btnFornecedores.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnFornecedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedores.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedores.ForeColor = System.Drawing.Color.White;
            this.btnFornecedores.Location = new System.Drawing.Point(0, 215);
            this.btnFornecedores.Margin = new System.Windows.Forms.Padding(0);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Padding = new System.Windows.Forms.Padding(40, 5, 5, 5);
            this.btnFornecedores.Size = new System.Drawing.Size(210, 43);
            this.btnFornecedores.TabIndex = 13;
            this.btnFornecedores.Text = "Fornecedores";
            this.btnFornecedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFornecedores.UseVisualStyleBackColor = true;
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Location = new System.Drawing.Point(0, 172);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(40, 5, 5, 5);
            this.btnClientes.Size = new System.Drawing.Size(210, 43);
            this.btnClientes.TabIndex = 12;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProdutos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProdutos.FlatAppearance.BorderSize = 0;
            this.btnProdutos.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.ForeColor = System.Drawing.Color.White;
            this.btnProdutos.Location = new System.Drawing.Point(0, 129);
            this.btnProdutos.Margin = new System.Windows.Forms.Padding(0);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Padding = new System.Windows.Forms.Padding(40, 5, 5, 5);
            this.btnProdutos.Size = new System.Drawing.Size(210, 43);
            this.btnProdutos.TabIndex = 11;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategorias.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.Color.White;
            this.btnCategorias.Location = new System.Drawing.Point(0, 86);
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(0);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Padding = new System.Windows.Forms.Padding(40, 5, 5, 5);
            this.btnCategorias.Size = new System.Drawing.Size(210, 43);
            this.btnCategorias.TabIndex = 10;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVendas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVendas.FlatAppearance.BorderSize = 0;
            this.btnVendas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnVendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendas.ForeColor = System.Drawing.Color.White;
            this.btnVendas.Location = new System.Drawing.Point(0, 43);
            this.btnVendas.Margin = new System.Windows.Forms.Padding(0);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Padding = new System.Windows.Forms.Padding(40, 5, 5, 5);
            this.btnVendas.Size = new System.Drawing.Size(210, 43);
            this.btnVendas.TabIndex = 9;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(40, 5, 5, 5);
            this.btnDashboard.Size = new System.Drawing.Size(210, 43);
            this.btnDashboard.TabIndex = 8;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlForms
            // 
            this.pnlForms.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.pnlForms.BackColor = System.Drawing.Color.White;
            this.pnlForms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlForms.Controls.Add(this.lblTituloSerial);
            this.pnlForms.Controls.Add(this.lblData);
            this.pnlForms.Controls.Add(this.lblHora);
            this.pnlForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForms.Location = new System.Drawing.Point(210, 49);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(772, 557);
            this.pnlForms.TabIndex = 5;
            this.pnlForms.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlForms_Paint);
            // 
            // lblTituloSerial
            // 
            this.lblTituloSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloSerial.AutoSize = true;
            this.lblTituloSerial.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSerial.ForeColor = System.Drawing.Color.Red;
            this.lblTituloSerial.Location = new System.Drawing.Point(370, 533);
            this.lblTituloSerial.Name = "lblTituloSerial";
            this.lblTituloSerial.Size = new System.Drawing.Size(281, 23);
            this.lblTituloSerial.TabIndex = 4;
            this.lblTituloSerial.Text = "Data de expiração da serial:";
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.Red;
            this.lblData.Location = new System.Drawing.Point(651, 533);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(28, 23);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "--";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHora.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Red;
            this.lblHora.Location = new System.Drawing.Point(0, 532);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(100, 23);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "DateTime";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 606);
            this.Controls.Add(this.pnlForms);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load_1);
            this.Leave += new System.EventHandler(this.FrmMenu_Leave);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogof)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitle)).EndInit();
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlForms.ResumeLayout(false);
            this.pnlForms.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblMini;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlForms;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbTitle;
        private System.Windows.Forms.Button btnFormasPagt;
        private System.Windows.Forms.Button btnFornecedores;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnParametros;
        public System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnAtivacao;
        private System.Windows.Forms.Label lblTituloSerial;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.PictureBox pictureBoxLogof;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minhaContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        public System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ToolStripMenuItem stripMenuContato;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnPesquisas;
    }
}