namespace _8___troca_de_posições
{
    internal class Program
    {
        // 8 - Leia um vetor de 40 posições e acumule os valores do primeiro elemento no segundo, deste no terceiro e assim por diante. Ao final, escreva o vetor obtido.
        static void Main(string[] args)
        {
            int[] vet = new int[40];
            int j = 1, aux = 0;
            for (int i = 0; i < vet.Length; i++, j++)
            {
                vet[i] = j;
            }

            for (int i = vet.Length-1; i < vet.Length; i--)
            {
                if (i == vet.Length - 1)
                {
                    aux = vet[i];
                }
                if (i == 0)
                {
                    vet[i] = aux;
                    break;
                }
                vet[i] = vet[i - 1];
            }

            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine(vet[i]);
            }

        }
    }
}