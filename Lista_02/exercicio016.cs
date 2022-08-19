/*16 – Elabore um algoritmo que calcule a área de um trapézio qualquer (figura
meramente ilustrativa).
Área = [(𝐵+𝑏) ×ℎ]
            2 */

Console.Write("Insira o valor da Base maior de um trapézio: ");
double bMaior = double.Parse(Console.ReadLine());
Console.Write("Insira o valor da Base menor: ");
double bMenor = double.Parse(Console.ReadLine());
Console.Write("Insira o valor da altura: ");
double altura = double.Parse(Console.ReadLine());

double area = ((bMaior+bMenor)*altura)/2 ;

Console.WriteLine($"A área do trapézio é: {area}");