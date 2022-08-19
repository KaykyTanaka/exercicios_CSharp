/* 30 - Ler uma temperatura em graus Celsius e apresentá-la convertida em graus
Fahrenheit.
A fórmula de conversão é: F = C*(9.0/5.0)+32.0, sendo F a temperatura em Fahrenheit e
C a temperatura em Celsius. */

Console.Write("Insira a temperatura em grasu Celsius: ");
double celsius = double.Parse(Console.ReadLine());

double convertF = celsius*(9.0/5.0)+32.0;

Console.Write($"A temperatura de {celsius}ºC equivale a {convertF}ºF");