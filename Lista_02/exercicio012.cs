/*12 – Crie um Algoritmo que receba um número e imprima sua raiz quadrada e sua raiz
cúbica.
 SAÍDA:
 O número digitado foi ...
 Sua raiz cúbica é ...
 Sua raiz quadrada é .. */

 Console.WriteLine("Insira um numero e descubra sua raiz quadrada e sua raiz cubica: ");
 Double num = Double.Parse(Console.ReadLine());
 Console.WriteLine($"O numero digitado foi {num}\nSua raiz cubica é {Math.Cbrt(num)}\nSua raiz quadrada é {Math.Sqrt(num)} ");

