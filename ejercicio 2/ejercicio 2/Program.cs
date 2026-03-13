int cuadrado (int numero)
{
    return numero * numero;
}
Console.WriteLine("ingrese numero");
int numero = int.Parse(Console.ReadLine()); 
Console.WriteLine("El cuadrado del numero es: " + cuadrado(numero));