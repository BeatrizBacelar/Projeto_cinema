using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;


namespace cinema2018
{
    public class FilmeBD
    {

         // classe que vai conter todos os metodos de categoria

        static string sql = "select * from filme";
        public string conn;
        public MySqlConnection conexao;
        static MySqlCommand comando;
        static MySqlDataAdapter da;

        // metodo que vai chamar todas as informacoes do banco
        public FilmeBD()
        {
            conn = ConfigurationManager.AppSettings["banco"]; // fazendo conexao com o banco, caminho para encontrar o banco

        }

        public DataSet ListarFilme()
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
        public int IncluirFilme(Filme filme) // está recebendo um representante da categoria para incluir no banco
        {
           
            
            
            conexao = new MySqlConnection(conn);
            string sql = "INSERT INTO filme (nomeFilme,duracaoFilme,codigoFornecedor) values (?pNome,?pDuracao,?pcodigoFornecedor)";
            comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("?pNome", filme.Nome);
            comando.Parameters.AddWithValue("?pDuracao", filme.Duracao);
            comando.Parameters.AddWithValue("?pcodigoFornecedor", filme.CodigoFornecedor);


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

        public int AlterarFilme(Filme filme, int codigoFilme) // está recebendo um representante do filme para alterar no banco
        {
            conexao = new MySqlConnection(conn);
            string sql = "UPDATE filme set nomeFilme= ?pNome, duracaoFilme= ?pDuracao, codigoFornecedor= ?pcodigoFornecedor where codigoFilme=" + codigoFilme + "";
            comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("?pNome", filme.Nome);
            comando.Parameters.AddWithValue("?pDuracao", filme.Duracao);
            comando.Parameters.AddWithValue("?pcodigoFornecedor", filme.CodigoFornecedor);


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

        public int ExcluirFilme(int codigoFilme) // está recebendo um representante da categoria para incluir no banco
        {
            conexao = new MySqlConnection(conn);



            string sql = " DELETE FROM filme WHERE codigoFilme = " + codigoFilme + " ";
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