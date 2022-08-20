/* Entrar com um número qualquer.
 Se o número for positivo, imprimir o número digitado e sua raiz
quadrada.
 Se o número for negativo, imprimir o número digitado e seu valor
elevado ao quadrado
 */
Console.Write("Digite um qualquer: ");
double num = double.Parse(Console.ReadLine());

if(num>0){
    Console.WriteLine($"O numero digitado foi {num}\nÉ positivo\nSua raiz quadrada é {Math.Sqrt(num)}");
}else if(num == 0){
    Console.WriteLine($"Nulo");
}else{
    Console.WriteLine($"O numero digitado foi {num}\nÉ negativo\nAo quadrado é {Math.Pow(num, 2)}");
}

