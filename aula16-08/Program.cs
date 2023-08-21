using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lista de Exercícios ATP...");

        //Console.WriteLine("Exercício 1: Lado de um Quadrado:");
        //LadosDeUmQuadrado();

        //Console.WriteLine("Exercício 2: Base e altura de um Retângulo");
        //BaseEAlturaDeRetangulo();

        //Console.WriteLine("Exercício 3: Numerador e Denominador");
        //NumeradorEDenominador();

        //Console.WriteLine("Exercício 4: Converter °F para °C");
        //FahrenheitParaCelsius();

        Console.WriteLine("Exercício 5: Quantidade de eleitores");
        QuantidadeDeEleitores();

        Console.ReadLine();
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
    }

    static void FahrenheitParaCelsius()
    {
        double f, c;
        Console.WriteLine("Informe a temperatura em Fahrenheit (°F):");
        f = double.Parse(Console.ReadLine()!);

        c = 5 * (f - 32) / 9;

        Console.WriteLine($"A temperatura {f} °F, é equivalente à {c.ToString("N1")} °C");
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
            $"Podemos dizer que {percentualValidos}% dos votos foram válidos, {percentualNulos}% dos votos foram nulos" +
            $" e {percentualBrancos}% dos votos foram em branco.");

    }
} 