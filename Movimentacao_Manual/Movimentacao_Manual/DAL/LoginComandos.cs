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
        public string Inclusao(string mes, string ano, string valor, string descricao)
        {
            try
            {
                cmd.Connection = conec.Conectar();
                cmd = new SqlCommand("Proc_CRUD", conec.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mes", SqlDbType.VarChar).Value = mes;
                cmd.Parameters.Add("@ano", SqlDbType.VarChar).Value = ano;
                cmd.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = descricao;
                cmd.ExecuteNonQuery();
                this.mensagem = "Cadastrado com sucesso";
                conec.Desconectar();

            }
            catch (SqlException)
            {

                this.mensagem = "Erro com o Banco de Dados";
            }

            return mensagem;
        }
    }
}

