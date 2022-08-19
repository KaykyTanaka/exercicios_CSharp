/*18 – Crie um algoritmo que possa calcular a área de uma coroa de forma circular (figura
meramente ilustrativa).
Área da circunferência = PI * raio2
Área = (Área da circunferência Maior) – (Área da circunferência menor)
 */

Console.Write("Insira o valor do raio da circunferencia maior: ");
double raioMaior = double.Parse(Console.ReadLine());

Console.Write("Insira o valor do raio da circunferencia menor: ");
double raioMenor = double.Parse(Console.ReadLine());

double pi = 3.14; 
double aMaior = pi * Math.Pow(raioMaior, 2);
double aMenor = pi * Math.Pow(raioMenor, 2);

double areaC = aMaior - aMenor;

Console.WriteLine($"O valor da área de uma coroa de forma circular é {areaC}");