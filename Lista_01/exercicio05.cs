/* 05 – Cria um algoritmo que receba 5 números do tipo double e exiba a soma com a
seguinte frase:
“Os números digitados foram ..., ..., ..., ... e sua soma é ... . */

Console.WriteLine("Digite o 1º numero: ");
double num = double.Parse((Console.ReadLine()));

Console.WriteLine("Digite o 2º numero: ");
double num1 = double.Parse((Console.ReadLine()));

Console.WriteLine("Digite o 3º numero: ");
double num2 = double.Parse((Console.ReadLine()));

Console.WriteLine("Digite o 4º numero: ");
double num3 = double.Parse((Console.ReadLine()));

Console.WriteLine("Digite o 5º numero: ");
double num4 = double.Parse((Console.ReadLine()));

Console.WriteLine($"Os valores digitados foram: {num}, {num1}, {num2}, {num3} e {num4}\na soma é : {num + num1 + num2 + num3 + num4}");