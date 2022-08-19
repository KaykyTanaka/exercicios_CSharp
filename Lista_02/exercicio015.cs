/*15 – Entrar com os lados A, B e C de um paralelepípedo.
Calcular e imprimir o volume.
• Volume = A * B * C 
*/

Console.Write("digite o lado A de um paralelepípedo: ");
double lA = double.Parse(Console.ReadLine()); 

Console.Write("digite o lado B de um paralelepípedo: ");
double lB = double.Parse(Console.ReadLine());

Console.Write("digite o lado C de um paralelepípedo: ");
double lC = double.Parse(Console.ReadLine());

double volume = lA * lB * lC;

Console.WriteLine($"O volume do paralelepípedo é: {volume}");