/* 33 - Receber a altura do degrau de uma escada e a altura que o usuário deseja alcançar
subindo a escada. Calcular e mostrar quantos degraus o usuário deverá subir para
atingir seu objetivo, sem se preocupar com a altura do usuário. */


Console.Write("Insira a altura do degrau de uma escada: ");
double altura = double.Parse(Console.ReadLine());

Console.Write("Insira altura que deseja alcançar subindo a escada: ");
double alturaDesejada = double.Parse(Console.ReadLine());

double objetivo = (alturaDesejada/altura);

Console.WriteLine($"A escada possui {altura} de altura, você deseja chegar a {alturaDesejada}, para isso precisara subir {objetivo} degraus.");