/* Exercício 53
Criar um algoritmo que entre com cinco números e imprima o quadrado de cada
número.
Atenção:
• Utilizar obrigatoriamente uma estrutura de repetição.
• Não utilizar cinco variáveis.
*/
double num = 0; 

while(0<5){
    Console.Write("Insira um numero: ");
    num = double.Parse(Console.ReadLine()); 
    Console.WriteLine($"{Math.Pow(num, 2)}");
    roda++;
}