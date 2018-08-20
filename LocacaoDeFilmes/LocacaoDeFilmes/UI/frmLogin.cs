﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocacaoDeFilmes.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        internal BLL.Login RetornaLogin()
        {
            return login;
        }
      

        BLL.Login login = new BLL.Login();
        DAL.LoginDAL loginDAL = new DAL.LoginDAL();
        
        private void btnAutenticar_Click(object sender, EventArgs e)
        {
            login.Usuario = txtUsuario.Text;
            login.Senha = txtSenha.Text;

            login = loginDAL.Autenticar(login);

            if (login.Autenticado == false)
            {
                MessageBox.Show("Usuário ou senha inválidos");
            }
            else
            {
                MessageBox.Show("Logado");
                
                this.Close();
                
            }
        }
    }
}
