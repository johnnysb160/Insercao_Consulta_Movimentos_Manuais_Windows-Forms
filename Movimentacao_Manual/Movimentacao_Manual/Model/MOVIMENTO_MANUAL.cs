using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movimentacao_Manual.Model
{
    class MOVIMENTO_MANUAL
    {
        public int DAT_MES { get; set; }
        public int DAT_ANO { get; set; }
        public decimal NUM_LANCAMENTO { get; set; }
        public string COD_PRODUTO { get; set; }
        public string COD_COSIF { get; set; }
        public string DES_DESCRICAO { get; set; }
        public  DateTime DAT_MOVIMENTO { get; set; }
        public string COD_USUARIO { get; set; }
        public decimal VAL_VALOR { get; set; }

        public MOVIMENTO_MANUAL()
        {
        }

        //public MOVIMENTO_MANUAL(int dAT_MES, int dAT_ANO, decimal nUM_LANCAMENTO, string cOD_PRODUTO, string cOD_COSIF, string dES_DESCRICAO, DateTime dAT_MOVIMENTO, string cOD_USUARIO, decimal vAL_VALOR)
        //{
        //    DAT_MES = dAT_MES;
        //    DAT_ANO = dAT_ANO;
        //    NUM_LANCAMENTO = nUM_LANCAMENTO;
        //    COD_PRODUTO = cOD_PRODUTO;
        //    COD_COSIF = cOD_COSIF;
        //    DES_DESCRICAO = dES_DESCRICAO;
        //    DAT_MOVIMENTO = dAT_MOVIMENTO;
        //    COD_USUARIO = cOD_USUARIO;
        //    VAL_VALOR = vAL_VALOR;
        //}

        public MOVIMENTO_MANUAL(int dAT_MES, int dAT_ANO, decimal nUM_LANCAMENTO, string cOD_PRODUTO, string cOD_COSIF, string dES_DESCRICAO, DateTime dAT_MOVIMENTO, string cOD_USUARIO, string sTRING_VAL_VALOR)
        {
            DAT_MES = dAT_MES;
            DAT_ANO = dAT_ANO;
            NUM_LANCAMENTO = nUM_LANCAMENTO;
            COD_PRODUTO = cOD_PRODUTO;
            COD_COSIF = cOD_COSIF;
            DES_DESCRICAO = dES_DESCRICAO;
            DAT_MOVIMENTO = dAT_MOVIMENTO;
            COD_USUARIO = cOD_USUARIO;
            VAL_VALOR = decimal.Parse( sTRING_VAL_VALOR.Replace("R$", ""));
        }
    }
}
