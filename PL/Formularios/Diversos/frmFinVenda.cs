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
    public partial class frmFinVenda : Form
    {
        public frmFinVenda()
        {
            InitializeComponent();
        }
        vendaBLL vendabll = new vendaBLL();
        public VendaINFO objVenda = new VendaINFO();

        List<pagamentoINFO> listPag = new List<pagamentoINFO>();
        pagamentoBLL PagamentoBll = new pagamentoBLL();
        pagamentoINFO ObjPag = new pagamentoINFO();

        public List<ComponenteVendaINFO> listComp = new List<ComponenteVendaINFO>();
        componenteVendaBLL componentevendabll = new componenteVendaBLL();
        ComponenteVendaINFO objComp = new ComponenteVendaINFO();

        public string msg;

        private void frmFinVenda_Load(object sender, EventArgs e)
        {
            RetornaFormPagt();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            msg = "";
            Close();
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Salvar();
            Close();
        }

        private void RetornaFormPagt()
        {
            listPag = PagamentoBll.RetornaTable();
            cmbFormPagt.DataSource = listPag;
            cmbFormPagt.DisplayMember = "descPag";
            cmbFormPagt.ValueMember = "idFormPag";
            Refresh();
        }

        private void Salvar()
        {
            objVenda.IdFormPag = (int)cmbFormPagt.SelectedValue;
            vendabll.Salvar(objVenda);
            if (listComp.Count > 0)
            {
                foreach(ComponenteVendaINFO comp in listComp)
                {
                    comp.IdVenda = objVenda.IdVenda;
                    componentevendabll.Salvar(comp);
                }
            }
            msg = "Venda finalizada com sucesso!";           
        }
    }
}
