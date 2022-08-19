/*19 – Elabore um algoritmo que possa calcular o volume de um cilindro (figura
meramente ilustrativa).
Área da base = área da circunferência
Volume = área da base x altura  
*/

Console.Write("Insira o valor da base do Cilindro: ");
double cbase = double.Parse(Console.ReadLine());

Console.Write("Insira o valor da altura: ");
double altura = double.Parse(Console.ReadLine());
double volume = cbase * altura;

Console.WriteLine($"O valor do volume do cilindro é: {volume}");