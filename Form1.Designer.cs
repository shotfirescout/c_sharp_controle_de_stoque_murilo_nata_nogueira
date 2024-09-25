namespace c_sharp_controle_de_stoque_murilo_nata_nogueira
{
    partial class Form1
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
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dataGridProdutos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioNome = new System.Windows.Forms.RadioButton();
            this.radioPreco = new System.Windows.Forms.RadioButton();
            this.radioQuantidade = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.btnRecarregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutos)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(830, 86);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(134, 75);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dataGridProdutos
            // 
            this.dataGridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProdutos.Location = new System.Drawing.Point(12, 75);
            this.dataGridProdutos.Name = "dataGridProdutos";
            this.dataGridProdutos.ReadOnly = true;
            this.dataGridProdutos.RowHeadersWidth = 51;
            this.dataGridProdutos.RowTemplate.Height = 24;
            this.dataGridProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProdutos.Size = new System.Drawing.Size(602, 422);
            this.dataGridProdutos.TabIndex = 1;
            this.dataGridProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProdutos_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "CONTROLE DE ESTOQUE";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(629, 172);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(168, 22);
            this.textBoxNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(626, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(626, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantidade";
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(629, 225);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(168, 22);
            this.textBoxQuantidade.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(626, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Preço";
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(629, 278);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(168, 22);
            this.textBoxPreco.TabIndex = 7;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(830, 169);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(134, 75);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(830, 250);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(134, 75);
            this.btnRemover.TabIndex = 10;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(3, 73);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(218, 22);
            this.textBoxPesquisa.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.textBoxPesquisa);
            this.panel1.Location = new System.Drawing.Point(629, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 98);
            this.panel1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "pesquisa:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioNome);
            this.groupBox1.Controls.Add(this.radioPreco);
            this.groupBox1.Controls.Add(this.radioQuantidade);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 57);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "forma de pesquisa";
            // 
            // radioNome
            // 
            this.radioNome.AutoSize = true;
            this.radioNome.Checked = true;
            this.radioNome.Location = new System.Drawing.Point(5, 21);
            this.radioNome.Name = "radioNome";
            this.radioNome.Size = new System.Drawing.Size(65, 20);
            this.radioNome.TabIndex = 13;
            this.radioNome.TabStop = true;
            this.radioNome.Text = "Nome";
            this.radioNome.UseVisualStyleBackColor = true;
            // 
            // radioPreco
            // 
            this.radioPreco.AutoSize = true;
            this.radioPreco.Location = new System.Drawing.Point(180, 21);
            this.radioPreco.Name = "radioPreco";
            this.radioPreco.Size = new System.Drawing.Size(64, 20);
            this.radioPreco.TabIndex = 15;
            this.radioPreco.Text = "Preço";
            this.radioPreco.UseVisualStyleBackColor = true;
            // 
            // radioQuantidade
            // 
            this.radioQuantidade.AutoSize = true;
            this.radioQuantidade.Location = new System.Drawing.Point(76, 21);
            this.radioQuantidade.Name = "radioQuantidade";
            this.radioQuantidade.Size = new System.Drawing.Size(98, 20);
            this.radioQuantidade.TabIndex = 14;
            this.radioQuantidade.Text = "Quantidade";
            this.radioQuantidade.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(246, 66);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(80, 32);
            this.btnPesquisar.TabIndex = 14;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(626, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Id";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(629, 112);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(168, 22);
            this.textBoxId.TabIndex = 15;
            // 
            // btnRecarregar
            // 
            this.btnRecarregar.Location = new System.Drawing.Point(620, 453);
            this.btnRecarregar.Name = "btnRecarregar";
            this.btnRecarregar.Size = new System.Drawing.Size(335, 44);
            this.btnRecarregar.TabIndex = 17;
            this.btnRecarregar.Text = "Recarregar Tabela";
            this.btnRecarregar.UseVisualStyleBackColor = true;
            this.btnRecarregar.Click += new System.EventHandler(this.btnRecarregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 506);
            this.Controls.Add(this.btnRecarregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridProdutos);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "Form1";
            this.Text = "Controlador de Estoque";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdutos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dataGridProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioPreco;
        private System.Windows.Forms.RadioButton radioQuantidade;
        private System.Windows.Forms.RadioButton radioNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRecarregar;
    }
}

