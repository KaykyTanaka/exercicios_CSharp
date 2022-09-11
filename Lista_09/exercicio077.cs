/* Exercício 77
Utilizando a estrutura for imprima o quadrado dos números de 1 ate 20. */

Console.Write("O quadrado dos numeros de 1 a 20:\n");
for (int i = 1; i <=20; i++)
{
    Console.Write($"{Math.Pow(i,2)} | ");
}