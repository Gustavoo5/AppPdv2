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
    public partial class frmDashboardUserAdm : Form
    {
        public UsuarioINFO objUser = new UsuarioINFO();
        VendaINFO objVendas = new VendaINFO();
        List<VendaINFO> listObj = new List<VendaINFO>();
        List<VendaINFO> listObjVendaCount = new List<VendaINFO>();
        List<VendaINFO> listObjFiltro = new List<VendaINFO>();
        vendaBLL vendabll = new vendaBLL();

        ComponenteVendaINFO objComp = new ComponenteVendaINFO();
        List<ComponenteVendaINFO> listObjComp = new List<ComponenteVendaINFO>();
        componenteVendaBLL compbll = new componenteVendaBLL();

        clienteBLL clientebll = new clienteBLL();
        ClienteINFO clieteinfo = new ClienteINFO();
        List<ClienteINFO> ClintInfo = new List<ClienteINFO>();

        private int iLargeChange;
        private int iSmallChange;
        public frmDashboardUserAdm()
        {
            InitializeComponent();

                    //guardo o tamanho que o form deveria ter
            //iAlturaDoForm += 30;

            //configura o tamanho máximo do scrollbar: qtos pixels ele vai rolar
            this.vScrollBar1.Maximum = 500;

            //configura o quanto deve descer ao page down ou page up
            iLargeChange = this.Height = 30;
            this.vScrollBar1.LargeChange = iLargeChange;

            //configura o minimo para zero, para q a barra apareça no topo do scroll
            this.vScrollBar1.Minimum = 0;        

            //configura a qtde a rolar ao clicar nas setas
            iSmallChange = 10;// (int)this.Height / 2;
            this.vScrollBar1.SmallChange = iSmallChange;

            this.VerticalScroll.Maximum = this.vScrollBar1.Maximum;
        }

        private void frmDashboardUserAdm_Load(object sender, EventArgs e)
        {
            Selecionar();
            CriarGraficoVendasPorDatas();
            GraficoClientes();
            FiltrarCliente();
            CarregarGrafico();           
        }

        private void Selecionar()
        {
            decimal CompararTotalMaior = 0;            

            string nomeMaior = "", nomeMenor = "";
            listObj = vendabll.RetornaTableCountTotalUserSelecionar();
            gridPesq.AutoGenerateColumns = false;
            gridPesq.DataSource = listObj;
            if (listObj.Count > 0)
            {
                foreach (VendaINFO vInfo in listObj)
                {
                    if (vInfo.total > CompararTotalMaior)
                    {
                        CompararTotalMaior = vInfo.total;
                        nomeMaior = vInfo.NomeUser;
                    }
                }
                decimal CompararTotalMenor = CompararTotalMaior;
                foreach (VendaINFO vInfo in listObj)
                {
                    if (vInfo.total < CompararTotalMenor)
                    {
                        CompararTotalMenor = vInfo.total;
                        nomeMenor = vInfo.NomeUser;
                    }
                }

                lblMaiorVenda.Text = nomeMaior;
                lblMenosVenda.Text = nomeMenor;
            }
        }
           
        private void txtPesq_TextChanged(object sender, EventArgs e)
        {
            gridPesq.DataSource = vendabll.RetornaTableCountTotalUser(txtPesq.Text);
        }
   
        private void btnBuscar_Click(object sender, EventArgs e)
        {          
            Filtrar();
        }
        private void Filtrar()
        {
            listObjVendaCount = vendabll.FiltrarPorDatasGrafico(txtDataInicial.Value, txtDataFinal.Value);

            chtGrafico.Series[0].Points.Clear();
            chtGrafico.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;

            foreach (VendaINFO VendaInf in listObjVendaCount)
            {
                if (chtGrafico.Series[0].Points.Count > 6)
                {
                    chtGrafico.Series[0].Points.RemoveAt(0);
                    chtGrafico.Update();
                }
                chtGrafico.Series[0].Points.AddXY(VendaInf.DataVenda, VendaInf.qtd);
                chtGrafico.Series[0].IsValueShownAsLabel = true;
            }
        }

        private void CriarGraficoVendasPorDatas()
        {
            listObjVendaCount = vendabll.Filtrar();                      
            chtGrafico.Legends.Clear();
            chtGrafico.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;

            foreach (VendaINFO VendaInf in listObjVendaCount)
            {
            if(chtGrafico.Series[0].Points.Count > 6)
            {
                chtGrafico.Series[0].Points.RemoveAt(0);
                chtGrafico.Update();
            }
                chtGrafico.Series[0].Points.AddXY(VendaInf.DataVenda, VendaInf.qtd);
                chtGrafico.Series[0].IsValueShownAsLabel = true;
            }
            
        }
        private void GraficoClientes()
        {
            ClintInfo = clientebll.TodosClientesAdicionados();
            chartCliente.Legends.Clear();
            chartCliente.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            foreach (ClienteINFO clientInf in ClintInfo)
            {
                if (chartCliente.Series[0].Points.Count > 6)
                {
                    chartCliente.Series[0].Points.RemoveAt(0);
                    chartCliente.Update();
                }
                chartCliente.Series[0].Points.AddXY(clientInf.DataCadastro, clientInf.qtdClientes);
                chtGrafico.Series[0].IsValueShownAsLabel = true;
            }
        }

        private void FiltrarCliente()
        {
            List<ClienteINFO> cliente = clientebll.TodosClientesAdicionados();
            lblCliente.Text = cliente.Sum(p=> p.qtdClientes).ToString();

            ClintInfo = clientebll.FiltrarPorDatasGrafico(Convert.ToDateTime(DateTime.Now.ToShortDateString()));

           foreach (ClienteINFO ClientInf in ClintInfo)
            {          
               lblAdc.Text = ClientInf.qtdClientes.ToString();
            }
        }
        private void CarregarGrafico()
        {
            List<ComponenteVendaINFO> obj = compbll.RetornaTable();
          
                foreach (ComponenteVendaINFO compvenda in obj)
                {
                    chart2.Series[0].Points.AddXY(compvenda.DescProd, compvenda.QtdProd);
                }
                        
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {        
        }
    }
}
