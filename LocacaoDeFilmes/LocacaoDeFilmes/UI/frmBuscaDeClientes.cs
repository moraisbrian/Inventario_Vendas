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
    public partial class frmBuscaDeClientes : Form
    {
        public frmBuscaDeClientes()
        {
            InitializeComponent();
        }

        DAL.FilmesDAL filmesDAL = new DAL.FilmesDAL();
        DAL.ClienteDAL clienteDAL = new DAL.ClienteDAL();
        BLL.Filmes filmes = new BLL.Filmes();
        BLL.Clientes clientes = new BLL.Clientes();

        private void frmBuscaDeClientes_Load(object sender, EventArgs e)
        {
            dgvResultado.DataSource = clienteDAL.Consultar();
            dgvResultado.ReadOnly = true;

            dgvResultado.AllowUserToAddRows = false;

            dgvResultado.AllowUserToDeleteRows = false;

            dgvResultado.MultiSelect = false;

            dgvResultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvResultado.RowHeadersVisible = false;

            dgvResultado.AllowUserToResizeRows = false;

            dgvResultado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows.Count > 0)
            {
              
                clientes.Cod = Convert.ToInt16(dgvResultado.SelectedRows[0].Cells["Cod"].Value);
                clientes.Nome = dgvResultado.SelectedRows[0].Cells["Nome"].Value.ToString();

                ((frmLocacao)Application.OpenForms["frmLocacao"]).Clientes = clientes;
                this.Close();
            }
        }
    }
}
