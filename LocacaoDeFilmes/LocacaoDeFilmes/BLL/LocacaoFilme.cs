using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoDeFilmes.BLL
{
    class LocacaoFilme
    {
        private int _cod;
        private int _codLocacao;
        private int _codFilme;

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

        public int CodLocacao
        {
            get
            {
                return _codLocacao;
            }

            set
            {
                _codLocacao = value;
            }
        }

        public int CodFilme
        {
            get
            {
                return _codFilme;
            }

            set
            {
                _codFilme = value;
            }
        }
    }
}
