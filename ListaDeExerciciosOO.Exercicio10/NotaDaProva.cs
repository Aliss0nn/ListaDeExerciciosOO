using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO.Exercicio10
{
    internal class NotaDaProva
    {
       public double nota1 = 8;
       public double nota2 = 6;
       public double peso1 = 3;
       public double peso2 = 1;

        public double CalcularMedia()
        {

         return ((nota1 * peso1 + nota2 * peso2) / (peso1 + peso2));

        }
        



    }
}
