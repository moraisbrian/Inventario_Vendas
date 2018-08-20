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
    public partial class frmBuscaDeFilmes : Form
    {
        public frmBuscaDeFilmes()
        {
            InitializeComponent();
        }

        DAL.FilmesDAL filmesDAL = new DAL.FilmesDAL();
        BLL.Filmes filmes = new BLL.Filmes();

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            filmes.Cod = Convert.ToInt16(dgvResultado.SelectedRows[0].Cells["Cod"].Value);
            filmes.Titulo = dgvResultado.SelectedRows[0].Cells["Titulo"].Value.ToString();
            filmes.TipoDeMidia = dgvResultado.SelectedRows[0].Cells["TipoDeMidia"].Value.ToString();
            filmes.Observacoes = dgvResultado.SelectedRows[0].Cells["Observacoes"].Value.ToString();
            filmes.Qtd = Convert.ToInt16(dgvResultado.SelectedRows[0].Cells["qtd"].Value);

            ((frmLocacao)Application.OpenForms["frmLocacao"]).Filmes = filmes;
            
            this.Close();
        }

        private void frmBuscaDeFilmes_Load(object sender, EventArgs e)
        {
            dgvResultado.DataSource = filmesDAL.Consultar();

            dgvResultado.ReadOnly = true;

            dgvResultado.AllowUserToAddRows = false;

            dgvResultado.AllowUserToDeleteRows = false;

            dgvResultado.MultiSelect = false;

            dgvResultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvResultado.RowHeadersVisible = false;

            dgvResultado.AllowUserToResizeRows = false;

            dgvResultado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
