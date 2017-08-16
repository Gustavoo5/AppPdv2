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
    public partial class FrmVendas : Form
    {
        public FrmVendas()
        {
            InitializeComponent();
        }

        List<ClienteINFO> listClie = new List<ClienteINFO>();
        List<ComponenteVendaINFO> listComp = new List<ComponenteVendaINFO>();
        List<ProdutosINFO> listProd = new List<ProdutosINFO>();
        List<CategoriasINFO> listCateg = new List<CategoriasINFO>();
        List<VendaINFO> listVenda = new List<VendaINFO>();
        List<pagamentoINFO> listPag = new List<pagamentoINFO>();

        clienteBLL clientebll = new clienteBLL();
        componenteVendaBLL componentevendabll = new componenteVendaBLL();
        produtosBLL produtobll = new produtosBLL();
        categoriasBLL categoriabll = new categoriasBLL();
        vendaBLL vendabll = new vendaBLL();
        pagamentoBLL PagamentoBll = new pagamentoBLL();

        ClienteINFO objClie = new ClienteINFO();
        ComponenteVendaINFO objComp = new ComponenteVendaINFO();
        ProdutosINFO objProd = new ProdutosINFO();
        CategoriasINFO objCateg = new CategoriasINFO();
        VendaINFO objVenda = new VendaINFO();
        pagamentoINFO ObjPag = new pagamentoINFO();

        decimal valorVenda;
        string prodMeia = "MEIA 1/2";

        private void GroupCliente_Enter(object sender, EventArgs e)
        {

        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            
            RetornaTableCateg();
            RetornaTableCliente();            
            RetornaTableProd();
            RetornaTableVendas();
            RetornaTableCVenda();
            RetornaTablePagamentos();
            rbTel.Checked = true;
            objClie = null;
            ControleForms(false);
        }

        private void RetornaTableCliente ()
        {
            listClie = clientebll.RetornaTable();
        }

        private void RetornaTableProd()
        {
            listProd = produtobll.RetornaTable();
        }

        private void RetornaTableCVenda ()
        {
            listComp = componentevendabll.RetornaTable();
            gridItensProd.DataSource = listComp.FindAll(p => p.IdVenda == objVenda.IdVenda);
        }

        private void RetornaTableCateg ()
        {
            listCateg = categoriabll.RetornaTable();
            cmbCateg.Items.Clear();
            cmbCateg.DataSource = listCateg;
            cmbCateg.DisplayMember = "descCateg";
            cmbCateg.ValueMember = "idCateg";
            Refresh();
        }

        private void RetornaTablePagamentos ()
        {
            listPag = PagamentoBll.RetornaTable();
            cmbPag.Items.Clear();
            cmbPag.DataSource = listPag;
            cmbPag.DisplayMember = "descPag";
            cmbPag.ValueMember = "idFormPag";
            Refresh();
        }

        private void RetornaTableVendas ()
        {
            listVenda = vendabll.RetornaTable();
        }

        private void CmbCateg_SelectionChangeCommitted(object sender, EventArgs e)
        {
            gridProd.DataSource = listProd.FindAll(p => p.IdCateg == (int)cmbCateg.SelectedValue);
        }

        private void RbTel_CheckedChanged(object sender, EventArgs e)
        {
            txtTel.Clear();
            txtTel.Mask = "(00)0000-0000";
        }

        private void RbCel_CheckedChanged(object sender, EventArgs e)
        {
            txtTel.Clear();
            txtTel.Mask = "(00)00000-0000";
        }

        private void BtnPesqClie_Click(object sender, EventArgs e)
        {
             FiltroCliente();
        }

        private void FiltroCliente()
        {
            if (listClie.Count > 0)
            {
                if (rbTel.Checked == true)
                {
                    objClie = listClie.Find(p => p.TelClie == txtTel.Text);
                    if (objClie != null)
                    {
                        txtBairroClie.Text = objClie.BairroClie;
                        txtCepClie.Text = objClie.CepClie;
                        txtCidadeClie.Text = objClie.CidadeClie;
                        txtEndClie.Text = objClie.EndClie;
                        txtNomeClie.Text = objClie.NomeClie;
                        txtSexoClie.Text = objClie.SexoClie;
                        lblCliente.Text = objClie.NomeClie;
                        //gridHistoricoCliente.DataSource = listVenda.FindAll(p => p.IdClie == objClie.IdClie);
                    }
                }
                else
                {
                    objClie = listClie.Find(p => p.CelClie == txtTel.Text);
                    if (objClie != null)
                    {
                        txtBairroClie.Text = objClie.BairroClie;
                        txtCepClie.Text = objClie.CepClie;
                        txtCidadeClie.Text = objClie.CidadeClie;
                        txtEndClie.Text = objClie.EndClie;
                        txtNomeClie.Text = objClie.NomeClie;
                        txtSexoClie.Text = objClie.SexoClie;
                        lblCliente.Text = objClie.NomeClie;
                        //gridHistoricoCliente.DataSource = listVenda.FindAll(p => p.IdClie == objClie.IdClie);
                    }
                }
            }
        }

        private void BtnAddProd_Click(object sender, EventArgs e)
        {
            InserirItensProd();
        }

        private void InserirItensProd ()
        {
            if(objProd.IdProd != 0)
            {
                if (txtQtdItens.Text != "")
                {
                    objComp = new ComponenteVendaINFO()
                    {
                        IdProd = objProd.IdProd,
                        IdVenda = objVenda.IdVenda,
                        QtdProd = Convert.ToInt16(txtQtdItens.Text)
                    };
                    if (chkMeia.Checked == true) objComp.DescVenda = objProd.DescProd + " " + prodMeia; else objComp.DescVenda = objProd.DescProd;
                    componentevendabll.Salvar(objComp);
                    RetornaTableCVenda();
                    if (chkMeia.Checked == true)
                    {
                        valorVenda = (valorVenda + (objProd.ValorProd / 2)) * Convert.ToInt16(txtQtdItens.Text);
                        lblValorVenda.Text = valorVenda.ToString();
                    }
                    else
                    {
                        valorVenda = (valorVenda + objProd.ValorProd) * Convert.ToInt16(txtQtdItens.Text);
                        lblValorVenda.Text = valorVenda.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Adicione a quantidade de itens.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if(MessageBox.Show("Não a produtos cadastrado. Deseja cadastrar Produtos?", "Informações", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    frmProdutos frmProd = new frmProdutos();
                    Hide();
                    frmProd.ShowDialog();
                }
            }
        }

        private void GridProd_Click(object sender, EventArgs e)
        {
            RetornaFormProd();
        }

        private void RetornaFormProd ()
        {
            if (gridProd.Rows.Count > 0)
            {
                objProd = null;
                objProd = (ProdutosINFO)gridProd.SelectedRows[0].DataBoundItem;
            }
        }

        private void BtnAbrirV_Click(object sender, EventArgs e)
        {
            if (txtNomeClie.Text != "")
            {
                 AbrirVenda();
                 MessageBox.Show(objVenda.IdVenda.ToString());
            }
            else
            {
                MessageBox.Show("Selecione um Cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTel.Focus();
                return;
            }
            ControleForms(true);
        }

        private void AbrirVenda ()
        {
            objVenda = new VendaINFO()
            {
                DataVenda = DateTime.Now,
                IdClie = objClie.IdClie,
                IdUserVenda = 1,
                ativa = true                
            };
            vendabll.Salvar(objVenda);
                lblVenda.Text = objVenda.IdVenda.ToString();
        }

       private void ControleForms (bool status)
        {
            ControleBtns(status);
            groupCliente.Enabled = !status;
            groupProd.Enabled = status;
            groupAdd.Enabled = status;
        }

        private void ControleBtns (bool status)
        {
            btnAbrirV.Enabled = !status;
            btnConcluir.Enabled = status;
            btnCancel.Enabled = status;
        }

        private void BtnConcluir_Click(object sender, EventArgs e)
        {
            ConcluirVenda();
            
        }

        private void ConcluirVenda ()
        {
            if(MessageBox.Show("Confirma a Conclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (gridItensProd.Rows.Count > 0)
                {
                    objVenda = new VendaINFO()
                    {
                        DataVenda = DateTime.Now,
                        IdClie = objClie.IdClie,
                        IdUserVenda = 1,
                        ValorTotal = Convert.ToDecimal(lblValorVenda.Text),
                        IdVenda = Convert.ToInt16(lblVenda.Text),
                        IdFormPag = (int) cmbPag.SelectedValue,
                        ativa = false
                    };
                    vendabll.Salvar(objVenda);

                    frmRltConcluirVenda Relatorio = new frmRltConcluirVenda();
                    Relatorio.IdVenda = objVenda.IdVenda;
                    Relatorio.ShowDialog();

                    LimparForm();
                    objClie = null;
                    objComp = null;
                    objVenda.IdVenda = 0;
                    RetornaTableCVenda();
                    ControleForms(false);
                    
                 }
                else
                {
                    MessageBox.Show("Adicione itens na venda.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ControleForms(false);
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            DeletarItensVenda();
        }

        private void DeletarItensVenda()
        {
            if(gridItensProd.Rows.Count > 0)
            {
                componentevendabll.Delete(objComp);
                RetornaTableCVenda();
                valorVenda = valorVenda - objComp.ValorProd;
                lblValorVenda.Text = valorVenda.ToString();
            }
        }

        private void GridItensProd_Click(object sender, EventArgs e)
        {
            RetornaFormItensVenda();            
        }

        private void RetornaFormItensVenda()
        {
            if (gridItensProd.Rows.Count > 0)
            {
                objComp = (ComponenteVendaINFO)gridItensProd.SelectedRows[0].DataBoundItem;
            }
        }

        private void ChkMeia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LimparForm ()
        {
            listComp = new List<ComponenteVendaINFO>();
            gridItensProd.DataSource = listComp;
            gridProd.DataSource = listProd;
            txtBairroClie.Clear(); txtCepClie.Clear(); txtCidadeClie.Clear(); txtDescontoVenda.Clear(); txtEndClie.Clear();
            txtNomeClie.Clear(); txtSexoClie.Clear(); txtTel.Clear(); txtUfClie.Clear(); valorVenda = 0; lblValorVenda.Text = "0,00";
            lblVenda.Text = "0";
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {

        }

        private void GridHistoricoCliente_Click(object sender, EventArgs e)
        {
           // objVenda = new VendaINFO();
           //// if (gridHistoricoCliente.Rows.Count > 0)
           // {
           //     objVenda = (VendaINFO)gridHistoricoCliente.SelectedRows[0].DataBoundItem;
           //     //gridHistoricoItens.DataSource = listComp.FindAll(p => p.IdVenda == objVenda.IdVenda);
           // }
        }

        private void TxtDescontoVenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupAdd_Enter(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            RetornaTableVendas();
            if(objClie != null)
            {
                //gridHistoricoCliente.DataSource = listVenda.FindAll(p => p.IdClie == objClie.IdClie);
            }
        }
    }
}
