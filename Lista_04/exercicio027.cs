/* 27 - Ler um número qualquer positivo e maior que zero.
Se o valor do número elevado à quarta for par e múltiplo de cinco o algoritmo
deverá imprimir a seguinte mensagem:
o “O número digitado foi __.”
o “Seu valor elevado ao quadrado é __.”
o “Seu valor elevado ao cubo é __.”
o “Seu valor elevado a sétima é __.”

Se o valor for ímpar o algoritmo deverá imprimir a seguinte mensagem:
o “O número digitado foi __.”
o “Sua raiz quadrada é __.”
o “Sua raiz cúbica é __.”
o “Sua raiz a sétima é __.”
Observação: Se o usuário digitar um valor inválido o algoritmo deverá emitir uma
mensagem de erro */

Console.Write("Insira um numero maior que zero: ");
double num = Double.Parse(Console.ReadLine());
double conta = Math.Pow(num, 4);


if(num%2==0){
    if((conta%2==0)&&(conta%5==0)){
        Console.WriteLine($"O número digitado foi {num}\nSeu valor elevado ao quadrado é {Math.Pow(num, 2)}\nSeu valor elevado ao cubo é {Math.Pow(num, 3)}\nSeu valor elevado a setima é {Math.Pow(num, 7)} ");
    }else{
        Console.Write("O número não é multiplo de 5!");
    };
}else{
Console.WriteLine($"O número digitado foi {num}\nSua raiz quadrada é {Math.Sqrt(num)}\nSua raiz cúbica é {Math.Cbrt(num)}\nSua raiz a setima é {Math.Pow(num, 0.14)}");
    
};
