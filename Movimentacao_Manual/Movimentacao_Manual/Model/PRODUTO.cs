using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movimentacao_Manual.Model
{
    class PRODUTO
    {
        public string COD_PRODUTO { get; set; }
        public string DES_PRODUTO { get; set; }

        public PRODUTO()
        {
        }

        public PRODUTO(string cOD_PRODUTO, string dES_PRODUTO)
        {
            COD_PRODUTO = cOD_PRODUTO;
            DES_PRODUTO = dES_PRODUTO;
        }
    }
}
