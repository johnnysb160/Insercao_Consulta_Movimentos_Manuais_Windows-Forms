namespace Movimentacao_Manual
{
    partial class Consulta_Movimentos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Movimentos));
            this.lblMes = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblCosif = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.gbMovimento = new System.Windows.Forms.GroupBox();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.cbCosif = new System.Windows.Forms.ComboBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblProdutos2 = new System.Windows.Forms.Label();
            this.lblCosif2 = new System.Windows.Forms.Label();
            this.cODPRODUTODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODCOSIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODCLASSIFICACAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTASTATUSDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbMovimento.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.BackColor = System.Drawing.Color.Transparent;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(8, 27);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(42, 17);
            this.lblMes.TabIndex = 0;
            this.lblMes.Text = "Mês:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(6, 63);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(70, 17);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "Produto:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(8, 101);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(51, 17);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor:";
            // 
            // lblCosif
            // 
            this.lblCosif.AutoSize = true;
            this.lblCosif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosif.Location = new System.Drawing.Point(210, 63);
            this.lblCosif.Name = "lblCosif";
            this.lblCosif.Size = new System.Drawing.Size(49, 17);
            this.lblCosif.TabIndex = 4;
            this.lblCosif.Text = "Cosif:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.BackColor = System.Drawing.Color.Transparent;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(210, 27);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(41, 17);
            this.lblAno.TabIndex = 3;
            this.lblAno.Text = "Ano:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(6, 160);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(85, 17);
            this.lblDescricao.TabIndex = 5;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtMes
            // 
            this.txtMes.Enabled = false;
            this.txtMes.Location = new System.Drawing.Point(91, 21);
            this.txtMes.MaxLength = 2;
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(106, 23);
            this.txtMes.TabIndex = 1;
            this.txtMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMes_KeyPress);
            // 
            // txtAno
            // 
            this.txtAno.Enabled = false;
            this.txtAno.Location = new System.Drawing.Point(257, 24);
            this.txtAno.MaxLength = 4;
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(106, 23);
            this.txtAno.TabIndex = 2;
            this.txtAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAno_KeyPress);
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(91, 98);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(106, 23);
            this.txtValor.TabIndex = 5;
            this.txtValor.Enter += new System.EventHandler(this.txtValor_Enter);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(91, 128);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(272, 87);
            this.txtDescricao.TabIndex = 6;
            // 
            // gbMovimento
            // 
            this.gbMovimento.Controls.Add(this.txtDescricao);
            this.gbMovimento.Controls.Add(this.cbProduto);
            this.gbMovimento.Controls.Add(this.lblDescricao);
            this.gbMovimento.Controls.Add(this.lblValor);
            this.gbMovimento.Controls.Add(this.lblAno);
            this.gbMovimento.Controls.Add(this.lblProduto);
            this.gbMovimento.Controls.Add(this.txtValor);
            this.gbMovimento.Controls.Add(this.txtMes);
            this.gbMovimento.Controls.Add(this.cbCosif);
            this.gbMovimento.Controls.Add(this.btnIncluir);
            this.gbMovimento.Controls.Add(this.btnNovo);
            this.gbMovimento.Controls.Add(this.btnLimpar);
            this.gbMovimento.Controls.Add(this.lblMes);
            this.gbMovimento.Controls.Add(this.txtAno);
            this.gbMovimento.Controls.Add(this.lblCosif);
            this.gbMovimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMovimento.Location = new System.Drawing.Point(12, 2);
            this.gbMovimento.Name = "gbMovimento";
            this.gbMovimento.Size = new System.Drawing.Size(379, 262);
            this.gbMovimento.TabIndex = 16;
            this.gbMovimento.TabStop = false;
            this.gbMovimento.Text = "Movimento";
            // 
            // cbProduto
            // 
            this.cbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduto.Enabled = false;
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(91, 60);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(106, 25);
            this.cbProduto.TabIndex = 3;
            this.cbProduto.SelectedIndexChanged += new System.EventHandler(this.cbProduto_SelectedIndexChanged);
            // 
            // cbCosif
            // 
            this.cbCosif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCosif.Enabled = false;
            this.cbCosif.FormattingEnabled = true;
            this.cbCosif.Location = new System.Drawing.Point(257, 60);
            this.cbCosif.Name = "cbCosif";
            this.cbCosif.Size = new System.Drawing.Size(106, 25);
            this.cbCosif.TabIndex = 4;
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.SystemColors.Control;
            this.btnIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIncluir.Enabled = false;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnIncluir.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Location = new System.Drawing.Point(294, 225);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(69, 23);
            this.btnIncluir.TabIndex = 9;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNovo.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(190, 225);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(69, 23);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpar.Enabled = false;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLimpar.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(91, 225);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(69, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 275);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 19);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(681, 253);
            this.dataGridView.TabIndex = 0;
            // 
            // lblProdutos2
            // 
            this.lblProdutos2.AutoSize = true;
            this.lblProdutos2.Location = new System.Drawing.Point(446, 72);
            this.lblProdutos2.Name = "lblProdutos2";
            this.lblProdutos2.Size = new System.Drawing.Size(0, 13);
            this.lblProdutos2.TabIndex = 18;
            // 
            // lblCosif2
            // 
            this.lblCosif2.AutoSize = true;
            this.lblCosif2.Location = new System.Drawing.Point(432, 115);
            this.lblCosif2.Name = "lblCosif2";
            this.lblCosif2.Size = new System.Drawing.Size(0, 13);
            this.lblCosif2.TabIndex = 19;
            // 
            // cODPRODUTODataGridViewTextBoxColumn1
            // 
            this.cODPRODUTODataGridViewTextBoxColumn1.DataPropertyName = "COD_PRODUTO";
            this.cODPRODUTODataGridViewTextBoxColumn1.HeaderText = "COD_PRODUTO";
            this.cODPRODUTODataGridViewTextBoxColumn1.Name = "cODPRODUTODataGridViewTextBoxColumn1";
            // 
            // cODCOSIFDataGridViewTextBoxColumn
            // 
            this.cODCOSIFDataGridViewTextBoxColumn.DataPropertyName = "COD_COSIF";
            this.cODCOSIFDataGridViewTextBoxColumn.HeaderText = "COD_COSIF";
            this.cODCOSIFDataGridViewTextBoxColumn.Name = "cODCOSIFDataGridViewTextBoxColumn";
            // 
            // cODCLASSIFICACAODataGridViewTextBoxColumn
            // 
            this.cODCLASSIFICACAODataGridViewTextBoxColumn.DataPropertyName = "COD_CLASSIFICACAO";
            this.cODCLASSIFICACAODataGridViewTextBoxColumn.HeaderText = "COD_CLASSIFICACAO";
            this.cODCLASSIFICACAODataGridViewTextBoxColumn.Name = "cODCLASSIFICACAODataGridViewTextBoxColumn";
            // 
            // sTASTATUSDataGridViewTextBoxColumn1
            // 
            this.sTASTATUSDataGridViewTextBoxColumn1.DataPropertyName = "STA_STATUS";
            this.sTASTATUSDataGridViewTextBoxColumn1.HeaderText = "STA_STATUS";
            this.sTASTATUSDataGridViewTextBoxColumn1.Name = "sTASTATUSDataGridViewTextBoxColumn1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(420, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(410, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 262);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(78, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Consulta_Movimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(711, 542);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCosif2);
            this.Controls.Add(this.lblProdutos2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbMovimento);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Consulta_Movimentos";
            this.Text = "Consulta Movimentos";
            this.Load += new System.EventHandler(this.Consulta_Movimentos_Load);
            this.gbMovimento.ResumeLayout(false);
            this.gbMovimento.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblCosif;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.GroupBox gbMovimento;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtMes;
        public System.Windows.Forms.TextBox txtAno;
        public System.Windows.Forms.TextBox txtValor;
        public System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblProdutos2;
        private System.Windows.Forms.Label lblCosif2;
        public System.Windows.Forms.ComboBox cbCosif;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODPRODUTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCOSIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCLASSIFICACAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTASTATUSDataGridViewTextBoxColumn1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView;
        public System.Windows.Forms.ComboBox cbProduto;
    }
}

