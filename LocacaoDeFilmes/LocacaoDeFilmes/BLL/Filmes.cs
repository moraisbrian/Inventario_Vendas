using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoDeFilmes.BLL
{
    class Filmes
    {
        private int _cod;
        private string _titulo;
        private string _tipoDeMidia;
        private string _observacoes;
        private int _qtd;

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

        public string Titulo
        {
            get
            {
                return _titulo;
            }

            set
            {
                _titulo = value;
            }
        }

        public string Observacoes
        {
            get
            {
                return _observacoes;
            }

            set
            {
                _observacoes = value;
            }
        }

        public int Qtd
        {
            get
            {
                return _qtd;
            }

            set
            {
                _qtd = value;
            }
        }

        public string TipoDeMidia
        {
            get
            {
                return _tipoDeMidia;
            }

            set
            {
                _tipoDeMidia = value;
            }
        }
    }
}
