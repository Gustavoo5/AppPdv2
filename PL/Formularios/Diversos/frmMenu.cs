using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PL.Formularios.Diversos;
using ORM.AppPdv2.INFO;
using ORM.AppPdv2.BLL;

namespace PL
{
    public partial class FrmMenu : Form
    {
        ParametrosBLL parametrosbll = new ParametrosBLL();
        public AtivacaoINFO obj = new AtivacaoINFO();
        public AtivacaoBLL ativacaobll = new AtivacaoBLL();

        public UsuarioINFO objUser = new UsuarioINFO();
        public parametrosINFO objParam = new parametrosINFO();

        public FrmMenu()
        {
            InitializeComponent();
        }
        Form objForm;

        private void Tmr_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }

        private void FrmMenu_Leave(object sender, EventArgs e)
        {
            
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void menuS_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void tsmCadastro_MouseHover(object sender, EventArgs e)
        {

        }
        private void pbLogo_Click(object sender, EventArgs e)
        {
            if(objForm != null)
            {
                objForm.Close();
                lblTitle.Text = "Dashboard";
                pbTitle.BackgroundImage = PL.Properties.Resources.House_08;
               // LblsMenu(true);
            }
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {

            if (objForm != null) objForm.Close();
            objForm = new Formularios.Diversos.frmVenda
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                ObjUserSistema = objUser,
                objParametros = objParam
            };
            LblsMenu(false);
            objForm.Show();
            pnlForms.Controls.Add(objForm);
            pbTitle.BackgroundImage = PL.Properties.Resources.Shopping_Add;
            lblTitle.Text = "Vendas";
            
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            if (objForm != null) objForm.Close();
            objForm = new frmCategoria
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
            };
            LblsMenu(false);
            objForm.Show();
            pnlForms.Controls.Add(objForm);
            pbTitle.BackgroundImage = PL.Properties.Resources.Atv_list;
            lblTitle.Text = "Cadastro de Categorias";          
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            if (objForm != null) objForm.Close();
            objForm = new frmProdutos
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
            };
            LblsMenu(false);
            objForm.Show();
            pnlForms.Controls.Add(objForm);
            pbTitle.BackgroundImage = PL.Properties.Resources.Product_Box;
            lblTitle.Text = "Cadastro de Produtos";
            
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (objForm != null) objForm.Close();
            objForm = new frmCliente
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
            };
            LblsMenu(false);
            objForm.Show();
            pnlForms.Controls.Add(objForm);
            pbTitle.BackgroundImage = PL.Properties.Resources.People_Titulo;
            lblTitle.Text = "Cadastro de Cliente";
            
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            if (objForm != null) objForm.Close();
            objForm = new frmFornecedor
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
            };
            LblsMenu(false);
            objForm.Show();
            pnlForms.Controls.Add(objForm);
            pbTitle.BackgroundImage = PL.Properties.Resources.Business_Man_Add_01;
            lblTitle.Text = "Cadastro de Fornecedor";
            
        }

        private void btnFormasPagt_Click(object sender, EventArgs e)
        {
            if (objUser.AcessoUser == 0)
            {
                if (objForm != null) objForm.Close();
                objForm = new Formularios.Cadastro.frmPagamento
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                };
                LblsMenu(false);
                objForm.Show();
                pnlForms.Controls.Add(objForm);
                pbTitle.BackgroundImage = PL.Properties.Resources.Money_Credit_Card;
                lblTitle.Text = "Cadastro de Pagamentos";
            }
            else
            {
                MessageBox.Show("Permissão invalida!\nSomente Administradores.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnParametros_Click(object sender, EventArgs e)
        {
            if (objUser.AcessoUser == 0)
            {
                frmParametros parametros = new frmParametros();
                parametros.ShowDialog();

                List<parametrosINFO> listObj = new List<parametrosINFO>();
                parametrosINFO obj = new parametrosINFO();
                listObj = parametrosbll.SelecionarTodos();
                obj = listObj.Find(p => p.Codigo > 0);

                pbLogo.ImageLocation = obj.img;
            }
            else
            {
                MessageBox.Show("Permissão invalida!\nSomente Administradores.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
          
        }

        private void RetornarDataExpiracao ()
        {
            List<AtivacaoINFO> list = new List<AtivacaoINFO>();
            AtivacaoINFO Obj = new AtivacaoINFO();
            list = ativacaobll.SelecionarTodos();
            Obj = list.Find(p => p.Ativo == true);
            if (Obj != null)
            {
                lblData.Text = Obj.DiaDaExpiracao.ToShortDateString();
            }
        }

        private void RetornarImgMenu()
        {
            frmInformacaoDoUsuario FIDU = new frmInformacaoDoUsuario();
            picbox.Image = FIDU.picbox.Image;

            if (objParam.img != "")
            {
                pbLogo.ImageLocation = objParam.img;
                lblEmp.Text = objParam.Razão_social;
                
            }
            else
            {
                pbLogo.Image = PL.Properties.Resources.Wrong;
                lblEmp.Text = objParam.Razão_social;
            }
        }

        private void FrmMenu_Load_1(object sender, EventArgs e)
        {
            BtnsVisibleUser();
            RetornarImgMenu();                            
            Ativar();
            RetornarDataExpiracao();
            ImgPerfil();
        }

        private void ImgPerfil()
        {
            if (objUser.img == "") picbox.Image = PL.Properties.Resources.User_Login; else picbox.ImageLocation = objUser.img;
            lblNome.Text = objUser.NomeUser;
        }
   
        private void Ativar()
        {
          List<AtivacaoINFO> listObj = new List<AtivacaoINFO>();

             listObj = ativacaobll.SelecionarTodos();
            obj = listObj.Find(p => p.Ativo == true);
            if (obj == null)
            {
                if (MessageBox.Show("Uma nova Licença obrigatória, Deseja Inseri-la?", "Atenção",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmAtivacao fm = new frmAtivacao();
                    fm.obj = obj;
                    fm.ShowDialog();
                     if (fm.Cont == 2)
                    {
                        btnAtivacao.Visible = false;
                    }
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {                
                AtivacaoINFO DATA = new AtivacaoINFO();
                AtivacaoINFO Alterar = new AtivacaoINFO();

                if (DateTime.Now >= obj.DiaDaExpiracao)
                {

                    if (obj.Contador <= 5)
                    {
                        MessageBox.Show("Atenção o sistema poderar ser executado até 5 vezes:" + " " + obj.Contador + ". " + "Registre uma nova serial.", "Atenção");

                        obj.Contador++;
                        ativacaobll.AlterarContador(obj);
                    }

                    else
                    {
                        MessageBox.Show("Você poderá acessar-lo apenas se inserir uma nova serial de validação!", "Atenção");

                        frmAtivacao fm = new frmAtivacao();
                        fm.obj = obj;
                        fm.ShowDialog();                       

                        if (fm.Cont == 2)
                        {
                            btnAtivacao.Visible = false;
                        }
                        else
                        {
                            Application.Exit();
                        }
                    }

                }
                else
                {
                    btnAtivacao.Visible = false;
                }

            }
        }
    
        private void btnAtivacao_Click(object sender, EventArgs e)
        {
            frmAtivacao fm = new frmAtivacao();
            fm.obj = obj;
            fm.ShowDialog();

            if (fm.Cont == 2)
            {
                btnAtivacao.Visible = false;
            }
        }

        private void LblsMenu (bool status)
        {
          lblHora.Visible = status;       
          lblData.Visible = status;
          lblTituloSerial.Visible = status;     
        }

        private void CadUser_Click(object sender, EventArgs e)
        {
            if (objUser.AcessoUser == 0)
            {
                if (objForm != null) objForm.Close();
                objForm = new FrmUsuario
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                };
                LblsMenu(false);
                objForm.Show();
                pnlForms.Controls.Add(objForm);
                //pbTitle.BackgroundImage = PL.Properties.Resources.User_Add;
                lblTitle.Text = "Cadastro de Usuários";
            }
            else
            {
                MessageBox.Show("Permissão invalida!\nSomente Administradores.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void BtnsVisibleUser ()
        {
            if(objUser.AcessoUser != 0)
            {
                btnFormasPagt.Visible = false;
                btnParametros.Visible = false;
                btnUser.Visible = false;
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (objForm != null) objForm.Close();
            objForm = new frmCliente
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
            };
            LblsMenu(false);
            objForm.Show();
            pnlForms.Controls.Add(objForm);
            lblTitle.Text = "Cadastro de Cliente";
        }

        private void lblCliente_Click(object sender, EventArgs e)
        {

        }

        private void Cliente()
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblAdc_Click(object sender, EventArgs e)
        {

        }

        private void gridPesq_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if(objUser.AcessoUser == 1)
            {
                if (objForm != null) objForm.Close();
                objForm = new Formularios.Diversos.frmDashboardUserComum
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                    objUser = objUser
                };
                LblsMenu(false);
                objForm.Show();
                pnlForms.Controls.Add(objForm);
                pbTitle.BackgroundImage = PL.Properties.Resources.Noticias;
                lblTitle.Text = "Dashboard";
            }
            else
            {              
                    if (objForm != null) objForm.Close();
                    objForm = new Formularios.Diversos.frmDashboardUserAdm
                    {
                        TopLevel = false,
                        Dock = DockStyle.Fill,                      
                    };
                    LblsMenu(false);
                    objForm.Show();
                    pnlForms.Controls.Add(objForm);
                    pbTitle.BackgroundImage = PL.Properties.Resources.Noticias;
                    lblTitle.Text = "Dashboard";
                }
        }

        private void pictureBoxLogof_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            Hide();
            login.ShowDialog();
            Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void pnlForms_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void minhaContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformacaoDoUsuario frmInfoUser = new frmInformacaoDoUsuario();
    
            frmInfoUser.objUser = objUser;          
            frmInfoUser.ShowDialog();

            if (frmInfoUser.objUser.img != null)
            {
                picbox.ImageLocation = frmInfoUser.objUser.img;
            }

            LblsMenu(false);                    
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre Fs = new frmSobre();
            Fs.ShowDialog();
        }

        private void stripMenuContato_Click(object sender, EventArgs e)
        {
            frmContato contato = new frmContato();
            contato.obj = objParam;
            contato.ShowDialog();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            if (objForm != null) objForm.Close();
            objForm = new frmRelatorios
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
            };
            LblsMenu(false);
            objForm.Show();
            pnlForms.Controls.Add(objForm);
            lblTitle.Text = "Relatórios";
        }

        private void btnPesquisas_Click(object sender, EventArgs e)
        {
            if (objForm != null) objForm.Close();
            objForm = new frmPesquisas
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
            };
            LblsMenu(false);
            objForm.Show();
            pnlForms.Controls.Add(objForm);
            lblTitle.Text = "Pesquisas";
        }
    }
}
