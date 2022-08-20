/* Uma sorveteria vende três tipos de picolés.
 Sabendo-se que o picolé do tipo 1 é vendido por R$ 1.50, o do tipo 2 por R$ 2.60
e o do tipo 3 por R$ 3.75, faça um algoritmo que receba a quantidade comprada
e o tipo do picolé (1, 2 ou 3) e imprima a quantidade vendida , o tipo, o preço e
o total arrecadado. */

Console.WriteLine("Picole tipo 1 - R$1.50\nPicole tipo 2 - R$2.60\nPicole tipo 3 - R$3.75");
Console.Write("Digite o tipo do Picole que deseja comprar: ");
int tipo = int.Parse(Console.ReadLine());
Console.Write("Insira a quantidade que deseja comprar: ");
int quantidade = int.Parse(Console.ReadLine());

if(tipo == 1){
Console.WriteLine($"O tipo do picolé escolhido foi: {tipo}\na quantidade comprada foi: {quantidade}\nPreço(uni): R$1.50\nTotal: {quantidade*1.50}");

}else if(tipo == 2){
Console.WriteLine($"O tipo do picolé escolhido foi: {tipo}\na quantidade comprada foi: {quantidade}\nPreço(uni): R$6.50\nTotal: {quantidade*2.60}");

}else if(tipo == 3){
Console.WriteLine($"O tipo do picolé escolhido foi: {tipo}\na quantidade comprada foi: {quantidade}\nPreço(uni): R$3.75\nTotal: R${quantidade*3.75}");


}else{
    Console.WriteLine("Insira uma opção valida! ");
}
