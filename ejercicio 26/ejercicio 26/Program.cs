Console.WriteLine("Ingrese su edad:");
int edad = int.Parse(Console.ReadLine());

void mostrarAnioNacimiento(int edad)
{
    int anioNacimiento = 2026 - edad;
    Console.WriteLine("Su año aproximado de nacimiento es: " + anioNacimiento);
}

mostrarAnioNacimiento(edad);
