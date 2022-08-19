/*14 – Elabore um algoritmo que entre com valor do raio e calcule a área e o perímetro do
círculo correspondente.
• A fórmula para se calcular a área da circunferência é : A = π ∗ raio2
• A fórmula para se calcular o perímetro da circunferência é : A = 2 ∗ π ∗ r */

Console.Write("Digite o valor do raio da circunferencia: ");
double r = double.Parse(Console.ReadLine());
double pi = 3.14;
double area = pi * Math.Pow(r,2);
double perimetro = 2*pi*r;

Console.WriteLine($"Valor do raio: {r}\nÁrea da circunferencia: {area}\nPerímetro da circunferencia: {perimetro.ToString("F2")}");