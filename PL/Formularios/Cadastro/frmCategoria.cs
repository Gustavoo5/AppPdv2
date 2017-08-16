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
    public partial class frmCategoria : frmBase
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        List<CategoriasINFO> listObj = new List<CategoriasINFO>();
        CategoriasINFO obj = new CategoriasINFO();
        categoriasBLL categoriabll = new categoriasBLL();

        public override void FrmBase_Load(object sender, System.EventArgs e)
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
            Deletar();
            RetornaTable();
            base.BtnDel_Click(sender, e);
        }

        public override void BtnNovo_Click(object sender, EventArgs e)
        {
            LimparForm();
            txtData.Text = DateTime.Now.ToString();
            base.BtnNovo_Click(sender, e);
            txtDesc.Focus();
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
            listObj = categoriabll.RetornaTable();
            gridPesq.DataSource = listObj;
        }

        private void RetornaForm()
        {
            obj = null;
            if (gridPesq.Rows.Count > 0)
            {
                obj = (CategoriasINFO)gridPesq.SelectedRows[0].DataBoundItem;
                txtData.Text = obj.DataCateg.ToString();
                txtDesc.Text = obj.DescCateg;
                txtId.Text = obj.IdCateg.ToString();
            }
        }

        private void Salvar()
        {
            if (txtDesc.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Campo descrição não pode ficar em branco.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDesc.Focus();
                return;
            }

            else
            {
                obj = new CategoriasINFO();
                if (txtId.Text == "") obj.IdCateg = 0; else obj.IdCateg = Convert.ToInt16(txtId.Text);
                obj.DataCateg = Convert.ToDateTime(txtData.Text);
                obj.DescCateg = txtDesc.Text;
                categoriabll.Salvar(obj);
                RetornaTable();
            }
        }

        private void Deletar()
        {
            if (obj == null)
            {
                MessageBox.Show("Selecione um registro para ser deletado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Confirma Exclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    categoriabll.Delete(obj);
                    LimparForm();
                    RetornaTable();
                }
            }
        }

        private void LimparForm()
        {
            txtId.Clear(); txtDesc.Clear();
        }

        private void Filtro()
        {
            if (cmbPesq.Text == "ALL")
            {
                gridPesq.DataSource = listObj;
            }

            if (cmbPesq.Text == "ID")
            {
                gridPesq.DataSource = listObj.FindAll(p => p.IdCateg == Convert.ToInt16(txtPesq.Text));
            }

            if (cmbPesq.Text == "DESCRIÇÃO")
            {
                gridPesq.DataSource = listObj.FindAll(p => p.DescCateg == txtPesq.Text);
            }
        }
    }
}
