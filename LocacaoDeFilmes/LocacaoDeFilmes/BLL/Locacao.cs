using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoDeFilmes.BLL
{
    class Locacao
    {
        private int _cod;
        private int _codCliente;
        private DateTime _dataLocacao;

        private List<LocacaoFilme> listaLocacao = new List<LocacaoFilme>();
        public List<LocacaoFilme> ListaDeItens
        {
            get { return listaLocacao; }
            set { listaLocacao = value; }
        }

        public int Cod
        {
            get
            {
                return _cod;
            }

            set
            {
                _cod = value;
            }
        }

        public int CodCliente
        {
            get
            {
                return _codCliente;
            }

            set
            {
                _codCliente = value;
            }
        }

        public DateTime DataLocacao
        {
            get
            {
                return _dataLocacao;
            }

            set
            {
                _dataLocacao = value;
            }
        }
    }
}
