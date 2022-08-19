/*17 – Construa um algoritmo que possa calcular o volume de um prisma de base
triangular (figura meramente ilustrativa).
Volume = área da base x altura.

 */

 
Console.Write("Insira o valor da área da base do prisma: ");
double areaB = double.Parse(Console.ReadLine());

Console.Write("Insira o valor da altura: ");
double altura = double.Parse(Console.ReadLine());

double volume = areaB * altura ;

Console.WriteLine($"O volume do prisma é: {volume}");