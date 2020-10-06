using Movimentacao_Manual.DAL;
using Movimentacao_Manual.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movimentacao_Manual
{
    public partial class Consulta_Movimentos : Form
    {
        public Consulta_Movimentos()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtMes.Enabled = true;
            txtAno.Enabled = true;
            cbProduto.Enabled = true;
            cbCosif.Enabled = true;
            txtValor.Enabled = true;
            txtDescricao.Enabled = true;
            btnIncluir.Enabled = true;
            btnLimpar.Enabled = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMes.Enabled = false;
            txtMes.Text = "";
            txtAno.Enabled = false;
            txtAno.Text = "";
            cbProduto.Enabled = false;
            cbProduto.Text = "";
            cbCosif.Enabled = false;
            cbCosif.Text = "";
            txtValor.Enabled = false;
            txtValor.Text = "";
            txtDescricao.Enabled = false;
            txtDescricao.Text = "";
            btnIncluir.Enabled = false;
            btnLimpar.Enabled = false;
        }
        Controle controle = new Controle();
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMes.Text != "" && txtAno.Text != "" && txtValor.Text != "" && txtDescricao.Text != "")
                {
                    LoginComandos loginComandos = new LoginComandos();
                    string mensagem2 = controle.Incluir(txtMes.Text, txtAno.Text, txtValor.Text, txtDescricao.Text);
                    MessageBox.Show(mensagem2, "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (txtMes.Text == "")
                    {
                        MessageBox.Show("Campo Mês vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMes.Focus();
                        return;
                    }
                    if (txtAno.Text == "")
                    {
                        MessageBox.Show("Campo Ano vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAno.Focus();
                        return;
                    }
                    if (txtValor.Text == "")
                    {
                        MessageBox.Show("Campo Valor vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtValor.Focus();
                        return;
                    }
                    if (txtDescricao.Text == "")
                    {
                        MessageBox.Show("Campo Descrição vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDescricao.Focus();
                        return;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
