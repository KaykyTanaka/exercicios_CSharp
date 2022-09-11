/* Exercício 83
Utilizando a estrutura for crie um algoritmo que imprima uma tabela de conversão de
polegadas para centímetros.
Deseja-se que na tabela conste valores desde 1 polegada até 20 polegadas inteiras.
Cada polegada vale 25,4 cm */

for (int i = 1; i <= 31; i++)
{
    Console.WriteLine($"{i} Polegadas => {i*25.4:N} Centimetros");
}