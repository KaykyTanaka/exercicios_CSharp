// See https://aka.ms/new-console-template for more information
  /* Crie um algoritmo que, dado dois números informados pelo usuário (obrigatoriamente
  maior que zero e menor ou igual a cem), informe qual é o menor deles. */

            
Console.Write("Insira um valor: ");
int num = int.Parse(Console.ReadLine());
        
Console.Write("Insira outro valor: ");
int num2 = int.Parse(Console.ReadLine());

if (num>0 && num<=100 && num2>0 && num2<=100){
    if (num>num2){
        Console.Write($"o valor {num2} é menor que {num}");
    }
    else{
        Console.Write($"o valor {num} é menor que {num2}");
    }
}else{
    Console.Write("Insira um valor valido!");}