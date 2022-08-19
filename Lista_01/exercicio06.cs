/* 06 – Ler dois números e exibir as seguintes mensagens:
 O números digitados foram ... e .... .
 A soma dos números ... e ... é ... .
 A subtração dos números ... e ... é ... .
 A multiplicação dos números ... e ... é ... .
 A divisão dos números ... e ... é ... .
 A média dos números ... e ... é ... . */
 
Console.WriteLine("Digite um numero: ");
int num = int.Parse((Console.ReadLine()));

Console.WriteLine("Digite outro numero: ");
int num1 = int.Parse((Console.ReadLine()));

Console.WriteLine($"O números digitados foram {num} e {num1}\nA soma dos números {num} e {num1} é {num + num1} .\nA subtração dos números {num} e {num1} é {num - num1} .\nA multiplicação dos números {num} e {num1} é {num * num1} .\nA divisão dos números {num} e {num1} é {num / num1} .\nA média dos números {num} e {num1} é {(num + num1) / 2}.");