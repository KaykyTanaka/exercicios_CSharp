/* Faça um algoritmo que leia uma variável e some 5 ao número caso ele seja par ou some 8
caso seja ímpar. Deve-se imprimir o resultado desta operação */


Console.Write("Insira um valor: ");
int num = int.Parse(Console.ReadLine());

if(num%2==0){
    Console.WriteLine($"O valor é par, e somado a 5 resulta em: {num+5}");
}else if(num%2!=0){
    Console.WriteLine($"O valor é impar, e somado a 8 resulta em: {num+8}");
};