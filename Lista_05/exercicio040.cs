/* Algoritmo CALCULADORA SIMPLES
 Em um primeiro momento o algoritmo deve perguntar ao usuário que tipo de
operação ele deseja efetuar:
 Soma;
 Subtração;
 Divisão;
 Multiplicação.

 Em um segundo momento o algoritmo deve solicitar que o usuário digite dois
número e exibir o resultado desejado.
 Cuidado com as divisões que tenham como denominador o número zero */

Console.WriteLine("Que tipo de operação deseja realizar:\n1- Soma\n2- Subtração\n3- Divisão\n4- Multiplicação");
int opc = int.Parse(Console.ReadLine());

Console.Write("Insira o primeiro valor: ");
double val1 = double.Parse(Console.ReadLine());
Console.Write("Insira o segundo valor: ");
double val2 = double.Parse(Console.ReadLine());

switch(opc){
    case 1:
        Console.WriteLine($"Opcão: Soma\n {val1} + {val2} = {val1+val2}\n");
    break;

    case 2:
        Console.WriteLine($"Opcão: Subtração\n {val1} - {val2} = {val1-val2}\n");
    break;

    case 3:
        if(val2 == 0){
            Console.WriteLine($"Por favor, insira um denominador diferente de 0\n");
        }else{
            Console.WriteLine($"Opcão: Divisão\n {val1} ÷ {val2} = {val1/val2}\n");
        }
    break;

    case 4:
    Console.WriteLine($"Opcão: Multiplicação\n {val1} × {val2} = {val1*val2}\n");
    break;

    default: 
    Console.WriteLine("Insira uma opção valida");
    break;

}