namespace ListaDeExerciciosOO.Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsumoDeGasolinacarro gasolina = new ConsumoDeGasolinacarro();

            Console.WriteLine(" Seu consumo médio é de: " + gasolina.CalcularConsumo() + "KM/L");
            Console.ReadLine();

        }
    }
}