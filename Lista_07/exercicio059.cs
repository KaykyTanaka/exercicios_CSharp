/* Ler dois números e imprimir todos os números pares e múltiplos de 7 compreendidos
entre os números digitados pelo usuário.
Atenção: o usuário pode digitar o primeiro número menor que o segundo e vice-versa.
 */

Console.Write("Digite um numero: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Digite outro numero: ");
int num2 = int.Parse(Console.ReadLine());

while(num1<num2){
    num1++;
    if(num1%2==0 && num1%7==0){
    Console.Write($"{num1} | ");
    }
}

while(num1>num2){
    num2++;
      if(num1%2==0 && num1%7==0){
    Console.Write($"{num2} | ");
    }
}