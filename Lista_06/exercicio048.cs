/* • Criar um algoritmo que receba um número obrigatoriamente maior que zero e
imprima todos os números de zero até o número digitado.
 */

Console.Write("Insira um valor positivo: ");
double num = double.Parse(Console.ReadLine());
double x = 0;
if(num<=0){
    Console.WriteLine("Insira um valor valido!");
}else{
    while(x<num){
        x++;
        Console.Write($"{x}\n");
    }
    
}