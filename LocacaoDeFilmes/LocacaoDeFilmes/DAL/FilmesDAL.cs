using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LocacaoDeFilmes.DAL
{
    class FilmesDAL
    {

        Conexao con = new Conexao();
        public void Cadastrar(BLL.Filmes f)
        {

            

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"INSERT INTO TB_Filmes(                                   
                                    Cod,
                                    Titulo,
                                    TipoDeMidia,
                                    Observacoes,
                                    qtd)
                                VALUES(@cod, @titulo, @tipoDeMidia, @obs, @qtd)";

            cmd.Parameters.AddWithValue("@cod", f.Cod);
            cmd.Parameters.AddWithValue("@titulo", f.Titulo);
            cmd.Parameters.AddWithValue("@tipoDeMidia", f.TipoDeMidia);
            cmd.Parameters.AddWithValue("@obs", f.Observacoes);
            cmd.Parameters.AddWithValue("@qtd", f.Qtd);

            cmd.ExecuteNonQuery();

            con.Desconectar();
        }

        public DataTable Consultar()
        {

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    Cod,
                                    Titulo,
                                    TipoDeMidia,
                                    Observacoes,
                                    qtd
                                FROM
                                    TB_Filmes";
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Desconectar();

            return dt;
        }

        public void Excluir(BLL.Filmes f)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"DELETE
                                FROM 
                                    TB_Filmes
                                WHERE
                                    Cod = @cod";
            cmd.Parameters.AddWithValue("@cod", f.Cod);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public void Atualizar(BLL.Filmes f)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"UPDATE
                                    TB_Filmes
                                SET
                                    Titulo = @titulo,
                                    TipoDeMidia =@tipoDeMidia,
                                    Observacoes = @obs,
                                    qtd = @qtd                                    
                                WHERE
                                    Cod = @cod";
            cmd.Parameters.AddWithValue("@cod", f.Cod);
            cmd.Parameters.AddWithValue("@titulo", f.Titulo);
            cmd.Parameters.AddWithValue("@tipoDeMidia", f.TipoDeMidia);
            cmd.Parameters.AddWithValue("@obs", f.Observacoes);
            cmd.Parameters.AddWithValue("@qtd", f.Qtd);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public BLL.Filmes PreecheFilmes(BLL.Filmes f)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    Cod,
                                    Titulo,
                                    Observacoes,
                                    TipoDeMidia,
                                    qtd
                                FROM 
                                    TB_Filmes
                                WHERE 
                                    Cod = @cod";
            cmd.Parameters.AddWithValue("@cod", f.Cod);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                f.Cod = Convert.ToInt32(dr["Cod"]);
                f.Titulo = dr["Titulo"].ToString();
                f.Observacoes = dr["Observacoes"].ToString();
                f.TipoDeMidia = dr["TipoDeMidia"].ToString();
                f.Qtd = Convert.ToInt32(dr["qtd"]);
                dr.Close();
                con.Desconectar();
            }
            else
            {
                f.Cod = 0;
            }

            return (f);

        }
    }
}
