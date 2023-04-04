using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ListaDeExerciciosOO.Exercicio09
{
    internal class NotaDaProva
    {
        public double nota1 = 8;
        public double nota2 = 10;
        public double nota3 = 6;

        public double CalcularMediaHarmonica()
        {

            return  3 / ((1 / nota1) + (1 / nota2) + (1 / nota3));
        }

    }
}
