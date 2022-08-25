/* Imprimir todos os números ímpares de 1000 até 150 em ordem decrescente. */

int num = 1000;

while(num>150){
    num--;
    if(num%2==1){
        Console.Write($"{num} | ");
    }
}
