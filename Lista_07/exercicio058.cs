/* Imprimir em ordem decrescente todos os números múltiplos de 3 e de 5
compreendidos entre 30 e 300. */

int num = 300;
while(num>29){
        num--;
    if(num%3==0 && num%5==0){
        Console.Write($"{num} | ");
        
    }
}