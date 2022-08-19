/* 11 – Crie um Algoritmo que receba um número e imprima seu valor elevado a 2,
elevado a 3, elevado a 4 e elevado a 5.
 SAÍDA:
 O número digitado foi ... E seu valor elevado a 2 é ..., elevado a 3 é ..., ... */

Console.WriteLine("Insira um numero: ");
double num = double.Parse(Console.ReadLine());

Console.WriteLine($"O número digitado foi {num}\nE seu valor elevado a 2 é {Math.Pow(num, 2)},\nelevado a 3 é {Math.Pow(num, 3)},\nelevado a 4 é {Math.Pow(num, 4)},\nelevado a 5 é {Math.Pow(num, 5)}");
