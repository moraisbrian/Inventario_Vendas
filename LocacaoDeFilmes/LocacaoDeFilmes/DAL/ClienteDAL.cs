using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LocacaoDeFilmes.DAL
{
    class ClienteDAL
    {
        Conexao con = new Conexao();
        public DataTable Consultar()
        {

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    Cod,
                                    Nome
                                FROM
                                    TB_Clientes";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Desconectar();

            return dt;
        }
    }
}
