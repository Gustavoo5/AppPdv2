using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ORM.AppPdv2.INFO;
using ORM.AppPdv2.BLL;

namespace PL.Formularios.Diversos
{
    public partial class frmInformacaoDoUsuario : Form
    {

    
        usuarioBLL usuariobll = new usuarioBLL();
        List<UsuarioINFO> listUsuario = new List<UsuarioINFO>();

        public frmInformacaoDoUsuario()
        {
            InitializeComponent();
        }
        public UsuarioINFO objUser = new UsuarioINFO();
        private void picbox_Click(object sender, EventArgs e)
        {

        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            EnableBtnsTrue();
        }
        private void EnableBtnsFalse()
        {
            btnSalvar.Enabled = false;
            btnCancel.Enabled = false;
            btnAlt.Enabled = true;
            btnSelecionar.Enabled = false;
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            txtLogin.Enabled = false;
        }
        private void EnableBtnsTrue()
        {
            btnSalvar.Enabled = true;
            btnCancel.Enabled = true;
            btnAlt.Enabled = false;
            btnSelecionar.Enabled = true;
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
            txtLogin.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnableBtnsFalse();
            usuarioLogado();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvar();
            if(txtLogin.Text != "" && txtNome.Text != "" && txtSenha.Text != "") EnableBtnsFalse();         
        }

        private void frmInformacaoDoUsuario_Load(object sender, EventArgs e)
        {
            usuarioLogado();
        }
        private void usuarioLogado()
        {
            txtId.Text = objUser.IdUser.ToString();
            txtLogin.Text = objUser.LoginUser;
            txtNome.Text = objUser.NomeUser;
            txtSenha.Text = objUser.Senha;
            cmbAcesso.SelectedIndex = objUser.AcessoUser;
            if (objUser.img == "") picbox.Image = PL.Properties.Resources.User_Login; else picbox.ImageLocation = objUser.img;           
        }
        private void salvar()
        {          
                if (txtLogin.Text == "") { MessageBox.Show("O campo Login não pode ficar em branco.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                if (txtNome.Text == "") { MessageBox.Show("O campo Nome não pode ficar em branco.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                if (txtSenha.Text == "") { MessageBox.Show("O campo Senha não pode ficar em branco.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }

                objUser.IdUser = Convert.ToInt32(txtId.Text);
                objUser.LoginUser = txtLogin.Text;
                objUser.NomeUser = txtNome.Text;
                objUser.Senha = txtSenha.Text;
                objUser.AcessoUser = cmbAcesso.SelectedIndex;
                objUser.img = txtImg.Text;
                usuariobll.Salvar(objUser);         
        }

        private void lblClose_Click(object sender, EventArgs e)
        {        
            Close();
        }

        private void lblMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            BuscarImg();
        }
        private void BuscarImg()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picbox.ImageLocation = openFileDialog1.FileName;
                picbox.Load();
                txtImg.Text = openFileDialog1.FileName;
            }
        }

        private void chkMSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMSenha.Checked == true)
            {
                txtSenha.PasswordChar = '\u0000';
            }
            else
            {
                txtSenha.PasswordChar = '*';
            }
        }
    }
}
