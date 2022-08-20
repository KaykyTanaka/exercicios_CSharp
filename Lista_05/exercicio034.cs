/* Criar um algoritmo que calcule e imprima a área de um losango.
Se os valores de entrada forem negativos ou iguais a zero o algoritmo deve imprimir
uma mensagem de erro - “Valores inválidos”
 
Á𝑟𝑒𝑎 = (𝑑 ∗ 𝐷 )/2 */

Console.Write("Insira a medida da diagonal 1: ");
double d1 = double.Parse(Console.ReadLine());

Console.Write("Insira a medida da diagonal 2: ");
double d2 = double.Parse(Console.ReadLine());

double area = ((d1*d2) /2);

if((d1<0) || (d1==0) || (d2<0) || (d2==0)){
    Console.Write("Valores inválidos");
}else{
Console.Write($"Área do losango é {area}");
}