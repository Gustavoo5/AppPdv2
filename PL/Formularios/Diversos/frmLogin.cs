using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ORM.AppPdv2.BLL;
using ORM.AppPdv2.INFO;


namespace PL
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();          
        }

        List<UsuarioINFO> listUser = new List<UsuarioINFO>();
        UsuarioINFO obj = new UsuarioINFO();
        usuarioBLL usuariobll = new usuarioBLL();

        parametrosINFO parametroinfo = new parametrosINFO();
        ParametrosBLL parametrosbll = new ParametrosBLL();
        List<parametrosINFO> listObj = new List<parametrosINFO>();

        private void BtnOk_Click(object sender, EventArgs e)
        {
            obj = listUser.Find(p => p.LoginUser == cmbUsuario.Text && p.Senha == txtSenha.Text);
            if(obj != null)
            {
                MessageBox.Show("Bem-vindo " + obj.NomeUser, "Boas Vindas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmMenu frmmenu = new FrmMenu();
                Hide();
                frmmenu.objUser = obj;
                frmmenu.objParam = parametroinfo;
                frmmenu.ShowDialog();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Login ou Senha incorreto." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);               
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            VerificacaoEmp();
            RetornaTable();
          
            UsuariosNoCmb();
        }
      
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void RetornaTable ()
        {
            listUser = usuariobll.RetornaTable();
        }

        private void TmrBox_Tick(object sender, EventArgs e)
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void VerificacaoEmp()
        {
            listObj = parametrosbll.SelecionarTodos();
            parametroinfo = listObj.Find(p => p.Codigo > 0);

            if(parametroinfo != null)
            {
                lblCliente.Text = parametroinfo.Razão_social;
                lblCidade.Text = parametroinfo.CEP;
            }
            else
            {
                MessageBox.Show("Você não é proprietario dessa lincença. \nEntre em contato : 16 99318-7409", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    SendKeys.Send((e.Shift ? "+" : "") + "{TAB}");
                    break;
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
        private void UsuariosNoCmb()
        {        
            cmbUsuario.DataSource = listUser;     
            cmbUsuario.DisplayMember = "LoginUser";
            cmbUsuario.ValueMember = "IdUser";
        }
    }
}
