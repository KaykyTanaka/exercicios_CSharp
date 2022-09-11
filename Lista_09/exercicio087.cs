/* Exercício 87
Utilizando a estrutura for crie um algoritmo que imprima a soma dos números pares
entre 25 e 200. */
int soma = 0;
for (int i = 25; i <= 200; i++)
{
    if (i % 2 == 0)
    {
        soma += i;
    }
}

Console.Write($"A soma dos numeros pares compreendidos entre 25 e 200 é {soma}");