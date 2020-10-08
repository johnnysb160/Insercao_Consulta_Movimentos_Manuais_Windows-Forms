using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movimentacao_Manual.DAL
{
    class LoginComandos
    {
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao conec = new Conexao();
        public string Inclusao(string mes, string ano, string produto, string cosif, string valor, string descricao)
        {
            try
            {
                cmd.Connection = conec.Conectar();
                cmd = new SqlCommand("PROC_CRUD", conec.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mes", SqlDbType.Real).Value = mes;
                cmd.Parameters.Add("@ano", SqlDbType.Real).Value = ano;
                cmd.Parameters.Add("@produto", SqlDbType.Char).Value = produto;
                cmd.Parameters.Add("@cosif", SqlDbType.Char).Value = cosif;
                cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = descricao;
                cmd.Parameters.Add("@valor", SqlDbType.Real).Value = valor;
                cmd.ExecuteNonQuery();
                this.mensagem = "Cadastrado com sucesso";
                conec.Desconectar();

            }
            catch (SqlException e)
            {

                this.mensagem = "Erro com o Banco de Dados"+e.Message;
            }

            return mensagem;
        }
        
      
    }
}

