/* Exercício 82
Utilizando a estrutura for entre com quatro números e imprimir o cubo e a raiz cúbica
de cada número. */

for (int i = 0; i < 4; i++)
{
    Console.Write("\nInsira um valor: ");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine($"O valor ELEVADO AO CUBO é = {Math.Pow(x,3)} | E sua RAIZ CÚBICA é = {Math.Cbrt(x)}");
}