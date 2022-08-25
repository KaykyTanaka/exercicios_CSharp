/* Faça um algoritmo que leia dois valores inteiros A e B e maiores que zero. Se os valores
forem iguais deverá se somar os dois, caso contrário multiplique A por B. Ao final de
qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu
conteúdo na tela.  */

Console.Write("Insira o valor A: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Insira o valor B: ");
int B = int.Parse(Console.ReadLine());

int C = 0;


if(A>0 && B>0){
    if(A==B){
        C = A+B;
        Console.WriteLine($"Os valores somados resulta em: {C}");
    }else{
        C = A*B;
        Console.WriteLine($"Os valores multiplicados resulta em: {C}");
    }
}