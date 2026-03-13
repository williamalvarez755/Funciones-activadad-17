Console.WriteLine("Ingrese el precio del producto 1:");
double precio1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el precio del producto 2:");
double precio2 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el precio del producto 3:");
double precio3 = double.Parse(Console.ReadLine());

double calcularTotal(double precio1, double precio2, double precio3)
{
    double total = precio1 + precio2 + precio3;
    return total;
}

Console.WriteLine("El total de la compra es: " + calcularTotal(precio1, precio2, precio3));
