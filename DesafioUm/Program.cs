// DESAFIO 1
// Desafios de Código Básico C# - Pottencial
// 1 / 3 - Subtraindo o produto e a soma de um número inteiro

using System;

class DIO
{

    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        int p = 1, s = 0;
        while (n > 0)
        {
            int l = n % 10;
            // TODO: Crie as outras condições necessárias para a resolução do desafio:
            p *= l;
            s += l;
            n /= 10;
        }


        Console.WriteLine(p - s);
    }
}


