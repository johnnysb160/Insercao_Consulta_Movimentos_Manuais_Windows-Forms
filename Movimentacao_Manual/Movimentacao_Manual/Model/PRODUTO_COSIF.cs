using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movimentacao_Manual.Model
{
    class PRODUTO_COSIF
    {
        string COD_PRODUTO { get; set; }
        string COD_COSIF { get; set; }
        string COD_CLASSIFICACAO { get; set; }
        string STA_STATUS { get; set; }

        public PRODUTO_COSIF()
        {
        }

        public PRODUTO_COSIF(string cOD_PRODUTO, string cOD_COSIF, string cOD_CLASSIFICACAO, string sTA_STATUS)
        {
            COD_PRODUTO = cOD_PRODUTO;
            COD_COSIF = cOD_COSIF;
            COD_CLASSIFICACAO = cOD_CLASSIFICACAO;
            STA_STATUS = sTA_STATUS;
        }
    }
}
