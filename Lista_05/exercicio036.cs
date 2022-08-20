/* Em época de pouco dinheiro, os comerciantes estão procurando aumentar suas vendas
oferecendo desconto.
Faça um algoritmo que possa entrar com o valor de um produto e imprimir o novo valor
tendo em vista que o desconto foi de 9%.
O valor do produto não pode ser menor ou igual a zero.
 */

Console.Write("Insira o valor do produto: ");
double produto = double.Parse(Console.ReadLine());

double calculo = produto-(0.09*produto);

if((produto<=0)){
    Console.Write("Insira um valor valido");
}else{
    Console.Write($"O valor do produto com 9% de desconto é {calculo}");
}