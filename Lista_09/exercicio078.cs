/* Exercício 78
Utilizando a estrutura for crie um algoritmo que imprima os números pares no intervalo
de 1 a 600 */

for (int i = 1; i <= 600; i++)
{
    if (i%2==0)
    {
        Console.Write($"{i} | ");
    }
}