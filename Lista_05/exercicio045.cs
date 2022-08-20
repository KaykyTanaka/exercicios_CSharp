/* O cardápio de uma lanchonete é o seguinte:
Código Especificação Preço unitário
100 Cachorro quente 4,50
101 Bauru simples 4,50
102 Bauru c/ovo 5,50
103 Hambúrguer 6,50
104 Refrigerante 3,50
Escrever um algoritmo que leia o código do item pedido, a quantidade e calcule o valor
a ser pago por aquele lanche.
Considere que a cada execução somente será calculado um item. */

Console.WriteLine("100 Cachorro quente R$4.50\n101 Bauru Simples R$4.50\n102 Bauru com ovo R$5.50\n103 Hambúrguer R$6.50\n104 Refrigerante R$3.50");
Console.Write("Digite o tipo do Picole que deseja comprar: ");
int tipo = int.Parse(Console.ReadLine());
Console.Write("Insira a quantidade que deseja comprar: ");
int quantidade = int.Parse(Console.ReadLine());

if(tipo == 100){
Console.WriteLine($"O produto escolhido foi: Cachorro Quente\nA quantidade comprada foi: {quantidade}\nPreço(uni): R$4.50\nTotal: R${quantidade*4.50}");

}else if(tipo == 101){
Console.WriteLine($"O produto escolhido foi: Bauru Simples\nA quantidade comprada foi: {quantidade}\nPreço(uni): R$4.50\nTotal: R${quantidade*4.50}");

}else if(tipo == 102){
Console.WriteLine($"O produto escolhido foi: Bauru com ovo\nA quantidade comprada foi: {quantidade}\nPreço(uni): R$5.50\nTotal: R${quantidade*5.50}");

}else if(tipo == 103){
Console.WriteLine($"O produto escolhido foi: Hamburguer\nA quantidade comprada foi: {quantidade}\nPreço(uni): R$6.50\nTotal: R${quantidade*6.50}");

}else if(tipo == 104){
Console.WriteLine($"O produto escolhido foi: Refrigerante\nA quantidade comprada foi: {quantidade}\nPreço(uni): R$3.50\nTotal: R${quantidade*3.50}");

}else{
    Console.WriteLine("Insira uma opção valida! ");
}