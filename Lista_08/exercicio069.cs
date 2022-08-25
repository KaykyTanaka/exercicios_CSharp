/* Faca um algoritmo que percorra todos os números de 1 até 100. Para os números ímpares, deve ser impresso um “*”, 
e para os números pares, deve ser impresso o próprio número. */

int x = 0;

do{
if(x%2!=0){
    Console.Write($" *{x}* |");
}else{
    Console.Write($" {x} |");
}
x++;
} while (x <= 100);