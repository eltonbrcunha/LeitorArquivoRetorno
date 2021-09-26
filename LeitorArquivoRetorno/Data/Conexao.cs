using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace LeitorArquivoRetorno.Data
{
    public class Conexao
    {

        public static SqlConnection _conexao;
        public static readonly string _strConexao = "Data Source=127.0.0.1;database=boletos_geral; User ID=sa;Password=xxxxxx;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public SqlConnection DbConnection()
        {
            try
            {
                _conexao = new SqlConnection(_strConexao);
                _conexao.Open();
                return _conexao;
            }
            catch (Exception)
            {
                throw new ArgumentNullException("Não foi possível conectar, verifique os dados da conexão.");
            }
           
        }

       
    }
}
