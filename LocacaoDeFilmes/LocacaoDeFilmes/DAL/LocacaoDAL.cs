using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LocacaoDeFilmes.DAL
{
    class LocacaoDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.Locacao l)
        {
            
            int chaveGerada;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"INSERT INTO TB_Locacao       
                                    (CodCliente, DataLocacao)
                                VALUES 
                                    (@codCli, getdate());
                                
                                SELECT SCOPE_IDENTITY();";
            cmd.Parameters.AddWithValue("@codCli", l.CodCliente);
            chaveGerada = Convert.ToInt16(cmd.ExecuteScalar());

            SqlCommand cmdItens = new SqlCommand();
            cmdItens.Connection = con.Conectar();
            cmdItens.CommandText = @"INSERT INTO TB_Locacao_Filme
                                        (CodLocacao, CodFilme)
                                    VALUES
                                        (@codLocacao, @codFilme)";
            cmdItens.Parameters.Add("@codLocacao", SqlDbType.Int);
            cmdItens.Parameters.Add("@codFilme", SqlDbType.Int);
            
            foreach (BLL.LocacaoFilme item in l.ListaDeItens)
            {
                cmdItens.Parameters["@codLocacao"].Value = chaveGerada;
                cmdItens.Parameters["@codFilme"].Value = item.CodFilme;
                cmdItens.ExecuteNonQuery(); 
            }

            con.Desconectar();


        }
    }
}
