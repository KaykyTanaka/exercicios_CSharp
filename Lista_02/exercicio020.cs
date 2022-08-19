/*20 – Elabore um algoritmo para calcular o volume e a área de uma esfera*/

Console.Write("Insira o valor do raio da esfera: ");
double raio = double.Parse(Console.ReadLine());
double pi = 3.14;
double area = 4 * pi * Math.Pow(raio, 2);

double volume = (4*pi*Math.Pow(raio, 3))/3;

Console.WriteLine($"O valor da area da esfera é {area}\n Seu volume é {volume}");