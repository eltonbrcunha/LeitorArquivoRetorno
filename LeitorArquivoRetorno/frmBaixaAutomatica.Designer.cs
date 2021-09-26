
namespace LeitorArquivoRetorno
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtDiretorioArquivoRetorno = new System.Windows.Forms.TextBox();
            this.BtnListarArquivos = new System.Windows.Forms.Button();
            this.txtTipoArquivo = new System.Windows.Forms.TextBox();
            this.txtCodBanco = new System.Windows.Forms.TextBox();
            this.txtValorArquivo = new System.Windows.Forms.TextBox();
            this.txtNomeBanco = new System.Windows.Forms.TextBox();
            this.btnProcessarArquivo = new System.Windows.Forms.Button();
            this.DtGridLinhas = new System.Windows.Forms.DataGridView();
            this.sequencialLinha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linhaArquivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linhaSituacao = new System.Windows.Forms.DataGridViewImageColumn();
            this.abasForm = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTotalArquivos = new System.Windows.Forms.Label();
            this.gbImport = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDadosArquivo = new System.Windows.Forms.GroupBox();
            this.txtDataArquivo = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBanco = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridLinhas)).BeginInit();
            this.abasForm.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbImport.SuspendLayout();
            this.gbDadosArquivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtDiretorioArquivoRetorno
            // 
            this.TxtDiretorioArquivoRetorno.Location = new System.Drawing.Point(7, 22);
            this.TxtDiretorioArquivoRetorno.Name = "TxtDiretorioArquivoRetorno";
            this.TxtDiretorioArquivoRetorno.Size = new System.Drawing.Size(423, 23);
            this.TxtDiretorioArquivoRetorno.TabIndex = 0;
            // 
            // BtnListarArquivos
            // 
            this.BtnListarArquivos.Location = new System.Drawing.Point(437, 22);
            this.BtnListarArquivos.Name = "BtnListarArquivos";
            this.BtnListarArquivos.Size = new System.Drawing.Size(75, 23);
            this.BtnListarArquivos.TabIndex = 1;
            this.BtnListarArquivos.Text = "Selecionar";
            this.BtnListarArquivos.UseVisualStyleBackColor = true;
            this.BtnListarArquivos.Click += new System.EventHandler(this.BtnListarArquivos_Click);
            // 
            // txtTipoArquivo
            // 
            this.txtTipoArquivo.Location = new System.Drawing.Point(115, 53);
            this.txtTipoArquivo.Name = "txtTipoArquivo";
            this.txtTipoArquivo.ReadOnly = true;
            this.txtTipoArquivo.Size = new System.Drawing.Size(315, 23);
            this.txtTipoArquivo.TabIndex = 4;
            // 
            // txtCodBanco
            // 
            this.txtCodBanco.Location = new System.Drawing.Point(53, 23);
            this.txtCodBanco.Name = "txtCodBanco";
            this.txtCodBanco.ReadOnly = true;
            this.txtCodBanco.Size = new System.Drawing.Size(38, 23);
            this.txtCodBanco.TabIndex = 5;
            // 
            // txtValorArquivo
            // 
            this.txtValorArquivo.Location = new System.Drawing.Point(540, 53);
            this.txtValorArquivo.Name = "txtValorArquivo";
            this.txtValorArquivo.ReadOnly = true;
            this.txtValorArquivo.Size = new System.Drawing.Size(90, 23);
            this.txtValorArquivo.TabIndex = 6;
            // 
            // txtNomeBanco
            // 
            this.txtNomeBanco.Location = new System.Drawing.Point(97, 23);
            this.txtNomeBanco.Name = "txtNomeBanco";
            this.txtNomeBanco.ReadOnly = true;
            this.txtNomeBanco.Size = new System.Drawing.Size(333, 23);
            this.txtNomeBanco.TabIndex = 7;
            // 
            // btnProcessarArquivo
            // 
            this.btnProcessarArquivo.Location = new System.Drawing.Point(654, 40);
            this.btnProcessarArquivo.Name = "btnProcessarArquivo";
            this.btnProcessarArquivo.Size = new System.Drawing.Size(75, 23);
            this.btnProcessarArquivo.TabIndex = 8;
            this.btnProcessarArquivo.Text = "Processar";
            this.btnProcessarArquivo.UseVisualStyleBackColor = true;
            this.btnProcessarArquivo.Click += new System.EventHandler(this.btnProcessarArquivo_Click);
            // 
            // DtGridLinhas
            // 
            this.DtGridLinhas.AllowUserToAddRows = false;
            this.DtGridLinhas.AllowUserToDeleteRows = false;
            this.DtGridLinhas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DtGridLinhas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtGridLinhas.ColumnHeadersHeight = 28;
            this.DtGridLinhas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sequencialLinha,
            this.codigoBarras,
            this.dataPagamento,
            this.dataCredito,
            this.valorPago,
            this.linhaArquivo,
            this.linhaSituacao});
            this.DtGridLinhas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtGridLinhas.EnableHeadersVisualStyles = false;
            this.DtGridLinhas.Location = new System.Drawing.Point(3, 3);
            this.DtGridLinhas.Name = "DtGridLinhas";
            this.DtGridLinhas.ReadOnly = true;
            this.DtGridLinhas.RowHeadersVisible = false;
            this.DtGridLinhas.RowTemplate.Height = 25;
            this.DtGridLinhas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtGridLinhas.Size = new System.Drawing.Size(885, 230);
            this.DtGridLinhas.TabIndex = 9;
            this.DtGridLinhas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DtGridLinhas_CellFormatting);
            // 
            // sequencialLinha
            // 
            this.sequencialLinha.DataPropertyName = "sequencialLinha";
            this.sequencialLinha.HeaderText = "Sequência";
            this.sequencialLinha.Name = "sequencialLinha";
            this.sequencialLinha.ReadOnly = true;
            this.sequencialLinha.Width = 65;
            // 
            // codigoBarras
            // 
            this.codigoBarras.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codigoBarras.DataPropertyName = "codigoBarras";
            this.codigoBarras.HeaderText = "Código Barras";
            this.codigoBarras.Name = "codigoBarras";
            this.codigoBarras.ReadOnly = true;
            // 
            // dataPagamento
            // 
            this.dataPagamento.DataPropertyName = "dataPagamento";
            dataGridViewCellStyle1.Format = "N2";
            this.dataPagamento.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataPagamento.HeaderText = "Data Pagamento";
            this.dataPagamento.Name = "dataPagamento";
            this.dataPagamento.ReadOnly = true;
            this.dataPagamento.Width = 120;
            // 
            // dataCredito
            // 
            this.dataCredito.DataPropertyName = "dataCredito";
            this.dataCredito.HeaderText = "Data Crédito";
            this.dataCredito.Name = "dataCredito";
            this.dataCredito.ReadOnly = true;
            // 
            // valorPago
            // 
            this.valorPago.DataPropertyName = "valorPago";
            this.valorPago.HeaderText = "Valor Pago";
            this.valorPago.Name = "valorPago";
            this.valorPago.ReadOnly = true;
            // 
            // linhaArquivo
            // 
            this.linhaArquivo.DataPropertyName = "linhaArquivo";
            this.linhaArquivo.HeaderText = "linha_arquivo";
            this.linhaArquivo.Name = "linhaArquivo";
            this.linhaArquivo.ReadOnly = true;
            this.linhaArquivo.Visible = false;
            // 
            // linhaSituacao
            // 
            this.linhaSituacao.DataPropertyName = "linhaSituacao";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "0";
            this.linhaSituacao.DefaultCellStyle = dataGridViewCellStyle2;
            this.linhaSituacao.HeaderText = "...";
            this.linhaSituacao.Name = "linhaSituacao";
            this.linhaSituacao.ReadOnly = true;
            this.linhaSituacao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.linhaSituacao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.linhaSituacao.Width = 25;
            // 
            // abasForm
            // 
            this.abasForm.Controls.Add(this.tabPage1);
            this.abasForm.Controls.Add(this.tabPage2);
            this.abasForm.Location = new System.Drawing.Point(0, 149);
            this.abasForm.Name = "abasForm";
            this.abasForm.SelectedIndex = 0;
            this.abasForm.Size = new System.Drawing.Size(899, 264);
            this.abasForm.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DtGridLinhas);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(891, 236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Arquivos de Retorno";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(891, 236);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pagamentos a processar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTotalArquivos
            // 
            this.lblTotalArquivos.AutoSize = true;
            this.lblTotalArquivos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalArquivos.Location = new System.Drawing.Point(6, 425);
            this.lblTotalArquivos.Name = "lblTotalArquivos";
            this.lblTotalArquivos.Size = new System.Drawing.Size(0, 15);
            this.lblTotalArquivos.TabIndex = 10;
            // 
            // gbImport
            // 
            this.gbImport.Controls.Add(this.label1);
            this.gbImport.Controls.Add(this.TxtDiretorioArquivoRetorno);
            this.gbImport.Controls.Add(this.BtnListarArquivos);
            this.gbImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbImport.Location = new System.Drawing.Point(0, 0);
            this.gbImport.Name = "gbImport";
            this.gbImport.Size = new System.Drawing.Size(899, 60);
            this.gbImport.TabIndex = 12;
            this.gbImport.TabStop = false;
            this.gbImport.Text = "Importar Arquivo de Retorno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(550, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Baixa Automática";
            // 
            // gbDadosArquivo
            // 
            this.gbDadosArquivo.Controls.Add(this.txtDataArquivo);
            this.gbDadosArquivo.Controls.Add(this.label4);
            this.gbDadosArquivo.Controls.Add(this.label3);
            this.gbDadosArquivo.Controls.Add(this.label2);
            this.gbDadosArquivo.Controls.Add(this.btnProcessarArquivo);
            this.gbDadosArquivo.Controls.Add(this.lblBanco);
            this.gbDadosArquivo.Controls.Add(this.txtCodBanco);
            this.gbDadosArquivo.Controls.Add(this.txtNomeBanco);
            this.gbDadosArquivo.Controls.Add(this.txtTipoArquivo);
            this.gbDadosArquivo.Controls.Add(this.txtValorArquivo);
            this.gbDadosArquivo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDadosArquivo.Location = new System.Drawing.Point(0, 60);
            this.gbDadosArquivo.Name = "gbDadosArquivo";
            this.gbDadosArquivo.Size = new System.Drawing.Size(899, 87);
            this.gbDadosArquivo.TabIndex = 13;
            this.gbDadosArquivo.TabStop = false;
            this.gbDadosArquivo.Text = "Dados do Arquivo";
            // 
            // txtDataArquivo
            // 
            this.txtDataArquivo.Location = new System.Drawing.Point(540, 24);
            this.txtDataArquivo.Mask = "00/00/0000";
            this.txtDataArquivo.Name = "txtDataArquivo";
            this.txtDataArquivo.ReadOnly = true;
            this.txtDataArquivo.Size = new System.Drawing.Size(90, 23);
            this.txtDataArquivo.TabIndex = 14;
            this.txtDataArquivo.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Data do Arquivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Valor do Arquivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome do Arquivo";
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(7, 27);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(40, 15);
            this.lblBanco.TabIndex = 14;
            this.lblBanco.Text = "Banco";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.gbDadosArquivo);
            this.Controls.Add(this.gbImport);
            this.Controls.Add(this.lblTotalArquivos);
            this.Controls.Add(this.abasForm);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leitor de Arquivo de Retorno";
            ((System.ComponentModel.ISupportInitialize)(this.DtGridLinhas)).EndInit();
            this.abasForm.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbImport.ResumeLayout(false);
            this.gbImport.PerformLayout();
            this.gbDadosArquivo.ResumeLayout(false);
            this.gbDadosArquivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDiretorioArquivoRetorno;
        private System.Windows.Forms.Button BtnListarArquivos;
        private System.Windows.Forms.TextBox txtTipoArquivo;
        private System.Windows.Forms.TextBox txtCodBanco;
        private System.Windows.Forms.TextBox txtValorArquivo;
        private System.Windows.Forms.TextBox txtNomeBanco;
        private System.Windows.Forms.Button btnProcessarArquivo;
        private System.Windows.Forms.DataGridView DtGridLinhas;
        private System.Windows.Forms.TabControl abasForm;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTotalArquivos;
        private System.Windows.Forms.GroupBox gbImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDadosArquivo;
        private System.Windows.Forms.MaskedTextBox txtDataArquivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn sequencialLinha;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn linhaArquivo;
        private System.Windows.Forms.DataGridViewImageColumn linhaSituacao;
    }
}

