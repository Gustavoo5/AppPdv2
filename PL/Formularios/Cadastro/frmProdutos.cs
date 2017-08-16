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
    public partial class frmProdutos : frmBase
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        ProdutosINFO objProd = new ProdutosINFO();
        CategoriasINFO objCateg = new CategoriasINFO();
        ComponenteProdINFO objComp = new ComponenteProdINFO();

        List<ProdutosINFO> listProd = new List<ProdutosINFO>();
        List<CategoriasINFO> listCateg = new List<CategoriasINFO>();
        List<CategoriasINFO> listCategComp = new List<CategoriasINFO>();
        List<ComponenteProdINFO> listComp = new List<ComponenteProdINFO>();

        produtosBLL produtobll = new produtosBLL();
        categoriasBLL categoriabll = new categoriasBLL();
        componenteProdBLL componentebll = new componenteProdBLL();

        public override void FrmBase_Load(object sender, EventArgs e)
        {
            RetornaTableProd();
            RetornaTableCateg();
            RetornaCategCmbComp();
            
            cmbPesq.SelectedIndex = 0;
            base.FrmBase_Load(sender, e);
        }

        public override void BtnAlt_Click(object sender, EventArgs e)
        {
            if (txtIdProd.Text == "")
            {
                MessageBox.Show("Selecione um registro para ser Alterado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                groupComp.Enabled = true;
            }
            base.BtnAlt_Click(sender, e);
        }

        public override void BtnCancel_Click(object sender, EventArgs e)
        {
            base.BtnCancel_Click(sender, e);
            gridPesqComp.Enabled = true;
        }

        public override void BtnDel_Click(object sender, EventArgs e)
        {
            Delete();           
            base.BtnDel_Click(sender, e);
        }

        public override void BtnNovo_Click(object sender, EventArgs e)
        {
            LimparForm();
            LimparGridComp();
            groupComp.Enabled = false;
            base.BtnNovo_Click(sender, e);
            txtDesc.Focus();
        }

        public override void BtnSalvar_Click(object sender, EventArgs e)
        {
             if (cmbCateg.Items.Count > 0)
            {
                    if (txtDesc.Text.Replace(" ", "") == "")
                    {
                        MessageBox.Show("Campo Descrição não pode ficar em branco.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDesc.Focus();
                        return;
                    }
                    if(txtValor.Text.Replace(" ","") == "")
                    {
                        MessageBox.Show("Campo Valor não pode ficar em branco.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtValor.Focus();
                        return;
                    }                   
                    else
                    {
                        Salvar();
                        LimparGridComp();
                    }
                    gridPesqComp.Enabled = true;
             }
             else
             {                 
                     if (MessageBox.Show("Não a Categorias cadastradas. Deseja cadastrar nova categoria?", "Informações", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                     {
                         frmCategoria frmcateg = new frmCategoria();
                         this.Close();
                         frmcateg.ShowDialog();
                     }                
             }
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
            RetornaComponente();

        }

        private void CmbCategComp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RetornaProdCmb();
        }

        //METODOS

        private void RetornaTableProd()
        {
            listProd = produtobll.RetornaTable();
            gridPesq.DataSource = listProd;
        }

        private void RetornaTableCateg()
        {
            listCateg = categoriabll.RetornaTable();
            cmbCateg.Items.Clear();
            cmbCateg.DataSource = listCateg;
            cmbCateg.DisplayMember = "descCateg";
            cmbCateg.ValueMember = "idCateg";
            Refresh();         
        }     

        private void RetornaForm()
        {
            if (gridPesq.Rows.Count > 0)
            {
                double Calc1, Calc2, Calc3;
                objProd = (ProdutosINFO)gridPesq.SelectedRows[0].DataBoundItem;
                txtDesc.Text = objProd.DescProd;
                txtProd.Text = objProd.DescProd;
                txtIdProd.Text = objProd.IdProd.ToString();
                txtQtd.Text = objProd.QtdProd.ToString();
                txtValor.Text = objProd.ValorProd.ToString();
                cmbCateg.SelectedValue = objProd.IdCateg;
                Calc1 = Convert.ToDouble(objProd.ValorProd); Calc2 = objProd.QtdProd;
                Calc3 = Calc1 * Calc2;
                if (txtQtd.Text == "0") txtTotal.Text = Calc1.ToString(); else txtTotal.Text = Calc3.ToString();
            }
        }

        private void Salvar()
        {
                        objProd = new ProdutosINFO();
                        if (txtIdProd.Text == "") objProd.IdProd = 0; else objProd.IdProd = Convert.ToInt16(txtIdProd.Text);
                        objProd.IdCateg = (int)cmbCateg.SelectedValue;
                        objProd.QtdProd = Convert.ToDouble(txtQtd.Text);
                        objProd.ValorProd = Convert.ToDecimal(txtValor.Text);
                        objProd.DescProd = txtDesc.Text;
                        produtobll.Salvar(objProd);
                        LimparForm();
                        RetornaTableProd();
        }

        private void LimparForm()
        {
            txtDesc.Clear(); txtIdProd.Clear(); txtQtd.Text = "0"; txtValor.Clear(); txtTotal.Clear();
        }

        private void Delete()
        {
            
            if (txtIdProd.Text == "" && objProd == null)
            {
                MessageBox.Show("Selecione um registro para ser deletado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (listComp.FindAll(p=>p.IdProd == objProd.IdProd || p.IdProdComp == objProd.IdProd).Count > 0)
                {
                    MessageBox.Show("Apague os componentes do produto.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (MessageBox.Show("Confirma Exclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        produtobll.Delete(objProd);
                        RetornaTableProd();
                        LimparForm();
                    }
                }
            }
        }

        private void Filtro()
        {
            if (cmbPesq.Text == "ALL")
            {
                gridPesq.DataSource = listProd;
            }

            if (cmbPesq.Text == "ID")
            {
                gridPesq.DataSource = listProd.FindAll(p => p.IdProd == Convert.ToInt16(txtPesq.Text));
            }

            if (cmbPesq.Text == "DESCRIÇÃO")
            {
                gridPesq.DataSource = listProd.FindAll(p => p.DescProd == txtPesq.Text);
            }

            if (cmbPesq.Text == "CATEGORIA")
            {
                gridPesq.DataSource = listProd.FindAll(p => p.DescCateg == txtPesq.Text);
            }
        }

        //COMPONENTES

        private void RetornaCategCmbComp()
        {
            listCategComp = categoriabll.RetornaTable();
            cmbCategComp.Items.Clear();
            cmbCategComp.DataSource = listCategComp;
            cmbCategComp.DisplayMember = "descCateg";
            cmbCategComp.ValueMember = "idCateg";
            Refresh();
        }

        private void RetornaProdCmb()
        {
            cmbProd.DataSource = listProd.FindAll(p => p.IdCateg == (int)cmbCategComp.SelectedValue);
            cmbProd.DisplayMember = "descProd";
            cmbProd.ValueMember = "idProd";
            Refresh();
        }

        private void RetornaComponente ()
        {
             listComp = componentebll.RetornaTable();
             if (objProd != null)
             {
                 gridPesqComp.DataSource = listComp.FindAll(p => p.IdProd == objProd.IdProd);
             }
        }      

        private void RetornaFormComp ()
        {
            if (gridPesqComp.Rows.Count > 0)
            {
                objComp = (ComponenteProdINFO)gridPesqComp.SelectedRows[0].DataBoundItem;
                txtQtdC.Text = objComp.QtdComp.ToString();
                lblCod.Text = objComp.IdCompProd.ToString();
            }
        }

        private void BtnSalvarComp_Click(object sender, EventArgs e)
        {
            SalvarComp();         
        }

        private void BtnDeletarComp_Click(object sender, EventArgs e)
        {
            DeleteComp();      
        }

        private void BtnNovoComp_Click(object sender, EventArgs e)
        {
            
        }

        private void GridPesqComp_Click(object sender, EventArgs e)
        {
            RetornaFormComp();
        }

        private void SalvarComp ()
        {
            if(txtProd.Text == "")
            {
                MessageBox.Show("Selecione um produto acima para que você poda complementa-lo.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtQtdC.Text == "")
            {
                MessageBox.Show("O campo Quantidade em Componentes não pode ficar em branco.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(cmbProd.SelectedValue == null)
            {
                MessageBox.Show("O campo Comp. em Componentes não pode ficar em branco.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                objComp = new ComponenteProdINFO();
                if (lblCod.Text == "") objComp.IdCompProd = 0; else objComp.IdCompProd = Convert.ToInt16(lblCod.Text);
                objComp.IdProd = objProd.IdProd;
                objComp.IdProdComp = (int)cmbProd.SelectedValue;
                objComp.QtdComp = Convert.ToDouble(txtQtdC.Text);
                objComp.DescProd = cmbProd.Text;
                componentebll.Salvar(objComp);
                RetornaComponente();
                LimparComplementos();              
            }
        }

        private void LimparComplementos ()
        {
            txtQtdC.Clear(); lblCod.Text = "";
        }

        private void LimparGridComp ()
        {
            listComp = new List<ComponenteProdINFO>();
            gridPesqComp.DataSource = listComp;
        }

        private void DeleteComp ()
        {
            if(lblCod.Text == "")
            {
                MessageBox.Show("Selecione um Componente na lista ao lado para ser deletado!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                componentebll.Delete(objComp);
                RetornaComponente();
                LimparComplementos();
            }
        }

       
    }
}
