using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO.Exercicio05
{
    internal class Esfera
    {
        public double raio = 10;
        public double x = 3;
        
        
        public double CalcularVolumeEsfera()
       
        {
            return (4.0 / 3.0) * 3.14 * Math.Pow(raio, x);
        }
    
    
    
    
    
    }

}
