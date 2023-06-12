Matematica m = new Matematica();
erro:;
while (true)
{
    Console.WriteLine("\n0-Sair\n1-Somar\n2-Maior número\n3-Raiz quadrada\nescolha o que deseja fazer");
    byte opcao = Convert.ToByte(Console.ReadLine());


    switch (opcao)
    {
        case 0:
            goto sair;

        case 1:
            Console.WriteLine("Digite dois valores pra ser feita a soma");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Resultado da soma: {m.Somar(num1, num2)}");
            break;

        case 2:
            Console.WriteLine("Digite dois valores para verificação do maior número");
            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Resultado: {m.Maior(num1, num2)}");
            break;

        case 3:
            Console.WriteLine("Digite o valor para verificar a raiz quadrada");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Raiz: {m.RaizQuadrada(num1)}");
            break;

        default:
            goto erro;
    }
}
sair:;
