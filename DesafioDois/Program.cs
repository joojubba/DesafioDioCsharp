﻿// Desafios de Código Básico C# - Pottencial
// 2 / 3 - Encaixa ou Não?

using System.IO;
using System.Linq;
using System;

class Program {

    static void Main(string[] args)
    {
        int qt = int.Parse(Console.ReadLine());
// TODO: Crie as outras condições necessárias para a resolução do desafio:
        string[] v = new string[2];
    
        for (int i = 0; i < qt; i++) {
          v = Console.ReadLine().Split(" ");
          string a = v[0];
          string b = v[1];

          if (b.Length > a.Length)
            Console.WriteLine("nao encaixa");
          else if (a.EndsWith(b))
            Console.WriteLine("encaixa");
          else
            Console.WriteLine("nao encaixa");
        }

    }

}