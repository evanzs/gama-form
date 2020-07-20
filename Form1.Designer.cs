namespace WindowsFormsCliente
{
    partial class FFCliente
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
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textDoc = new System.Windows.Forms.TextBox();
            this.textFaturamento = new System.Windows.Forms.TextBox();
            this.textPFaturamento = new System.Windows.Forms.TextBox();
            this.CBoxAtivo = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lalteracao = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gridCliente = new System.Windows.Forms.DataGridView();
            this.btnAtualiza = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.textDFundacao = new System.Windows.Forms.MaskedTextBox();
            this.textDAlteracao = new System.Windows.Forms.MaskedTextBox();
            this.textPDataLimite = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPopular = new System.Windows.Forms.Button();
            this.btnOrdena = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(39, 44);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(40, 20);
            this.textCodigo.TabIndex = 0;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(104, 44);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(201, 20);
            this.textNome.TabIndex = 1;
            // 
            // textDoc
            // 
            this.textDoc.Location = new System.Drawing.Point(39, 99);
            this.textDoc.Name = "textDoc";
            this.textDoc.Size = new System.Drawing.Size(124, 20);
            this.textDoc.TabIndex = 2;
            // 
            // textFaturamento
            // 
            this.textFaturamento.Location = new System.Drawing.Point(180, 99);
            this.textFaturamento.Name = "textFaturamento";
            this.textFaturamento.Size = new System.Drawing.Size(125, 20);
            this.textFaturamento.TabIndex = 3;
            // 
            // textPFaturamento
            // 
            this.textPFaturamento.Location = new System.Drawing.Point(19, 36);
            this.textPFaturamento.Name = "textPFaturamento";
            this.textPFaturamento.Size = new System.Drawing.Size(100, 20);
            this.textPFaturamento.TabIndex = 4;
            // 
            // CBoxAtivo
            // 
            this.CBoxAtivo.FormattingEnabled = true;
            this.CBoxAtivo.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.CBoxAtivo.Location = new System.Drawing.Point(264, 147);
            this.CBoxAtivo.Name = "CBoxAtivo";
            this.CBoxAtivo.Size = new System.Drawing.Size(43, 21);
            this.CBoxAtivo.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(39, 192);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(306, 30);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Faturamento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Faturamento:";
            // 
            // lalteracao
            // 
            this.lalteracao.AutoSize = true;
            this.lalteracao.Location = new System.Drawing.Point(150, 131);
            this.lalteracao.Name = "lalteracao";
            this.lalteracao.Size = new System.Drawing.Size(96, 13);
            this.lalteracao.TabIndex = 15;
            this.lalteracao.Text = "Data de Alteração:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ativo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Data de Fundação:";
            // 
            // gridCliente
            // 
            this.gridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCliente.Location = new System.Drawing.Point(341, 99);
            this.gridCliente.Name = "gridCliente";
            this.gridCliente.Size = new System.Drawing.Size(447, 174);
            this.gridCliente.TabIndex = 7;
            // 
            // btnAtualiza
            // 
            this.btnAtualiza.Location = new System.Drawing.Point(199, 192);
            this.btnAtualiza.Name = "btnAtualiza";
            this.btnAtualiza.Size = new System.Drawing.Size(108, 23);
            this.btnAtualiza.TabIndex = 19;
            this.btnAtualiza.Text = "Atualizar Tabela";
            this.btnAtualiza.UseVisualStyleBackColor = true;
            this.btnAtualiza.Click += new System.EventHandler(this.btnAtualiza_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(400, 281);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Resetar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // textDFundacao
            // 
            this.textDFundacao.Location = new System.Drawing.Point(39, 148);
            this.textDFundacao.Mask = "00/00/0000";
            this.textDFundacao.Name = "textDFundacao";
            this.textDFundacao.Size = new System.Drawing.Size(100, 20);
            this.textDFundacao.TabIndex = 21;
            this.textDFundacao.ValidatingType = typeof(System.DateTime);
            // 
            // textDAlteracao
            // 
            this.textDAlteracao.Location = new System.Drawing.Point(153, 148);
            this.textDAlteracao.Mask = "00/00/0000";
            this.textDAlteracao.Name = "textDAlteracao";
            this.textDAlteracao.Size = new System.Drawing.Size(100, 20);
            this.textDAlteracao.TabIndex = 22;
            this.textDAlteracao.ValidatingType = typeof(System.DateTime);
            // 
            // textPDataLimite
            // 
            this.textPDataLimite.Location = new System.Drawing.Point(150, 33);
            this.textPDataLimite.Mask = "00/00/0000";
            this.textPDataLimite.Name = "textPDataLimite";
            this.textPDataLimite.Size = new System.Drawing.Size(100, 20);
            this.textPDataLimite.TabIndex = 24;
            this.textPDataLimite.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Data de Fundação:";
            // 
            // btnPopular
            // 
            this.btnPopular.Location = new System.Drawing.Point(37, 257);
            this.btnPopular.Name = "btnPopular";
            this.btnPopular.Size = new System.Drawing.Size(268, 47);
            this.btnPopular.TabIndex = 25;
            this.btnPopular.Text = "Populando Cliente";
            this.btnPopular.UseVisualStyleBackColor = true;
            this.btnPopular.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnOrdena
            // 
            this.btnOrdena.Location = new System.Drawing.Point(553, 281);
            this.btnOrdena.Name = "btnOrdena";
            this.btnOrdena.Size = new System.Drawing.Size(169, 23);
            this.btnOrdena.TabIndex = 26;
            this.btnOrdena.Text = "Ordena Faturamento";
            this.btnOrdena.UseVisualStyleBackColor = true;
            this.btnOrdena.Click += new System.EventHandler(this.btnOrdena_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(99, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(642, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "INTERFACE CRIADA PARA AUXILIAR NOS TESTES DAS FUNÇÕES";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textPFaturamento);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textPDataLimite);
            this.groupBox1.Location = new System.Drawing.Point(341, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 61);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa (Questão 1 item a)";
            // 
            // FFCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 354);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnOrdena);
            this.Controls.Add(this.btnPopular);
            this.Controls.Add(this.textDAlteracao);
            this.Controls.Add(this.textDFundacao);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAtualiza);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lalteracao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gridCliente);
            this.Controls.Add(this.CBoxAtivo);
            this.Controls.Add(this.textFaturamento);
            this.Controls.Add(this.textDoc);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.textCodigo);
            this.Name = "FFCliente";
            this.Text = "Formulário Cliente";
            this.Load += new System.EventHandler(this.FFCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textDoc;
        private System.Windows.Forms.TextBox textFaturamento;
        private System.Windows.Forms.TextBox textPFaturamento;
        private System.Windows.Forms.ComboBox CBoxAtivo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lalteracao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView gridCliente;
        private System.Windows.Forms.Button btnAtualiza;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.MaskedTextBox textDFundacao;
        private System.Windows.Forms.MaskedTextBox textDAlteracao;
        private System.Windows.Forms.MaskedTextBox textPDataLimite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPopular;
        private System.Windows.Forms.Button btnOrdena;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

