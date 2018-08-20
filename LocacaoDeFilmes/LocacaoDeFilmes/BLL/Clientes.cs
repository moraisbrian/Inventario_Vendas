using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoDeFilmes.BLL
{
    class Clientes
    {
        private int _cod;
        private string _nome;

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

        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }
    }
}
