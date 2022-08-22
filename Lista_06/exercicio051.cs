/* Exercício 51
• Criar um algoritmo que receba dois números e imprima a soma dos valores
pares compreendidos entre estes números. */


Console.Write("Insira um valor: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Insira outro valor: ");
int num2 = int.Parse(Console.ReadLine());
Console.Clear();
int soma = 0;

if(num1 > num2){
    int aux = num1;
    num1 = num2;
    num2 = aux;
}

while(num1 <= num2 ){
    if(num1%2==0){
        soma+= num1;
    }
    num1++;
}
Console.WriteLine($"A soma dos numeros pares é {soma}");