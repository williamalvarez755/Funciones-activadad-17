Console.WriteLine("Ingrese el precio del producto:");
double precio = double.Parse(Console.ReadLine());

void mostrarPrecioConDescuento(double precio)
{
    double descuento = precio * 0.10;
    double precioFinal = precio - descuento;
    Console.WriteLine("Precio original:      " + precio);
    Console.WriteLine("Descuento del 10%:    " + descuento);
    Console.WriteLine("Precio con descuento: " + precioFinal);
}

mostrarPrecioConDescuento(precio);