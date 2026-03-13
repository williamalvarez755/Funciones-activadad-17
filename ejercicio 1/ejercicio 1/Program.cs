int funcionprincipal(int numero1, int numero2)
{
    return numero1 + numero2;
}

Console.WriteLine("Ingrese numero 1");
int numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese numero 2");
int numero2 = int.Parse(Console.ReadLine());

Console.WriteLine(funcionprincipal(numero1, numero2));