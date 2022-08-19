/* 07 – Ler um número inteiro e imprimir seu antecessor e seu sucessor.
 SAÍDA:
 O número digitado foi ..., seu antecessor é ... e seu sucessor é ... */

Console.WriteLine("Insira um numero: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"O número digitado foi {num}, seu antecessor é {num-1} e seu sucessor é {num+1}!");


