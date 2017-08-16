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


namespace PL.Formularios.Diversos
{
    public partial class frmDashboardUserComum : Form
    {
        public frmDashboardUserComum()
        {
            InitializeComponent();
        }
      

        public UsuarioINFO objUser = new UsuarioINFO();

        VendaINFO objVendas = new VendaINFO();
        List<VendaINFO> listObj = new List<VendaINFO>();
        List<VendaINFO> listObjVendaCount = new List<VendaINFO>();
        List<VendaINFO> listObjFiltro = new List<VendaINFO>();
        vendaBLL vendabll = new vendaBLL();

        ComponenteVendaINFO objComp = new ComponenteVendaINFO();
        List<ComponenteVendaINFO> listObjComp = new List<ComponenteVendaINFO>();
        componenteVendaBLL compbll = new componenteVendaBLL();

        int TotalItensVendidos = 0;
        int CompararTotal = 0;
        string nomeItensVencedor;
        
        private void frmDashboardUserComum_Load(object sender, EventArgs e)
        {            
            RetornarVendas();
            RetornaTodosCompVendasUser();
            PreencherDashUser();
            FiltroDiario();
            CarregarGrafico();
        }

        private void PreencherDashUser()
        {
            txtNomeUser.Text = objUser.NomeUser;
            txtLogin.Text = objUser.LoginUser;
            if (objUser.AcessoUser == 0) txtAcesso.Text = "ADMINISTRADOR"; else txtAcesso.Text = "COMUM";
            if (objUser.img == "") pbUser.Image = PL.Properties.Resources.User_Login; else pbUser.ImageLocation = objUser.img;
            txtTotalVendas.Text = listObjFiltro.Count.ToString();
            txtProdTotal.Text = TotalItensVendidos.ToString();
            txtProdVendidos.Text = CompararTotal.ToString() + " de " + nomeItensVencedor;
        }

        private void RetornarVendas()
        {
            if (objUser.IdUser != 0 || objUser != null)
            {
                listObj = vendabll.RetornaTable();
                listObjFiltro = listObj.FindAll(p => p.IdUserVenda == objUser.IdUser);
            }
        }

        private void FiltroDiario()
        {
            listObjFiltro = new List<VendaINFO>();
            listObjFiltro = listObj.FindAll(p => p.DataVenda == DateTime.Now.Date);
            txtTotalVendasDia.Text = listObjFiltro.Count.ToString();
        }

        private void RetornaTodosCompVendasUser()
        {

            objComp.IdUserVenda = objUser.IdUser;
            listObjComp = compbll.RetornaTableItensUser(objComp);
            if (listObjComp.Count > 0)
            {
                foreach (ComponenteVendaINFO compVenda in listObjComp)
                {
                    TotalItensVendidos = compVenda.qtd + TotalItensVendidos;
                }
                foreach (ComponenteVendaINFO compVenda in listObjComp)
                {
                    if (compVenda.qtd > CompararTotal)
                    {
                        CompararTotal = compVenda.qtd;
                        nomeItensVencedor = compVenda.DescProd;
                    }
                }
            }
        }

        private void pbUser_Click(object sender, EventArgs e)
        {

        }

        private void vendasCountBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void pdvDataSet_Initialized(object sender, EventArgs e)
        {

        }      

        private void CarregarGrafico ()
        {
            objVendas.IdUserVenda = objUser.IdUser;
            listObjVendaCount = vendabll.RetornaTableCountDataNow(objVendas);

            if (listObjVendaCount.Count > 0)
            {
                chtGrafico.Legends.Clear();
                chtGrafico.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
                foreach (VendaINFO vInfo in listObjVendaCount)
                {
                    if (chtGrafico.Series[0].Points.Count > 7)
                    {
                        chtGrafico.Series[0].Points.RemoveAt(0);
                        chtGrafico.Update();
                    }
                    chtGrafico.Series[0].Points.AddXY(vInfo.DataVenda, vInfo.qtd);
                      chtGrafico.Series[0].IsValueShownAsLabel = true;
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //objVendas.IdUserVenda = objUser.IdUser;
            //listObjVendaCount = vendabll.RetornaTableCountDataNow(objVendas);

            //if (listObjVendaCount.Count > 0)
            //{
            //    chtGrafico.Legends.Clear();
            //    chtGrafico.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
            //    foreach (VendaINFO vInfo in listObjVendaCount)
            //    {
            //        if (chtGrafico.Series[0].Points.Count > 7)
            //        {
            //            chtGrafico.Series[0].Points.RemoveAt(0);
            //            chtGrafico.Update();
            //        }
            //        chtGrafico.Series[0].Points.AddXY(vInfo.DataVenda, vInfo.qtd);
            //    }
            //}
        }
    }
}
