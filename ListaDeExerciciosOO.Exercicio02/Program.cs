using ListaDeExerciciosOO.Exercicio02;

namespace ListaDeExercicios.Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Temperatura celsius = new Temperatura();
            
            Console.Write("Esta temperatura em Celsius é:" + celsius.ConversaoDeTemperatura());
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}