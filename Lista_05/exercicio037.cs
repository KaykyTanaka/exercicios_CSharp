/* Efetuar a leitura de um número e apresentar o resultado do quadrado desse número.
Depois verificar se este novo valor é maior que 10.00, menor que 10.00 ou igual a
10.00.
Se for maior que 10.00 apresentar também sua Raiz Cúbica */

Console.Write("Insira um valor: ");
double num = double.Parse(Console.ReadLine());
num = Math.Pow(num, 2);

if(num > 10.00){
    Console.WriteLine($"Numero maior que 10.00\nSua raiz cubica é {Math.Pow(num, 3)}");
}else if(num ==10 ){
    Console.WriteLine("O Numero igual a 10.00");
}else{
    Console.Write("Numero menor que 10.00");
}