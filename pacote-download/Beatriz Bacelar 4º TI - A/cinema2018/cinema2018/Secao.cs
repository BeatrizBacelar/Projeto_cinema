using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cinema2018
{
    public class Secao
    {
         // propriedades 
        public int CodigoSecao { private set; get; }
        public int Sala { set; get; }
        public string Horario { set; get; }
        public int QtdCadeiras {  set; get; }
        public double Valor { set; get; }
        public int CodigoFilme { set; get; }

        // construtores

        public Secao (int codigoSecao )
        {
            this.CodigoSecao = codigoSecao;
        }

        public Secao ( int sala, string horario, int cadeiras, double valor, int filme)
        {
            this.Sala = sala;
            this.Horario = horario;
            this.QtdCadeiras = cadeiras;
            this.Valor = valor;
            this.CodigoFilme = filme;
        }





    }
}