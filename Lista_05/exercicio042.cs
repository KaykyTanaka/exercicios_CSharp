/*  Entrar com o nome e duas notas de um aluno.
 As notas vão de zero a dez. O algoritmo deve imprimir o nome do aluno, suas
notas e sua média.
 Se a nota for maior que 7 – imprimir “Aprovado”.
 Se a nota for menor que 5 – imprimir “Retido”.
 Caso contrário - imprimir “Recuperação”.
 Se as notas não estiverem no intervalo estabelecido o algoritmo deve emitir
uma mensagem de erro. */

Console.Write("Digite o nome do aluno: ");
String nome = Console.ReadLine();

Console.Write("Digite a primeira nota do aluno: ");
double n1 = double.Parse(Console.ReadLine());
Console.Write("Digite a segunta nota do aluno: ");
double n2 = double.Parse(Console.ReadLine());

double media = (n1+n2)/2 ;

Console.WriteLine($"Aluno: {nome}\nNota 1 = {n1}\nNota 2 = {n2}\nMédia = {media}\n");

if((media>7) && (n1<=10) && (n1>=0) && (n2<=10) && (n2>=0)){
    Console.WriteLine($"Aluno Aprovado!!");
 
}else if((media<5) && (n1<=10) && (n1>=0) && (n2<=10) && (n2>=0)){
    Console.WriteLine($"Aluno Reprovado!");

}else{
    Console.WriteLine($"Aluno de Recuperação!");

}