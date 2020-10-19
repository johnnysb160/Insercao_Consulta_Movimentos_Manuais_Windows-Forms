using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movimentacao_Manual.Model
{
    class PROC_GRID
    {
        public int DAT_MES { get; set; }
        public int DAT_ANO { get; set; }
        public string COD_PRODUTO { get; set; }
        public string DES_PRODUTO { get; set; }
        public decimal NUM_LANCAMENTO { get; set; }
        public string DES_DESCRICAO { get; set; }
        public double VAL_VALOR { get; set; }

        public PROC_GRID()
        {
        }

        public PROC_GRID(int dAT_MES, int dAT_ANO, string cOD_PRODUTO, string dES_PRODUTO, decimal nUM_LANCAMENTO, string dES_DESCRICAO, double vAL_VALOR)
        {
            DAT_MES = dAT_MES;
            DAT_ANO = dAT_ANO;
            COD_PRODUTO = cOD_PRODUTO;
            DES_PRODUTO = dES_PRODUTO;
            NUM_LANCAMENTO = nUM_LANCAMENTO;
            DES_DESCRICAO = dES_DESCRICAO;
            VAL_VALOR = vAL_VALOR;
        }


    }
}
