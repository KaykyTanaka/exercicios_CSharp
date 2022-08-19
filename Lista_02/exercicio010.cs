/* 10- Crie um Algoritmo que receba um número e imprima sua raiz quadrada.
SAÍDA:
A raiz quadrada de no número .... é ... */

Console.WriteLine("Digite um número para descobrir sua raíz quadrada: ");
double raiz = double.Parse(Console.ReadLine());
Console.WriteLine($"A raiz quadrada do numero {raiz} é {Math.Sqrt(raiz)}");