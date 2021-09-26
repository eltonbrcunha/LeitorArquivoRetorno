using LeitorArquivoRetorno.Classes;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Autor: Elton Brito da Cunha
/// </summary>
namespace LeitorArquivoRetorno
{
    public partial class Form1 : Form
    {
        private readonly DataTable dtLancamento = new DataTable();
        private MD5 Md5 = MD5.Create();

        public Form1()
        {
            InitializeComponent();
            dtLancamento.Columns.Add("sequencialLinha");
            dtLancamento.Columns.Add("codigoBarras");
            dtLancamento.Columns.Add("dataPagamento");
            dtLancamento.Columns.Add("dataCredito");
            dtLancamento.Columns.Add("valorPago", typeof(decimal));
            dtLancamento.Columns.Add("linhaArquivo");
            dtLancamento.Columns.Add("linhaSituacao");

            DtGridLinhas.DataSource = dtLancamento;
           
        }
        public static string BytesParaString(byte[] bytes)
        {

            string resultado = "";
            foreach (byte b in bytes)
            {
                resultado += b.ToString("x2");
            }
            return resultado;
        }
        private byte[] GetHashMD5(string arquivo)

        {

            using (FileStream stream = File.OpenRead(arquivo))
            {
                return Md5.ComputeHash(stream);
            }

        }
        private bool CamposObrig()
        {
            //  var campoVazio = false;
            if (String.IsNullOrWhiteSpace((string)DtGridLinhas.Rows[0].Cells[0].Value))
            {
                MessageBox.Show(@"Campo (Efetue a listagem dos arquivos", @"Inconsistência",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                DtGridLinhas.Select();
                return false;//
            }
            return true;
        }

        private void BtnListarArquivos_Click(object sender, EventArgs e)
        {
            try
            {
                var up1 = new OpenFileDialog { Filter = "Retorno | *.ret" };
                if (up1.ShowDialog() == DialogResult.OK)
                {

                    dtLancamento.Clear();
                    TxtDiretorioArquivoRetorno.Text = up1.FileName.ToString();

                    string[] arquivo = File.ReadAllLines(up1.FileName.ToString());
                    int qtdeLinhaArquivo = arquivo.Length;
                    txtTipoArquivo.Text = Path.GetFileNameWithoutExtension(up1.FileName.ToString()) + ".ret";

                    txtCodBanco.Text = arquivo[0].Substring(42, 3);
                    txtNomeBanco.Text = arquivo[0].Substring(45, 20);
                    txtDataArquivo.Text = arquivo[0].Substring(71, 2) + "/" + arquivo[0].Substring(69, 2) + "/" + arquivo[0].Substring(65, 4);
                    string hashArquivo = BytesParaString(GetHashMD5(up1.FileName.ToString()));

                    string versaoArquivo = arquivo[0].Substring(79, 2);


                    // Leitura das Demais Linhas e inserção no DataTable x DataGridView
                    for (int i = 0; i < arquivo.Length; i++)
                    {
                        // Desconsiderando a primeira linha e a última
                        if (i == 0 || i == qtdeLinhaArquivo || i == qtdeLinhaArquivo - 1)
                        {

                        }
                        else
                        {

                            var dataPagamento = arquivo[i].Substring(27, 2) + "/" + arquivo[i].Substring(25, 2) + "/" + arquivo[i].Substring(21, 4);
                            var dataCredito = arquivo[i].Substring(35, 2) + "/" + arquivo[i].Substring(33, 2) + "/" + arquivo[i].Substring(29, 4);
                            var codigoBarra = arquivo[i].Substring(37, 44);
                            decimal valorPago = Convert.ToDecimal(arquivo[i].Substring(81, 12)) / 100;
                            var sequencial_linha = arquivo[i].Substring(100, 8).TrimStart('0');
                            var linhaArquivo = arquivo[i];



                            var x = Boleto.LocalizarCodigoBarras(codigoBarra);
                            if (x == 1)
                            {
                                dtLancamento.Rows.Add(sequencial_linha, codigoBarra, dataPagamento, dataCredito, string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:N2}", valorPago), linhaArquivo, "1");

                            }
                            else
                            {
                                dtLancamento.Rows.Add(sequencial_linha, codigoBarra, dataPagamento, dataCredito, string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:N2}", valorPago), linhaArquivo, "0");

                            }

                            DtGridLinhas.DataSource = dtLancamento;
                        }

                    }

                }
                else
                {

                }

                decimal totalValorArquivo = 0;
                lblTotalArquivos.Text = "Total de Pagamentos: " + DtGridLinhas.RowCount;
                foreach (DataGridViewRow dtGrid in DtGridLinhas.Rows)
                    totalValorArquivo += Convert.ToDecimal(dtGrid.Cells["valorPago"].Value);
                txtValorArquivo.Text = @"R$" + Convert.ToString(totalValorArquivo, CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                dtLancamento.Clear();
            }

        }

        private void DtGridLinhas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DtGridLinhas.Columns[e.ColumnIndex].Name == "linhaSituacao")
            {

                {
                    if (e.Value.ToString() == "1")
                    {
                        e.Value = Properties.Resources.status_online;
                    }
                    else
                    {
                        e.Value = Properties.Resources.status_offline;
                    }

                }
            }
        }

        private void btnProcessarArquivo_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dtArquivoRetornoLinha in DtGridLinhas.Rows)
                {
                    var datapagamento = Convert.ToDateTime(dtArquivoRetornoLinha.Cells["dataPagamento"].Value.ToString()); ;
                    var datacredito = Convert.ToDateTime(dtArquivoRetornoLinha.Cells["dataCredito"].Value.ToString()); ;
                    var valorpagamento = Convert.ToDecimal(dtArquivoRetornoLinha.Cells["valorPago"].Value.ToString()); ;
                    var numerocodigobarras = dtArquivoRetornoLinha.Cells["codigoBarras"].Value.ToString();

                    var resultado = Boleto.AtualizarSituacaoBoleto(datapagamento, datacredito, valorpagamento, numerocodigobarras);

                }
                MessageBox.Show("Arquivos processados com sucesso!");

                Task task = RunAsync();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        public static async Task RunAsync()
        {
            using (var cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri("https://localhost:44312/");
                cliente.DefaultRequestHeaders.Accept.Clear();
                cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP GET
                HttpResponseMessage response = await cliente.GetAsync("Boleto/ListarBoletos");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("OK");
               //    Boleto produto = await response.Content.ReadAsAsync<Boleto>();

                    //   Console.WriteLine("{0}\t${1}\t{2}", produto.Nome, produto.Preco, produto.Categoria);
                }




            }
        }
    }
}
