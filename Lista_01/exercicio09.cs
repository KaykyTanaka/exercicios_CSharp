Console.WriteLine("Insira o valor da base do retangulo: ");
double baseR = double.Parse(Console.ReadLine());

Console.WriteLine("Insira o valor da altura do retangulo: ");
double altR = double.Parse(Console.ReadLine());

Console.WriteLine($"O Retangulo de base {baseR} e altura {altR}\npossuí area de {baseR * altR} e perimetro de {(2 * baseR) + (2 * altR)}");
