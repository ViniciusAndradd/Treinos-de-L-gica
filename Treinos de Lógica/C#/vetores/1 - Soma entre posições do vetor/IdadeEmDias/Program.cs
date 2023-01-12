namespace IdadeEmDias
{
    internal class Program
    {
        static int Pesquisador(ref int[] vet,int x)
        {
            for (int i = 0; i <= x; i++)
            {
                if (i == x)
                {
                    x = vet[i];
                    break;
                }
                
            }
            return x;
        }
        static void Main(string[] args)
        {
            /* Leia um vetor de 12 posições e em seguida ler também dois valores X e Y quaisquer correspondentes a duas posições no vetor.
            Ao final seu programa deverá escrever a soma dos valores encontrados nas respectivas posições X e Y.*/

            int x, y;
            int[] vet = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            Console.WriteLine("Digite a primeira posição:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda posição:");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("O resultado de "+ (x+1) + " + " + (y+1) + " é: " + (Pesquisador(ref vet, x) + Pesquisador(ref vet, y)));
        }
    }
}