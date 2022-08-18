Console.WriteLine("Digite um numero: ");
int num = int.Parse((Console.ReadLine()));

Console.WriteLine("Digite outro numero: ");
int num1 = int.Parse((Console.ReadLine()));

Console.WriteLine($"O números digitados foram {num} e {num1}\nA soma dos números {num} e {num1} é {num + num1} .\nA subtração dos números {num} e {num1} é {num - num1} .\nA multiplicação dos números {num} e {num1} é {num * num1} .\nA divisão dos números {num} e {num1} é {num / num1} .\nA média dos números {num} e {num1} é {(num + num1) / 2}.");