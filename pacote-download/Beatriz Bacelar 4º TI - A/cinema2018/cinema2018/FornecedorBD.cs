using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace cinema2018
{
    public class FornecedorBD
    {

         // classe que vai conter todos os metodos de categoria

        static string sql = "select * from fornecedor";
        public string conn;
        public MySqlConnection conexao;
        static MySqlCommand comando;
        static MySqlDataAdapter da;

        // metodo que vai chamar todas as informacoes do banco
        public FornecedorBD()
        {
            conn = ConfigurationManager.AppSettings["banco"]; // fazendo conexao com o banco, caminho para encontrar o banco

        }

        public DataSet ListarFornecedor()
        {
            conexao = new MySqlConnection(conn); // criando nova conexao (objeto)
            comando = new MySqlCommand(sql, conexao);
            try
            {
                DataSet ds = new DataSet(); // tabela virtual que fica em memoria, joga todas as info tiradas da tabela
                da = new MySqlDataAdapter(comando); // executa a linha de comando
                da.Fill(ds); // guarda a informaçao no DataSet


                return ds;

            }

            catch (MySqlException erro)
            {
                throw erro;
            }
        }
        public int IncluirFornecedor(Fornecedor fornecedor) // está recebendo um representante da categoria para incluir no banco
        {
           
            
            
            conexao = new MySqlConnection(conn);
            string sql = "INSERT INTO fornecedor (cnpj, nomeFornecedor, endereco) values (?pCNPJ,?pNome,?pEndereco)";
            comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("?pCNPJ", fornecedor.CNPJ);
            comando.Parameters.AddWithValue("?pNome", fornecedor.NomeFornecedor);
            comando.Parameters.AddWithValue("?pEndereco", fornecedor.Endereco);


            try
            {
                conexao.Open();
                int quant = comando.ExecuteNonQuery(); // vai executar o comando sql e retornar a quantidade de linhas efetadas
                return quant;
            }
            catch (MySqlException erro)
            {
                throw erro;
            }

        }

        public int AlterarFornecedor(Fornecedor fornecedor, int codigoFornecedor) // está recebendo um representante do filme para alterar no banco
        {
            conexao = new MySqlConnection(conn);
            string sql = "UPDATE fornecedor set cnpj= ?pCNPJ, nomeFornecedor= ?pNome, endereco= ?pEndereco where codigoFornecedor=" + codigoFornecedor + "";
            comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("?pCNPJ", fornecedor.CNPJ);
            comando.Parameters.AddWithValue("?pNome", fornecedor.NomeFornecedor);
            comando.Parameters.AddWithValue("?pEndereco", fornecedor.Endereco);


            try
            {
                conexao.Open();
                int quant = comando.ExecuteNonQuery(); // vai executar o comando sql e retornar a quantidade de linhas efetadas
                return quant;
            }
            catch (MySqlException erro)
            {
                throw erro;
            }

        }

        public int ExcluirFornecedor(int codigoFornecedor) // está recebendo um representante da categoria para incluir no banco
        {
            conexao = new MySqlConnection(conn);



            string sql = " DELETE FROM fornecedor WHERE codigoFornecedor= " + codigoFornecedor + " ";
            comando = new MySqlCommand(sql, conexao);

            try
            {
                conexao.Open();
                int quant = comando.ExecuteNonQuery(); // vai executar o comando sql e retornar a quantidade de linhas efetadas
                return quant;
            }
            catch (MySqlException erro)
            {
                throw erro;
            }

        }

    }
}