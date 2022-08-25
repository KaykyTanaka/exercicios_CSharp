/* Faça um programa que calcule e mostre a soma dos 50 primeiros números pares
positivos.
 */
int num = 0;
int soma = 0;
while(num<50){
    num++;
    if(num%2 == 0){
        Console.Write($"{num}|");
        soma += num;
        
    }
}

Console.WriteLine($"\n{soma}");

