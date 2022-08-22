/* Exercício 49
• Criar um algoritmo que receba dois números e imprima os números
compreendidos entre estes números.
 */

Console.Write("Insira um valor: ");
double num = double.Parse(Console.ReadLine());
Console.Write("Insira outro valor: ");
double num2 = double.Parse(Console.ReadLine());
Console.Clear();

if(num>num2){
    while(num!=num2){
        Console.WriteLine(num);
        num--;
    }
}else if(num2>num){
    while(num!=num2){
        Console.WriteLine(num2);
        num2--;
    }   
}else{
    Console.Write("O numeros digitados são iguais!");
}