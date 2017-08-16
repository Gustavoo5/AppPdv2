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
    public partial class frmFluxoDeCaixa : Form
    {
        FluxoCaixaINFO fluxoinfo = new FluxoCaixaINFO();
        FluxoCaixaBLL fluxobll = new FluxoCaixaBLL();
        List<FluxoCaixaINFO> listFluxo = new List<FluxoCaixaINFO>();

        public frmFluxoDeCaixa()
        {
            InitializeComponent();
        }
        public void carregarGrafico()
        {
            listFluxo = fluxobll.SelecionarTodos();
            foreach(FluxoCaixaINFO fluxo in listFluxo)
            {
                if (chart.Series[0].Points.Count > 6)
                {
                    chart.Series[0].Points.RemoveAt(0);
                    chart.Update();
                }
                chart.Series[0].Points.AddXY(fluxo.dataAbertura, fluxo.saldoLiquido);
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmFluxoCaixa_Load(object sender, EventArgs e)
        {
            carregarGrafico();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Filtrar();
        }
        private void Filtrar()
        {
           listFluxo = fluxobll.Filtrar(Convert.ToDateTime(TxtData1.Value.ToShortDateString()), Convert.ToDateTime(TxtData2.Value.ToShortDateString()));
            chart.Series[0].Points.Clear();

            foreach (FluxoCaixaINFO fluxo in listFluxo)
            {
                if(chart.Series[0].Points.Count > 6)
                {
                    chart.Series[0].Points.RemoveAt(0);
                    chart.Update();
                }
                chart.Series[0].Points.AddXY(fluxo.dataAbertura, fluxo.saldoLiquido);
            }
        }
    }
}
