/* Exercício 81
Utilizando a estrutura for entre com 10 números e imprimir a metade de cada número.*/

for (int i = 0; i < 10; i++)
{
    Console.Write("\nInsira um numero: ");
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine($"Sua metade é = {x/2}");

}