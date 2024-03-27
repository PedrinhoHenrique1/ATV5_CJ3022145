using System;

int ativ; 
Console.WriteLine("Digite o número da atividade que deseja: ");
ativ = int.Parse(Console.ReadLine());

switch (ativ)
{


    //Atividade 1
    case 1:
        int n1;
        Console.WriteLine("Digite um número inteiro: ");
        n1 = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n1; i++)
        {
            Console.WriteLine(i);
        }
        break;

    //Atividade 2
    case 2:
        int n2;
        Console.WriteLine("Digite um número inteiro: ");
        n2 = int.Parse(Console.ReadLine());

        for (int i = 2; i <= n2; i += 2)
        {
            Console.WriteLine(i);
        }
        break;

    //Atividade 3
    case 3:
        int n3;
        Console.WriteLine("Digite um número inteiro menor que 1000: ");
        n3 = int.Parse(Console.ReadLine());

        for (int i = 1000; i >= n3; i -= 2)
        {
            Console.WriteLine(i);
        }
        break;

    //Atividade 4
    case 4:
        int n4,positivos = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Digite um número: ");
            n4 = int.Parse(Console.ReadLine());

            if (n4 > 0)
            {
                positivos += n4;
                Console.WriteLine(n4);
            }

            if (positivos >= 200)
                break;
        }

        if (positivos < 200)
            Console.WriteLine("A soma dos números positivos é menor que 200.");
        break;

    //Atividade 5
    case 5:
        int div;
    Console.WriteLine("Digite um número inteiro: ");
    int n5 = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n5; i++);
        {