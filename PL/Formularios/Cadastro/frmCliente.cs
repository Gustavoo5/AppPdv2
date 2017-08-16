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

namespace PL
{
    public partial class frmCliente : frmBase
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        List<ClienteINFO> listObj = new List<ClienteINFO>();

        clienteBLL clientebll = new clienteBLL();

        ClienteINFO obj = new ClienteINFO();

        //trazer todas vendas para sabermos se o usuario pode ser excluido

        public override void FrmBase_Load(object sender, EventArgs e)
        {
            RetornaTable();
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
            listObj = clientebll.RetornaTable();
            gridPesq.DataSource = listObj;
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
            else if(txtNumero.Text.Replace(" ","") == "")
            {
                MessageBox.Show("Campo numero não pode ficar em branco.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumero.Focus();
                return;
            }
            else
            {
                obj = new ClienteINFO();
                if (txtId.Text == "") obj.IdClie = 0; else obj.IdClie = Convert.ToInt16(txtId.Text);
                obj.BairroClie = txtBairro.Text;
                obj.CidadeClie = txtCidade.Text;
                obj.CpfClie = txtCpf.Text;
                obj.EndClie = txtEnd.Text;
                obj.NomeClie = txtNome.Text;
                obj.ObsClie = txtObs.Text;
                obj.telNumero = txtNumero.Text;
                obj.DataCadastro = DateTime.Now.Date;
                
                clientebll.Salvar(obj);
                RetornaTable();
            }
        }

        private void RetornaForm ()
        {
            if(gridPesq.Rows.Count > 0)
            {
                obj = (ClienteINFO)gridPesq.SelectedRows[0].DataBoundItem;
                txtBairro.Text = obj.BairroClie;
                txtCidade.Text = obj.CidadeClie;
                txtCpf.Text = obj.CpfClie;
                txtEnd.Text = obj.EndClie;
                txtId.Text = obj.IdClie.ToString();
                txtNome.Text = obj.NomeClie;
                txtObs.Text = obj.ObsClie;
                txtNumero.Text = obj.telNumero;
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
                    clientebll.Delete(obj);
                    RetornaTable();
                    LimparForm();
                }
            }
        }

        private void LimparForm ()
        {
            txtBairro.Clear();txtCpf.Clear();
            txtEnd.Clear(); txtId.Clear(); txtNome.Clear(); txtObs.Clear(); txtPesq.Clear(); txtNumero.Clear();
        }

        private void Filtro()
        {
            if (cmbPesq.Text == "ALL")
            {
                gridPesq.DataSource = listObj;
            }

            if (cmbPesq.Text == "ID")
            {
                //gridPesq.DataSource = listObj.FindAll(p => p.IdClie == Convert.ToInt16(txtPesq.Text));
            }

            if (cmbPesq.Text == "NOME")
            {
                gridPesq.DataSource = listObj.FindAll(p => p.NomeClie == txtPesq.Text);
            }
        }

    }
}
