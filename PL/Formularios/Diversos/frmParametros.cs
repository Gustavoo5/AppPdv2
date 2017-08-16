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

namespace PL.Formularios.Diversos
{
    public partial class frmParametros : Form
    {
        ParametrosBLL parametrosbll = new ParametrosBLL();
        
        public frmParametros()
        {
            InitializeComponent();
        }

        private void frmParametros_Load(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            btnCancel.Enabled = false;

            List<parametrosINFO> listObj = new List<parametrosINFO>();
            parametrosINFO obj = new parametrosINFO();
            listObj = parametrosbll.SelecionarTodos();
            obj = listObj.Find(p => p.Codigo > 0);

            txtBairro.Text = obj.Bairro;
            txtCep.Text = obj.CEP;
            txtCnpj.Text = obj.CNPJ;
            txtEmailE.Text = obj.Email;
            txtEnd.Text = obj.Endereco;
            txtInscE.Text = obj.Inscr_Estadual;
            txtTel.Text = obj.Telefone;
            txtcont.Text = obj.Contador.ToString();
            txtid.Text = obj.Codigo.ToString();
            dtvalidade.Text = obj.Dt_Validade.ToShortDateString();
            txtRazao.Text = obj.Razão_social;
            if(obj.img != "")
            {
                FotoPictureBox.ImageLocation = obj.img;
                FotoPictureBox.Load();
            }
            else
            {
                FotoPictureBox.Image = PL.Properties.Resources.Wrong;               
            }

        }

        private void lblMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSeleciona_Click(object sender, EventArgs e)
        {
         if(SelecionaOpenFileDialog.ShowDialog() == DialogResult.OK)
            {                
                FotoPictureBox.ImageLocation = SelecionaOpenFileDialog.FileName;
                FotoPictureBox.Load();
                txtNomeImagem.Text = SelecionaOpenFileDialog.FileName;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            btnSeleciona.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancel.Enabled = false;
            btnAlt.Enabled = true;

            btnAlt.Enabled = true;
            txtBairro.Enabled = false;
            txtCep.Enabled = false;
            txtCnpj.Enabled = false;
            txtEmailE.Enabled = false;
            txtEnd.Enabled = false;
            txtInscE.Enabled = false;
            txtTel.Enabled = false;

            parametrosINFO parametros = new parametrosINFO();
            parametros.Bairro = txtBairro.Text;
            parametros.CEP = txtCep.Text;
            parametros.CNPJ = txtCnpj.Text;
            parametros.Email = txtEmailE.Text;
            parametros.Endereco = txtEnd.Text;
            parametros.Inscr_Estadual = txtInscE.Text;
            parametros.Telefone = txtTel.Text;
            parametros.Razão_social = txtRazao.Text;
            parametros.Dt_Validade = Convert.ToDateTime(dtvalidade.Text);
            parametros.Contador = Convert.ToInt32(txtcont.Text);
            parametros.Codigo = Convert.ToInt32(txtid.Text);
            parametros.img = txtNomeImagem.Text;

            parametrosbll.Salvar(parametros);
            
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            btnSeleciona.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancel.Enabled = true;
            btnAlt.Enabled = false;
            txtBairro.Enabled = true;
            txtCep.Enabled = true;
            txtCnpj.Enabled = true;
            txtEmailE.Enabled = true;
            txtEnd.Enabled = true;
            txtInscE.Enabled = true;
            txtTel.Enabled = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSeleciona.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancel.Enabled = false;

            btnAlt.Enabled = true;
            txtBairro.Enabled = false;
            txtCep.Enabled = false;
            txtCnpj.Enabled = false;
            txtEmailE.Enabled = false;
            txtEnd.Enabled = false;
            txtInscE.Enabled = false;
            txtTel.Enabled = false;

            List<parametrosINFO> listObj = new List<parametrosINFO>();
            parametrosINFO obj = new parametrosINFO();
            listObj = parametrosbll.SelecionarTodos();
            obj = listObj.Find(p => p.Codigo > 0);
          
            FotoPictureBox.ImageLocation = obj.img;
        }

        private void lblClose_Click_1(object sender, EventArgs e)
        {        
            Close();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRazao_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
