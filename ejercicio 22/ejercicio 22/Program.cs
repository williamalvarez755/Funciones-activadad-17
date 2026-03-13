Console.WriteLine("Ingrese su nombre:");
string nombre = Console.ReadLine();

void mostrarSaludo(string nombre)
{
    Console.WriteLine("¡Hola, " + nombre + "! Bienvenido/a.");
    Console.WriteLine("Es un gusto tenerte aquí, " + nombre + ".");
}

mostrarSaludo(nombre);
