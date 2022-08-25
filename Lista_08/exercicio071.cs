/* Exercício 71
Entrar com 10 números e imprimir a metade de cada número. */
int x = 0;
while (x < 10)
{
    Console.Write("\nInsira um valor: ");
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine($"Sua metade é: {num / 2}");
    x++;
}