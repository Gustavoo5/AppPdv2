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
    public partial class frmPesquisas : Form
    {
        public frmPesquisas()
        {
            InitializeComponent();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            Pesquisa.frmPesqVendas frmPesqVenda = new Pesquisa.frmPesqVendas();
            frmPesqVenda.Show();
        }
    }
}
