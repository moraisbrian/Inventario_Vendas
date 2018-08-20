using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace LocacaoDeFilmes.DAL
{
    class Conexao
    {
        SqlConnection con;


        public Conexao()
        {
            con = new SqlConnection();
            con.ConnectionString = @"DATA SOURCE = (LOCAL);
                                   INITIAL CATALOG = BD_Locacao;
                                   INTEGRATED SECURITY = TRUE";
        }

        public SqlConnection Conectar()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void Desconectar()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}

