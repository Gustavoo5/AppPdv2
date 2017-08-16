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
    public partial class frmFluxoCaixa : Form
    {
        public frmFluxoCaixa()
        {
            InitializeComponent();
        }

        List<FluxoCaixaINFO> listObj = new List<FluxoCaixaINFO>();
        public FluxoCaixaINFO obj = new FluxoCaixaINFO();
        FluxoCaixaBLL Fluxocaixabll = new FluxoCaixaBLL();

        public bool prosseguir = false;

        private void frmFluxoCaixa_Load(object sender, EventArgs e)
        {
            RetornarTodos();
            txtData.Text = DateTime.Now.ToShortDateString();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            obj = listObj.Find(p => p.dataAbertura == DateTime.Now.Date && p.situacao == true);
            if (obj == null)
            {
                if (txtSaldoIni.Text.Replace(" ", "") != "")
                {
                    Salvar();
                    MessageBox.Show("Caixa aberto com sucesso! \nLembre-se de feixar ao término do expediente. Isso pode ser feito teclando F9 na tela de vendas.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RetornarTodos ()
        {
            listObj = Fluxocaixabll.SelecionarTodos();
        }

        private void Salvar ()
        {
            obj = new FluxoCaixaINFO
            {
                dataAbertura = DateTime.Now.Date,
                saldoInicial = Convert.ToDecimal(txtSaldoIni.Text),
                saldoBruto = 0,
                userFechamento = 1,
                saldoLiquido = 0,
                situacao = true
            };
            Fluxocaixabll.Salvar(obj);
            prosseguir = true;
        }
    }
}
