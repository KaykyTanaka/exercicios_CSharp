/* Criar um algoritmo que leia um número que será o limite superior de um intervalo e o
incremento.
Imprimir todos os números no intervalo de 0 até esse número.
Suponha que os dois números lidos são obrigatoriamente maiores que zero.
Exemplo:
• Limite superior: 20
• Incremento: 5
• Saída: 0, 5, 10, 15, 20 */

Console.Write("Insira um numero limite de um intervalo: ");
int lim = int.Parse(Console.ReadLine());

Console.Write("Insira o Incremento: ");

int incremento = int.Parse(Console.ReadLine());
int x = 0;


while(x<=lim){
    Console.Write(x+", ");
    x+= incremento;
}
