/* Criar um algoritmo que imprima uma tabela de conversão de polegadas para
centímetros. Deseja-se que na tabela conste valores de 1 polegada até 20 polegadas
inteiras.
Cada polegada possui 25,4 mm. 

Divida o valor de comprimento por 10
*/ 

double polegada = 1.00;
int num = 0;

while(num<20){
    num++;
    x++;
    Console.WriteLine($"{num} polegadas -> {polegada*(2.54*num)} Centimetros");
}
