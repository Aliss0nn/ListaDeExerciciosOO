using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO.Exercicio07
{
    internal class Salario
    {
        public double salarioinicial = 2000;
        public double totaldevendas = 10;
        public double percentualvendas = 20;

        public double CalcularSalario()
        {

         return salarioinicial + (totaldevendas * percentualvendas) / 100;

        }



    }
}
