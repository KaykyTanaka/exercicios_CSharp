/* Faça um algoritmo que percorra todos os números de 1 até 100. Para os números
múltiplos de 4, imprima a palavra “PI” e para os outros imprima o próprio número. */

int x = 0;

do{
if(x%4==0){
    Console.Write($" *PI* |");
}else{
    Console.Write($" {x} |");
}
x++;
} while (x <= 100);