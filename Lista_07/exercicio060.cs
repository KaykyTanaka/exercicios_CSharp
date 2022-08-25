/* Criar um algoritmo que imprima a soma dos números ímpares de 1 a 200. */

int num = 1;
int soma = 0;
while(num<199){
    num++;
    if(num%2==1){
        Console.Write($"{num} |");
        soma += num;
    }
}
Console.WriteLine($"\n{soma}");