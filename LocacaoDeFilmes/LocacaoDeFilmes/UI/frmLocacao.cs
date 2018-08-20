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
    public partial class frmLocacao : Form
    {
        public frmLocacao()
        {
            InitializeComponent();
        }

        private BLL.Clientes clientes = new BLL.Clientes();
        private BLL.Filmes filmes = new BLL.Filmes();
        List<BLL.Filmes> listaFilmes = new List<BLL.Filmes>();

        internal BLL.Filmes Filmes
        {
            get
            {
                return filmes;
            }
            set
            {
                filmes = value;

            }
        }

        internal BLL.Clientes Clientes
        {
            get
            {
                return clientes;
            }
            set
            {
                clientes = value;

            }
        }

        

        private void btnSelecionarCliente_Click(object sender, EventArgs e)
        {
            UI.frmBuscaDeClientes tela = new frmBuscaDeClientes();
            tela.ShowDialog();
            if (clientes.Cod != 0)
            {
                txtCodCli.Text = clientes.Cod.ToString();
                txtNomeCli.Text = clientes.Nome;
            }
        }

        private void btnSelecionarProduto_Click(object sender, EventArgs e)
        {
            UI.frmBuscaDeFilmes tela = new frmBuscaDeFilmes();
            tela.ShowDialog();
            if (clientes.Cod != 0)
            {
                txtCodFilme.Text = filmes.Cod.ToString();
                txtTitulo.Text = filmes.Titulo;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            BLL.Filmes f = new BLL.Filmes();
            f.Cod = Convert.ToInt16(txtCodFilme.Text);
            f.Titulo = txtTitulo.Text;
            f.Qtd = Convert.ToInt16(nudQtd.Value);
            f.Observacoes = filmes.Observacoes;
            f.TipoDeMidia = filmes.TipoDeMidia;

            if (listaFilmes.Exists(x => x.Cod == f.Cod))
            {
                f = listaFilmes.First(x => x.Cod == f.Cod);
                if (f.Qtd + Convert.ToInt16(nudQtd.Value) <= nudQtd.Maximum)
                {
                    f.Qtd = f.Qtd + Convert.ToInt16(nudQtd.Value);
                }
                else
                {
                    MessageBox.Show("Quantidade máxima não permitida");
                }

            }
            else
            {
                listaFilmes.Add(f);
            }

            dgvResultado.DataSource = null;
            dgvResultado.DataSource = listaFilmes;

            
        }

        private void frmLocacao_Load(object sender, EventArgs e)
        {
            dgvResultado.ReadOnly = true;

            dgvResultado.AllowUserToAddRows = false;

            dgvResultado.AllowUserToDeleteRows = false;

            dgvResultado.MultiSelect = false;

            dgvResultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvResultado.RowHeadersVisible = false;

            dgvResultado.AllowUserToResizeRows = false;

            dgvResultado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnLimparItens_Click(object sender, EventArgs e)
        {
            listaFilmes.Clear();
            dgvResultado.DataSource = null;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows.Count > 0)
            {
                int cod;
                cod = Convert.ToInt16(dgvResultado.SelectedRows[0].Cells["Cod"].Value);

                BLL.Filmes f = listaFilmes.First(x => x.Cod == cod);
                if (f.Qtd <= nudQtdRemover.Value)
                {
                    listaFilmes.Remove(listaFilmes.First(x => x.Cod == cod));
                }
                else
                {
                    f.Qtd -= Convert.ToInt16(nudQtdRemover.Value);
                }

                listaFilmes.Remove(listaFilmes.First(x => x.Cod == cod));

                dgvResultado.DataSource = null;
                dgvResultado.DataSource = listaFilmes;

                
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            DAL.LocacaoDAL lDAL = new DAL.LocacaoDAL();
            BLL.Locacao locacao = new BLL.Locacao();
            List<BLL.LocacaoFilme> locacaoFilme = new List<BLL.LocacaoFilme>();

            foreach (BLL.Filmes f in listaFilmes)
            {
                BLL.LocacaoFilme lItem = new BLL.LocacaoFilme();
                lItem.CodFilme = f.Cod;
                lItem.CodLocacao = f.Cod;
                

                locacaoFilme.Add(lItem);
            }

            locacao.CodCliente = clientes.Cod;
            locacao.ListaDeItens = locacaoFilme;

            try
            {

                lDAL.Cadastrar(locacao);
                MessageBox.Show("Locação Registrada");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            listaFilmes.Clear();
            dgvResultado.DataSource = null;
        }
    }
    
}
