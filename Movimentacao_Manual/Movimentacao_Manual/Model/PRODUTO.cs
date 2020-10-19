using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movimentacao_Manual.Model
{
    class PRODUTO
    {
        string COD_PRODUTO { get; set; }
        string DES_PRODUTO { get; set; }
        string STA_STATUS { get; set; }

        public PRODUTO()
        {
        }

        public PRODUTO(string cOD_PRODUTO, string dES_PRODUTO, string sTA_STATUS)
        {
            COD_PRODUTO = cOD_PRODUTO;
            DES_PRODUTO = dES_PRODUTO;
            STA_STATUS = sTA_STATUS;
        }
    }
}
