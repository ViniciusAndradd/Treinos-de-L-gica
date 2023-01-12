namespace _5___Contando_pares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Leia um vetor de 40 posições. Contar e escrever quantos valores pares ele possui.

            int[] vet = new int[40];
            int j = 1,cont = 0;
            for (int i = 0; i < vet.Length; i++,j++)
            {
                vet[i] = j;
                if (j % 2 == 0)
                {
                    cont++;
                }
            }
            Console.WriteLine("O vetor tem " + cont +" números pares.");
            Console.WriteLine("São eles:");
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    Console.Write(vet[i]+" ");
                }
            }
        }
    }
}