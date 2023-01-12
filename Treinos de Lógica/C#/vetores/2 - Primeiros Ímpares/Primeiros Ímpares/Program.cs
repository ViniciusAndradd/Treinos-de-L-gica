namespace Primeiros_Ímpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare um vetor de 10 posições e o preencha com os 10 primeiros números impares e o escreva.

            int[] vet = new int[10];
            int j = 0;
            for (int i = 0; i < vet.Length; )
            {
                if (j % 2 != 0)
                {
                    vet[i] = j;
                    i++;
                }
                j++;
            }

            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine(vet[i]);
            }
        }
    }
}