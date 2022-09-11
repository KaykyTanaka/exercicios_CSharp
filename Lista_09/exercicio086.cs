/* Exercício 86
Utilizando a estrutura for crie um algoritmo que leia um número e imprima todos os
números de 1 até o número lido e o seu produto.
Exemplo:
número: 3
Saída: 1 2 3
6 (produto) */

Console.Write("Insira um numero para ser o valor maximo: ");
int max = int.Parse(Console.ReadLine());
int produto = 1;
for (int i = 1; i <= max; i++)
{
    Console.Write($"{i} | ");
    produto = i * produto;
}
Console.Write($"\nO produto é = {produto}");