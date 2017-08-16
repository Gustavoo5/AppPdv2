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
using System.Net.Mail;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.Net;
namespace PL.Formularios.Diversos
{
    public partial class frmContato : Form
    {
        public frmContato()
        {
            InitializeComponent();
        }

        public parametrosINFO obj = new parametrosINFO();

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void frmContato_Load(object sender, EventArgs e)
        {
            RetornaForm();
        }

        private void txtEmailE_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void EnvioEmail()
        {

            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("suporte.bgsoftware@gmail.com", "bgsuporte2cn");
            MailMessage mail = new MailMessage();
            mail.Sender = new System.Net.Mail.MailAddress(obj.Email, obj.Razão_social);
            mail.From = new MailAddress(obj.Email, obj.Razão_social);
            mail.To.Add(new MailAddress("suporte.bgsoftware@gmail.com", "Suporte BG"));
            mail.Subject = txtAssunto.Text;
            mail.Body = "<h1>Suporte</h1></br><p> Enviado Por:  " + obj.Razão_social + "<br/> Endereço :" + obj.Endereco + "</br>Contato :" + obj.Telefone + "</p><p>" + "Mensagem :" + txtConteudo.Text + "</p>";
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;
            try
            {
                client.Send(mail);
                MessageBox.Show("E-mail enviado com Sucesso!", "E-mail enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Entre em contato com o responsavel pelo sistema.","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                mail = null;
            }
                                      
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(txtAssunto.Text.Replace(" ","") == "")
            {
                MessageBox.Show("Assunto não pode ficar em branco.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAssunto.Focus();
                return;
            }
            else if (txtConteudo.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Conteudo não pode ficar em branco.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConteudo.Focus();
                return;
            }
            else
            {
                Thread EnviarEmail = new Thread(EnvioEmail);
                EnviarEmail.Start();
                Close();
            }
        }

        private void RetornaForm ()
        {
            txtEmailE.Text = obj.Email;
            txtRazao.Text = obj.Razão_social;
        }
    }
}
