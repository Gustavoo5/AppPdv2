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
    public partial class frmFornecedor : frmBase
    {
        public frmFornecedor()
        {
            InitializeComponent();
        }

        List<FornecedorINFO> listObj = new List<FornecedorINFO>();
        FornecedorINFO obj = new FornecedorINFO();

        fornecedorBLL fornecedorbll = new fornecedorBLL();

        public override void FrmBase_Load(object sender, EventArgs e)
        {
            RetornaTable();
            cmbUF.SelectedIndex = 25;
            cmbPesq.SelectedIndex = 0;
            base.FrmBase_Load(sender, e);
        }

        public override void BtnAlt_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
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
            LimparForm();
            base.BtnDel_Click(sender, e);
        }

        public override void BtnNovo_Click(object sender, EventArgs e)
        {
            LimparForm();
            base.BtnNovo_Click(sender, e);
            txtRazao.Focus();
        }

        public override void BtnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
            
            base.BtnSalvar_Click(sender, e);
        }

        public override void BtnPesq_Click(object sender, EventArgs e)
        {
            Filtro();
            base.BtnPesq_Click(sender, e);
        }

        private void GridPesq_Click(object sender, EventArgs e)
        {
            RetornaForm();
        }

        //METODOS

        private void RetornaTable()
        {
            listObj = fornecedorbll.RetornaTable();
            gridPesq.DataSource = listObj;
        }

        private void Salvar()
        {
            if (txtRazao.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Campo Razão Social não pode ficar em branco.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRazao.Focus();
                return;
            }

            if (txtEnd.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Campo endereço não pode ficar em branco.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEnd.Focus();
                return;
            }

            if (txtBairro.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Campo bairro não pode ficar em branco.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBairro.Focus();
                return;
            }

            if (txtCep.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Campo CEP não pode ficar em branco.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCep.Focus();
                return;
            }

            if (txtCidade.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Campo cidade não pode ficar em branco.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCidade.Focus();
                return;
            }

            else
            {
                obj = new FornecedorINFO();
                if (txtid.Text == "") obj.IdForn = 0; else obj.IdForn = Convert.ToInt16(txtid.Text);
                obj.AgenciaForn = txtAg.Text;
                obj.BairroForn = txtBairro.Text;
                obj.BancoForn = txtBanco.Text;
                obj.CargoForn = txtCargo.Text;
                obj.CepForn = txtCep.Text;
                obj.CidadeForn = txtCidade.Text;
                obj.CnpjForn = txtCnpj.Text;
                obj.ContaCorrForn = txtContaC.Text;
                obj.CpfForn = txtCpf.Text;
                obj.EmailEmpForn = txtEmailE.Text;
                obj.EmailForn = txtEmailC.Text;
                obj.EndForn = txtEnd.Text;
                obj.FaxEmpForn = txtFax.Text;
                obj.InscEstadualForn = txtInscE.Text;
                obj.InscMunicipalForn = txtInscM.Text;
                obj.Nome_fantasia = txtNomeF.Text;
                obj.NomeContForn = txtNomeC.Text;
                obj.Razao_social = txtRazao.Text;
                obj.SiteEmpForn = txtSEmp.Text;
                obj.TelEmpForn = txtTel.Text;
                obj.TelForn = txtTelC.Text;
                obj.UfForn = cmbUF.Text;
                fornecedorbll.Salvar(obj);
                RetornaTable();
            }
        }

        private void LimparForm()
        {
            txtAg.Clear(); txtBairro.Clear(); txtBanco.Clear(); txtCargo.Clear(); txtCep.Clear(); txtCidade.Clear(); txtCnpj.Clear(); txtContaC.Clear();
            txtCpf.Clear(); txtEmailC.Clear(); txtEmailE.Clear(); txtEnd.Clear(); txtFax.Clear(); txtid.Clear(); txtInscE.Clear(); txtInscM.Clear(); txtNomeC.Clear();
            txtNomeF.Clear(); txtRazao.Clear(); txtSEmp.Clear(); txtTel.Clear(); txtTelC.Clear();
        }

        private void Delete()
        {
            if (txtid.Text == "" && obj == null)
            {
                MessageBox.Show("Selecione um registro para ser deletado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Confirma Exclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    fornecedorbll.Delete(obj);
                    RetornaTable();
                }
            }
        }

        private void RetornaForm()
        {
            if (gridPesq.Rows.Count > 0)
            {
                obj = (FornecedorINFO)gridPesq.SelectedRows[0].DataBoundItem;
                txtAg.Text = obj.AgenciaForn;
                txtBairro.Text = obj.BairroForn;
                txtBanco.Text = obj.BancoForn;
                txtCargo.Text = obj.CargoForn;
                txtCep.Text = obj.CepForn;
                txtCidade.Text = obj.CidadeForn;
                txtCnpj.Text = obj.CnpjForn;
                txtContaC.Text = obj.ContaCorrForn;
                txtCpf.Text = obj.CpfForn;
                txtEmailC.Text = obj.EmailForn;
                txtEmailE.Text = obj.EmailEmpForn;
                txtEnd.Text = obj.EndForn;
                txtFax.Text = obj.FaxEmpForn;
                txtid.Text = obj.IdForn.ToString();
                txtInscE.Text = obj.InscEstadualForn;
                txtInscM.Text = obj.InscMunicipalForn;
                txtNomeC.Text = obj.NomeContForn;
                txtNomeF.Text = obj.Nome_fantasia;
                txtRazao.Text = obj.Razao_social;
                txtSEmp.Text = obj.SiteEmpForn;
                txtTel.Text = obj.TelEmpForn;
                txtTelC.Text = obj.TelForn;
                cmbUF.SelectedText = obj.UfForn;
            }
        }

        private void Filtro()
        {
            if (cmbPesq.Text == "ALL")
            {
                gridPesq.DataSource = listObj;
            }

            if (cmbPesq.Text == "ID")
            {
                gridPesq.DataSource = listObj.FindAll(p => p.IdForn == Convert.ToInt16(txtPesq.Text));
            }

            if (cmbPesq.Text == "NOME FANTASIA")
            {
                gridPesq.DataSource = listObj.FindAll(p => p.Nome_fantasia == txtPesq.Text);
            }
        }

    }
}
