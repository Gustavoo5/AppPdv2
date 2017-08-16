using ORM.AppPdv2.BLL;
using ORM.AppPdv2.INFO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Formularios.Cadastro
{
    public partial class frmCadClienteRapido : Form
    {
        public frmCadClienteRapido()
        {
            InitializeComponent();
        }

        List<ClienteINFO> listObj = new List<ClienteINFO>();

        clienteBLL clientebll = new clienteBLL();

        public ClienteINFO obj = new ClienteINFO();

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void RetornaTable()
        {
            listObj = clientebll.RetornaTable();
        }

        private void Salvar()
        {
            if (txtNome.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Campo Nome não pode ficar em branco.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }

            else if (txtEnd.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Campo endereço não pode ficar em branco.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEnd.Focus();
                return;
            }

            else if (txtBairro.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Campo bairro não pode ficar em branco.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBairro.Focus();
                return;
            }


            else if (txtCidade.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Campo cidade não pode ficar em branco.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCidade.Focus();
                return;
            }
            else if (txtNumero.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Campo numero não pode ficar em branco.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumero.Focus();
                return;
            }
            else
            {
                obj = new ClienteINFO();           
                obj.BairroClie = txtBairro.Text;
                obj.CidadeClie = txtCidade.Text;
                obj.EndClie = txtEnd.Text;
                obj.NomeClie = txtNome.Text;
                obj.telNumero = txtNumero.Text;
                obj.DataCadastro = DateTime.Now.Date;
                clientebll.InserirRetornoId(obj);
            }
        }

        private void frmCadClienteRapido_Load(object sender, EventArgs e)
        {
            RetornaTable();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            obj = listObj.Find(p => p.telNumero == txtNumero.Text);
            if(obj == null)
            {
                Salvar();               
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
