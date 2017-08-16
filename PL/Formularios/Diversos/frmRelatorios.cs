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
    public partial class frmRelatorios : Form
    {
        VendaINFO vendainfo = new VendaINFO();
        vendaBLL vendabll = new vendaBLL();

        public frmRelatorios()
        {
            InitializeComponent();
        }

        private void btnVendasPorData_Click(object sender, EventArgs e)
        {
            frmVendasPorDatas Fv = new frmVendasPorDatas();        
            Fv.Show();
        }

        private void btnFluxo_Click(object sender, EventArgs e)
        {
           frmFluxoDeCaixa Ff = new frmFluxoDeCaixa();
            Ff.Show();
        }
    }
}
