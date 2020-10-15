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
            this.components = new System.ComponentModel.Container();
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
            this.cbCosif = new System.Windows.Forms.ComboBox();
            this.pRODUTOCOSIFBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.movimentosManuaisDataSet = new Movimentacao_Manual.MovimentosManuaisDataSet();
            this.pRODUTOCOSIFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.pRODUTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUTOTableAdapter = new Movimentacao_Manual.MovimentosManuaisDataSetTableAdapters.PRODUTOTableAdapter();
            this.pRODUTO_COSIFTableAdapter = new Movimentacao_Manual.MovimentosManuaisDataSetTableAdapters.PRODUTO_COSIFTableAdapter();
            this.mOVIMENTOMANUALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOVIMENTO_MANUALTableAdapter = new Movimentacao_Manual.MovimentosManuaisDataSetTableAdapters.MOVIMENTO_MANUALTableAdapter();
            this.movimentosManuaisDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOVIMENTOMANUALBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKPRODUTOCOSIFPRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblProdutos2 = new System.Windows.Forms.Label();
            this.lblCosif2 = new System.Windows.Forms.Label();
            this.mOVIMENTOMANUALBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.gbMovimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOCOSIFBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentosManuaisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOCOSIFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIMENTOMANUALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentosManuaisDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIMENTOMANUALBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPRODUTOCOSIFPRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIMENTOMANUALBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.BackColor = System.Drawing.Color.Transparent;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(20, 29);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(42, 17);
            this.lblMes.TabIndex = 0;
            this.lblMes.Text = "Mês:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(20, 65);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(70, 17);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "Produto:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(20, 100);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(51, 17);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor:";
            // 
            // lblCosif
            // 
            this.lblCosif.AutoSize = true;
            this.lblCosif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosif.Location = new System.Drawing.Point(222, 65);
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
            this.lblAno.Location = new System.Drawing.Point(222, 29);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(41, 17);
            this.lblAno.TabIndex = 3;
            this.lblAno.Text = "Ano:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(20, 133);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(85, 17);
            this.lblDescricao.TabIndex = 5;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtMes
            // 
            this.txtMes.Enabled = false;
            this.txtMes.Location = new System.Drawing.Point(103, 26);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(106, 20);
            this.txtMes.TabIndex = 7;
            // 
            // txtAno
            // 
            this.txtAno.Enabled = false;
            this.txtAno.Location = new System.Drawing.Point(269, 29);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(106, 20);
            this.txtAno.TabIndex = 9;
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(103, 100);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(106, 20);
            this.txtValor.TabIndex = 10;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(103, 133);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(272, 87);
            this.txtDescricao.TabIndex = 11;
            // 
            // gbMovimento
            // 
            this.gbMovimento.Controls.Add(this.cbCosif);
            this.gbMovimento.Controls.Add(this.cbProduto);
            this.gbMovimento.Controls.Add(this.btnIncluir);
            this.gbMovimento.Controls.Add(this.btnNovo);
            this.gbMovimento.Controls.Add(this.btnLimpar);
            this.gbMovimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMovimento.Location = new System.Drawing.Point(12, -1);
            this.gbMovimento.Name = "gbMovimento";
            this.gbMovimento.Size = new System.Drawing.Size(379, 262);
            this.gbMovimento.TabIndex = 16;
            this.gbMovimento.TabStop = false;
            this.gbMovimento.Text = "Movimento";
            // 
            // cbCosif
            // 
            this.cbCosif.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pRODUTOCOSIFBindingSource1, "COD_CLASSIFICACAO", true));
            this.cbCosif.DataSource = this.pRODUTOCOSIFBindingSource;
            this.cbCosif.DisplayMember = "COD_COSIF";
            this.cbCosif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCosif.Enabled = false;
            this.cbCosif.FormattingEnabled = true;
            this.cbCosif.Location = new System.Drawing.Point(257, 67);
            this.cbCosif.Name = "cbCosif";
            this.cbCosif.Size = new System.Drawing.Size(106, 25);
            this.cbCosif.TabIndex = 21;
            this.cbCosif.ValueMember = "COD_CLASSIFICACAO";
            // 
            // pRODUTOCOSIFBindingSource1
            // 
            this.pRODUTOCOSIFBindingSource1.DataMember = "PRODUTO_COSIF";
            this.pRODUTOCOSIFBindingSource1.DataSource = this.movimentosManuaisDataSet;
            // 
            // movimentosManuaisDataSet
            // 
            this.movimentosManuaisDataSet.DataSetName = "MovimentosManuaisDataSet";
            this.movimentosManuaisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUTOCOSIFBindingSource
            // 
            this.pRODUTOCOSIFBindingSource.DataMember = "PRODUTO_COSIF";
            this.pRODUTOCOSIFBindingSource.DataSource = this.movimentosManuaisDataSet;
            // 
            // cbProduto
            // 
            this.cbProduto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pRODUTOCOSIFBindingSource1, "COD_CLASSIFICACAO", true));
            this.cbProduto.DataSource = this.pRODUTOBindingSource1;
            this.cbProduto.DisplayMember = "DES_PRODUTO";
            this.cbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduto.Enabled = false;
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(91, 66);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(106, 25);
            this.cbProduto.TabIndex = 20;
            this.cbProduto.TabStop = false;
            this.cbProduto.ValueMember = "COD_PRODUTO";
            // 
            // pRODUTOBindingSource1
            // 
            this.pRODUTOBindingSource1.DataMember = "PRODUTO";
            this.pRODUTOBindingSource1.DataSource = this.movimentosManuaisDataSet;
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
            this.btnIncluir.TabIndex = 2;
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
            this.btnNovo.TabIndex = 1;
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
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 268);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(294, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Incluir";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(190, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Novo";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(91, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // pRODUTOBindingSource
            // 
            this.pRODUTOBindingSource.DataMember = "PRODUTO";
            this.pRODUTOBindingSource.DataSource = this.movimentosManuaisDataSet;
            // 
            // pRODUTOTableAdapter
            // 
            this.pRODUTOTableAdapter.ClearBeforeFill = true;
            // 
            // pRODUTO_COSIFTableAdapter
            // 
            this.pRODUTO_COSIFTableAdapter.ClearBeforeFill = true;
            // 
            // mOVIMENTOMANUALBindingSource
            // 
            this.mOVIMENTOMANUALBindingSource.DataMember = "MOVIMENTO_MANUAL";
            this.mOVIMENTOMANUALBindingSource.DataSource = this.movimentosManuaisDataSet;
            // 
            // mOVIMENTO_MANUALTableAdapter
            // 
            this.mOVIMENTO_MANUALTableAdapter.ClearBeforeFill = true;
            // 
            // movimentosManuaisDataSetBindingSource
            // 
            this.movimentosManuaisDataSetBindingSource.DataSource = this.movimentosManuaisDataSet;
            this.movimentosManuaisDataSetBindingSource.Position = 0;
            // 
            // mOVIMENTOMANUALBindingSource1
            // 
            this.mOVIMENTOMANUALBindingSource1.DataMember = "MOVIMENTO_MANUAL";
            this.mOVIMENTOMANUALBindingSource1.DataSource = this.movimentosManuaisDataSetBindingSource;
            // 
            // fKPRODUTOCOSIFPRODUTOBindingSource
            // 
            this.fKPRODUTOCOSIFPRODUTOBindingSource.DataMember = "FK_PRODUTO_COSIF_PRODUTO";
            this.fKPRODUTOCOSIFPRODUTOBindingSource.DataSource = this.pRODUTOBindingSource;
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
            // mOVIMENTOMANUALBindingSource2
            // 
            this.mOVIMENTOMANUALBindingSource2.DataMember = "MOVIMENTO_MANUAL";
            this.mOVIMENTOMANUALBindingSource2.DataSource = this.movimentosManuaisDataSetBindingSource;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 19);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(681, 246);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Consulta_Movimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(711, 535);
            this.Controls.Add(this.lblCosif2);
            this.Controls.Add(this.lblProdutos2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblCosif);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.gbMovimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Consulta_Movimentos";
            this.Text = "Consulta Movimentos";
            this.Load += new System.EventHandler(this.Consulta_Movimentos_Load);
            this.gbMovimento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOCOSIFBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentosManuaisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOCOSIFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIMENTOMANUALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentosManuaisDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIMENTOMANUALBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPRODUTOCOSIFPRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIMENTOMANUALBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox txtMes;
        public System.Windows.Forms.TextBox txtAno;
        public System.Windows.Forms.TextBox txtValor;
        public System.Windows.Forms.TextBox txtDescricao;
        private MovimentosManuaisDataSet movimentosManuaisDataSet;
        private System.Windows.Forms.BindingSource pRODUTOBindingSource;
        private MovimentosManuaisDataSetTableAdapters.PRODUTOTableAdapter pRODUTOTableAdapter;
        private System.Windows.Forms.BindingSource pRODUTOCOSIFBindingSource;
        private MovimentosManuaisDataSetTableAdapters.PRODUTO_COSIFTableAdapter pRODUTO_COSIFTableAdapter;
        private System.Windows.Forms.BindingSource pRODUTOCOSIFBindingSource1;
        private System.Windows.Forms.BindingSource mOVIMENTOMANUALBindingSource;
        private MovimentosManuaisDataSetTableAdapters.MOVIMENTO_MANUALTableAdapter mOVIMENTO_MANUALTableAdapter;
        private System.Windows.Forms.BindingSource movimentosManuaisDataSetBindingSource;
        private System.Windows.Forms.BindingSource mOVIMENTOMANUALBindingSource1;
        private System.Windows.Forms.BindingSource fKPRODUTOCOSIFPRODUTOBindingSource;
        private System.Windows.Forms.Label lblProdutos2;
        private System.Windows.Forms.Label lblCosif2;
        private System.Windows.Forms.BindingSource pRODUTOBindingSource1;
        public System.Windows.Forms.ComboBox cbProduto;
        public System.Windows.Forms.ComboBox cbCosif;
        private System.Windows.Forms.BindingSource mOVIMENTOMANUALBindingSource2;
        public System.Windows.Forms.DataGridView dataGridView;
    }
}

