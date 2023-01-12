namespace _7___Entre_pares_e_ímpares
{
    internal class Program
    {
        // 7 - Leia dois vetores de 20 posições e calcule um terceiro vetor contendo, nas posições pares os valores do primeiro e nas posições impares os valores do segundo.
        static void Main(string[] args)
        {
            int[] vet = new int[20];
            int[] vet2 = new int[20];
            int[] vet3 = new int[40];
            int j = 1;
            // Prenchendo o primeiro vetor
            for (int i = 0; i < vet.Length; i++, j++)
            {
                vet[i] = j;
            }
            j = -1;
            // Prenchendo o segundo vetor
            for (int i = 0; i < vet2.Length; i++, j--)
            {
                vet2[i] = j;
            }
            // Prenchendo o terceiro vetor com os números do primeiro vetor
            j = 0;
            for (int i = 0; i < vet3.Length; i += 2, j++)
            {
                vet3[i] = vet[j];
            }
            // Prenchendo o terceiro vetor com os números do segundo vetor
            j = 0;
            for (int i = 1; i < vet3.Length; i += 2, j++)
            {
                vet3[i] = vet2[j];
            }
            // Escrevendo o vetor
            for (int i = 0; i < vet3.Length; i++)
            {
                Console.WriteLine(i + ": " + vet3[i]);
            }
        }
    }
}