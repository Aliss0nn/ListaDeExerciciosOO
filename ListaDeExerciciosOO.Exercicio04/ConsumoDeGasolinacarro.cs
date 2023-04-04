using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO.Exercicio04
{
  
    internal class ConsumoDeGasolinacarro
    {
        public double distancia = 20;
        public double volume = 10;

        public double CalcularConsumo()
        {
            return distancia / volume;
           
        }
  
    
    }


}
