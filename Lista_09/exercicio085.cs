/* Exercício 85
Utilizando a estrutura for crie um algoritmo que leia um número que servirá para
controlar os números pares que serão impressos a partir de 2.
Exemplo:
Quantos: 4
Saída: 2 4 6 8 */

Console.Write("Insira um valor para a quantidade de numeros pares a serem impressos: ");
int x = int.Parse(Console.ReadLine());
int num = 0;
for (int i = 1; i <= x; i++)
{
    num += 2;
    Console.Write($"{num} | ");
}