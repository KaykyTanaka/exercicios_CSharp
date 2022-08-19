/* 26 - Digitar um valor qualquer e imprimir se o valor digitado é “Par” ou “Ímpar”.
Atenção: os números dever ser maiores que zero.
 */

 Console.WriteLine("Insira um numero qualquer: ");
 double num = Double.Parse(Console.ReadLine());

 if(num>0){
     if(num%2 == 0 ){
         Console.WriteLine($"O numero: {num} é par!");
     }else{
Console.WriteLine($"O numero: {num} é impar!");
     };
}else{
     Console.WriteLine("Por favor, insira um numero maior que zero!!");
 };