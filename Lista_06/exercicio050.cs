/* Exercício 50
• Criar um algoritmo que receba dois números e imprima a soma dos valores
compreendidos entre estes números.
 */

Console.Write("Insira um valor: ");
double num = double.Parse(Console.ReadLine());
Console.Write("Insira outro valor: ");
double num2 = double.Parse(Console.ReadLine());
Console.Clear();
double soma = 0;

if(num>num2){
    double aux = num;
    num = num2;
    num2 = aux;
}

while(num <= num2){
soma += num;
num++;
}
Console.WriteLine($"Soma: {soma}");