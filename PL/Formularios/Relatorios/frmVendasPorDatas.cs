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
    public partial class frmVendasPorDatas : Form
    {
        pagamentoBLL pagamentobll = new pagamentoBLL();
        pagamentoINFO obj = new pagamentoINFO();
        List<pagamentoINFO> listObj = new List<pagamentoINFO>();
        public frmVendasPorDatas()
        {
            InitializeComponent();
        }

        private void frmVendasPorDatas_Load(object sender, EventArgs e)
        {
            RetornaPagamentosCmb();
            cmbStatus.SelectedIndex = 0;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void RetornaPagamentosCmb()
        {
            listObj = pagamentobll.RetornaTable();

            cmbPagt.DataSource = listObj;
            cmbPagt.DisplayMember = "descPag";
            cmbPagt.ValueMember = "idFormPag";
            cmbPagt.Refresh();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AppPdvDataSet.RetornaVendasDataPagt' table. You can move, or remove it, as needed.
            this.RetornaVendasDataPagtTableAdapter.Fill(this.AppPdvDataSet.RetornaVendasDataPagt, Convert.ToDateTime(TxtData1.Text), Convert.ToDateTime(TxtData2.Text), (int) cmbPagt.SelectedValue, cmbStatus.Text);
            this.rptVendas.RefreshReport();
        }
    }
}
