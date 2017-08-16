using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Formularios.Pesquisa.Base
{
    public partial class frmBasePesq : Form
    {
        public frmBasePesq()
        {
            InitializeComponent();
        }

        public virtual void frmBasePesq_Load(object sender, EventArgs e)
        {

        }

        public virtual void btnPesq_Click(object sender, EventArgs e)
        {

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
