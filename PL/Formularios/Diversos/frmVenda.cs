using ORM.AppPdv2.BLL;
using ORM.AppPdv2.INFO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Formularios.Diversos
{
    public partial class frmVenda : Form
    {
        public frmVenda()
        {
            InitializeComponent();
        }

        public UsuarioINFO ObjUserSistema = new UsuarioINFO();
        public parametrosINFO objParametros = new parametrosINFO();

        List<ClienteINFO> listClie = new List<ClienteINFO>();
        List<ComponenteVendaINFO> listComp = new List<ComponenteVendaINFO>();
        List<ComponenteVendaINFO> listCompRetorno = new List<ComponenteVendaINFO>();
        List<ProdutosINFO> listProd = new List<ProdutosINFO>();
        List<CategoriasINFO> listCateg = new List<CategoriasINFO>();
        List<VendaINFO> listVenda = new List<VendaINFO>();
        List<pagamentoINFO> listPag = new List<pagamentoINFO>();

        //Listas de ações temporarias no sistema
        List<VendaINFO> listVendaAguardando = new List<VendaINFO>();
        List<ComponenteVendaINFO> listCompAguardando = new List<ComponenteVendaINFO>();     
        List<ComponenteVendaINFO> listCompLimpar = new List<ComponenteVendaINFO>();
        List<VendaINFO> listVendaFiltroCaixa = new List<VendaINFO>();

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

        List<FluxoCaixaINFO> listObjFluxoCaixa = new List<FluxoCaixaINFO>();
        FluxoCaixaINFO objFluxoCaixa = new FluxoCaixaINFO();
        FluxoCaixaBLL fluxocaixaBll = new FluxoCaixaBLL();


        decimal valorVenda;
        string prodMeia = "MEIA 1/2";

        //IMPORTAÇÃO DA DLL SHELL
        [DllImport("shell32.dll", EntryPoint = "ShellExecute")]
        public static extern int ShellExecuteA(int hwnd, string lpOperation,
              string lpFile, string lpParameters, string lpDirectory, int nShowCmd);

        private void frmVenda_Load(object sender, EventArgs e)
        {
            FluxoCaixa();
            RetornaTableCateg();
            RetornaTableCategGraficos();
            RetornaTableCliente();
            RetornaTableProd();
            RetornaTableVendas();
            RetornaTableCVenda();
            txtTel.Focus();
            txtDataFinal.Text = DateTime.Now.AddDays(1).ToShortDateString();
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            if (txtQtd.Text.Replace(" ", "").Replace("0", "") != "")
            {
                InserirItensProd();
                pnlProdItens.Enabled = false;
                LimparForm();
                cmbProd.Focus();
                cmbProd_Enter(sender, e);
            }
            else
            {
                MessageBox.Show("Campo quantidade NULO", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtd.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CancelarVendaNula();   
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            FinalizarVenda();
        }

        private void cmbCateg_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RetornaTableProdCateg();
            cmbProd.Focus();
            cmbProd_Enter(sender, e);
        }

        private void cmbProd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SelecionarProduto();
        }

        private void SelecionarProduto()
        {
            objProd = listProd.Find(p => p.IdProd == (int)cmbProd.SelectedValue);
            if (objProd != null)
            {
                txtVTotal.Text = "0,00"; txtQtd.Text = "0";
                txtCod.Text = objProd.IdProd.ToString();
                txtVUni.Text = objProd.ValorProd.ToString();
                pnlProdItens.Enabled = true;
                txtQtd.Focus();
            }
        }
       
        private void RetornaTableVendas()
        {
            listVenda = vendabll.RetornaTable();
        }

        private void RetornaTableCliente()
        {
            listClie = clientebll.RetornaTable();
        }

        private void RetornaTableProd()
        {
            listProd = produtobll.RetornaTable();
        }

        private void RetornaTableCVenda()
        {
            listCompRetorno = componentevendabll.RetornaTable();
            //gridItensProd.DataSource = listCompRetorno.FindAll(p => p.IdVenda == objVenda.IdVenda);
        }

        private void RetornaTableCateg()
        {
            listCateg = categoriabll.RetornaTable();
            cmbCateg.DataSource = listCateg;
            cmbCateg.DisplayMember = "descCateg";
            cmbCateg.ValueMember = "idCateg";
            Refresh();
        }

        private void RetornaTableCategGraficos()
        {
            cmbCategGrafico.DataSource = listCateg;
            cmbCategGrafico.DisplayMember = "descCateg";
            cmbCategGrafico.ValueMember = "idCateg";
            Refresh();
        }

        private void RetornaTableProdCateg()
        {
            cmbProd.DataSource = listProd.FindAll(p => p.IdCateg == (int)cmbCateg.SelectedValue);
            cmbProd.DisplayMember = "descProd";
            cmbProd.ValueMember = "idProd";
            Refresh();
        }

        private void txtQtd_TextChanged(object sender, EventArgs e)
        {
            
            if (txtQtd.Text.Replace(" ", "") != "")
            {
                decimal v1, v2;
                int qtd;
                v1 = Convert.ToDecimal(txtVUni.Text);
                qtd = Convert.ToInt16(txtQtd.Text);
                v2 = qtd * v1;
                txtVTotal.Text = v2.ToString();
            }           
            else
            {
                txtVTotal.Text = "0,00";
            }
        }

        private void LimparForm ()
        {
            txtCod.Text = "0"; txtQtd.Text = "0"; txtVTotal.Text = "0,00"; txtVUni.Text = "0,00"; chkMeia.Checked = false; txtNomeClie.Clear(); txtEndClie.Clear();
            
        }

        private void InserirItensProd()
        {            
            if (objProd.IdProd != 0)
            {
                if (txtQtd.Text != "")
                {
                    objComp = new ComponenteVendaINFO()
                    {
                        IdProd = objProd.IdProd,
                        QtdProd = Convert.ToInt16(txtQtd.Text),
                        ValorItem = Convert.ToDecimal(txtVTotal.Text)
                    };
                    if (chkMeia.Checked == true) objComp.DescVenda = objProd.DescProd + " " + prodMeia; else objComp.DescVenda = objProd.DescProd;
                    listComp.Add(objComp);
                    gridItensProd.DataSource = listCompLimpar;
                    gridItensProd.DataSource = listComp;
                    valorVenda = valorVenda + Convert.ToDecimal(txtVTotal.Text);
                    txtValor.Text = valorVenda.ToString();
                }
                else
                {
                    MessageBox.Show("Adicione a quantidade de itens.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnPesqClie_Click(object sender, EventArgs e)
        {
            FiltroCliente();
            cmbCateg_Enter(sender, e);
            listComp = new List<ComponenteVendaINFO>();
        }

        private void MontarGraficoConsumo ()
        {
            objComp = new ComponenteVendaINFO
            {
                IdClie = objClie.IdClie
            };
            chtConsumo.Series["Produtos"].Points.Clear();
            chtConsumo.DataSource = componentevendabll.RetornaTableGraficoCons(objComp);
            chtConsumo.Series["Produtos"].XValueMember = "descProd";
            chtConsumo.Series["Produtos"].YValueMembers = "qtd";
        }

        private void FiltroCliente()
        {
            if (listClie.Count > 0)
            {
                objClie = null;
                    objClie = listClie.Find(p => p.telNumero == txtTel.Text);
                    if (objClie != null)
                    {
                        txtEndClie.Text = objClie.EndClie + ", " + objClie.BairroClie;
                        txtNomeClie.Text = objClie.NomeClie;
                        lblCliente.Text = objClie.NomeClie;
                        pnlProd.Enabled = true;
                        gridHistoricoCliente.DataSource = listVenda.FindAll(p => p.IdClie == objClie.IdClie);
                        MontarGraficoConsumo();
                        cmbCateg.Focus();                       
                    }
                    else
                    {
                        if (MessageBox.Show("Deseja cadastrar novo cliente?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            Cadastro.frmCadClienteRapido frmCadClie = new Cadastro.frmCadClienteRapido();
                            frmCadClie.txtNumero.Text = txtTel.Text;
                            frmCadClie.ShowDialog();
                            if (frmCadClie.obj.IdClie != 0)
                            {
                                RetornaTableCliente();
                                objClie = listClie.Find(p => p.IdClie == frmCadClie.obj.IdClie);
                                txtEndClie.Text = objClie.EndClie + ", " + objClie.BairroClie;
                                txtNomeClie.Text = objClie.NomeClie;
                                lblCliente.Text = objClie.NomeClie;
                                pnlProd.Enabled = true;
                                gridHistoricoCliente.DataSource = listVenda.FindAll(p => p.IdClie == objClie.IdClie);
                                MontarGraficoConsumo();
                                cmbCateg.Focus();
                            }
                        }
                    }
            }
            else
            {
                if (MessageBox.Show("Deseja cadastrar novo cliente?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Cadastro.frmCadClienteRapido frmCadClie = new Cadastro.frmCadClienteRapido();
                    frmCadClie.txtNumero.Text = txtTel.Text;
                    frmCadClie.ShowDialog();
                    if (frmCadClie.obj.IdClie != 0)
                    {
                        RetornaTableCliente();
                        objClie = listClie.Find(p => p.IdClie == frmCadClie.obj.IdClie);
                        txtEndClie.Text = objClie.EndClie + ", " + objClie.BairroClie;
                        txtNomeClie.Text = objClie.NomeClie;
                        lblCliente.Text = objClie.NomeClie;
                        pnlProd.Enabled = true;
                        gridHistoricoCliente.DataSource = listVenda.FindAll(p => p.IdClie == objClie.IdClie);
                        MontarGraficoConsumo();
                        cmbCateg.Focus();
                    }
                }
            }
        }

        private void chkMeia_CheckedChanged(object sender, EventArgs e)
        {
            decimal v1, v2;
            int qtd;
            if(chkMeia.Checked == true)
            {              
                v1 = Convert.ToDecimal(txtVUni.Text);
                qtd = Convert.ToInt16(txtQtd.Text);
                v2 = (qtd * v1) / 2;
                txtVTotal.Text = v2.ToString();
            }
            else
            {
                v1 = Convert.ToDecimal(txtVUni.Text);
                qtd = Convert.ToInt16(txtQtd.Text);
                v2 = (qtd * v1);
                txtVTotal.Text = v2.ToString();
            }
        }

        private void DeleteItens ()
        {
            if(listComp.Count > 0)
            {
                listComp.Remove(objComp);
                gridItensProd.DataSource = listCompLimpar;
                gridItensProd.DataSource = listComp;
                txtValor.Text = (valorVenda - objComp.ValorItem).ToString();
            }
            else
            {
                MessageBox.Show("Item não selecionado.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmVenda_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    if (tbpVendas.ContainsFocus == true)
                    {
                        DeleteItens();
                    }
                    else if (tbpConsultas.ContainsFocus == true)
                    {
                        if (MessageBox.Show("Confirma o cancelamento da venda?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            CanelarVenda();
                        }
                    }
                    break;  
                case Keys.F9 :
                    if (ObjUserSistema.AcessoUser == 0)
                    {
                        if (MessageBox.Show("Confirma o fechamento do caixa do dia : " + objFluxoCaixa.dataAbertura, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            FecharCaixa();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Permissão invalida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case Keys.Enter :
                    
                    if (cmbCateg.Focused == false && cmbProd.Focused == false)
                    {
                        SendKeys.Send((e.Shift ? "+" : "") + "{TAB}");
                    }
                    else if(cmbCateg.Focused == true)
                    {                      
                        RetornaTableProdCateg();
                        cmbProd.Focus();
                        cmbProd_Enter(sender, e);
                    }
                    else if(cmbProd.Focused == true)
                    {
                        SelecionarProduto();
                    }
                        break;
            }           
        }

        private void gridItensProd_Click(object sender, EventArgs e)
        {
            if (gridItensProd.Rows.Count > 0)
            {
                objComp = (ComponenteVendaINFO)gridItensProd.SelectedRows[0].DataBoundItem;
            }
        }

        private void gridHistoricoCliente_Click(object sender, EventArgs e)
        {
            objVenda = new VendaINFO();
            if (gridHistoricoCliente.Rows.Count > 0)
            {
                objVenda = (VendaINFO)gridHistoricoCliente.SelectedRows[0].DataBoundItem;
                gridHistoricoItens.DataSource = listCompRetorno.FindAll(p => p.IdVenda == objVenda.IdVenda);
            }
        }

        private void FinalizarVenda()
        {
            if (gridItensProd.Rows.Count > 0)
            {
                objVenda = new VendaINFO()
                {
                    DataVenda = objFluxoCaixa.dataAbertura,
                    IdClie = objClie.IdClie,
                    IdUserVenda = ObjUserSistema.IdUser,
                    ValorTotal = Convert.ToDecimal(txtValor.Text),
                    IdVenda = 0,
                    ativa = false,
                    status = "Concluida",
                    idFC = objFluxoCaixa.idFC,
                 
                    };
                    Formularios.Diversos.frmFinVenda frmFimVenda = new frmFinVenda();
                    frmFimVenda.objVenda = objVenda;
                    frmFimVenda.listComp = listComp;
                    frmFimVenda.ShowDialog();
                    if (frmFimVenda.msg != "")
                    {
                        ImprimirCupom(objVenda, listComp);
                        MessageBox.Show(frmFimVenda.msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RetornaTableVendas();
                        RetornaTableCVenda();
                        valorVenda = 0;
                        gridItensProd.DataSource = listCompLimpar;
                        LimparForm();
                        txtTel.Clear();
                        pnlProdItens.Enabled = false;
                        pnlProd.Enabled = false;
                        objVenda = null;
                        txtTel.Focus();
                    }
                }               
            }               
       
        private void CancelarVendaNula ()
        {
            MessageBox.Show("Venda cancelada com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            gridItensProd.DataSource = listCompLimpar;
            LimparForm();
            txtTel.Clear();
            pnlProdItens.Enabled = false;
            pnlProd.Enabled = false;
            objVenda = null;
            txtTel.Focus();
            valorVenda = 0;
        }

        private void ImprimirCupom (VendaINFO obj, List<ComponenteVendaINFO> listCompImp)
        {
            try
            {
                StreamWriter SW;
                SW = File.CreateText("C:\\pdv\\Cupom.txt");
                SW.WriteLine(" ");
                SW.WriteLine(" ");
                SW.WriteLine("\t\t CUPOM DE VENDA - SEM VALOR FISCAL");
                SW.WriteLine(" ");
                SW.WriteLine("DADOS DA EMPRESA");
                SW.WriteLine("--------------------------------------------------------------");
                SW.WriteLine("RAZÃO : " + objParametros.Razão_social + " CNPJ : " + objParametros.CNPJ);
                SW.WriteLine("ENDEREÇO : " + objParametros.Endereco + ", BAIRRO : " + objParametros.Bairro);
                SW.WriteLine("CONTATO : " + objParametros.Telefone + " EMAIL : " + objParametros.Email);
                SW.WriteLine(" ");
                SW.WriteLine("DADOS DE VENDA");
                SW.WriteLine("--------------------------------------------------------------");
                SW.WriteLine("NR. DA VENDA : " + obj.IdVenda + "\t DATA : " + obj.DataVenda);
                SW.WriteLine(" ");
                SW.WriteLine("ID PROD." +"\t" + "DESCRIÇÃO" + "\t\t" + "QTD." + "\t" + "VALOR" + "\t");
                SW.WriteLine("--------------------------------------------------------------");
                SW.WriteLine(" ");
                foreach (ComponenteVendaINFO comp in listCompImp)
                {
                    SW.WriteLine(comp.IdProd + "\t" + comp.DescVenda + "\t\t" + comp.QtdProd + "\t" + comp.ValorItem + "\t");
                }
                SW.WriteLine(" ");
                SW.WriteLine("\t\t\t\t\t\t TOTAL ==>" +obj.ValorTotal.ToString("######0.00"));
                SW.WriteLine(" ");
                SW.WriteLine("DADOS PARA ENTREGA");
                SW.WriteLine("--------------------------------------------------------------");
                SW.WriteLine("CLIENTE : " + objClie.NomeClie);
                SW.WriteLine("ENDEREÇO : " + objClie.EndClie);
                SW.WriteLine("BAIRRO : " + objClie.BairroClie);
                SW.WriteLine(" ");
                SW.WriteLine(" ");
                SW.WriteLine("--------------------------------------------------------------");
                SW.WriteLine("                AGRADECEMOS A PREFERÊNCIA");
                SW.Close();
                string local = "C:\\pdv\\Cupom.txt";

                //imprimir

                frmVenda.ShellExecuteA(this.Handle.ToInt32(), "print", local, null, null, 0);
            }
            catch
            {
                MessageBox.Show("Não foi possivel imprimir direto. Acesse a pasta do programa e abra o arquivo Cupom", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void cmbCategGrafico_SelectionChangeCommitted(object sender, EventArgs e)
        {
            objComp = new ComponenteVendaINFO
            {
                IdClie = objClie.IdClie,
                IdCateg = (int) cmbCategGrafico.SelectedValue
            };
            chtGraficoModel.Series["Produtos"].Points.Clear();
            chtGraficoModel.DataSource = componentevendabll.RetornaTableGraficoModel(objComp);
            chtGraficoModel.Series["Produtos"].XValueMember = "descProd";
            chtGraficoModel.Series["Produtos"].YValueMembers = "qtd";
        }       

        private void CanelarVenda ()
        {
            if (objVenda.IdVenda != 0 || objVenda != null)
            {
                objVenda.status = "Cancelada";
                vendabll.Salvar(objVenda);
                MessageBox.Show("Cancelada com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selecione uma venda para exclusão", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pnlFiltro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltroConsulta(Convert.ToDateTime(txtDataInicial.Text), Convert.ToDateTime(txtDataFinal.Text));
        }

        private void FiltroConsulta (DateTime dataIni, DateTime dataFin)
        {
            gridPesqConsultas.DataSource = vendabll.RetornaTablePorData(dataIni, dataFin);
        }

        private void gridPesqConsultas_Click(object sender, EventArgs e)
        {
            if(gridPesqConsultas.Rows.Count > 0)
            {
                objVenda = (VendaINFO)gridPesqConsultas.SelectedRows[0].DataBoundItem;
            }
        }

        private void FluxoCaixa()
        {
            RetornaFluxo();
            objFluxoCaixa = listObjFluxoCaixa.Find(p => p.dataAbertura == DateTime.Now.Date);
            if(objFluxoCaixa == null)
            {
                if (objFluxoCaixa == null)
                {
                    if (DateTime.Now.Hour >= 00.00 && DateTime.Now.Hour < 05.00)
                    {
                        DateTime dataMenosUm = DateTime.Now.AddDays(-1).Date;
                        objFluxoCaixa = new FluxoCaixaINFO();
                        objFluxoCaixa = listObjFluxoCaixa.Find(p => p.dataAbertura == DateTime.Now.AddDays(-1).Date);
                        if (objFluxoCaixa == null)
                        {
                            Formularios.Diversos.frmFluxoCaixa frmFC = new frmFluxoCaixa();
                            frmFC.ShowDialog();
                            if (frmFC.prosseguir == false)
                            {
                                if (MessageBox.Show("Atenção, o caixa diário não foi aberto!\nDeseja abrir o caixa?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                {
                                    FluxoCaixa();
                                }
                                else
                                {
                                    MessageBox.Show("Erro, o sistema não pode emitir vendas!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    Close();
                                                      
                                }
                            }
                            else
                            {
                                RetornaFluxo();
                            }
                        }
                    }
                    else if (MessageBox.Show("Atenção, o caixa diário não foi aberto!\nDeseja abrir o caixa?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Formularios.Diversos.frmFluxoCaixa frmFC = new frmFluxoCaixa();
                        frmFC.ShowDialog();
                        if (frmFC.prosseguir == false)
                        {
                            if (MessageBox.Show("Atenção, o caixa diário não foi aberto!\nDeseja abrir o caixa?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                FluxoCaixa();
                            }
                            else
                            {
                                MessageBox.Show("Erro, o sistema não pode emitir vendas!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Close();                          

                            }
                        }
                        else
                        {
                            RetornaFluxo();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro, o sistema não pode emitir vendas!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);                   
                    }
                
                }           
            }
            else
            {
                objFluxoCaixa.situacao = true;
                fluxocaixaBll.Salvar(objFluxoCaixa);
            }
        }
        

        private void FecharCaixa()
        {
            RetornaTableVendas();
            if (listVenda.Count > 0)
            {
                listVendaFiltroCaixa = listVenda.FindAll(p => p.DataVenda == objFluxoCaixa.dataAbertura);
                if (listVendaFiltroCaixa.Count > 0)
                {
                    decimal valorTotalVenda = 0;
                    foreach (VendaINFO VInfo in listVendaFiltroCaixa)
                    {
                        valorTotalVenda = VInfo.ValorTotal + valorTotalVenda;
                    }
                    objFluxoCaixa.userFechamento = ObjUserSistema.IdUser;
                    objFluxoCaixa.saldoBruto = objFluxoCaixa.saldoInicial + valorTotalVenda;
                    objFluxoCaixa.saldoLiquido = valorTotalVenda;
                    objFluxoCaixa.situacao = false;
                    fluxocaixaBll.Salvar(objFluxoCaixa);
                    MessageBox.Show("Caixa fechado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }          
        
        private void RetornaFluxo ()
        {
            listObjFluxoCaixa = fluxocaixaBll.SelecionarTodos();
            objFluxoCaixa = listObjFluxoCaixa.Find(p => p.dataAbertura == DateTime.Now.Date && p.situacao == true);
        }

        private void btnAddProd_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void pnlClientes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbCateg_Click(object sender, EventArgs e)
        {

        }

        private void cmbCateg_Enter(object sender, EventArgs e)
        {

            if (cmbCateg.Focused == true)
            {
                cmbCateg.DroppedDown = true;
            }              

        }

        private void cmbCateg_Leave(object sender, EventArgs e)
        {
            cmbCateg.DroppedDown = false;
        }

        private void cmbProd_Leave(object sender, EventArgs e)
        {
            cmbProd.DroppedDown = false;
        }

        private void cmbProd_Enter(object sender, EventArgs e)
        {
            if (cmbProd.Focused == true)
            {
                cmbProd.DroppedDown = true;
            }
        }

        private void cmbCateg_DropDown(object sender, EventArgs e)
        {

        }

        private void cmbCateg_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void cmbProd_Click(object sender, EventArgs e)
        {

        }

      
    }
}
