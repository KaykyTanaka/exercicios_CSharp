/* Um professor deseja um algoritmo pelo qual possa escolher que tipo de média
deseja calcular a partir de três notas.
 Faça um algoritmo que leia as notas, a opção escolhida pelo usuário e calcule a
média:
 1- aritmética
 2- ponderada (pesos 3, 3, 4) */


Console.Write("Insira a primeira nota: ");
double n1 = double.Parse(Console.ReadLine());

Console.Write("Insira a segunda nota: ");
double n2 = double.Parse(Console.ReadLine());

Console.Write("Insira a terceira nota: ");
double n3 = double.Parse(Console.ReadLine());

Console.WriteLine("Escolha uma opção para o calculo da média:\n1-Aritmética\n2-Ponderada (pesos 3, 3, 4)");
int opc = int.Parse(Console.ReadLine());

switch(opc){
    case 1:
        Console.WriteLine($"Opção: Média Aritmética\nNotas {n1} - {n2} - {n3}\nSua média é {(n1+n2+n3)/3}");
    break;
    case 2:
        Console.WriteLine($"Opção: Média Ponderada\nNotas {n1} - {n2} - {n3}\nSua média é {((n1*3)+(n2*3)+(n3*4))/(3+3+4)}\n");
    break;
}