/* Exercício 76
Utilizando a estrutura for imprima os múltiplos de 5, no intervalo de 1 até 500. */

for (int i = 1; i <= 500; i++)
{
    if (i%5==0)
    {
    Console.Write($"{i} | ");
    }
}