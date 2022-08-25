/* Crie um algoritmo que, dado o nível de alerta de risco, imprima se ele for GRAVE. O nível de
alerta é um número que varia de 0 a 10. O nível é considerado GRAVE quando ele é
superior a 9. */


Console.Write("Insira o nivel de alerta: ");
int nivel = int.Parse(Console.ReadLine());

if(nivel>9){
    Console.Write("GRAVE!");
}else{
    Console.Write("Não há risco");
}