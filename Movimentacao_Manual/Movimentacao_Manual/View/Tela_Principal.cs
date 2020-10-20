using Movimentacao_Manual.DAL;
using Movimentacao_Manual.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movimentacao_Manual
{
    public partial class Consulta_Movimentos : Form
    {
        LoginComandos loginComandos = new LoginComandos();
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
            cbCosif.Enabled = false;
            txtValor.Enabled = false;
            txtValor.Text = "";
            txtDescricao.Enabled = false;
            txtDescricao.Text = "";
            btnIncluir.Enabled = false;
            btnLimpar.Enabled = false;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMes.Text == "" || int.Parse(txtMes.Text) < 1 || int.Parse(txtMes.Text) > 12)
                {
                    MessageBox.Show("Campo Mês errado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMes.Focus();
                    return;
                }
                if (txtAno.Text == "" || int.Parse(txtAno.Text) < 1990 || int.Parse(txtAno.Text) > 2030)
                {
                    MessageBox.Show("Campo Ano errado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                else
                {
                    MOVIMENTO_MANUAL movManual = new MOVIMENTO_MANUAL(int.Parse(txtMes.Text), int.Parse(txtAno.Text), 0, cbProduto.SelectedValue.ToString(), cbCosif.Text, txtDescricao.Text, DateTime.Now, "", txtValor.Text);
                    string mensagem2 = loginComandos.Inclusao(movManual);
                    MessageBox.Show(mensagem2, "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarGrid();
                    txtMes.Enabled = false;
                    txtMes.Text = "";
                    txtAno.Enabled = false;
                    txtAno.Text = "";
                    cbProduto.Enabled = false;
                    cbCosif.Enabled = false;
                    txtValor.Enabled = false;
                    txtValor.Text = "";
                    txtDescricao.Enabled = false;
                    txtDescricao.Text = "";
                    btnIncluir.Enabled = false;
                    btnLimpar.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(loginComandos.mensagem);
            }
        }

        public void ListarGrid()
        {
            try
            {
                dataGridView.DataSource = loginComandos.ListarGrid();

                //formatar o GridView
                var grade = dataGridView;
                grade.AutoGenerateColumns = false;
                grade.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                grade.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                //altera a cor das linhas alternadas no grid
                grade.RowsDefaultCellStyle.BackColor = Color.White;
                grade.AlternatingRowsDefaultCellStyle.BackColor = Color.Cyan;
                //altera o nome das colunas
                grade.Columns[0].HeaderText = "Mês";
                grade.Columns[1].HeaderText = "Ano";
                grade.Columns[2].HeaderText = "Código do Produto";
                grade.Columns[3].HeaderText = "Descrição do Produto";
                grade.Columns[4].HeaderText = "NR Lançamento";
                grade.Columns[5].HeaderText = "Descrição";
                grade.Columns[6].HeaderText = "Valor";
                grade.Columns[0].Width = 40;
                grade.Columns[1].Width = 40;
                grade.Columns[2].Width = 70;
                grade.Columns[3].Width = 100;
                grade.Columns[4].Width = 90;
                grade.Columns[5].Width = 150;
                grade.Columns[6].Width = 110;
                //formata as colunas valor, vencimento e pagamento
                grade.Columns[6].DefaultCellStyle.Format = "c";
                //seleciona a linha inteira
                grade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //não permite seleção de multiplas linhas    
                grade.MultiSelect = false;
                // exibe nulos formatados
                //grade.DefaultCellStyle.NullValue = " - ";
                //permite que o texto maior que célula não seja truncado
                grade.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                //define o alinhamento à direita
                grade.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grade.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grade.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                grade.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            }
            catch (SqlException e)
            {

                MessageBox.Show("Erro com o Banco de Dados" + e.Message);
            }
        }

        public void CarregaProdutos()
        {
            try
            {
                cbProduto.DataSource = loginComandos.CarregarProdutos();
                cbProduto.ValueMember = "cod_produto";
                cbProduto.DisplayMember = "des_produto";
                cbProduto.Refresh();
            }
            catch (SqlException e)
            {

                MessageBox.Show("Erro com o Banco de Dados" + e.Message);
            }
        }

        public void CarregaCosif()
        {
            try
            {
                cbCosif.DataSource = loginComandos.CarregarCodCosif();
                cbCosif.ValueMember = "cod_classificacao";
                cbCosif.DisplayMember = "cod_cosif";
                cbCosif.Refresh();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro com o Banco de Dados" + e.Message);
            }
        }

        private void cbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query = from p in loginComandos.CarregarCodCosif()
                        where p.COD_PRODUTO == cbProduto.SelectedValue.ToString()
                        select p;
            cbCosif.DataSource = query.ToList();
            cbCosif.ValueMember = "cod_classificacao";
            cbCosif.DisplayMember = "cod_cosif";
            cbCosif.Refresh();
        }

        //Não utilizado************************************************************
        //private void cbCosif_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    var query = from p in loginComandos.CarregarCodCosif()
        //              where p.COD_CLASSIFICACAO == cbCosif.SelectedValue.ToString()
        //              select p.COD_PRODUTO;

        //    var query2 = from p in loginComandos.CarregarProdutos()
        //                where p.COD_PRODUTO == query.First()
        //                select p.DES_PRODUTO;
        //    cbProduto.DataSource = query2.ToList();
        //    cbProduto.ValueMember = "cod_produto";
        //    cbProduto.DisplayMember = "des_produto";
        //    cbProduto.Refresh();
        //}
        //Não utilizado************************************************************

        private void Consulta_Movimentos_Load(object sender, EventArgs e)
        {
            ListarGrid();
            CarregaProdutos();
            CarregaCosif();
        }

        private void txtMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)

                {
                    e.Handled = true;
                    MessageBox.Show("Este campo aceita apenas números");
                }
                else
                {
                    e.Handled = false;
                }
            }
            catch (Exception a)
            {

                MessageBox.Show("Error" + a.Message);
            }
        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)

                {
                    e.Handled = true;
                    MessageBox.Show("Este campo aceita apenas números");
                }
            }
            catch (Exception a)
            {

                MessageBox.Show("Error" + a.Message);
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                var ContDecimal = txtValor.Text.Length;
                if (txtValor.Text.Contains(','))
                {
                    ContDecimal = txtValor.Text.IndexOf(',') + 2;
                    if (txtValor.Text.Length > ContDecimal && e.KeyChar != (Char)8)
                    {
                        e.KeyChar = (Char)0;
                    }
                }
                if ((e.KeyChar < '0' || e.KeyChar > '9') &&
                 (e.KeyChar != ',' && e.KeyChar != '.' &&
                  e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
                {
                    e.KeyChar = (Char)0;
                }
                else
                {
                    if (e.KeyChar == '.' || e.KeyChar == ',')
                    {
                        if (!txtValor.Text.Contains(',') && txtValor.Text.Length > 0)
                        {
                            e.KeyChar = ',';
                        }
                        else
                        {
                            e.KeyChar = (Char)0;
                        }
                    }
                }
            }
            catch (Exception a)
            {

                MessageBox.Show("Error" + a.Message);
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtValor.Text.Length > 0)
                {
                    txtValor.Text = Convert.ToDouble(txtValor.Text).ToString("C");
                }
            }
            catch (Exception a)
            {

                MessageBox.Show("Error" + a.Message);
            }
        }

        private void txtValor_Enter(object sender, EventArgs e)
        {
            try
            {
                String x = "";
                for (int i = 0; i <= txtValor.Text.Length - 1; i++)
                {
                    if ((txtValor.Text[i] >= '0' &&
                        txtValor.Text[i] <= '9') ||
                        txtValor.Text[i] == ',')
                    {
                        x += txtValor.Text[i];
                    }
                }
                txtValor.Text = x;
                txtValor.SelectAll();
            }
            catch (Exception a)
            {

                MessageBox.Show("Error" + a.Message);
            }
        }

    }
}
