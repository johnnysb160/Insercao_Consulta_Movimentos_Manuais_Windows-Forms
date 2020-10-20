using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movimentacao_Manual.Model
{
    class PRODUTO_COSIF
    {
        public string COD_CLASSIFICACAO { get; set; }
        public string COD_COSIF { get; set; }
        public string COD_PRODUTO { get; set; }

        public PRODUTO_COSIF()
        {
        }

        public PRODUTO_COSIF(string cOD_CLASSIFICACAO, string cOD_COSIF, string cOD_PRODUTO)
        {
            COD_CLASSIFICACAO = cOD_CLASSIFICACAO;
            COD_COSIF = cOD_COSIF;
            COD_PRODUTO = cOD_PRODUTO;
        }
    }
}
