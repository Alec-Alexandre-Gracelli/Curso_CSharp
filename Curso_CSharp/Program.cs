using System.Globalization;

namespace Prova_Logica;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha o exercício para executar (1, 2, 3, 4, 5 e 6): ");
        int escolha = Convert.ToInt32(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                Exercicio1();
                break;
            case 2:
                Exercicio2();
                break;
            case 3:
                Exercicio3();
                break;
            case 4:
                Exercicio4();
                break;
            case 5:
                Exercicio5();
                break;
            case 6:
                Exercicio6();
                break;
            default:
                Console.WriteLine("Escolha inválida.");
                break;
        }
    }

    static void Exercicio1()
    {
        int codigo1, quantidadeCod1, codigo2, quantidadeCod2;
        double valorCod1, valorCod2;

        string[] input1 = Console.ReadLine().Split(' ');

        codigo1 = Convert.ToInt32(input1[0]);
        quantidadeCod1 = Convert.ToInt32(input1[1]);
        valorCod1 = Convert.ToDouble(input1[2], CultureInfo.InvariantCulture);

        string[] input2 = Console.ReadLine().Split(' ');

        codigo2 = Convert.ToInt32(input2[0]);
        quantidadeCod2 = Convert.ToInt32(input2[1]);
        valorCod2 = Convert.ToDouble(input2[2], CultureInfo.InvariantCulture);

        var resultadoSomaFinal = quantidadeCod1 * valorCod1 + quantidadeCod2 * valorCod2;

        string resultadoFormatado = resultadoSomaFinal.ToString("F2", CultureInfo.InvariantCulture);

        Console.WriteLine($"VALOR A PAGAR: R${resultadoFormatado}");
        Console.ReadKey();
    }

    static void Exercicio2()
    {
        double raio;
        double pi = 3.14159;

        Console.WriteLine();
        raio = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        var formulaAreaDoCirculo = pi * Math.Pow(raio, 2);

        string resultadoFormatado = formulaAreaDoCirculo.ToString("F4", CultureInfo.InvariantCulture);

        Console.WriteLine($"A={resultadoFormatado}");
        Console.ReadKey();

    }

    static void Exercicio3()
    {
        int codigo;
        int quantidade;
        double preco;
        double valor;

        string[] input1 = Console.ReadLine().Split(' ');

        codigo = Convert.ToInt32(input1[0]);
        quantidade = Convert.ToInt32(input1[1]);

        if (codigo == 1)
        {
            preco = 4.00;
            valor = quantidade * preco;
            Console.WriteLine($"Total: R$ {valor.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        else if (codigo == 2)
        {
            preco = 4.50;
            valor = quantidade * preco;
            Console.WriteLine($"Total: R$ {valor.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        else if (codigo == 3)
        {
            preco = 5.00;
            valor = quantidade * preco;
            Console.WriteLine($"Total: R$ {valor.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        else if (codigo == 4)
        {
            preco = 2.00;
            valor = quantidade * preco;
            Console.WriteLine($"Total: R$ {valor.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        else if (codigo == 5)
        {
            preco = 1.50;
            valor = quantidade * preco;
            Console.WriteLine($"Total: R$ {valor.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        else
        {
            Console.WriteLine("Código não encontrado!");
        }

        Console.ReadKey();
    }
    static void Exercicio4()
    {
        double a, b, c;
        double resultado;

        string[] input1 = Console.ReadLine().Split(' ');

        Console.WriteLine();
        a = Convert.ToDouble(input1[0], CultureInfo.InvariantCulture);
        b = Convert.ToDouble(input1[1], CultureInfo.InvariantCulture);
        c = Convert.ToDouble(input1[2], CultureInfo.InvariantCulture);

        double delta = b * b - 4 * a * c;

        if (delta > 0 && a != 0)
        {
            var formulaBaskaraX1 = (-b + Math.Sqrt(delta)) / (2 * a);
            var formulaBaskaraX2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine($"X1 = {formulaBaskaraX1.ToString("F5", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"X2 = {formulaBaskaraX2.ToString("F5", CultureInfo.InvariantCulture)}");
        }

        else
        {
            Console.WriteLine("Impossível calcular");
        }
        Console.ReadKey();
    }
    static void Exercicio5()
    {
        int senha = 2002;
        int leitura;

        do
        {
            Console.WriteLine();
            leitura = Convert.ToInt32(Console.ReadLine());

            if (leitura == senha)
            {
                Console.WriteLine("Acesso Permitido");
                break;
            }
            else
            {
                Console.WriteLine("Senha Invalida");
            }
        }
        while (leitura != senha);
    }
    static void Exercicio6()
    {
        int valorN;
        int valorX = 0;
        int contadorValorX = 0;
        int[] listValorX = new int[valorX];

        Console.WriteLine();
        valorN = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < valorN; i++)
        {
            listValorX = new int[valorN];
            Console.WriteLine();
            valorX = Convert.ToInt32(Console.ReadLine());
        }

        for (int j = 0; j < listValorX[valorN]; j++)
        {
            if (valorX >= 10 && valorX <= 20)
            {
                contadorValorX += 1;
                Console.WriteLine($"{contadorValorX} in");
            }

            else
            {
                contadorValorX += 1;
                Console.WriteLine($"{contadorValorX} out");
            }
        }

        Console.ReadKey();
    }
}


