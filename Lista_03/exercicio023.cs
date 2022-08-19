 
/* 23 - O algoritmo deve receber um número qualquer.
Se o número for par o algoritmo deve imprimir seu valor e seu valor elevado ao
quadrado.
Se o número for ímpar o algoritmo deve imprimir seu valor e seu valor elevado ao cubo.
 */

Console.Write("Digite um valor qualquer: ");
double valor = double.Parse(Console.ReadLine());



if(valor % 2 == 0){
    Console.WriteLine($"O valor digitado é par");
    Console.WriteLine($"Seu valor elevado ao quadrado é {Math.Pow(valor, 2 )}");
}else{
    Console.WriteLine($"O valor digitado é impar");
    Console.WriteLine($"Seu valor elevado ao cubo é {Math.Pow(valor, 3 )}");
}

/* Console.WriteLine((valor%2 == 0) ? $"O valor digitado é par\nSeu valor elevado ao quadrado é {Math.Pow(valor, 2 )}" :
 $"O valor digitado é impar\nSeu valor elevado ao cubo é {Math.Pow(valor, 3 )}"); */