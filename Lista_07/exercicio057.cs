/* Imprimir todos os números pares , múltiplos de 5 e 7 de 1 até 100.
Imprimir também a soma destes números. */

int num = 0;
int soma = 0;
while(num<100){
        num++;
    if(num%2==0 && num%5==0 && num%7==0){
        Console.Write($"{num} | ");
        soma += num;
    }
}
Console.WriteLine($"\nA soma é: {soma}");