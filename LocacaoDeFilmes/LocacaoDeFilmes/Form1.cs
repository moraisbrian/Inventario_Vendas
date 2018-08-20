using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocacaoDeFilmes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void filmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmFilmeCadastro"] == null)
            {
                UI.frmFilmeCadastro tela = new UI.frmFilmeCadastro();
                tela.MdiParent = this;
                tela.Show();
            }
        }
        DAL.LoginDAL loginDAL = new DAL.LoginDAL();
       
        private void Form1_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Usuário: Nenhum";
            filmesToolStripMenuItem.Enabled = false;
            locaçãoToolStripMenuItem.Enabled = false;
            loginLogoutToolStripMenuItem.Text = "Login";

            
            
                UI.frmLogin tela = new UI.frmLogin();
                tela.ShowDialog();
            

            if (tela.RetornaLogin().Autenticado)
            {

                lblUsuario.Text = "Usuário: " + tela.RetornaLogin().Usuario;
                filmesToolStripMenuItem.Enabled = true;
                locaçãoToolStripMenuItem.Enabled = true;
                loginLogoutToolStripMenuItem.Text = "Logout";
            }
        }

        private void loginLogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1_Load(null, null);
        }

        private void locaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmLocacao"] == null)
            {
                UI.frmLocacao tela = new UI.frmLocacao();
                tela.MdiParent = this;
                tela.Show();
            }
        }
    }
}

