namespace ListaDeExerciciosOO.Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            NotaDaProva media = new NotaDaProva();

            Console.WriteLine(Math.Round(media.CalcularMediaHarmonica(), 2));
        }
    }
}