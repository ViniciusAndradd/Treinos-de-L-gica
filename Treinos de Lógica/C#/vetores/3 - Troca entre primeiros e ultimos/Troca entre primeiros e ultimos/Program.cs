namespace Troca_entre_primeiros_e_ultimos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Leia um vetor de 16 posições e troque os 8 primeiros valores pelos 8 últimos e vice-e-versa. Escreva ao final o vetor obtido.

            int[] vet = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            int aux, j = vet.Length/2;
            for (int i = 0; i < vet.Length / 2; i++,j++)
            {
                aux = vet[i];
                vet[i] = vet[j];
                vet[j] = aux;
            }
            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine(vet[i]);
            }
        }
    }
}