using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cinema2018
{
    public class Filme
    {

         // propriedades 
        public int CodigoFilme { private set; get; }
        public string Nome { set; get; }
        public string Duracao { set; get; }
        public int CodigoFornecedor { set; get; }
       

        // construtores

        public Filme (int codigoFilme )
        {
            this.CodigoFilme = codigoFilme;
        }

        public Filme ( string nome, string duracao, int fornecedor)
        {
            this.Nome = nome;
            this.Duracao = duracao;
            this.CodigoFornecedor = fornecedor;
            
        }

      //  background-image: url('Imagem do mar calma e belo da Praia da Engenhoca-Itacaré-Bahia-BA (1).jpg');
    }
}