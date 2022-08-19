/* 04 – Crie um algoritmo que receba duas variáveis do tipo inteiro.
Atribuir um valor para cada variável e posteriormente exibir este valor.
Para finalizar, exibir a primeira variável acrescida de uma unidade e exibir a segunda
variável decrescida de uma unidade. */

Console.WriteLine("Digite um numero: ");
int num = int.Parse((Console.ReadLine()));

Console.WriteLine("Digite outro numero: ");
int num1 = int.Parse((Console.ReadLine()));

Console.WriteLine($"Os valores digitados foram: {num} e {num1} \n {num} + 1 = {num + 1} \n {num1} - 1 = {num1 - 1}");