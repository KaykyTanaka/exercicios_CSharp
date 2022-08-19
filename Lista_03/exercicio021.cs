/* 21 – Entrar com quatro notas de um aluno e imprimir a média ponderada destas notas,
sabendo-se que os pesos são respectivamente 3, 5, 6 e 6.
Imprima também se o aluno está aprovado ou reprovado sabendo-se que para ser
aprovado a média deve ser maior que 6,00.
 */

Console.Write("Digite a 1º nota: ");
double nota1 = double.Parse(Console.ReadLine());

Console.Write("Digite a 2º nota: ");
double nota2 = double.Parse(Console.ReadLine());

Console.Write("Digite a 3º nota: ");
double nota3 = double.Parse(Console.ReadLine());

Console.Write("Digite a 4º nota: ");
double nota4 = double.Parse(Console.ReadLine());

double calculo = ((nota1 * 3)+(nota2 * 5)+(nota3 * 6)+(nota4 * 6))/(3+5+6+6);

Console.WriteLine($"A média ponderada é: {calculo}");
Console.WriteLine((calculo >= 6.00) ? "Aluno Aprovado" : "Aluno Reprovado");