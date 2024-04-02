
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

        for (int contador0 = 1; contador0 <= n1; contador0++)
        {
            Console.WriteLine(contador0);
        }
        break;

    //Atividade 2
    case 2:
        int n2;
        Console.WriteLine("Digite um número inteiro: ");
        n2 = int.Parse(Console.ReadLine());

        for (int contador = 2; contador <= n2; contador += 2)
        {
            Console.WriteLine(contador);
        }
        break;

    //Atividade 3
    case 3:
        int n3;
        Console.WriteLine("Digite um número inteiro menor que 1000: ");
        n3 = int.Parse(Console.ReadLine());

        for (int contador1 = 1000; contador1 >= n3; contador1 -= 2)
        {
            Console.WriteLine(contador1);
        }
        break;

    //Atividade 4
    case 4:
        int n4, positivos = 0;

        for (int contador2 = 0; contador2 < 10; contador2++)
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
        Console.Write("Digite um número inteiro: ");
        int n5 = int.Parse(Console.ReadLine());

        Console.Write("Divisores de " + n5 + ": ");

        for (int contador3 = 1; contador3 <= n5; contador3++)
        {
            if (n5 % contador3 == 0)
            {
                Console.Write(contador3 + " ");
            }
        }

        Console.ReadLine();
        break;
        break;

    //Atividade 6
    case 6:
        Console.WriteLine("Digite 10 números, um por linha: ");
        int[] n6 = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite um número {i + 1}: ");
            string input = Console.ReadLine();
            n6[i] = int.Parse(input);
        }

        int maior_num = n6.Max();
        int menor_num = n6.Min();

        Console.WriteLine($"O maior número é: {maior_num}");
        Console.WriteLine($"O menor número é: {menor_num}");
        break;
    //Atividade 7
    case 7:

        for (int nmr4 = 0, pares = 0, impares = 0; ;)
        {
            Console.WriteLine("Digite um valor, somaremos os ímpares e os pares, se digitar '0' o programa é encerrado");
            nmr4 = int.Parse(Console.ReadLine());

            if (nmr4 == 0)
            {
                Console.WriteLine("A soma dos números pares é:{0}}\nA soma dos números ímpares é: {1}", pares, impares);
                break;
            }
            if (nmr4 % 2 == 0)
            {
                pares = pares + nmr4;
            else
                impares = impares + nmr4;
            }
            break;
            
           

