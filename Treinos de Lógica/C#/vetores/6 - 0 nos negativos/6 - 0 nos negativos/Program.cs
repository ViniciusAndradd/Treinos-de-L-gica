namespace _6___0_nos_negativos
{
    internal class Program
    {
        // Leia um vetor de 40 posições e atribua valor 0 para todos os elementos que possuírem valores negativos.
        static void Main(string[] args)
        {
            int[] vet = new int[40];
            int j = -19;
            for (int i = 0; i < vet.Length; i++, j++)
            {
                vet[i] = j;
            }
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] < 0)
                {
                    vet[i] = 0;
                }
            }
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i]+" ");
            }
        }
    }
}