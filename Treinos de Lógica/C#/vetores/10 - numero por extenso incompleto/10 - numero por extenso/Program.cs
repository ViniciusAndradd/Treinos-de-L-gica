namespace _10___numero_por_extenso
{
    internal class Program
    {
        // 10 - Leia um vetor de 5 posições contendo os caracteres de um numero. Em seguida escreva esse numero por extenso.
        static void Main(string[] args)
        {
            int[] num = new int[5];
            Console.WriteLine("Escreva um número de 5 dígitos");
            string[] linha = Console.ReadLine().Split(" ");
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(linha[i]);
            }

            string[] extenso = new string[5];
         
            for (int i = num.Length - 1; i >= 0; i--)
            {
                if (i == 4)
                {
                    switch (num[i])
                    {
                        case 1:
                            if (num[i - 1] == 0 && num[i - 2] == 0 && num[i - 3] == 0 && num[i - 4] == 0)
                            {
                                extenso[i] = "um";
                            }
                            else
                            {
                                extenso[i] = "e um";
                            }
                            break;
                        case 2:
                            if (num[i - 1] == 0 && num[i - 2] == 0 && num[i - 3] == 0 && num[i - 4] == 0)
                            {
                                extenso[i] = "dois";
                            }
                            else
                            {
                                extenso[i] = "e dois";
                            }
                            break;
                        case 3:
                            if (num[i - 1] == 0 && num[i - 2] == 0 && num[i - 3] == 0 && num[i - 4] == 0)
                            {
                                extenso[i] = "três";
                            }
                            else
                            {
                                extenso[i] = "e três";
                            }
                            break;
                        case 4:
                            if (num[i - 1] == 0 && num[i - 2] == 0 && num[i - 3] == 0 && num[i - 4] == 0)
                            {
                                extenso[i] = "quatro";
                            }
                            else
                            {
                                extenso[i] = "e quatro";
                            }
                            break;
                        case 5:
                            if (num[i - 1] == 0 && num[i - 2] == 0 && num[i - 3] == 0 && num[i - 4] == 0)
                            {
                                extenso[i] = "cinco";
                            }
                            else
                            {
                                extenso[i] = "e cinco";
                            }
                            break;
                        case 6:
                            if (num[i - 1] == 0 && num[i - 2] == 0 && num[i - 3] == 0 && num[i - 4] == 0)
                            {
                                extenso[i] = "seis";
                            }
                            else
                            {
                                extenso[i] = "e seis";
                            }
                            break;
                        case 7:
                            if (num[i - 1] == 0 && num[i - 2] == 0 && num[i - 3] == 0 && num[i - 4] == 0)
                            {
                                extenso[i] = "sete";
                            }
                            else
                            {
                                extenso[i] = "e sete";
                            }
                            break;
                        case 8:
                            if (num[i - 1] == 0 && num[i - 2] == 0 && num[i - 3] == 0 && num[i - 4] == 0)
                            {
                                extenso[i] = "oito";
                            }
                            else
                            {
                                extenso[i] = "e oito";
                            }
                            break;
                        case 9:
                            if (num[i - 1] == 0 && num[i - 2] == 0 && num[i - 3] == 0 && num[i - 4] == 0)
                            {
                                extenso[i] = "nove";
                            }
                            else
                            {
                                extenso[i] = "e nove";
                            }
                            break;
                        default:
                            if (num[i - 1] == 0 && num[i - 2] == 0 && num[i - 3] == 0 && num[i - 4] == 0)
                            {
                                extenso[i] = "zero";
                            }
                            else
                            {
                                extenso[i] = "";
                            }
                            break;
                    }
                }
                if (i == 3)
                {
                    switch (num[i])
                    {
                        case 1:
                            extenso[i] = "dez ";
                            break;
                        case 2:
                            extenso[i] = "vinte ";
                            break;
                        case 3:
                            extenso[i] = "trinta ";
                            break;
                        case 4:
                            extenso[i] = "quarenta ";
                            break;
                        case 5:
                            extenso[i] = "cinquenta ";
                            break;
                        case 6:
                            extenso[i] = "sessenta ";
                            break;
                        case 7:
                            extenso[i] = "setenta ";
                            break;
                        case 8:
                            extenso[i] = "oitenta ";
                            break;
                        case 9:
                            extenso[i] = "noventa ";
                            break;
                        default:
                            extenso[i] = "";
                            break;


                    }

                }
                if (i == 2)
                {
                    switch (num[i])
                    {
                        case 1:
                            if (num[i + 1] == 0 && num[i + 2] == 0 && num[i - 1] == 0 && num[i - 2] == 0)
                            {
                                extenso[i] = "cem";
                                break;
                            }
                            if (num[i + 1] == 0)
                            {
                                extenso[i] = "cento ";
                            }
                            else
                            {
                                extenso[i] = "cento e ";
                            }
                            break;
                        case 2:
                            if (num[i + 1] == 0)
                            {
                                extenso[i] = "duzentos ";
                            }
                            else
                            {
                                extenso[i] = "duzentos e ";
                            }
                            break;
                        case 3:
                            if (num[i + 1] == 0)
                            {
                                extenso[i] = "trezentos ";
                            }
                            else
                            {
                                extenso[i] = "trezentos e ";
                            }
                            break;
                        case 4:
                            if (num[i + 1] == 0)
                            {
                                extenso[i] = "quatrocentos ";
                            }
                            else
                            {
                                extenso[i] = "quatrocentos e ";
                            }
                            break;
                        case 5:
                            if (num[i + 1] == 0)
                            {
                                extenso[i] = "quinhentos ";
                            }
                            else
                            {
                                extenso[i] = "quinhentos e ";
                            }
                            break;
                        case 6:
                            if (num[i + 1] == 0)
                            {
                                extenso[i] = "seiscentos ";
                            }
                            else
                            {
                                extenso[i] = "seicencentos e ";
                            }
                            break;
                        case 7:
                            if (num[i + 1] == 0)
                            {
                                extenso[i] = "setecentos ";
                            }
                            else
                            {
                                extenso[i] = "setecentos e ";
                            }
                            break;
                        case 8:
                            if (num[i + 1] == 0)
                            {
                                extenso[i] = "oitocentos ";
                            }
                            else
                            {
                                extenso[i] = "oitocentos e ";
                            }
                            break;
                        case 9:
                            if (num[i + 1] == 0)
                            {
                                extenso[i] = "novecentos ";
                            }
                            else
                            {
                                extenso[i] = "novecentos e ";
                            }
                            break;
                        default:
                            extenso[i] = "";
                            break;

                    }
                }
                if (i == 1)
                {
                    switch (num[i])
                    {
                        case 1:
                            if (num[i + 1] == 0 && num[i + 2] == 0 && num[i + 3] == 0 && num[i - 1] == 0)
                            {
                                extenso[i] = "mil";
                                break;
                            }
                            if (num[i - 1] == 1)
                            {
                                extenso[i] = "mil ";
                            }
                            else
                            {
                                extenso[i] = "um mil ";
                            }
                            break;
                        case 2:
                            if (num[i + 1] == 0 && num[i + 2] == 0 && num[i + 3] == 0 && num[i - 1] == 0)
                            {
                                extenso[i] = "dois mil";
                                break;
                            }
                            if (num[i - 1] == 1)
                            {
                                extenso[i] = "mil ";
                            }
                            else if (num[i - 1] >= 2)
                            {
                                extenso[i] = "dois mil ";
                            }
                            break;
                        case 3:
                            if (num[i + 1] == 0 && num[i + 2] == 0 && num[i + 3] == 0 && num[i - 1] == 0)
                            {
                                extenso[i] = "três mil";
                                break;
                            }
                            if (num[i - 1] == 1)
                            {
                                extenso[i] = "mil ";
                            }
                            else if (num[i - 1] >= 2)
                            {
                                extenso[i] = "três mil ";
                            }
                            break;
                        case 4:
                            if (num[i + 1] == 0 && num[i + 2] == 0 && num[i + 3] == 0 && num[i - 1] == 0)
                            {
                                extenso[i] = "quatro mil";
                                break;
                            }
                            if (num[i - 1] == 1)
                            {
                                extenso[i] = "mil ";
                            }
                            else if (num[i - 1] >= 2)
                            {
                                extenso[i] = "quatro mil ";
                            }
                            break;
                        case 5:
                            if (num[i + 1] == 0 && num[i + 2] == 0 && num[i + 3] == 0 && num[i - 1] == 0)
                            {
                                extenso[i] = "cinco mil";
                                break;
                            }
                            if (num[i - 1] == 1)
                            {
                                extenso[i] = "mil ";
                            }
                            else if (num[i - 1] >= 2)
                            {
                                extenso[i] = "cinco mil ";
                            }
                            break;
                        case 6:
                            if (num[i + 1] == 0 && num[i + 2] == 0 && num[i + 3] == 0 && num[i - 1] == 0)
                            {
                                extenso[i] = "seis mil";
                                break;
                            }
                            if (num[i - 1] == 1)
                            {
                                extenso[i] = "mil ";
                            }
                            else if (num[i - 1] >= 2)
                            {
                                extenso[i] = "seis mil ";
                            }
                            break;
                        case 7:
                            if (num[i + 1] == 0 && num[i + 2] == 0 && num[i + 3] == 0 && num[i - 1] == 0)
                            {
                                extenso[i] = "sete mil";
                                break;
                            }
                            if (num[i - 1] == 1)
                            {
                                extenso[i] = "mil ";
                            }
                            else if (num[i - 1] >= 2)
                            {
                                extenso[i] = "sete mil ";
                            }
                            break;
                        case 8:
                            if (num[i + 1] == 0 && num[i + 2] == 0 && num[i + 3] == 0 && num[i - 1] == 0)
                            {
                                extenso[i] = "oito mil";
                                break;
                            }
                            if (num[i - 1] == 1)
                            {
                                extenso[i] = "mil ";
                            }
                            else if (num[i - 1] >= 2)
                            {
                                extenso[i] = "oito mil ";
                            }
                            break;
                        case 9:
                            if (num[i + 1] == 0 && num[i + 2] == 0 && num[i + 3] == 0 && num[i - 1] == 0)
                            {
                                extenso[i] = "nove mil";
                                break;
                            }
                            if (num[i - 1] == 1)
                            {
                                extenso[i] = "mil ";
                            }
                            else if (num[i - 1] >= 2)
                            {
                                extenso[i] = "nove mil ";
                            }
                            break;
                        default:
                            if (num[i - 1] == 1)
                            {
                                extenso[i] = "mil ";
                            }
                            else
                            {
                                extenso[i] = "";
                            }

                            break;

                    }

                }
                if (i == 0)
                {
                    switch (num[i])
                    {
                        case 1:
                            if (num[i + 1] == 1)
                                extenso[i] = "onze ";
                            if (num[i + 1] == 2)
                                extenso[i] = "doze ";
                            if (num[i + 1] == 3)
                                extenso[i] = "treze ";
                            if (num[i + 1] == 4)
                                extenso[i] = "quatorze ";
                            if (num[i + 1] == 5)
                                extenso[i] = "quinze ";
                            if (num[i + 1] == 6)
                                extenso[i] = "dezesseis ";
                            if (num[i + 1] == 7)
                                extenso[i] = "dezessete ";
                            if (num[i + 1] == 8)
                                extenso[i] = "dezoito ";
                            if (num[i + 1] == 9)
                                extenso[i] = "dezenove ";
                            if (num[i + 1] == 0)
                                extenso[i] = "dez ";
                            break;
                        case 2:
                            if (num[i + 1] > 0)
                            {
                                extenso[i] = "vinte e ";
                            }
                            else
                            {
                                extenso[i] = "vinte mil ";
                            }
                            break;
                        case 3:
                            if (num[i + 1] > 0)
                            {
                                extenso[i] = "trinta e ";
                            }
                            else
                            {
                                extenso[i] = "trinta mil ";
                            }
                            break;
                        case 4:
                            if (num[i + 1] > 0)
                            {
                                extenso[i] = "quarenta e ";
                            }
                            else
                            {
                                extenso[i] = "quarenta mil ";
                            }
                            break;
                        case 5:
                            if (num[i + 1] > 0)
                            {
                                extenso[i] = "cinquenta e ";
                            }
                            else
                            {
                                extenso[i] = "cinquenta mil ";
                            }
                            break;
                        case 6:
                            if (num[i + 1] > 0)
                            {
                                extenso[i] = "sessenta e ";
                            }
                            else
                            {
                                extenso[i] = "sessenta mil ";
                            }
                            break;
                        case 7:
                            if (num[i + 1] > 0)
                            {
                                extenso[i] = "setenta e ";
                            }
                            else
                            {
                                extenso[i] = "setenta mil ";
                            }
                            break;
                        case 8:
                            if (num[i + 1] > 0)
                            {
                                extenso[i] = "oitenta e ";
                            }
                            else
                            {
                                extenso[i] = "oitenta mil ";
                            }
                            break;
                        case 9:
                            if (num[i + 1] > 0)
                            {
                                extenso[i] = "noventa e ";
                            }
                            else
                            {
                                extenso[i] = "noventa mil ";
                            }
                            break;
                        default:
                            extenso[i] = "";
                            break;


                    }

                }
            }

            for (int i = 0; i < extenso.Length; i++)
            {
                Console.Write(extenso[i]);
            }
            /*for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i]);
            }*/
        }
    }
}