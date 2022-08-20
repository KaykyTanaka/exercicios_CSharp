/* Conhecendo a diagonal maior e a diagonal menor de um losango regular, calcular o
valor de seu lado.
Atenção: Os valores não podem ser negativos ou iguais a zero. */


Console.Write("Insira a medida da diagonal maior do losago: ");
double dMaior = double.Parse(Console.ReadLine());

Console.Write("Insira a medida da diagonal menor: ");
double dMenor = double.Parse(Console.ReadLine());

double lado = Math.Sqrt(Math.Pow((dMaior/2), 2) + Math.Pow((dMaior/2), 2)) ;

if((dMaior<0) || (dMaior==0) || (dMenor<0) || (dMenor==0)){
    Console.Write("Valores inválidos");
}else{
Console.Write($"O lado do losango é {lado}");
}