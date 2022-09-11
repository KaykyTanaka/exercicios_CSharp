/* Utilizando a estrutura for crie um algoritmo que entre 
com cinco números e imprimir o quadrado de cada número */

for (int i = 0; i < 5; i++)
{
    Console.Write("\nInsira um valor: ");
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine($"O quadrado desse numero é = {Math.Pow(num, 2)}");
}

