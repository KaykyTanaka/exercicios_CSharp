/* Exercício 84
Utilizando a estrutura for crie um algoritmo que leia um número que será o limite
superior de um intervalo e imprimir todos os números ímpares menores do que esse
número. Exemplo:
Limite superior: 15
Saída: 1 3 5 7 9 11 13 */

Console.Write("Insira um valor para ser o limite: ");
int max = int.Parse(Console.ReadLine());

for (int i = 1; i < max; i++)
{
    if (i%2!=0)
    {
        Console.Write($"{i} | ");
    }
}