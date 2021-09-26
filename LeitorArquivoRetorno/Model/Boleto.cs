using LeitorArquivoRetorno.Data;
using System;
using System.Data.SqlClient;
namespace LeitorArquivoRetorno.Classes
{
    public class Boleto
    {
        public int IdBoleto;
        public DateTime DataVencimento;
        public decimal ValorBoleto;
        public int IdPessoa;
        public DateTime DataPagamento;
        public string SituacaoBoleto;
        public string NumeroCodigoBarras;
        public DateTime DataCredito;
        public decimal ValorPagamento;


        public static int LocalizarCodigoBarras(string p_NumeroCodigoBarras)
        {
            var con = new Conexao();
            try
            {

                using (var cmd = new SqlCommand())
                {
                    cmd.CommandText = "SELECT * FROM BOLETO where NumeroCodigoBarras=@p_NumeroCodigoBarras";
                    cmd.Connection = con.DbConnection();
                    cmd.Parameters.AddWithValue("@p_NumeroCodigoBarras", p_NumeroCodigoBarras);

                    var dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }

                }
            }
            catch (Exception ex)
            {

                throw new ArgumentNullException("Ocorreu um erro na consulta, " + ex.Message);
            }
            finally
            {
            }

        }

       public static bool AtualizarSituacaoBoleto(DateTime p_datapagamento, DateTime p_datacredito,decimal p_valorpagamento,string p_numerocodigobarras)
        {
            var con = new Conexao();
            try
            {
                using (var cmd = new SqlCommand())
                {
                    cmd.CommandText = "Update boleto set SituacaoBoleto='P', " +
                        "DataPagamento=@p_datapagamento," +
                        "DataCredito=@p_datacredito,ValorPagamento=@p_valorpagamento " +
                        "where NumeroCodigoBarras=@p_numerocodigobarras";
                    cmd.Connection = con.DbConnection();
                    cmd.Parameters.AddWithValue("@p_datapagamento", p_datapagamento);
                    cmd.Parameters.AddWithValue("@p_datacredito", p_datacredito);
                    cmd.Parameters.AddWithValue("@p_valorpagamento", p_valorpagamento);
                    cmd.Parameters.AddWithValue("@p_NumeroCodigoBarras", p_numerocodigobarras);
                    var execute = cmd.ExecuteNonQuery();
                 
                    if(execute > 0 )
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }



        }
    }
}
