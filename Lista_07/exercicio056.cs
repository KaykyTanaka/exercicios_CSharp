/* Faça um programa que some todos os números abaixo de 1000 que são múltiplos de 3
e de 5. */

int num = 0;
int soma = 0;
while(num<1000){
        num++;
    if(num%3==0 && num%5==0){
        Console.Write($"{num} | ");
        soma += num;
    }
}
Console.WriteLine($"\nA soma é: {soma}");