/*13 – Entrar com quatro números e imprimir a média ponderada, sabendo-se que os
pesos são respectivamente 1, 2, 3 e 4.
 */

 Console.WriteLine("Digite a 1º Nota: ");
 double nota1 = double.Parse(Console.ReadLine());

 Console.WriteLine("Digite a 2º Nota: ");
 double nota2 = double.Parse(Console.ReadLine());
 
 Console.WriteLine("Digite a 3º Nota: ");
 double nota3 = double.Parse(Console.ReadLine());
 
 Console.WriteLine("Digite a 4º Nota: ");
 double nota4 = double.Parse(Console.ReadLine());

double media = ((nota1*1) + (nota2*2) + (nota3*3) + (nota4*4))/(1 + 2 + 3 + 4);

Console.WriteLine($"Sua média ponderada é : {media}");