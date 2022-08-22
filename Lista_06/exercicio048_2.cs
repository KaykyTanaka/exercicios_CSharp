/*  Criar um algoritmo que receba um número obrigatoriamente menor que dez e
imprima todos os números de vinte até o número digitado. */

Console.Write("Insira um valor positivo menor que 10: ");
double num = double.Parse(Console.ReadLine());


if(num>=10){
    Console.WriteLine("Insira um valor valido!");
}else{
    double x = 20;
    while(x>=num){
        Console.Write($"{x}\n");
        x--;
    }

}