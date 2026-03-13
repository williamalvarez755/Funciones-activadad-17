Console.WriteLine("Ingrese el primer número:");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número:");
double num2 = double.Parse(Console.ReadLine());

void mostrarSuma(double num1, double num2)
{
    double suma = num1 + num2;
    Console.WriteLine("La suma de " + num1 + " y " + num2 + " es: " + suma);
}

mostrarSuma(num1, num2);
