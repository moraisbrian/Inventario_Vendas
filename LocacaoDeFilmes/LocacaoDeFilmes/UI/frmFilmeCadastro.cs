using System;
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
    public partial class frmFilmeCadastro : Form
    {
        public frmFilmeCadastro()
        {
            InitializeComponent();
        }

        BLL.Filmes filmes = new BLL.Filmes();
        DAL.FilmesDAL filmesDAL = new DAL.FilmesDAL();
        bool atualizar;

        
        

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            filmes.Cod = Convert.ToInt32(txtCod.Text);
            filmes.Titulo = txtTitulo.Text;
            filmes.Observacoes = txtObs.Text;
            filmes.TipoDeMidia = txtTipoDeMidia.Text;
            filmes.Qtd = int.Parse(txtQtd.Text);

            if (atualizar)
            {
                filmesDAL.Atualizar(filmes);
                MessageBox.Show("Atualizado");
                atualizar = false;
                txtCod.ReadOnly = false;
                btnCancelar.Visible = false;
            }
            else
            {
                filmesDAL.Cadastrar(filmes);
                MessageBox.Show("Cadastrado!");
            }            

            

            txtCod.Clear();
            txtObs.Clear();
            txtQtd.Clear();
            txtTipoDeMidia.Clear();
            txtTitulo.Clear();
            txtCod.Focus();
        }
        
        DAL.LoginDAL loginDAL = new DAL.LoginDAL();
        private void frmFilmeCadastro_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.nivel == "usuario")
            {
                btnExcluir.Enabled = false;
            }

            dgvResultado.ReadOnly = true;
            
            dgvResultado.AllowUserToAddRows = false;
            
            dgvResultado.AllowUserToDeleteRows = false;
            
            dgvResultado.MultiSelect = false;
            
            dgvResultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           
            dgvResultado.RowHeadersVisible = false;
          
            dgvResultado.AllowUserToResizeRows = false;
         
            dgvResultado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            atualizar = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta;

            if (dgvResultado.SelectedRows.Count > 0)
            {
                resposta = MessageBox.Show("Deseja realmente excluir?",
                                            "Confirmação",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question,
                                            MessageBoxDefaultButton.Button2);
                if (resposta == DialogResult.Yes)
                {
                    filmes.Cod = Convert.ToInt32(dgvResultado.SelectedRows[0].Cells["Cod"].Value.ToString());
                    filmesDAL.Excluir(filmes);
                   
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            atualizar = false;
            btnCancelar.Visible = false;
            txtCod.ReadOnly = false;

            txtCod.Clear();
            txtTitulo.Clear();
            txtTipoDeMidia.Clear();
            txtObs.Clear();
            txtQtd.Clear();

            txtCod.Focus();
        }

        private void dgvResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            atualizar = true;
            txtCod.ReadOnly = true;
            btnCancelar.Visible = true;
            

            filmes.Cod = Convert.ToInt32(dgvResultado.SelectedRows[0].Cells["Cod"].Value.ToString());

            filmes = filmesDAL.PreecheFilmes(filmes);

            txtCod.Text = filmes.Cod.ToString(); 
            txtTitulo.Text = filmes.Titulo;
            txtTipoDeMidia.Text = filmes.TipoDeMidia;
            txtObs.Text = filmes.Observacoes;
            txtQtd.Text = filmes.Qtd.ToString();

            tabControl1.SelectTab(0);
        }
       
        private void tbpCadastro_Click(object sender, EventArgs e)
        {
           
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 1) 
            {
           
                dgvResultado.DataSource = filmesDAL.Consultar();
            }
        }
    }
}
