namespace ListaDeExerciciosOO.Exercicio01
{
    internal class Program
    {

        static void Main(string[] args)
        {
            CaixaRetangular caixa = new CaixaRetangular();
            caixa.altura = 20;
            caixa.largura = 5;
            caixa.comprimento = 10;

            Console.WriteLine("O volume da caixa retangular é: " + caixa.CalcularVolume());

        }
    }
}