/* Exercício 80
Utilizando a estrutura for crie um algoritmo que imprima todos os números de 1 ate
100 e a soma deles. */
int soma = 0;
for (int i = 1; i <= 100; i++)
{
    Console.Write($"{i} | ");
    soma +=i;    
}
Console.Write($"\nA soma de todos os numeros é = {soma}");