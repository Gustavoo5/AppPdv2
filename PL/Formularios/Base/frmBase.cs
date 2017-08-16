using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
        }

        public virtual void BtnCancel_Click(object sender, EventArgs e)
        {
            ControleForm(true);
        }

        public virtual void BtnSalvar_Click(object sender, EventArgs e)
        {
            ControleForm(true);
        }

        public virtual void BtnDel_Click(object sender, EventArgs e)
        {

        }

        public virtual void BtnAlt_Click(object sender, EventArgs e)
        {
            ControleForm(false);
        }

        public virtual void BtnNovo_Click(object sender, EventArgs e)
        {
            ControleForm(false);
        }

        public virtual void FrmBase_Load(object sender, EventArgs e)
        {
            ControleForm(true);
        }

        public virtual void BtnPesq_Click(object sender, EventArgs e)
        {

        }

        private void ControleForm(bool status)
        {
            ControleBtns(status);
            groupPesq.Enabled = status;
            groupDados.Enabled = !status;

        }

        private void ControleBtns(bool status)
        {
            btnAlt.Enabled = status;
            btnDel.Enabled = status;
            btnNovo.Enabled = status;
            btnCancel.Enabled = !status;
            btnSalvar.Enabled = !status;
        }

        private void frmBase_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    BtnNovo_Click(sender, e);
                    break;
                case Keys.F2:
                    BtnAlt_Click(sender, e);
                    break;
                case Keys.F3:
                    BtnDel_Click(sender, e);
                    break;
                case Keys.F4:
                    BtnSalvar_Click(sender, e);
                    break;
                case Keys.F5:
                    BtnCancel_Click(sender, e);
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void txtPesq_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
