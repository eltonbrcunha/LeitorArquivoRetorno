using System;
using System.Collections.Generic;
using System.Text;

namespace LeitorArquivoRetorno
{
    public class Arquivo
    {
        private string[] ConteudoArquivo { get; set; }
        private string LinhaArquivo { get; set; }
        private string PrimeiraLinha { get; set; }
        private int LinhaZ { get; set; }
        private string DataPagamento { get; set; }
        private string DataCredito { get; set; }
        private string CodigoBarra { get; set; }
        private decimal ValorPago { get; set; }
        private string SequencialLinha { get; set; }




        public Arquivo(string linhaArquivo, string primeiraLinha, int linhaZ, string dataPagamento, string dataCredito, string codigoBarras, decimal valoPago)
        {

            this.LinhaArquivo = linhaArquivo;
            this.PrimeiraLinha = primeiraLinha;
            this.LinhaZ = linhaZ;
            this.DataPagamento = dataPagamento;
            this.DataCredito = dataCredito;
            this.CodigoBarra = codigoBarras;
            this.ValorPago = valoPago;
        }
    }
}
