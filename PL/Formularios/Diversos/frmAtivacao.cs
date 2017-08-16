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
    public partial class frmAtivacao : Form
    {
        public int Cont;
        AtivacaoBLL Ativacaobll = new AtivacaoBLL();
        public DateTime dtInicio = DateTime.Now.AddMonths(1);
        public AtivacaoINFO obj = new AtivacaoINFO();
        List<AtivacaoINFO> listObj = new List<AtivacaoINFO>();

        public SerialINFO objSerial = new SerialINFO();
        List<SerialINFO> listObjSerial = new List<SerialINFO>();
        SerialBLL Serialbll = new SerialBLL();


        public frmAtivacao()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Confirmacao();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Now.ToShortDateString();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SelecionarTodos()
        {
            listObj = Ativacaobll.SelecionarTodos();
            obj = listObj.Find(p => p.Ativo == true);
        }

        private void SelecionarTodosSerial ()
        {
            listObjSerial = Serialbll.SelecionarTodosAtivos();          
        }

        private void Confirmacao ()
        {
            SelecionarTodosSerial();
            objSerial = listObjSerial.Find(p => p.Serial == txtSerial.Text);
            if (objSerial == null)
            {
                MessageBox.Show("Serial Invalido!");
                return;
            }
            else
            {
                SelecionarTodos();

                Cont = 1;
                Cont++;

                AtivacaoINFO salvar = new AtivacaoINFO();
                salvar.DiaDaAtivacao = Convert.ToDateTime(txtData.Text);

                txtData.Text = dtInicio.ToShortDateString();
                salvar.DiaDaExpiracao = Convert.ToDateTime(txtData.Text);
                salvar.Ativo = true;
                salvar.Serial = objSerial.SerialId;
                Ativacaobll.Salvar(salvar);
                MessageBox.Show("Ativação com Sucesso!");
                AlterarSerial();

                if (obj != null)
                {
                    AtivacaoINFO Alterar = new AtivacaoINFO();
                    Alterar.DataId = obj.DataId;
                    obj.DataId = Alterar.DataId;
                    Alterar.Ativo = false;
                    Ativacaobll.Alterar(Alterar);
                    Close();
                }

                else
                {
                    Close();
                }
            }
        }

        private void AlterarSerial()
        {
            objSerial.Ativo = false;
            Serialbll.Salvar(objSerial);
        }
    }
}
