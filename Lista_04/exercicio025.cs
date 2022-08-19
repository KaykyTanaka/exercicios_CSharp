/* - Criar um algoritmo que calcule e imprima a área e a hipotenusa de um triângulo
retângulo.
Observação: Os valores devem ser positivos.*/

Console.WriteLine("Insira a base do triangulo: ");
int baseT = int.Parse(Console.ReadLine());

Console.WriteLine("Insira a altura: ");
int altura = int.Parse(Console.ReadLine());

Console.WriteLine($"O valor da hipotenusa é: {(baseT*altura)/2}");