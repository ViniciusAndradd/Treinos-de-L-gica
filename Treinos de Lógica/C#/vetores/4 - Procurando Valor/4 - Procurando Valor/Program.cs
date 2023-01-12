namespace _4___Procurando_Valor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Leia um vetor de 20 posições e em seguida um valor X qualquer.
            //Seu programa devera fazer uma busca do valor de X no vetor lido e informar a posição em que foi encontrado ou se não foi encontrado.
            int[] vet = new int[20] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int x,posicao = 0;
            Console.WriteLine("Qual valor está procurando");
            x = int.Parse(Console.ReadLine());
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] == x)
                {
                    posicao = i;
                    break;
                }
            }

            if (posicao == 0)
            {
                Console.WriteLine("Item não encontrado");
            } else
            {
                Console.WriteLine("Seu item pesquisado está na posição " + posicao);
            }

            
        }
    }
}