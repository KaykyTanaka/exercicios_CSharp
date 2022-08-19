/* 31 - Efetuar a leitura de três valores e apresentar como resultado final a soma dos
quadrados dos três valores lidos. Apresentar também se a soma é um número par ou
ímpar. */
Console.Write("Insira o primeiro valor: ");
double num1 = double.Parse(Console.ReadLine());
Console.Write("Insira o segundo valor: ");
double num2 = double.Parse(Console.ReadLine());
Console.Write("Insira o terceiro valor: ");
double num3 = double.Parse(Console.ReadLine());

double soma = (Math.Pow(num1, 3) + Math.Pow(num2, 3) + Math.Pow(num3, 3));

if(soma%2==0){
    Console.WriteLine($"A soma dos quadrados dos numeros {num1}, {num2}, {num3}, é Par");
} else{
    Console.WriteLine($"A soma dos quadrados dos numeros {num1}, {num2}, {num3}, é Impar");
}