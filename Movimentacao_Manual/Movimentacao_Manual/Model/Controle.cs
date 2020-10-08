using Movimentacao_Manual.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movimentacao_Manual.Model
{
    class Controle
    {
        public string mensagem = "";
        LoginComandos loginDaoComandos = new LoginComandos();
        public string Incluir(string mes, string ano, string produto, string cosif, string valor, string descricao)
        {
            try
            {
                this.mensagem = loginDaoComandos.Inclusao(mes, ano, produto, cosif, valor, descricao);

            }
            catch (Exception e)
            {
                this.mensagem = "Error" + e.Message;
            }
            return mensagem;
        }
    }
}
