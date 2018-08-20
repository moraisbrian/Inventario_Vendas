using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoDeFilmes.BLL
{
    class Login
    {
        private string _usuario;
        private string _senha;
        private string _nivelAcesso;

        public string Usuario
        {
            get
            {
                return _usuario;
            }

            set
            {
                _usuario = value;
            }
        }

        public string Senha
        {
            get
            {
                return _senha;
            }

            set
            {
                _senha = value;
            }
        }

        public string NivelAcesso
        {
            get
            {
                return _nivelAcesso;
            }

            set
            {
                _nivelAcesso = value;
            }
        }
        private bool _autenticado;
        public bool Autenticado
        {
            get
            {
                return _autenticado;
            }

            set
            {
                _autenticado = value;
            }
        }
       
    }
}
