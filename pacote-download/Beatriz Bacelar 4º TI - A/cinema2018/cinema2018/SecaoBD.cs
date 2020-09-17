using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;


namespace cinema2018
{
    public class SecaoBD
    {

         // classe que vai conter todos os metodos de categoria

        static string sql = "select * from secao";
        public string conn;
        public MySqlConnection conexao;
        static MySqlCommand comando;
        static MySqlDataAdapter da;

        // metodo que vai chamar todas as informacoes do banco
        public SecaoBD()
        {
            conn = ConfigurationManager.AppSettings["banco"]; // fazendo conexao com o banco, caminho para encontrar o banco

        }

        public DataSet ListarSecao()
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
        public int IncluirSecao(Secao secao) // está recebendo um representante da categoria para incluir no banco
        {
           
            
            
            conexao = new MySqlConnection(conn);
            string sql = "INSERT INTO secao (sala,horario,qtdCadeiras,valor,codigoFilme) values (?pSala,?pHorario,?pqtdCadeiras,?pValor,?pcodigoFilme)";
            comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("?pSala", secao.Sala);
            comando.Parameters.AddWithValue("?pHorario", secao.Horario);
            comando.Parameters.AddWithValue("?pqtdCadeiras", secao.QtdCadeiras);
            comando.Parameters.AddWithValue("?pValor", secao.Valor);
            comando.Parameters.AddWithValue("?pcodigoFilme", secao.CodigoFilme);


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

        public int AlterarSecao(Secao secao, int codigoSecao) // está recebendo um representante do filme para alterar no banco
        {
            conexao = new MySqlConnection(conn);
            string sql = "UPDATE secao set sala= ?psala, horario= ?pHorario, qtdCadeiras= ?pqtdCadeiras, valor= ?pValor, codigoFilme= ?pcodigoFilme where codigoSecao=" + codigoSecao + "";
            comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("?pSala", secao.Sala);
            comando.Parameters.AddWithValue("?pHorario", secao.Horario);
            comando.Parameters.AddWithValue("?pqtdCadeiras", secao.QtdCadeiras);
            comando.Parameters.AddWithValue("?pValor", secao.Valor);
            comando.Parameters.AddWithValue("?pcodigoFilme", secao.CodigoFilme);


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

        public int ExcluirSecao(int codigoSecao) // está recebendo um representante da categoria para incluir no banco
        {
            conexao = new MySqlConnection(conn);



            string sql = " DELETE FROM secao WHERE codigoSecao = " + codigoSecao + " ";
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