using Movimentacao_Manual.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
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
         
        public string Inclusao(MOVIMENTO_MANUAL movManual)
        {
            try
            {
                cmd.Connection = conec.Conectar();
                cmd = new SqlCommand("PROC_CRUD", conec.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mes", SqlDbType.Real).Value = movManual.DAT_MES;
                cmd.Parameters.Add("@ano", SqlDbType.Real).Value = movManual.DAT_ANO;
                cmd.Parameters.Add("@produto", SqlDbType.Char).Value = movManual.COD_PRODUTO;
                cmd.Parameters.Add("@cosif", SqlDbType.Char).Value = movManual.COD_COSIF;
                cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = movManual.DES_DESCRICAO;
                cmd.Parameters.Add("@valor", SqlDbType.Real).Value = movManual.VAL_VALOR;
                cmd.Parameters.Add("@Acao", SqlDbType.VarChar).Value = "Inserir";
                cmd.ExecuteNonQuery();
                this.mensagem = "Cadastrado com sucesso";
                conec.Desconectar();

            }
            catch (SqlException e)
            {

                this.mensagem = "Erro com o Banco de Dados" + e.Message;
            }

            return mensagem;
        }


        public List<PROC_GRID> ListarGrid()
        {
            List<PROC_GRID> ListaGrid = new List<PROC_GRID>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                Conexao conec = new Conexao();
                DataTable TabelaDataTable = new DataTable();
                cmd.Connection = conec.Conectar();
                cmd = new SqlCommand("PROC_CRUD", conec.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Acao", SqlDbType.VarChar).Value = "Consultar";

                SqlDataReader ListaReader = cmd.ExecuteReader();
                TabelaDataTable.Load(ListaReader);

                foreach (DataRow obj in TabelaDataTable.Rows)
                {

                    int mes = int.Parse(obj[0].ToString());
                    int ano = int.Parse(obj[1].ToString());
                    string cod_prod = obj[2].ToString();
                    string des_prod = obj[3].ToString();
                    int num_lanca = int.Parse(obj[4].ToString());
                    string des_des = obj[5].ToString();
                    double valor = double.Parse(obj[6].ToString());
                    ListaGrid.Add(new PROC_GRID(mes, ano, cod_prod, des_prod, num_lanca, des_des, valor));
  
                }

                //formataGridView();
                conec.Desconectar();
            }
            catch (SqlException e)
            {

                this.mensagem = "Erro com o Banco de Dados" + e.Message;
            }
            return ListaGrid;

        }


        //******************************************************************************************
        //Não Utilizado
        public void CarregarProdutos()
        {
            try
            {
                cmd.Connection = conec.Conectar();
                Consulta_Movimentos consulta = new Consulta_Movimentos();
                SqlDataAdapter ListaAdapter = new SqlDataAdapter("SELECT * FROM PRODUTO", conec.con);
                DataTable TabelaDataTable = new DataTable();

                ListaAdapter.Fill(TabelaDataTable);
                consulta.cbProduto.DataSource = TabelaDataTable;
                consulta.cbProduto.ValueMember = "COD_PRODUTO";
                consulta.cbProduto.DisplayMember = "DES_PRODUTO";
                consulta.cbProduto.SelectedItem = "";
                consulta.cbProduto.Refresh();
                conec.Desconectar(); ;
            }
            catch (SqlException e)
            {

                this.mensagem = "Erro com o Banco de Dados" + e.Message;
            }
        }
        //******************************************************************************************
    }
}

