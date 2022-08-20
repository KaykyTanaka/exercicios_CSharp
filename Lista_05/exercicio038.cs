/*  Construir um algoritmo que leia dois valores numéricos e efetue sua adição.
 Caso o resultado da adição seja maior que 10, exibir os números digitados, o
valor da adição e a raiz cúbica da adição.
 Caso contrário exibir somente os valores digitados e o valor da adição */

Console.Write("Insira o primeiro valor: ");
double num1= double.Parse(Console.ReadLine());
Console.Write("Insira o primeiro valor: ");
double num2= double.Parse(Console.ReadLine());
double adicao = (num1 + num2) ;

if(adicao > 10){
    Console.WriteLine($"Os valores digitados foram {num1}, {num2}\nA soma entre eles resulta em {adicao}\nA raíz cubica da adição é {Math.Pow(adicao, 1.0/3.0)}");
}else{
    Console.WriteLine($"Os valores digitados foram {num1}, {num2}\nA soma entre eles resulta em {adicao}");
}