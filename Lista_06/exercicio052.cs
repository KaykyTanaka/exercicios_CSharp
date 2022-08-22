/* Exercício 52
Elabore um programa que faça leitura de vários números inteiros, até que se digite um
número negativo.
O programa tem que retornar o maior e o menor número lido. */

Console.Write("Insira um numero: ");
int num = int.Parse(Console.ReadLine());
int maior = num;
int menor = num;

while(num>=0){
    Console.Write("Insira um numero: ");
    num = int.Parse(Console.ReadLine());

    if(num>maior){
        maior = num;
    }

    if(num<menor && num>=0){
        menor = num;
    }

}
Console.WriteLine($"Maior numero: {maior}\nMenor numero: {menor}\n");