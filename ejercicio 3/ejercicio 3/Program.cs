int doble (int numero)
{
    return numero * 2;
}
Console.WriteLine("ingrese numero");
int numero = int.Parse(Console.ReadLine());
Console.WriteLine("El doble del numero es: " + doble(numero));