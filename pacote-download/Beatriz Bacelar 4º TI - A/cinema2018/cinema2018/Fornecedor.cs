using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cinema2018
{
    public class Fornecedor
    {

        
         // propriedades 
        public int CodigoFornecedor { private set; get; }
        public string CNPJ { set; get; }
        public string NomeFornecedor { set; get; }
        public string Endereco {  set; get; }
       

        // construtores

        public Fornecedor (int codigoFornecedor )
        {
            this.CodigoFornecedor = codigoFornecedor;
        }

        public Fornecedor ( string cnpj, string nome,  string endereco)
        {
            this.CNPJ =cnpj;
            this.NomeFornecedor = nome;
            this.Endereco = endereco;
            
        }

    }
}