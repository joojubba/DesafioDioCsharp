﻿// Desafios de Código Intermediário C# - Pottencial
// 2 / 3 - Aumento de Salário


using System;  

class minhaClasse
{

    public static void Main(string[] args)
    {

        double salario = 0.00;
        double reajuste = 0.00;
        double novoSalario = 0.00;
        double percentual = 0.00;

        salario = Convert.ToDouble(Console.ReadLine());

        //TODO: Complete os espaços em branco com uma possível solução para o problema:
        if (salario < 0.00)
        {
            return;

        }
        else if (salario <= 400.00)
        {
            percentual = 0.15;
            reajuste = percentual * salario;
            novoSalario = reajuste + salario;


        }
        else if (salario <= 800.00)
        {
            percentual = 0.12;
            reajuste = percentual * salario;
            novoSalario = reajuste + salario;

        }
        else if (salario <= 1200.00)
        {
            percentual = 0.10;
            reajuste = percentual * salario;
            novoSalario = reajuste + salario;

        }
        else if (salario <= 2000.00)
        {
            percentual = 0.07;
            reajuste = percentual * salario;
            novoSalario = reajuste + salario;

        }
        else
        {
            percentual = 0.04;
            reajuste = percentual * salario;
            novoSalario = reajuste + salario;

        }

        Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
        Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
        Console.WriteLine("Em percentual: {0} %", percentual * 100.00);

    }
}
