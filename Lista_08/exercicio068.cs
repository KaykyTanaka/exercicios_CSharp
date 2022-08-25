/* Tendo como dados de entrada a altura e o sexo de uma pessoa, construa um algoritmo que
calcule seu peso ideal, utilizando as seguintes fórmulas:
• para homens: (72.7 * h) – 58;
• para mulheres: (62.1 * h) – 44.7.  */

Console.Write("Insira sua altura: ");
double h = double.Parse(Console.ReadLine());

Console.Write("Insira seu sexo, Masculino(M) e Feminino(F): ");
string sexo = (Console.ReadLine());

if(sexo=="M"){
    Console.WriteLine($"Sexo: Masculino\nAltura: {h}\nPeso ideal: {(72.7*h)-58:N}");
}else if(sexo=="F"){
    Console.WriteLine($"Sexo: Feminino\nAltura: {h}\nPeso ideal: {(62.1*h)-44.7:N}");
}