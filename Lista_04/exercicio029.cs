/* 29 - Construir um algoritmo que leia dois valores numéricos e efetue sua adição.
 Caso o resultado da adição seja maior que 10, 
-exibir os números digitados
-valor da adição 
-raiz cúbica da adição.

 Caso contrário exibir somente os valores digitados e o valor da adição.
 */

Console.Write("Insira o primeiro valor: ");
double num1 = double.Parse(Console.ReadLine());
Console.Write("Insira o segundo valor: ");
double num2 = double.Parse(Console.ReadLine());

double soma = (num1+num2);

if(soma >= 10){
    Console.WriteLine($"Os numeros digitados foram {num1} e {num2}\nA soma é: {soma}\nRaiz cubica da adição é: {Math.Cbrt(soma)}");
}else{
    Console.WriteLine($"Os numeros digitados foram {num1} e {num2}\nA soma é: {soma}");
}