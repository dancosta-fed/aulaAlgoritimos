using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lista de Exercícios ATP...");
        // Write não pula uma linha, como o WriteLine
        // TEXTO estilizado tirado de: 'https://fsymbols.com/pt/geradores/'
        Console.WriteLine(@"

            ██╗░░░░░██╗░██████╗████████╗░█████╗░  ░░███╗░░
            ██║░░░░░██║██╔════╝╚══██╔══╝██╔══██╗  ░████║░░
            ██║░░░░░██║╚█████╗░░░░██║░░░███████║  ██╔██║░░
            ██║░░░░░██║░╚═══██╗░░░██║░░░██╔══██║  ╚═╝██║░░
            ███████╗██║██████╔╝░░░██║░░░██║░░██║  ███████╗
            ╚══════╝╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝  ╚══════╝

         ");

        ShowOptionsMenu();
    }

    static void ShowOptionsMenu()
    {
        Console.Clear();
        // \n adds skips one line
        Console.WriteLine("Digite 1 para o exercício: Lado de um Quadrado");
        Console.WriteLine("Digite 2 para o exercício: Base e altura de um Retângulo");
        Console.WriteLine("Digite 3 para o exercício: Numerador e Denominador");
        Console.WriteLine("Digite 4 para o exercício: Converter °F para °C");
        Console.WriteLine("Digite 5 para o exercício: Quantidade de eleitores");
        Console.WriteLine("Digite 6 para o exercício: Troca de Variáveis");
        Console.WriteLine("Digite 7 para o exercício: Gastos no Restaurante");
        Console.WriteLine("Digite 8 para o exercício: Inverter número");
        Console.WriteLine("Digite 9 para o exercício: Valor do Killowat");
        Console.WriteLine("Digite 0 para sair");

        Console.WriteLine("\nQual a sua escolha?");
        int opcao = int.Parse(Console.ReadLine()!);

        if (opcao == 1)
        {
            Console.Clear();
            Console.WriteLine($"A opção escolhida foi: {opcao}");
            Console.WriteLine("Exercício 1: Lado de Um Quadrado");
            LadosDeUmQuadrado();
        } else if (opcao == 2)
        {
            Console.Clear();
            Console.WriteLine($"A opção escolhida foi: {opcao}");
            Console.WriteLine("Exercício 2: Base e altura de um Retângulo");
            BaseEAlturaDeRetangulo();
        }
        else if (opcao == 3)
        {
            Console.Clear();
            Console.WriteLine($"A opção escolhida foi: {opcao}");
            Console.WriteLine("Exercício 3: Numerador e Denominador");
            NumeradorEDenominador();
        }
        else if (opcao == 4)
        {
            Console.Clear();
            Console.WriteLine($"A opção escolhida foi: {opcao}");
            Console.WriteLine("Exercício 4: Converter °F para °C");
            FahrenheitParaCelsius();
        } else if (opcao == 5)
        {
            Console.Clear();
            Console.WriteLine($"A opção escolhida foi: {opcao}");
            Console.WriteLine("Exercício 5: Quantidade de eleitores");
            QuantidadeDeEleitores();
        } else if (opcao == 6)
        {
            Console.Clear();
            Console.WriteLine($"A opção escolhida foi: {opcao}");
            Console.WriteLine("Exercício 6: Troca de Variáveis");
            TrocaDeVariaveis();
        } else if (opcao == 7)
        {
            Console.Clear();
            Console.WriteLine($"A opção escolhida foi: {opcao}");
            Console.WriteLine("Exercício 7: Gastos no Restaurante");
            GastosRestaurante();
        }
        else if (opcao == 8)
        {
            Console.Clear();
            Console.WriteLine($"A opção escolhida foi: {opcao}");
            Console.WriteLine("Exercício 8: Inverter número");
            InverterNumero();
        }
        else if (opcao == 9)
        {
            Console.Clear();
            Console.WriteLine($"A opção escolhida foi: {opcao}");
            Console.WriteLine("Exercício 9: Valor do Killowat");
            ValorKilowatt();
        } else if (opcao == 0)
        {
            Console.WriteLine(@"

                █▄▄ █▄█ █▀▀   █▄▄ █▄█ █▀▀ ░ ░ ░
                █▄█ ░█░ ██▄   █▄█ ░█░ ██▄ ▄ ▄ ▄
            ");
            Thread.Sleep(2000);
        } else
        {
            Console.WriteLine($"A opção escolhida foi: {opcao}. E esta opção é inválida!");
            HandleWrong();
        }
    }


    static void LadosDeUmQuadrado()
    {
        double l, p, a, d;

        Console.WriteLine("Informe o valor do Lado do quadrado:");
        l = double.Parse(Console.ReadLine()!);
        Console.WriteLine($"O lado do quadrado informado é de {l} ");

        p = (4 * l);
        a = Math.Pow(l, 2);
        d = Math.Sqrt(l);

        Console.WriteLine($"RESULTADO: O perímetro do quadrado é {p}, sua área é de {a} e sua diagonal é de {d}.");

        Console.WriteLine("\nBom, agora escolha 0 para sair ou 1 para voltar ao menu principal?");
        int escolha = int.Parse(Console.ReadLine()!);

        switch (escolha)
        {
            case 0:
                Console.WriteLine("Saindo do programa...");
                Thread.Sleep(2000);
                break;
            case 1:
                Console.WriteLine("Voltando ao menu principal...");
                Thread.Sleep(2000);
                ShowOptionsMenu();
                break;
            default:
                Console.WriteLine("Voltando ao menu principal...");
                Thread.Sleep(2000);
                ShowOptionsMenu();
                break;
        }
    }

    static void BaseEAlturaDeRetangulo()
    {
        double b, h, p, a, d;

        Console.WriteLine("Informe o valor a base do retângulo:");
        b = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Agora, informe o valor a altura do retângulo:");
        h = double.Parse(Console.ReadLine()!);

        Console.WriteLine($"Seu retângulo tem a base igual a {b}, e a altura igual a {h}.");

        p = 2 * (b + h);
        a = b * h;
        d = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));

        Console.WriteLine($"Com essas informações, podemos dizer que: O perímetro do retângulo é {p}, sua área é de {a} e sua diagonal é de {d}.");
        Console.WriteLine("\nBom, agora escolha 0 para sair ou 1 para voltar ao menu principal?");
        int escolha = int.Parse(Console.ReadLine()!);

        switch (escolha)
        {
            case 0:
                Console.WriteLine("Saindo do programa...");
                Thread.Sleep(2000);
                break;
            case 1:
                Console.WriteLine("Voltando ao menu principal...");
                Thread.Sleep(2000);
                ShowOptionsMenu();
                break;
            default:
                Console.WriteLine("Voltando ao menu principal...");
                Thread.Sleep(2000);
                ShowOptionsMenu();
                break;
        }
    }

    static void NumeradorEDenominador()
    {
        double numerador, denominador, result;

        Console.WriteLine("Informe o numerador da fração:");
        numerador = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Informe o denominador da fração:");
        denominador = double.Parse(Console.ReadLine()!);

        result = numerador / denominador;

        Console.WriteLine($"O resultado desta fração é: {result.ToString("N2")}");
        Console.WriteLine("\nBom, agora escolha 0 para sair ou 1 para voltar ao menu principal?");
        int escolha = int.Parse(Console.ReadLine()!);

        switch (escolha)
        {
            case 0:
                Console.WriteLine("Saindo do programa...");
                Thread.Sleep(2000);
                break;
            case 1:
                Console.WriteLine("Voltando ao menu principal...");
                Thread.Sleep(2000);
                ShowOptionsMenu();
                break;
            default:
                Console.WriteLine("Voltando ao menu principal...");
                Thread.Sleep(2000);
                ShowOptionsMenu();
                break;
        }
    }

    static void FahrenheitParaCelsius()
    {
        double f, c;
        Console.WriteLine("Informe a temperatura em Fahrenheit (°F):");
        f = double.Parse(Console.ReadLine()!);

        c = 5 * (f - 32) / 9;

        Console.WriteLine($"A temperatura {f} °F, é equivalente à {c.ToString("N1")} °C");
        Console.WriteLine("\nBom, agora escolha 0 para sair ou 1 para voltar ao menu principal?");
        int escolha = int.Parse(Console.ReadLine()!);

        switch (escolha)
        {
            case 0:
                Console.WriteLine("Saindo do programa...");
                Thread.Sleep(2000);
                break;
            case 1:
                Console.WriteLine("Voltando ao menu principal...");
                Thread.Sleep(2000);
                ShowOptionsMenu();
                break;
            default:
                Console.WriteLine("Voltando ao menu principal...");
                Thread.Sleep(2000);
                ShowOptionsMenu();
                break;
        }
    }

    static void QuantidadeDeEleitores()
    {
        int qntEleitores;
        double votosBrancos, votosNulos, votosValidos, percentualBrancos, percentualNulos, percentualValidos;

        Console.WriteLine("Qual a quantidade de eleitores da cidade?");
        qntEleitores = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Qual a quantidade de votos válidos?");
        votosValidos = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Qual a quantidade de votos nulos?");
        votosNulos = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Qual a quantidade de votos em branco?");
        votosBrancos = double.Parse(Console.ReadLine()!);

        percentualValidos = votosValidos / qntEleitores * 100;
        percentualNulos = votosNulos / qntEleitores * 100;
        percentualBrancos = votosBrancos / qntEleitores * 100;

        Console.WriteLine($"Para uma população com {qntEleitores}, e as quantidades de votos obtidas. " +
            $"Podemos dizer que {percentualValidos.ToString("N2")}% dos votos foram válidos, {percentualNulos.ToString("N2")}% dos votos foram nulos" +
            $" e {percentualBrancos.ToString("N2")}% dos votos foram em branco.");

        Console.WriteLine("\nBom, agora escolha 0 para sair ou 1 para voltar ao menu principal?");
        int escolha = int.Parse(Console.ReadLine()!);

        switch (escolha)
        {
            case 0:
                Console.WriteLine("Saindo do programa...");
                Thread.Sleep(2000);
                break;
            case 1:
                Console.WriteLine("Voltando ao menu principal...");
                Thread.Sleep(2000);
                ShowOptionsMenu();
                break;
            default:
                Console.WriteLine("Voltando ao menu principal...");
                Thread.Sleep(2000);
                ShowOptionsMenu();
                break;
        }

    }

    static void TrocaDeVariaveis()
    {
        double varA, varB, varC;

        Console.WriteLine("Me diga um número Real");
        varA = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Agora preciso de outro número Real");
        varB = double.Parse(Console.ReadLine()!);

        Console.WriteLine($"Seus números são A é igual a {varA} e B é igual a {varB}");
        Console.WriteLine("Vamos mudar essa ordem...");

        varC = varA;
        varA = varB;
        varB = varC;

        Console.WriteLine($"Prontinho... agora A é igual a {varA} e B é igual a {varB}");

        Console.WriteLine("\nBom, agora escolha 0 para sair ou 1 para voltar ao menu principal?");
        int escolha = int.Parse(Console.ReadLine()!);

        switch (escolha)
        {
            case 0:
                Console.WriteLine("Saindo do programa...");
                Thread.Sleep(2000);
                break;
            case 1:
                Console.WriteLine("Voltando ao menu principal...");
                Thread.Sleep(2000);
                ShowOptionsMenu();
                break;
            default:
                Console.WriteLine("Voltando ao menu principal...");
                Thread.Sleep(2000);
                ShowOptionsMenu();
                break;
        }
    }

    static void GastosRestaurante()
    {
        double valorConta, percentualGorgeta, valorFinal, gorgeta;

        Console.WriteLine("Qual foi o valor da sua conta?");
        valorConta = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Qual porcentagem você quer dar de gorgeta?");
        percentualGorgeta = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Calculando o valor total a pagar...");

        gorgeta = valorConta * (percentualGorgeta / 100);
        valorFinal = valorConta + gorgeta;

        Console.WriteLine($"Valor da gorgeta = R${gorgeta.ToString("N2")}");

        Console.WriteLine($"O valor total a ser pago é de R${valorFinal.ToString("N2")}");
        Console.WriteLine("\nBom, agora escolha 0 para sair ou 1 para voltar ao menu principal?");
        int escolha = int.Parse(Console.ReadLine()!);

        switch (escolha)
        {
            case 0:
                Console.WriteLine("Saindo do programa...");
                Thread.Sleep(2000);
                break;
            case 1:
                Console.WriteLine("Voltando ao menu principal...");
                Thread.Sleep(2000);
                ShowOptionsMenu();
                break;
            default:
                Console.WriteLine("Voltando ao menu principal...");
                Thread.Sleep(2000);
                ShowOptionsMenu();
                break;
        }
    }

    static void InverterNumero()
    {
        int num, cent, dez, un, newNum;

        Console.WriteLine("Diga um número com três dígitos.");
        string userInput = Console.ReadLine()!;

        if (userInput.Length != 3)
        {
            Console.WriteLine($"Seu número é {userInput}. Mas, o número precisa conter 3 digitos.");
        } else
        {
            num = int.Parse(userInput);
            Console.WriteLine($"Seu número é: {num}");

            cent = num / 100;
            dez = (num / 10) % 10;
            un = num % 10;

            newNum = 100 * un + 10 * dez + cent;

            Console.WriteLine($"O novo número é: {newNum}");
            Console.WriteLine("\nBom, agora escolha 0 para sair ou 1 para voltar ao menu principal?");
            int escolha = int.Parse(Console.ReadLine()!);

            switch (escolha)
            {
                case 0:
                    Console.WriteLine("Saindo do programa...");
                    Thread.Sleep(2000);
                    break;
                case 1:
                    Console.WriteLine("Voltando ao menu principal...");
                    Thread.Sleep(2000);
                    ShowOptionsMenu();
                    break;
                default:
                    Console.WriteLine("Voltando ao menu principal...");
                    Thread.Sleep(2000);
                    ShowOptionsMenu();
                    break;
            }
        }


    }

    static void ValorKilowatt()
    {
        double minimumWage, kilowatt, valorPorKilowatt, valorAPagar;

        Console.WriteLine("Qual o valor do salário Mínimo?");
        minimumWage = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Quanto kilowatt você gastou esse mês?");
        kilowatt = double.Parse(Console.ReadLine()!);

        Console.WriteLine($"kilowat: {kilowatt}");

        valorPorKilowatt = (1.0 / 10) * minimumWage;

        valorAPagar = valorPorKilowatt * kilowatt;

        Console.WriteLine($"O valor em reais de cada kilowat é de: R${valorPorKilowatt}");
        Console.WriteLine($"O valor total a pagar é de: R${valorAPagar}");

        Console.WriteLine("\nBom, agora escolha 0 para sair ou 1 para voltar ao menu principal?");
        int escolha = int.Parse(Console.ReadLine()!);

        switch (escolha)
        {
            case 0:
                Console.WriteLine("Saindo do programa...");
                Thread.Sleep(2000);
                break;
            case 1:
                Console.WriteLine("Voltando ao menu principal....");
                Thread.Sleep(2000);
                ShowOptionsMenu();
                break;
            default:
                Console.WriteLine("Voltando ao menu principal...");
                Thread.Sleep(2000);
                ShowOptionsMenu();
                break;
        }
    }

    static void HandleWrong()
    {
        Thread.Sleep(2000);
        ShowOptionsMenu();
    }
}
