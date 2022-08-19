/* 22 – Entrar com três números e imprimir a média aritmética. Imprima também se o
aluno está aprovado ou reprovado sabendo-se que para ser aprovado a média deve ser
maior ou igual à 7,50.
 */

Console.Write("Digite a 1º nota: ");
double nota1 = double.Parse(Console.ReadLine());

Console.Write("Digite a 2º nota: ");
double nota2 = double.Parse(Console.ReadLine());

Console.Write("Digite a 3º nota: ");
double nota3 = double.Parse(Console.ReadLine());

double calculo = (nota1 + nota2 + nota3)/(3);

Console.WriteLine($"A média  é: {calculo}");
Console.WriteLine((calculo >= 7.50) ? "Aluno Aprovado" : "Aluno Reprovado");
