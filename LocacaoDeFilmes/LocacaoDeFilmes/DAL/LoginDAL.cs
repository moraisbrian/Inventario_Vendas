using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace LocacaoDeFilmes.DAL
{
    class LoginDAL
    {
        Conexao con = new Conexao();
        

        public BLL.Login Autenticar(BLL.Login l)
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    Usuario,
                                    Senha,
                                    NivelAcesso
                                FROM
                                    TB_Login
                                WHERE
                                    Usuario = @usuario
                                AND
                                    Senha = @senha";
            cmd.Parameters.AddWithValue("@usuario", l.Usuario);
            cmd.Parameters.AddWithValue("@senha", (l.Senha));
            SqlDataReader dr = cmd.ExecuteReader();
            l.Autenticado = dr.HasRows; 
            con.Desconectar();

            Properties.Settings.Default.nivel = l.Usuario;
            return l;
        }
       
      
    }
}
