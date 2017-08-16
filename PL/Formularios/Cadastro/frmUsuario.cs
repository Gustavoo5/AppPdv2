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
    public partial class FrmUsuario : frmBase
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        List<UsuarioINFO> listObj = new List<UsuarioINFO>();

        UsuarioINFO obj = new UsuarioINFO();

        usuarioBLL usuariobll = new usuarioBLL();


        public override void FrmBase_Load(object sender, EventArgs e)
        {
            RetornaTable();
            cmbAcesso.SelectedIndex = 1;
            cmbPesq.SelectedIndex = 0;
            base.FrmBase_Load(sender, e);
        }

        public override void BtnAlt_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Selecione um registro para ser Alterado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            btnSeleciona.Enabled = true;
            base.BtnAlt_Click(sender, e);
        }

        public override void BtnCancel_Click(object sender, EventArgs e)
        {
            base.BtnCancel_Click(sender, e);
        }

        public override void BtnDel_Click(object sender, EventArgs e)
        {
            Delete();
            base.BtnDel_Click(sender, e);
        }

        public override void BtnNovo_Click(object sender, EventArgs e)
        {
            LimparForm();
            btnSeleciona.Enabled = true;
            base.BtnNovo_Click(sender, e);
            txtNome.Focus();
        }

        public override void BtnPesq_Click(object sender, EventArgs e)
        {
            Filtro();
            base.BtnPesq_Click(sender, e);
        }

        public override void BtnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
            
            base.BtnSalvar_Click(sender, e);
        }

        private void GridPesq_Click(object sender, EventArgs e)
        {
            RetornaForm();
        }

        private void RetornaTable ()
        {
            listObj = usuariobll.RetornaTable();
            gridPesq.DataSource = listObj;
        }

        private void RetornaForm()
        {
            if(gridPesq.Rows.Count > 0)
            {
                obj = (UsuarioINFO)gridPesq.SelectedRows[0].DataBoundItem;
                txtId.Text = obj.IdUser.ToString();
                txtLogin.Text = obj.LoginUser;
                txtNome.Text = obj.NomeUser;
                txtSenha.Text = obj.Senha;
                cmbAcesso.SelectedIndex = obj.AcessoUser;
                txtNomeDaUrl.Text = obj.img;
                if(obj.img != "")
                {
                    pbFoto.ImageLocation = obj.img;
                    pbFoto.Load();
                }
                else
                {
                    pbFoto.Image = PL.Properties.Resources.User_Login;
                }
            }
        }

        private void Salvar ()
        {
            if (txtNome.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Campo Nome não pode ficar em branco.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }

            if (txtLogin.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Campo Login não pode ficar em branco.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLogin.Focus();
                return;
            }
            else
            {
                obj = new UsuarioINFO();
                if (txtId.Text == "") obj.IdUser = 0; else obj.IdUser = Convert.ToInt16(txtId.Text);
                obj.AcessoUser = cmbAcesso.SelectedIndex;
                obj.LoginUser = txtLogin.Text;
                obj.NomeUser = txtNome.Text;
                obj.Senha = txtSenha.Text;
                obj.img = txtNomeDaUrl.Text;               

                usuariobll.Salvar(obj);
                RetornaTable();
            }
        }

        private void Delete ()
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Selecione um registro para ser deletado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Confirma Exclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    usuariobll.Delete(obj);
                    RetornaTable();
                    LimparForm();
                }
            }
        }

        private void LimparForm()
        {
            txtId.Clear(); txtLogin.Clear(); txtNome.Clear(); txtSenha.Clear();
        }

        private void Filtro()
        {
            if (cmbPesq.Text == "ALL")
            {
                gridPesq.DataSource = listObj;
            }

            if (cmbPesq.Text == "ID")
            {
                gridPesq.DataSource = listObj.FindAll(p => p.IdUser == Convert.ToInt16(txtPesq.Text));
            }

            if (cmbPesq.Text == "NOME")
            {
                gridPesq.DataSource = listObj.FindAll(p => p.NomeUser == txtPesq.Text);
            }
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void ChkMSenha_CheckedChanged(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleciona_Click(object sender, EventArgs e)
        {
            if (SelecionaOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbFoto.ImageLocation = SelecionaOpenFileDialog.FileName;
                pbFoto.Load();
                txtNomeDaUrl.Text = SelecionaOpenFileDialog.FileName;
            }
            
        }

        private void gridPesq_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void groupDados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNomeDaUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

   
    }
}
