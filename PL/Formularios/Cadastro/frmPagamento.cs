using ORM.AppPdv2.DAL;
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
    public partial class frmPagamento : frmBase
    {
        public frmPagamento()
        {
            InitializeComponent();
        }

        pagamentoINFO Obj = new pagamentoINFO();

        List<pagamentoINFO> ListObj = new List<pagamentoINFO>();

        pagamentoDAL PagamentoDal = new pagamentoDAL();

        public override void FrmBase_Load(object sender, EventArgs e)
        {
            RetornaTodos();
            cmbPesq.SelectedIndex = 0;
            base.FrmBase_Load(sender, e);
        }

        public override void BtnAlt_Click(object sender, EventArgs e)
        {
            if(TxtId.Text == "")
            {
                MessageBox.Show("Selecione um registro.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Deletar();
            base.BtnDel_Click(sender, e);
        }

        public override void BtnNovo_Click(object sender, EventArgs e)
        {
            LimparForm();
            base.BtnNovo_Click(sender, e);
            TxtDesc.Focus();
        }

        public override void BtnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
            RetornaTodos();
            base.BtnSalvar_Click(sender, e);
        }

        public override void BtnPesq_Click(object sender, EventArgs e)
        {
            Filtro();
            base.BtnPesq_Click(sender, e);
        }

        private void RetornaTodos ()
        {
            ListObj = PagamentoDal.RetornaTable();
            gridPesq.DataSource = ListObj;
        }

        private void gridPesq_Click(object sender, EventArgs e)
        {
            if(gridPesq.Rows.Count > 0)
            {
                Obj = (pagamentoINFO)gridPesq.SelectedRows[0].DataBoundItem;
                TxtId.Text = Obj.IdFormPag.ToString();
                TxtDesc.Text = Obj.DescPag;
            }
        }

        private void Salvar ()
        {           
            if (TxtId.Text == "") Obj.IdFormPag = 0; else Obj.IdFormPag = Convert.ToInt16(TxtId.Text);
            Obj.DescPag = TxtDesc.Text;
            PagamentoDal.Salvar(Obj);           
        }

        private void Deletar ()
        {
            if (MessageBox.Show("Confirma exclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                PagamentoDal.Delete(Obj);
                RetornaTodos();
                LimparForm();
            }
        }

        private void LimparForm()
        {
            TxtId.Clear(); TxtDesc.Clear();
        }

        private void Filtro()
        {
            if (cmbPesq.Text == "ALL")
            {
                gridPesq.DataSource = ListObj;
            }

            if (cmbPesq.Text == "ID")
            {
                gridPesq.DataSource = ListObj.FindAll(p => p.IdFormPag == Convert.ToInt16(txtPesq.Text));
            }

            if (cmbPesq.Text == "DESCRIÇÃO")
            {
                gridPesq.DataSource = ListObj.FindAll(p => p.DescPag == txtPesq.Text);
            }
        }

        private void frmPagamento_Load(object sender, EventArgs e)
        {

        }

        private void groupDados_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
