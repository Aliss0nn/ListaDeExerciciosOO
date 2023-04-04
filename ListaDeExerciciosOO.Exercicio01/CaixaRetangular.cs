using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosOO.Exercicio01
{

    public class CaixaRetangular
    {
       public decimal comprimento = 20;
       public decimal altura = 5;
       public decimal largura = 10;


        public decimal CalcularVolume()
        {

            return altura * comprimento * largura;

        }


        
     
    }
}
