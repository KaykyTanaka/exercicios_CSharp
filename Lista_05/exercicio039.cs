/* Receber o salário de um funcionário, exibir o valor deste salário, calcular
e mostrar seu novo salário, sabendo que ele recebeu um aumento de 25%. */

Console.Write("Insira seu salário: ");
double salario = double.Parse(Console.ReadLine());
double nsalario = (0.25 * salario) + (salario);
Console.WriteLine($"Seu salario era de: {salario}\ncom um reajuste de 25% seu\nnovo salario é de: {nsalario}");