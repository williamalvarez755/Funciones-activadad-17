Console.WriteLine("Ingrese el precio del producto 1:");
double producto1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el precio del producto 2:");
double producto2 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el precio del producto 3:");
double producto3 = double.Parse(Console.ReadLine());

double calcularTotalFactura(double producto1, double producto2, double producto3)
{
    double total = producto1 + producto2 + producto3;
    return total;
}

Console.WriteLine("El total de la factura es: " + calcularTotalFactura(producto1, producto2, producto3));
