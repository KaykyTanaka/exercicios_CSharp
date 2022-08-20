/* Calculando o IMC – Índice de Massa Corporal
Para calcular o índice de massa corporal basta utiliza a fórmula abaixo e comparar o
resultado com a tabela abaixo.
IMC = peso/altura2
Atenção:
Peso em Kg e altura em metros
Tabela:
Abaixo de 17 Muito abaixo do peso
Entre 17 e 18,49 Abaixo do peso
Entre 18,5 e 24,99 Peso normal
Entre 25 e 29,99 Acima do peso
Entre 30 e 34,99 Obesidade I
Entre 35 e 39,99 Obesidade II (severa)
Acima de 40 Obesidade III (mórbida)

Observação:
O peso e a altura não podem ser nulos ou negativos. 
 */

Console.WriteLine("Digite seu peso (Kg): ");
double peso = double.Parse(Console.ReadLine());

Console.WriteLine("Digite sua altura (metros): ");
double altura = double.Parse(Console.ReadLine());

double imc = (peso/(Math.Pow(altura, 2)))*10000;

if(imc<17){
    Console.WriteLine("Muito abaixo do peso!");
}else if(imc>17 && imc<18.49){
Console.WriteLine("Abaixo do peso!");
}else if(imc>18.5 && imc<24.99){
Console.WriteLine("Peso normal!");
}else if(imc>25 && imc<29.99){
Console.WriteLine("Acima do peso!");
}else if(imc>30 && imc<34.99){
    Console.WriteLine("Obesidade I!");
}else if(imc>35 && imc<39.99){
Console.WriteLine("Obesidade II (severa)!");
}else{
Console.WriteLine("Obesidade III (mórbida)!");
}

