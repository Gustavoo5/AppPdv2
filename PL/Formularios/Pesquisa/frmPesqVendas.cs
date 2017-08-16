using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ORM.AppPdv2.INFO;
using ORM.AppPdv2.BLL;

namespace PL.Formularios.Pesquisa
{
    public partial class frmPesqVendas : Pesquisa.Base.frmBasePesq
    {
        public frmPesqVendas()
        {
            InitializeComponent();
        }

        VendaINFO objVendas = new VendaINFO();
        vendaBLL vendabll = new vendaBLL();
        List<VendaINFO> listObjVendas = new List<VendaINFO>();

        ComponenteVendaINFO objItens = new ComponenteVendaINFO();
        componenteVendaBLL compBll = new componenteVendaBLL();
        List<ComponenteVendaINFO> listObjItens = new List<ComponenteVendaINFO>();

        public override void frmBasePesq_Load(object sender, EventArgs e)
        {
            base.frmBasePesq_Load(sender, e);
        }

        public override void btnPesq_Click(object sender, EventArgs e)
        {
            base.btnPesq_Click(sender, e);
        }

        private void RetornaTodasVendas ()
        {
            listObjVendas = vendabll.RetornaTablePorData(Convert.ToDateTime(TxtData1.Text), Convert.ToDateTime(TxtData2.Text));
            gridPesqVendas.DataSource = listObjVendas;
        }

        private void btnFiltroDatas_Click(object sender, EventArgs e)
        {
            RetornaTodasVendas();
        }

        private void RetornarItensVendas ()
        {
            objItens.IdClie = objVendas.IdClie;
            listObjItens = compBll.RetornaTableItensClie(objItens);
            gridPesqItens.DataSource = listObjItens;
        }

        private void gridPesqVendas_Click(object sender, EventArgs e)
        {
            if (gridPesqVendas.Rows.Count > 0)
            {
                objVendas =(VendaINFO) gridPesqVendas.SelectedRows[0].DataBoundItem;
                if (objVendas != null)
                {
                    RetornarItensVendas();
                }
            }
            
        }

    }
}
