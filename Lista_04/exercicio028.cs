/* 28 - Ler três números.
 Exibir os três números informando se eles são positivos, negativos ou nulos.
 Informar o maior número.
 */

Console.WriteLine("Digite o primeiro numero: ");
double num1 = Double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero: ");
double num2 = Double.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro numero: ");
double num3 = Double.Parse(Console.ReadLine());

if(num1>0){
    Console.WriteLine($"o numero {num1} é Positivo");
}else if(num1<0){
    Console.WriteLine($"o numero {num1} é Negativo");
}else{
    Console.WriteLine($"o numero {num1} é Nulo");
}

if(num2>0){
    Console.WriteLine($"o numero {num2} é Positivo");
}else if(num2<0){
    Console.WriteLine($"o numero {num2} é Negativo");
}else{
    Console.WriteLine($"o numero {num2} é Nulo");
}

if(num3>0){
    Console.WriteLine($"o numero {num3} é Positivo");
}else if(num3<0){
    Console.WriteLine($"o numero {num3} é Negativo");
}else{
    Console.WriteLine($"o numero {num3} é Nulo");
}

if(num1>num2){
    if(num1>num3){
        Console.WriteLine("Num1 Maior");
    }else{
        Console.WriteLine("Num3 Maior");
    }
}else{
     if(num2>num3){
        Console.WriteLine("Num2 Maior");
    }else{
        Console.WriteLine("Num3 Maior");
    }
}
