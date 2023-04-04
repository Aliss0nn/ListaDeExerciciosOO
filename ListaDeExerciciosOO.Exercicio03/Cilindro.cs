using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO.Exercicio03
{
    public class Cilindro
    {
        public double raio = 5;
        public double altura = 10;       

        public double CalcularohVolume()
        {                    
            return 3.14 * raio * raio * altura;
        }      
    }
}
