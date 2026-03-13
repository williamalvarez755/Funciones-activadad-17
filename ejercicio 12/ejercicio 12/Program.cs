Console.WriteLine("Ingrese su edad:");
int edad = int.Parse(Console.ReadLine());

string mostrarEdad(int edad)
{
    string mensaje = "La edad ingresada es: " + edad + " años";
    return mensaje;
}

Console.WriteLine(mostrarEdad(edad));
